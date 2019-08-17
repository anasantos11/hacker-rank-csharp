using Challenges;
using NUnit.Framework;
using System;

namespace ChallengesTest
{
    [TestFixture]
    public class ChallengeSockMerchantTest
    {
        [TestCase(1, new int[] { 10 }, ExpectedResult = 0)]
        [TestCase(2, new int[] { 10, 20 }, ExpectedResult = 0)]
        [TestCase(2, new int[] { 10, 10 }, ExpectedResult = 1)]
        [TestCase(3, new int[] { 10, 20, 30 }, ExpectedResult = 0)]
        [TestCase(3, new int[] { 10, 10, 20 }, ExpectedResult = 1)]
        [TestCase(3, new int[] { 10, 10, 10 }, ExpectedResult = 1)]
        [TestCase(4, new int[] { 10, 20, 30, 40 }, ExpectedResult = 0)]
        [TestCase(4, new int[] { 10, 10, 20, 30 }, ExpectedResult = 1)]
        [TestCase(4, new int[] { 10, 10, 10, 20 }, ExpectedResult = 1)]
        [TestCase(4, new int[] { 10, 10, 20, 20 }, ExpectedResult = 2)]
        [TestCase(9, new int[] { 10, 10, 10, 10, 20, 20, 20, 30, 50 }, ExpectedResult = 3)]
        [TestCase(100, new int[] {
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10
        }, ExpectedResult = 50)]
        public int ChallengeSockMerchantWithConstraintsRespecteds(int numberSocksInPile, int[] colorsEachSock)
        {
            return ChallengeSockMerchant.SockMerchant(numberSocksInPile, colorsEachSock);
        }

        [TestCase(0, new int[] { })]
        [TestCase(101, new int[] {
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
            10
        })]
        [TestCase(1, new int[] { 10, 10 })]
        [TestCase(3, new int[] { 0, 10, 10 })]
        [TestCase(3, new int[] { 101, 10, 10 })]
        public void ChallengeSockMerchantWithConstraintsNotRespecteds(int numberSocksInPile, int[] colorsEachSock)
        {
            Assert.Throws<Exception>(() => ChallengeSockMerchant.SockMerchant(numberSocksInPile, colorsEachSock));
        }
    }
}