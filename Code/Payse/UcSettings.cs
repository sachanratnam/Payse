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
    public partial class UcSettings : UserControl
    {
        public EventHandler SaveButtonClick;
        public EventHandler ResetButtonClick;

        public UcSettings()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (SaveButtonClick != null)
                SaveButtonClick(this, e);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (ResetButtonClick != null)
                ResetButtonClick(this, e);
        }

        private void TrkBarRefreshDelay_Scroll(object sender, EventArgs e)
        {
            LblRefreshValue.Text = (TrkBarRefreshDelay.Value * 5).ToString() + "s";
        }

        private void TrkBarReconnectDelay_Scroll(object sender, EventArgs e)
        {
            if (TrkBarReconnectDelay.Value == 0)
                LblReconnectValue.Text = "Never";
            else
                LblReconnectValue.Text = (TrkBarReconnectDelay.Value * 30).ToString() + "s";
            
        }
    }
}
