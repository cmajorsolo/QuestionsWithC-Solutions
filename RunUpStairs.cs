using System;

namespace SpencerStuart
{
    public class RunUpStairs
    {
        public const int StridesToTurnAround = 2;

        public int CalculateStrides(int[] staircase, int stepsPerStride){
            if(staircase.Length < 1 || staircase.Length > 50)
            {
                throw new ArgumentException("The staircase has between 1 and 50 flights of stairs");
            }
            if(stepsPerStride < 2 || stepsPerStride > 5)
            {
                throw new ArgumentException("The steps per stride has between 2 and 5");
            }
            int landings = staircase.Length - 1;
            int numberOfStrides = landings * StridesToTurnAround;
            foreach (int flights in staircase )
            {
                if (flights < 5 || flights > 30)
                {
                    throw new ArgumentException("The flight of stairs has between 5 and 30 steps");
                }
                numberOfStrides = numberOfStrides + flights / stepsPerStride;
                if (flights % stepsPerStride > 0)
                {
                    numberOfStrides++;
                }
            }

            return numberOfStrides;
        }
    }
}
