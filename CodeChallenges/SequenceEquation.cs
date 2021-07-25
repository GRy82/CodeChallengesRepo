using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    class SequenceEquation
    {

        // Given a sequence of n integers, p(1), p(2),...,p(n) where each element is distinct and
        // satisfies 1 <= p(x) <= n. For each x where 1 <= x <= n, that is x increments from 1 to n,
        // find any integer y such that p(p(y)) = x and keep a history of the values of y in a return
        // array.
        // ex. for p = [5, 2, 1, 3, 4], y = [4, 2, 5, 1, 3].
        public static List<int> permutationEquation(List<int> p)
        {
            List<int> recorded = new List<int>();
            for (int x = 1; x <= p.Count; x++)
                recorded.Add(p.IndexOf(p.IndexOf(x) + 1) + 1); //4
            
            return recorded;
        }
    }
}
