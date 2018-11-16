using System;
using System.Collections.Generic;
using System.Threading;

namespace BillingComponents
{
    public class BatchBilling
    {
        public List<string> PayerList { get; set; }
        public event EventHandler<PayerBillingArgs> PayerBillingEvent;

        public void RunBatchBilling(List<string> PayerList)
        {
            bool res = false;
            int i = 0;

            //test comment for github push
            foreach (var payer in PayerList)
            {
                res = ProcessPayerBatch(payer);
                i++;

                if (res == true)
                {
                    PayerBillingArgs args = new PayerBillingArgs(i, payer);
                    PayerBillingEvent?.Invoke(this, args);
                }
            }
        }

        private bool ProcessPayerBatch(string payer)
        {
            if (!string.IsNullOrEmpty(payer))
            {
                Thread.Sleep(100); //run process
                return true;
            }
            return false;
        }
    }
}
