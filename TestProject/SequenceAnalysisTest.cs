using SequenceAnalysis;
using System;
using Xunit;

namespace TestProject
{
    public class SequenceAnalysisTest
    {
        [Theory]
        [InlineData("This IS a STRING", "GIINRSSTT")]
        [InlineData("I am EKIN CErEn ErDOGan", "CDEEEEGIIKNO")]
        [InlineData(null, "")]
        [InlineData("", "")]
        public void SequenceAnalysis_Test(string input, string expected)
        {
            ISequenceAnalysisService sequenceAnalysis = new SequenceAnalysisService();
            Assert.Equal(expected, sequenceAnalysis.Do(input));
        }
    }
}
