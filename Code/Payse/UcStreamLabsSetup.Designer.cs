namespace Payse
{
    partial class UcStreamLabsSetup
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
            this.BtnStreamLabsLogin = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnStreamLabsLogin
            // 
            this.BtnStreamLabsLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.BtnStreamLabsLogin.FlatAppearance.BorderSize = 0;
            this.BtnStreamLabsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStreamLabsLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStreamLabsLogin.ForeColor = System.Drawing.Color.White;
            this.BtnStreamLabsLogin.Location = new System.Drawing.Point(160, 180);
            this.BtnStreamLabsLogin.Name = "BtnStreamLabsLogin";
            this.BtnStreamLabsLogin.Size = new System.Drawing.Size(160, 50);
            this.BtnStreamLabsLogin.TabIndex = 11;
            this.BtnStreamLabsLogin.Text = "LOGIN";
            this.BtnStreamLabsLogin.UseVisualStyleBackColor = false;
            this.BtnStreamLabsLogin.Click += new System.EventHandler(this.BtnStreamLabsLogin_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(87, 40);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(304, 72);
            this.LblTitle.TabIndex = 10;
            this.LblTitle.Text = "Connect your \r\nStreamLabs account";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcStreamLabsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.BtnStreamLabsLogin);
            this.Controls.Add(this.LblTitle);
            this.Name = "UcStreamLabsSetup";
            this.Size = new System.Drawing.Size(480, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnStreamLabsLogin;
        public System.Windows.Forms.Label LblTitle;
    }
}
