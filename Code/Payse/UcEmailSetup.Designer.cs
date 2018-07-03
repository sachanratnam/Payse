namespace Payse
{
    partial class UcEmailSetup
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnMailLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblTitle.Location = new System.Drawing.Point(26, 40);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(427, 36);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Connect your Gmail account";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMailLogin
            // 
            this.BtnMailLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.BtnMailLogin.FlatAppearance.BorderSize = 0;
            this.BtnMailLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMailLogin.ForeColor = System.Drawing.Color.White;
            this.BtnMailLogin.Location = new System.Drawing.Point(160, 180);
            this.BtnMailLogin.Name = "BtnMailLogin";
            this.BtnMailLogin.Size = new System.Drawing.Size(160, 50);
            this.BtnMailLogin.TabIndex = 9;
            this.BtnMailLogin.Text = "LOGIN";
            this.BtnMailLogin.UseVisualStyleBackColor = false;
            this.BtnMailLogin.Click += new System.EventHandler(this.BtnMailLogin_Click);
            // 
            // UcEmailSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.BtnMailLogin);
            this.Controls.Add(this.LblTitle);
            this.Name = "UcEmailSetup";
            this.Size = new System.Drawing.Size(480, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblTitle;
        public System.Windows.Forms.Button BtnMailLogin;
    }
}
