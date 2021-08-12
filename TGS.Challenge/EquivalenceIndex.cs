namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
        //Initial Solution Idea:
        //1. Loop through each number starting at Index[1]
        //2. For each loop, loop through numbers below index and get sum
        //3. For each loop, loop through numbers above index and get sum
        //4. If both sums are equal then return index

        public int Find(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int firstSum = 0;
                int lastSum = 0;
                
                for (int index = 0; index < i; index++)
                {
                    firstSum += numbers[index];
                }

                for (int index = i + 1; index < numbers.Length; index++)
                {
                    lastSum += numbers[index];
                }

                if (firstSum == lastSum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
