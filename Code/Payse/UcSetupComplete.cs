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
    public partial class UcSetupComplete : UserControl
    {
        public EventHandler SetupFinishButtonClick;

        public UcSetupComplete()
        {
            InitializeComponent();
        }

        private void BtnSetupFinish_Click(object sender, EventArgs e)
        {
            if (SetupFinishButtonClick != null)
                SetupFinishButtonClick(this, e);
        }
    }
}
