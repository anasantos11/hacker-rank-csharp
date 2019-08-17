using Challenges;
using NUnit.Framework;
using System;

namespace ChallengesTest
{
    [TestFixture]
    public class ChallengeCountingValleysTest
    {

        [TestCase(2, "UD", ExpectedResult = 0)]
        [TestCase(8, "UDUDUDUD", ExpectedResult = 0)]
        [TestCase(2, "DU", ExpectedResult = 1)]
        [TestCase(8, "DUDUDUDU", ExpectedResult = 4)]
        [TestCase(8, "DDUDUDUU", ExpectedResult = 1)]
        [TestCase(8, "UDDDUDUU", ExpectedResult = 1)]
        [TestCase(12, "DDUUDDUDUUUD", ExpectedResult = 2)]
        public int CountingValleysWithConstraintsRespecteds(int numberOfSteps, string path)
        {
            return ChallengeCountingValleys.CountingValleys(numberOfSteps, path);
        }

        [TestCase(1, "U")]
        [TestCase(1000001, "")]
        [TestCase(2, "U")]
        [TestCase(1, null)]
        public void CountingValleysWithConstraintsNotRespecteds(int numberOfSteps, string path)
        {
            Assert.Throws<Exception>(() => ChallengeCountingValleys.CountingValleys(numberOfSteps, path));
        }
    }
}
