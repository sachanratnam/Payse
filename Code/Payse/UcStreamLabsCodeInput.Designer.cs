namespace Payse
{
    partial class UcStreamLabsCodeInput
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
            this.BtnStreamLabsCodeVerify = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TbStreamLabsCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStreamLabsCodeVerify
            // 
            this.BtnStreamLabsCodeVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.BtnStreamLabsCodeVerify.FlatAppearance.BorderSize = 0;
            this.BtnStreamLabsCodeVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStreamLabsCodeVerify.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStreamLabsCodeVerify.ForeColor = System.Drawing.Color.White;
            this.BtnStreamLabsCodeVerify.Location = new System.Drawing.Point(160, 180);
            this.BtnStreamLabsCodeVerify.Name = "BtnStreamLabsCodeVerify";
            this.BtnStreamLabsCodeVerify.Size = new System.Drawing.Size(160, 50);
            this.BtnStreamLabsCodeVerify.TabIndex = 13;
            this.BtnStreamLabsCodeVerify.Text = "VERIFY";
            this.BtnStreamLabsCodeVerify.UseVisualStyleBackColor = false;
            this.BtnStreamLabsCodeVerify.Click += new System.EventHandler(this.BtnStreamLabsCodeVerify_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(56, 40);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(358, 36);
            this.LblTitle.TabIndex = 12;
            this.LblTitle.Text = "Enter code from browser";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbStreamLabsCode
            // 
            this.TbStreamLabsCode.BackColor = System.Drawing.Color.White;
            this.TbStreamLabsCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbStreamLabsCode.Location = new System.Drawing.Point(75, 108);
            this.TbStreamLabsCode.Name = "TbStreamLabsCode";
            this.TbStreamLabsCode.Size = new System.Drawing.Size(321, 27);
            this.TbStreamLabsCode.TabIndex = 14;
            // 
            // UcStreamLabsCodeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.TbStreamLabsCode);
            this.Controls.Add(this.BtnStreamLabsCodeVerify);
            this.Controls.Add(this.LblTitle);
            this.Name = "UcStreamLabsCodeInput";
            this.Size = new System.Drawing.Size(480, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnStreamLabsCodeVerify;
        public System.Windows.Forms.Label LblTitle;
        public System.Windows.Forms.TextBox TbStreamLabsCode;
    }
}
