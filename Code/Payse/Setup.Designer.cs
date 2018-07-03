namespace Payse
{
    partial class Setup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.PnlTitleBar = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlBottomBar = new System.Windows.Forms.Panel();
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.ucSetupComplete1 = new Payse.UcSetupComplete();
            this.ucStreamLabsCodeInput1 = new Payse.UcStreamLabsCodeInput();
            this.ucStreamLabsSetup1 = new Payse.UcStreamLabsSetup();
            this.ucEmailSetupComplete1 = new Payse.UcEmailSetupComplete();
            this.ucEmailSetup1 = new Payse.UcEmailSetup();
            this.PnlTitleBar.SuspendLayout();
            this.PnlSideBar.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.PnlTitleBar.Controls.Add(this.LblTitle);
            this.PnlTitleBar.Controls.Add(this.BtnMinimize);
            this.PnlTitleBar.Controls.Add(this.BtnClose);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.Size = new System.Drawing.Size(600, 50);
            this.PnlTitleBar.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(31, 6);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(99, 36);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Payse";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Image = global::Payse.Properties.Resources.min;
            this.BtnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMinimize.Location = new System.Drawing.Point(500, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(50, 50);
            this.BtnMinimize.TabIndex = 7;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = global::Payse.Properties.Resources.close;
            this.BtnClose.Location = new System.Drawing.Point(550, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(50, 50);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PnlBottomBar
            // 
            this.PnlBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.PnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottomBar.Location = new System.Drawing.Point(0, 390);
            this.PnlBottomBar.Name = "PnlBottomBar";
            this.PnlBottomBar.Size = new System.Drawing.Size(600, 10);
            this.PnlBottomBar.TabIndex = 1;
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PnlSideBar.Controls.Add(this.BtnBack);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 50);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(60, 340);
            this.PnlSideBar.TabIndex = 2;
            // 
            // BtnBack
            // 
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Image = global::Payse.Properties.Resources.back;
            this.BtnBack.Location = new System.Drawing.Point(0, 40);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(60, 37);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(540, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 340);
            this.panel1.TabIndex = 3;
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.ucSetupComplete1);
            this.PnlMain.Controls.Add(this.ucStreamLabsCodeInput1);
            this.PnlMain.Controls.Add(this.ucStreamLabsSetup1);
            this.PnlMain.Controls.Add(this.ucEmailSetupComplete1);
            this.PnlMain.Controls.Add(this.ucEmailSetup1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(60, 50);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(480, 340);
            this.PnlMain.TabIndex = 4;
            // 
            // ucSetupComplete1
            // 
            this.ucSetupComplete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ucSetupComplete1.Location = new System.Drawing.Point(0, 0);
            this.ucSetupComplete1.Name = "ucSetupComplete1";
            this.ucSetupComplete1.Size = new System.Drawing.Size(480, 340);
            this.ucSetupComplete1.TabIndex = 4;
            // 
            // ucStreamLabsCodeInput1
            // 
            this.ucStreamLabsCodeInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ucStreamLabsCodeInput1.Location = new System.Drawing.Point(0, 0);
            this.ucStreamLabsCodeInput1.Name = "ucStreamLabsCodeInput1";
            this.ucStreamLabsCodeInput1.Size = new System.Drawing.Size(480, 340);
            this.ucStreamLabsCodeInput1.TabIndex = 3;
            // 
            // ucStreamLabsSetup1
            // 
            this.ucStreamLabsSetup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ucStreamLabsSetup1.Location = new System.Drawing.Point(0, 0);
            this.ucStreamLabsSetup1.Name = "ucStreamLabsSetup1";
            this.ucStreamLabsSetup1.Size = new System.Drawing.Size(480, 340);
            this.ucStreamLabsSetup1.TabIndex = 2;
            // 
            // ucEmailSetupComplete1
            // 
            this.ucEmailSetupComplete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ucEmailSetupComplete1.Location = new System.Drawing.Point(0, 0);
            this.ucEmailSetupComplete1.Name = "ucEmailSetupComplete1";
            this.ucEmailSetupComplete1.Size = new System.Drawing.Size(480, 340);
            this.ucEmailSetupComplete1.TabIndex = 1;
            // 
            // ucEmailSetup1
            // 
            this.ucEmailSetup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ucEmailSetup1.Location = new System.Drawing.Point(0, 0);
            this.ucEmailSetup1.Name = "ucEmailSetup1";
            this.ucEmailSetup1.Size = new System.Drawing.Size(480, 340);
            this.ucEmailSetup1.TabIndex = 0;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlSideBar);
            this.Controls.Add(this.PnlBottomBar);
            this.Controls.Add(this.PnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.PnlSideBar.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitleBar;
        private System.Windows.Forms.Panel PnlBottomBar;
        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlMain;
        private UcSetupComplete ucSetupComplete1;
        private UcStreamLabsCodeInput ucStreamLabsCodeInput1;
        private UcStreamLabsSetup ucStreamLabsSetup1;
        private UcEmailSetupComplete ucEmailSetupComplete1;
        private UcEmailSetup ucEmailSetup1;
        private System.Windows.Forms.Label LblTitle;
    }
}