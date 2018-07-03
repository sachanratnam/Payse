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
    public partial class UcHome : UserControl
    {
        public event EventHandler StartButtonClick;

        public UcHome()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (StartButtonClick != null)
                StartButtonClick(this, e);
        }
    }
}
