using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    /// <summary>
    /// Problem resolved:
    ///     Gary is an avid hiker. He tracks his hikes meticulously, paying close attention to small details like topography. 
    ///     During his last hike he took exactly n steps. For every step he took, he noted if it was an uphill, U , or a downhill, D step. 
    ///     Gary's hikes start and end at sea level and each step up or down represents a  unit change in altitude. We define the following terms:
    ///
    ///     * A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step 
    ///     down to sea level.
    ///     * A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step 
    ///     up to sea level.
    ///
    ///     Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.
    /// 
    ///     For example, if Gary's path is s=[DDUUUUDD], he first enters a valley 2 units deep. Then he climbs out an up onto a mountain 2 units 
    ///     high. Finally, he returns to sea level and ends his hike.
    /// Function Description
    ///     Complete the countingValleys function in the editor below.It must return an integer that denotes the number of valleys Gary traversed.
    ///     countingValleys has the following parameter(s):
    ///     n: the number of steps Gary takes
    ///     s: a string describing his path
    /// Input Format
    ///     The first line contains an integer, the number of steps in Gary's hike. 
    ///     The second line contains a single string , of characters that describe his path.
    /// Constraints
    ///     <code>
    ///         2 <= n <= 10 ^ 6
    ///         s[i] == U || s[i] == D
    ///     </code>
    /// Output Format
    ///     Print a single integer that denotes the number of valleys Gary walked through during his hike.
    /// Sample Input
    ///     8
    ///     UDDDUDUU
    /// Sample Output
    ///     1
    /// </summary>
    public static class ChallengeCountingValleys
    {
        public static int CountingValleys(int n, string s)
        {
            if (s == null || n < 2 || n > 1000000)
            {
                throw new Exception("Constraints not respecteds.");
            }

            IEnumerable<char> path = s.ToCharArray().AsEnumerable();
            int numberSteps = path.Count();

            if (n != numberSteps || numberSteps != path.Count(step => step == 'U' || step == 'D'))
            {
                throw new Exception("Constraints not respecteds.");
            }

            var locations = new List<int>() { 0 };
            var numberValleys = 0;

            foreach (var step in path)
            {
                int lastStep = locations.LastOrDefault();
                int newStep = step == 'U' ? lastStep + 1 : lastStep - 1;
                locations.Add(newStep);
                if(newStep == 0 && lastStep < 0)
                {
                    ++numberValleys;
                }
            }

            return numberValleys;
        }
    }
}
