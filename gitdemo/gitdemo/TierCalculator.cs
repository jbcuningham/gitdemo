    using System;

namespace gitdemo
{

    public class TierCalculator
    {
        long balanceInTier;
        double rateForTier;

        public TierCalculator(long balance, double rate)
            {
            balanceInTier = balance;
            rateForTier = rate;
            }
        
        public double getAccrual()
        {
            return balanceInTier * rateForTier;
        }

    }
}
