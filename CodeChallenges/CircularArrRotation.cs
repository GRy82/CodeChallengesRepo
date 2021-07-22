using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{

    // John Watson knows of an operation called a right circular rotation 
    // on an array of integers. One rotation operation moves the last array 
    // element to the first position and shifts all remaining elements right 
    // one. To test Sherlock's abilities, Watson provides Sherlock with an 
    // array of integers. Sherlock is to perform the rotation operation a 
    // number of times then determine the value of the element at a given 
    // position.
    // For each array, perform a number of right circular rotations and 
    // return the values of the elements at the given indices.
    class CircularArrRotation
    {
        public static List<int> circularArrayRotation(List<int> arr, int rotations, List<int> queries)
        {
            while (rotations-- > 0)
            {
                int last = arr[arr.Count - 1];
                arr.RemoveAt(arr.Count - 1);
                arr.Insert(0, last);
            }

            List<int> responses = new List<int>(queries.Count);
            foreach (var query in queries)
                responses.Add(arr[query]);

            return responses;
        }
    }
}
