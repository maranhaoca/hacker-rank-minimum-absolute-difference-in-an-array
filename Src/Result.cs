using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'minimumAbsoluteDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int minimumAbsoluteDifference(List<int> arr)
        {
            int minAbsDif = int.MaxValue;
            arr.Sort();

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) == 0)
                {
                    return 0;
                }
               
                minAbsDif = Math.Abs(arr[i] - arr[i + 1]) < minAbsDif ? Math.Abs(arr[i] - arr[i + 1]) : minAbsDif;
            }

            return minAbsDif;
        }
    }
}