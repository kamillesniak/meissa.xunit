using Meissa.Core.Model;
using Meissa.Plugins.Contracts;
using Mono.Cecil;
using Mono.Cecil.Rocks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Meissa.xunit
{
    public class NativeTestsRunnerTestCasesPluginService : INativeTestsRunnerTestCasesPluginService
    {
        private const string XunitFactAttributeName = "Xunit.FactAttribute";
        private const string XunitTestTheoryAttributeName = "Xunit.TheoryAttribute";

        public string Name => throw new NotImplementedException();

        public List<TestCase> ExtractAllTestCasesFromTestLibrary(string testLibraryPath)
        {
            var module = ModuleDefinition.ReadModule(testLibraryPath);
            var testCases = new List<TestCase>();
            foreach (var currentType in module.GetTypes())
            {

                    foreach (var currentMethod in currentType.GetMethods())
                    {
                        if (currentMethod.CustomAttributes.Any(x => x.AttributeType.FullName.ToString().Equals(XunitFactAttributeName)))
                        {
                            var currentTestCase = CreateTestCase(currentMethod);
                            testCases.Add(currentTestCase);
                        }
                    
                }
            }

            return testCases;
        }

        private TestCase CreateTestCase(MethodDefinition testMethod)
        {
            var testCase = new TestCase
            {
                FullName = string.Concat(testMethod?.DeclaringType?.FullName, ".", testMethod.Name),
                ClassName = testMethod.DeclaringType.FullName,
            };
            var testCaseCategoryAttributes = testMethod.CustomAttributes.Where(x => x.AttributeType.FullName.ToString().Contains(XunitFactAttributeName));
            testCase.Categories = GetCategoryNamesFromAttributes(testCaseCategoryAttributes);

            return testCase;
        }

        private List<string> GetCategoryNamesFromAttributes(IEnumerable<CustomAttribute> attributes)
        {
            var categoryNames = new List<string>();

            foreach (var categoryAttribute in attributes)
            {
                if (categoryAttribute.HasConstructorArguments)
                {
                    foreach (var constructorArg in categoryAttribute.ConstructorArguments)
                    {
                        categoryNames.Add(constructorArg.Value.ToString());
                    }
                }
            }

            return categoryNames;
        }

    }
}
