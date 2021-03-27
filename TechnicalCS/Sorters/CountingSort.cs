namespace TechnicalCS.TechDemos.Sorters
{

    public static class CountSorter
    {

        public static int[] CountSort(this int[] input)
        {
            var counts = input.GetCounts();
            //setup count array to contain a running total (sum) of previous counts
            int runningTotal = 0;
            for (int j = 0; j < counts.Length; j++)
            {
                runningTotal += counts[j];
                counts[j] = runningTotal;
            }

            //build sorted output from counts and input
            int[] output = new int[input.Length];
            for (int k = 0; k < output.Length; k++)
            {
                output[counts[input[k]] - 1] = input[k];
                counts[input[k]] -= 1;
            }

            return output;

        }

        public static int[] GetCounts(this int[] input)
        {

            int[] counts = new int[input.Length];

            //setup counts
            foreach (int i in input)
            {
                counts[i] += 1;
            }
            return counts;
        }

    }

}