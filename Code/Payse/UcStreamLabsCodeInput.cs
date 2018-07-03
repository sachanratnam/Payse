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
    public partial class UcStreamLabsCodeInput : UserControl
    {
        public EventHandler StreamLabsCodeVerifyButtonClick;

        public UcStreamLabsCodeInput()
        {
            InitializeComponent();
        }

        private void BtnStreamLabsCodeVerify_Click(object sender, EventArgs e)
        {
            if (StreamLabsCodeVerifyButtonClick != null)
                StreamLabsCodeVerifyButtonClick(this, e);
        }
    }
}
