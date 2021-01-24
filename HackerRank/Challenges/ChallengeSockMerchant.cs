using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    /// <summary>
    /// Available in: <see href="https://www.hackerrank.com/challenges/sock-merchant/problem">HackerRank - Sales by Match</see>    
    /// Problem resolved:
    ///     John works at a clothing store.He has a large pile of socks that he must pair by color for sale. 
    ///     Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
    ///     For example, there are  socks with colors.There is one pair of color  and one of color . 
    ///     There are three odd socks left, one of each color. The number of pairs is .
    /// Function Description
    ///     Complete the sockMerchant function in the editor below.It must return an integer representing the number of matching pairs 
    ///     of socks that are available.
    ///     sockMerchant has the following parameter(s):
    ///     n: the number of socks in the pile
    ///     ar: the colors of each sock
    /// Input Format
    ///     The first line contains an integer , the number of socks represented in . 
    ///     The second line contains  space-separated integers describing the colors of the socks in the pile.
    /// Constraints
    ///     <code>
    ///         1 <= n <= 100
    ///         1 <= ar[i] <= 100 where 0 <= i < n 
    ///     </code>
    /// Output Format
    ///     Return the total number of matching pairs of socks that John can sell.
    /// Sample Input
    ///     9
    ///     10 20 20 10 10 30 50 10 20
    /// Sample output
    ///     3
    /// </summary>
    public static class ChallengeSockMerchant
    {
        public static int SockMerchant(int n, int[] ar)
        {
            IEnumerable<int> stockings = ar.AsEnumerable().Where(sock => sock > 0 && sock <= 100);
            if (n >= 1 && n <= 100 && ar.Count() == n && stockings.Count() == ar.Count())
            {
                var socks = new Dictionary<int, int>();
                foreach (int sock in stockings)
                {
                    if (socks.ContainsKey(sock))
                    {
                        ++socks[sock];
                    }
                    else
                    {
                        socks.Add(sock, 1);

                    }
                }

                return (int)socks.Values.Sum(amountSocks => Math.Truncate((decimal)amountSocks / 2));
            }
            else
            {
                throw new Exception("Constrains not respected.");
            }

        }
    }
}
