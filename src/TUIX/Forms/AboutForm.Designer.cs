﻿
namespace TweakUIX
{
    partial class AboutForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnAppUpdate = new System.Windows.Forms.Button();
            this.richInfo = new System.Windows.Forms.RichTextBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.linkAppInfo = new System.Windows.Forms.LinkLabel();
            this.lblAssemblyInfo = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.btnAppUpdate);
            this.groupBox.Controls.Add(this.richInfo);
            this.groupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox.Location = new System.Drawing.Point(12, 281);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(502, 188);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "About Tweak UIX";
            // 
            // btnAppUpdate
            // 
            this.btnAppUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnAppUpdate.Location = new System.Drawing.Point(356, 149);
            this.btnAppUpdate.Name = "btnAppUpdate";
            this.btnAppUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnAppUpdate.TabIndex = 12;
            this.btnAppUpdate.Text = "Check for updates...";
            this.btnAppUpdate.UseVisualStyleBackColor = true;
            this.btnAppUpdate.Click += new System.EventHandler(this.btnAppUpdate_Click);
            // 
            // richInfo
            // 
            this.richInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richInfo.BackColor = System.Drawing.SystemColors.Control;
            this.richInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richInfo.Location = new System.Drawing.Point(15, 29);
            this.richInfo.Name = "richInfo";
            this.richInfo.ReadOnly = true;
            this.richInfo.Size = new System.Drawing.Size(481, 114);
            this.richInfo.TabIndex = 11;
            this.richInfo.Text = "";
            this.richInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richInfo_LinkClicked);
            // 
            // picture1
            // 
            this.picture1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture1.ErrorImage = null;
            this.picture1.InitialImage = null;
            this.picture1.Location = new System.Drawing.Point(12, 12);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(502, 234);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 17;
            this.picture1.TabStop = false;
            this.picture1.Paint += new System.Windows.Forms.PaintEventHandler(this.picture1_Paint);
            // 
            // linkAppInfo
            // 
            this.linkAppInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkAppInfo.AutoEllipsis = true;
            this.linkAppInfo.BackColor = System.Drawing.Color.Transparent;
            this.linkAppInfo.Location = new System.Drawing.Point(148, 115);
            this.linkAppInfo.Name = "linkAppInfo";
            this.linkAppInfo.Size = new System.Drawing.Size(273, 13);
            this.linkAppInfo.TabIndex = 18;
            this.linkAppInfo.TabStop = true;
            this.linkAppInfo.Text = "More information about Tweak UIX...";
            this.linkAppInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAppInfo_LinkClicked);
            // 
            // lblAssemblyInfo
            // 
            this.lblAssemblyInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAssemblyInfo.AutoEllipsis = true;
            this.lblAssemblyInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblAssemblyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblyInfo.Location = new System.Drawing.Point(148, 88);
            this.lblAssemblyInfo.Name = "lblAssemblyInfo";
            this.lblAssemblyInfo.Size = new System.Drawing.Size(341, 27);
            this.lblAssemblyInfo.TabIndex = 19;
            this.lblAssemblyInfo.Text = "loading......";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 538);
            this.Controls.Add(this.lblAssemblyInfo);
            this.Controls.Add(this.linkAppInfo);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.groupBox);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.Shown += new System.EventHandler(this.AboutForm_Shown);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richInfo;
        private System.Windows.Forms.Button btnAppUpdate;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.LinkLabel linkAppInfo;
        private System.Windows.Forms.Label lblAssemblyInfo;
    }
}