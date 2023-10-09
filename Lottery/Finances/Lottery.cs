using System;
using System.Collections.Generic;

namespace Finances
{

    public class Lottery
    {
        private int maxValue;
        private int nrOfWantedNumbers;
        private List<int> drawnNumbers;
        private Random random;

        public Lottery(int maxValue, int nrOfWantedNumbers)
        {
            this.maxValue = maxValue;
            this.nrOfWantedNumbers = nrOfWantedNumbers;
            drawnNumbers = new List<int>();
            random = new Random();
        }

        public int DrawNextNumber()
        {
            if (IsLotteryFinished())
            {
                throw new InvalidOperationException("All numbers have been drawn.");
            }

            int nextNumber;
            do
            {
                nextNumber = random.Next(1, maxValue + 1);
            } while (drawnNumbers.Contains(nextNumber));

            drawnNumbers.Add(nextNumber);
            return nextNumber;
        }

        public void DrawAllNumbers()
        {
            while (!IsLotteryFinished())
            {
                DrawNextNumber();
            }
        }

        public bool IsLotteryFinished()
        {
            return drawnNumbers.Count == nrOfWantedNumbers;
        }

        public List<int> GetDrawnNumbers()
        {
            return drawnNumbers;
        }
    }


}
