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
    public partial class UcStreamLabsSetup : UserControl
    {
        public EventHandler StreamLoginButtonClick;

        public UcStreamLabsSetup()
        {
            InitializeComponent();
        }

        private void BtnStreamLabsLogin_Click(object sender, EventArgs e)
        {
            if (StreamLoginButtonClick != null)
                StreamLoginButtonClick(this, e);
        }
    }
}
