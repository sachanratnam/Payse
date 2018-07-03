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
    public partial class UcEmailSetup : UserControl
    {
        public EventHandler MailLoginButtonClick;

        public UcEmailSetup()
        {
            InitializeComponent();
        }

        private void BtnMailLogin_Click(object sender, EventArgs e)
        {
            if (MailLoginButtonClick != null)
                MailLoginButtonClick(this, e);
        }
    }
}
