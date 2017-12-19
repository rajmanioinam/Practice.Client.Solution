using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.WCF.WindowsClient
{
    public partial class Form1 : Form
    {
        PracticeWCFService.PracticeServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new PracticeWCFService.PracticeServiceClient();
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if(client.State == System.ServiceModel.CommunicationState.Faulted)
                {
                    client = new PracticeWCFService.PracticeServiceClient();
                }
                lblMessage.Text = client.GetMessage(txtMessage.Text);
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();
            }
        }
    }
}
