using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payse
{
    public partial class UcEmailSetupComplete : UserControl
    {
        public EventHandler MailSetupFinishButtonClick;

        public UcEmailSetupComplete()
        {
            InitializeComponent();
        }

        private void BtnMailSetupFinish_Click(object sender, EventArgs e)
        {
            if (MailSetupFinishButtonClick != null)
                MailSetupFinishButtonClick(this, e);
        }
    }
}
