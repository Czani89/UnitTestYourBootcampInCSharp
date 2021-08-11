using System;
using System.Collections.Generic;

namespace BootcampFunctions
{
    public class TotalPhoneBill
    {
        public TotalPhoneBill()
        {
            payCall = new List<string>();
            paySms = new List<string>();
        }
        public double Total(string param)
        {

            string[] splitParam = param.Trim().Split(",");
            for (var i = 0; i < splitParam.Length; i++)
            {
                if (splitParam[i].StartsWith("c"))
                {
                    payCall.Add(splitParam[i]);
                };
                if (splitParam[i].StartsWith("s"))
                {
                    paySms.Add(splitParam[i]);
                }
            }
            double callTotals = payCall.Count * 2.75 + paySms.Count * 0.65;
            var callTotal = Math.Round(callTotals, 2, MidpointRounding.ToZero);
            return callTotal;
            // return the result.
        }
        private List<string> payCall;
        private List<string> paySms;
    }
}
