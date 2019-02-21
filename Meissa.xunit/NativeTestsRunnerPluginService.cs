using System;
using System.Collections.Generic;
using System.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Meissa.API.Models;
using Meissa.Core.Model;
using Meissa.Plugins.Contracts;

namespace Meissa.Plugins.XUnit
{
    [Export(typeof(INativeTestsRunnerPluginService))]
    public class NativeTestsRunnerPluginService : INativeTestsRunnerPluginService
    {
        public string Name => "Xunit";

        public string RunnerFile => throw new NotImplementedException();

        public string ResultsFileExtension => "trx";

        public List<string> RunnerProcessesNamesToKill => throw new NotImplementedException();

        public string BuildNativeRunnerArguments(string libraryName, string libraryPath, List<TestCase> testCasesToBeExecuted, string testResultsFilePath, string outputFilesDir, string nativeArguments)
        {
            throw new NotImplementedException();
        }

        public object DeserializeTestResults(string originalRunTestResults)
        {
            throw new NotImplementedException();
        }

        public void ExecutePostRunActions()
        {
            throw new NotImplementedException();
        }

        public List<TestCase> GetAllNotPassedTests(string testResultsFileContent)
        {
            throw new NotImplementedException();
        }

        public int GetAllNotPassesTestsCount(object testRun)
        {
            throw new NotImplementedException();
        }

        public List<TestCase> GetAllPassesTestCases(string testResultsFileContent)
        {
            throw new NotImplementedException();
        }

        public object GetAllPassesTests(object testRun)
        {
            throw new NotImplementedException();
        }

        public object GetAllPassesTests(string testRunContent)
        {
            throw new NotImplementedException();
        }

        public int GetAllPassesTestsCount(object testRun)
        {
            throw new NotImplementedException();
        }

        public object GetRetriedTestResultsForTestRun(List<TestAgentRunDto> testAgentRuns)
        {
            throw new NotImplementedException();
        }

        public object GetTestResultsForTestRun(List<TestAgentRunDto> testAgentRuns)
        {
            throw new NotImplementedException();
        }

        public string MergeTestResults(object testResultsToBeMergedObj)
        {
            throw new NotImplementedException();
        }

        public string SerializeTestResults(object testResults)
        {
            throw new NotImplementedException();
        }

        public List<List<TestCase>> SplitTestCases(int availableCores, bool sameMachineByClass, List<TestCase> testCasesToBeDistributed)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassedTests(object passedTests, object testRun)
        {
            throw new NotImplementedException();
        }

        public void UpdateResultsSummary(object testRunObj)
        {
            throw new NotImplementedException();
        }

        public List<TestCaseRun> UpdateTestCasesHistory(object testRun, string libraryName)
        {
            throw new NotImplementedException();
        }
    }
}
