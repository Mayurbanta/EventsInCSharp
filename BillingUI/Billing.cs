using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BillingComponents;

namespace Events_POC
{
    public partial class Billing : Form
    {
        private List<string> payers;
        BatchBilling batchBilling;

        public Billing()
        {
            InitializeComponent();
            batchBilling = new BatchBilling();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            Wireup();
            payers = new List<string>
            {
                "Payer 111",
                "Payer 222",
                "Payer 333",
                "Payer 444",
                "Payer 555",
                "Payer 666",
                "Payer 777",
                "Payer 888",
                "Payer 999"
            };


            lstPayers.DataSource = payers;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            batchBilling.RunBatchBilling(payers);
        }

        private void Wireup()
        {
            batchBilling.PayerBillingEvent += BatchBilling_PayerBillingEvent;
        }

        private void BatchBilling_PayerBillingEvent(object sender, PayerBillingArgs e)
        {
            lstProcessedPayers.Items.Add($"Serial# {e.SlNo} -  {e.PayerName}");
            
        }
    }
}
