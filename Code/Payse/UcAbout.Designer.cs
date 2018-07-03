namespace Payse
{
    partial class UcAbout
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
            this.TbAbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TbAbout
            // 
            this.TbAbout.BackColor = System.Drawing.Color.White;
            this.TbAbout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAbout.Location = new System.Drawing.Point(0, 0);
            this.TbAbout.Name = "TbAbout";
            this.TbAbout.ReadOnly = true;
            this.TbAbout.Size = new System.Drawing.Size(440, 350);
            this.TbAbout.TabIndex = 0;
            this.TbAbout.Text = "\nPayse is a free and open source utility which send alert of payments recieved fr" +
    "om Indian payment system to StreamLabs.\n\nFor more infomation visit:\n https://git" +
    "hub.com/heyanush/Payse";
            // 
            // UcAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TbAbout);
            this.Name = "UcAbout";
            this.Size = new System.Drawing.Size(440, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TbAbout;
    }
}
