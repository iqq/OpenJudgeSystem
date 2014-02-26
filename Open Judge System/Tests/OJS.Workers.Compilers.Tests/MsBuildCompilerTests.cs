﻿namespace OJS.Workers.Compilers.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OJS.Common.Extensions;

    [TestClass]
    public class MsBuildCompilerTests
    {
        private const string MsBuildCompilerPath = @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe";

        [TestMethod]
        public void MsBuildCompilerShouldWorkWhenGivenValidZippedSolution()
        {
            var compiler = new MsBuildCompiler();
            var result = compiler.Compile(MsBuildCompilerPath, FileHelpers.SaveByteArrayToTempFile(this.GetSampleSolutionFile()), string.Empty);

            Assert.IsTrue(result.IsCompiledSuccessfully);
            Assert.IsTrue(string.IsNullOrWhiteSpace(result.OutputFile));
            Assert.IsTrue(result.OutputFile.EndsWith(".exe"));
        }

        private byte[] GetSampleSolutionFile()
        {
                return
                    Convert.FromBase64String(
@"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");
        }
    }
}
