namespace Payse
{
    partial class UcEmailSetupComplete
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
            this.BtnMailSetupFinish = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMailSetupFinish
            // 
            this.BtnMailSetupFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.BtnMailSetupFinish.FlatAppearance.BorderSize = 0;
            this.BtnMailSetupFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailSetupFinish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMailSetupFinish.ForeColor = System.Drawing.Color.White;
            this.BtnMailSetupFinish.Location = new System.Drawing.Point(160, 180);
            this.BtnMailSetupFinish.Name = "BtnMailSetupFinish";
            this.BtnMailSetupFinish.Size = new System.Drawing.Size(160, 50);
            this.BtnMailSetupFinish.TabIndex = 11;
            this.BtnMailSetupFinish.Text = "NEXT";
            this.BtnMailSetupFinish.UseVisualStyleBackColor = false;
            this.BtnMailSetupFinish.Click += new System.EventHandler(this.BtnMailSetupFinish_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblTitle.Location = new System.Drawing.Point(65, 40);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(349, 72);
            this.LblTitle.TabIndex = 10;
            this.LblTitle.Text = "Your Gmail account is \r\nconnected successfully";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcEmailSetupComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.BtnMailSetupFinish);
            this.Controls.Add(this.LblTitle);
            this.Name = "UcEmailSetupComplete";
            this.Size = new System.Drawing.Size(480, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnMailSetupFinish;
        public System.Windows.Forms.Label LblTitle;
    }
}
