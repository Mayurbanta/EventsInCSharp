using System;

namespace BillingComponents
{
    public class PayerBillingArgs : EventArgs
    {
        public int SlNo { get; private set; }
        public string PayerName { get; private set; }
        public PayerBillingArgs(int slno, string payer)
        {
            SlNo = slno;
            PayerName = payer;
        }
    }
}
