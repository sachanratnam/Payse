namespace Payse
{
    partial class UcHome
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TbError = new System.Windows.Forms.TextBox();
            this.PicBoxStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.BtnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(0, 300);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(440, 50);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "START";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(94, 17);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(248, 30);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "Inactive";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbError
            // 
            this.TbError.AcceptsReturn = true;
            this.TbError.BackColor = System.Drawing.Color.White;
            this.TbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.TbError.Location = new System.Drawing.Point(12, 243);
            this.TbError.Multiline = true;
            this.TbError.Name = "TbError";
            this.TbError.ReadOnly = true;
            this.TbError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbError.Size = new System.Drawing.Size(418, 45);
            this.TbError.TabIndex = 5;
            this.TbError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbError.Visible = false;
            this.TbError.WordWrap = false;
            // 
            // PicBoxStatus
            // 
            this.PicBoxStatus.Image = global::Payse.Properties.Resources.inactive;
            this.PicBoxStatus.Location = new System.Drawing.Point(154, 77);
            this.PicBoxStatus.Name = "PicBoxStatus";
            this.PicBoxStatus.Size = new System.Drawing.Size(130, 130);
            this.PicBoxStatus.TabIndex = 3;
            this.PicBoxStatus.TabStop = false;
            // 
            // UcHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TbError);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.PicBoxStatus);
            this.Controls.Add(this.BtnStart);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(440, 350);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnStart;
        public System.Windows.Forms.Label LblStatus;
        public System.Windows.Forms.TextBox TbError;
        public System.Windows.Forms.PictureBox PicBoxStatus;
    }
}
