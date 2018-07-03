namespace Payse
{
    partial class UcSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblRefresh = new System.Windows.Forms.Label();
            this.LblReconnect = new System.Windows.Forms.Label();
            this.LblExchange = new System.Windows.Forms.Label();
            this.TrkBarRefreshDelay = new System.Windows.Forms.TrackBar();
            this.TrkBarReconnectDelay = new System.Windows.Forms.TrackBar();
            this.LblReconnectValue = new System.Windows.Forms.Label();
            this.LblRefreshValue = new System.Windows.Forms.Label();
            this.NumUDExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.LblExchangeDescription = new System.Windows.Forms.Label();
            this.LblReset = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBarRefreshDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBarReconnectDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDExchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(0, 300);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(440, 50);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblRefresh
            // 
            this.LblRefresh.AutoSize = true;
            this.LblRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRefresh.Location = new System.Drawing.Point(17, 23);
            this.LblRefresh.Name = "LblRefresh";
            this.LblRefresh.Size = new System.Drawing.Size(113, 21);
            this.LblRefresh.TabIndex = 4;
            this.LblRefresh.Text = "Refresh delay";
            // 
            // LblReconnect
            // 
            this.LblReconnect.AutoSize = true;
            this.LblReconnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReconnect.Location = new System.Drawing.Point(17, 74);
            this.LblReconnect.Name = "LblReconnect";
            this.LblReconnect.Size = new System.Drawing.Size(144, 21);
            this.LblReconnect.TabIndex = 5;
            this.LblReconnect.Text = "Reconnect delay";
            // 
            // LblExchange
            // 
            this.LblExchange.AutoSize = true;
            this.LblExchange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExchange.Location = new System.Drawing.Point(17, 125);
            this.LblExchange.Name = "LblExchange";
            this.LblExchange.Size = new System.Drawing.Size(126, 21);
            this.LblExchange.TabIndex = 6;
            this.LblExchange.Text = "Exchange rate";
            // 
            // TrkBarRefreshDelay
            // 
            this.TrkBarRefreshDelay.BackColor = System.Drawing.Color.White;
            this.TrkBarRefreshDelay.LargeChange = 1;
            this.TrkBarRefreshDelay.Location = new System.Drawing.Point(182, 23);
            this.TrkBarRefreshDelay.Maximum = 60;
            this.TrkBarRefreshDelay.Minimum = 1;
            this.TrkBarRefreshDelay.Name = "TrkBarRefreshDelay";
            this.TrkBarRefreshDelay.Size = new System.Drawing.Size(170, 45);
            this.TrkBarRefreshDelay.TabIndex = 7;
            this.TrkBarRefreshDelay.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrkBarRefreshDelay.Value = 1;
            this.TrkBarRefreshDelay.Scroll += new System.EventHandler(this.TrkBarRefreshDelay_Scroll);
            // 
            // TrkBarReconnectDelay
            // 
            this.TrkBarReconnectDelay.LargeChange = 1;
            this.TrkBarReconnectDelay.Location = new System.Drawing.Point(182, 74);
            this.TrkBarReconnectDelay.Maximum = 20;
            this.TrkBarReconnectDelay.Name = "TrkBarReconnectDelay";
            this.TrkBarReconnectDelay.Size = new System.Drawing.Size(170, 45);
            this.TrkBarReconnectDelay.TabIndex = 10;
            this.TrkBarReconnectDelay.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrkBarReconnectDelay.Scroll += new System.EventHandler(this.TrkBarReconnectDelay_Scroll);
            // 
            // LblReconnectValue
            // 
            this.LblReconnectValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReconnectValue.Location = new System.Drawing.Point(369, 74);
            this.LblReconnectValue.Name = "LblReconnectValue";
            this.LblReconnectValue.Size = new System.Drawing.Size(57, 21);
            this.LblReconnectValue.TabIndex = 11;
            this.LblReconnectValue.Text = "Never";
            this.LblReconnectValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblRefreshValue
            // 
            this.LblRefreshValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRefreshValue.Location = new System.Drawing.Point(373, 23);
            this.LblRefreshValue.Name = "LblRefreshValue";
            this.LblRefreshValue.Size = new System.Drawing.Size(53, 21);
            this.LblRefreshValue.TabIndex = 12;
            this.LblRefreshValue.Text = "5s";
            this.LblRefreshValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NumUDExchangeRate
            // 
            this.NumUDExchangeRate.DecimalPlaces = 2;
            this.NumUDExchangeRate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NumUDExchangeRate.Location = new System.Drawing.Point(182, 125);
            this.NumUDExchangeRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumUDExchangeRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NumUDExchangeRate.Name = "NumUDExchangeRate";
            this.NumUDExchangeRate.Size = new System.Drawing.Size(130, 27);
            this.NumUDExchangeRate.TabIndex = 15;
            this.NumUDExchangeRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // LblExchangeDescription
            // 
            this.LblExchangeDescription.AutoSize = true;
            this.LblExchangeDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExchangeDescription.Location = new System.Drawing.Point(320, 127);
            this.LblExchangeDescription.Name = "LblExchangeDescription";
            this.LblExchangeDescription.Size = new System.Drawing.Size(106, 21);
            this.LblExchangeDescription.TabIndex = 16;
            this.LblExchangeDescription.Text = "1 USD to INR";
            // 
            // LblReset
            // 
            this.LblReset.AutoSize = true;
            this.LblReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReset.Location = new System.Drawing.Point(17, 216);
            this.LblReset.Name = "LblReset";
            this.LblReset.Size = new System.Drawing.Size(149, 21);
            this.LblReset.TabIndex = 17;
            this.LblReset.Text = "Reset Application";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(182, 211);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(244, 30);
            this.BtnReset.TabIndex = 18;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // UcSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblReset);
            this.Controls.Add(this.LblExchangeDescription);
            this.Controls.Add(this.NumUDExchangeRate);
            this.Controls.Add(this.LblRefreshValue);
            this.Controls.Add(this.LblReconnectValue);
            this.Controls.Add(this.TrkBarReconnectDelay);
            this.Controls.Add(this.TrkBarRefreshDelay);
            this.Controls.Add(this.LblExchange);
            this.Controls.Add(this.LblReconnect);
            this.Controls.Add(this.LblRefresh);
            this.Controls.Add(this.BtnSave);
            this.Name = "UcSettings";
            this.Size = new System.Drawing.Size(440, 350);
            ((System.ComponentModel.ISupportInitialize)(this.TrkBarRefreshDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBarReconnectDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDExchangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblRefresh;
        private System.Windows.Forms.Label LblReconnect;
        private System.Windows.Forms.Label LblExchange;
        public System.Windows.Forms.TrackBar TrkBarRefreshDelay;
        public System.Windows.Forms.TrackBar TrkBarReconnectDelay;
        public System.Windows.Forms.NumericUpDown NumUDExchangeRate;
        private System.Windows.Forms.Label LblExchangeDescription;
        private System.Windows.Forms.Label LblReset;
        public System.Windows.Forms.Button BtnReset;
        public System.Windows.Forms.Label LblReconnectValue;
        public System.Windows.Forms.Label LblRefreshValue;
    }
}
