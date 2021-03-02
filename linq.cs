using System;

using System.Diagnostics;

using System.Collections.Generic;

using System.Linq;

public class Problem1

{

    public static IEnumerable<int> myFilter(IEnumerable<int> input)

    {

        IList<int> temp1 = new List<int>();

        foreach (var item in input)

        {

            if (item > 50 && item % 5 == 0)
            {

                continue;

            }

            else
            {

                int cube = item * item * item;

                if (cube % 2 == 0)
                {

                    continue;

                }

                else
                {

                    temp1.Add(item);

                }

            }

        }

        return temp1;

    }

    public static void Main(string[] args)

    {

        Random rnd = new Random(5);

        var listForProblem =

        Enumerable.Range(1, 100).Select(i => rnd.Next() % 101);

        var answer = Problem1.myFilter(listForProblem);

        foreach (int i in answer)

        {

            Debug.WriteLine(i);

        }

    }

}
