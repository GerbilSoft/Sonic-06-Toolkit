﻿namespace Toolkit.Tools
{
    partial class XNOTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XNOTool));
            this.option_Culling = new System.Windows.Forms.ToolStripMenuItem();
            this.modes_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.modes_ModelAndAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.modes_Model = new System.Windows.Forms.ToolStripMenuItem();
            this.options_Modes = new System.Windows.Forms.ToolStripMenuItem();
            this.modes_BackfaceCulling = new System.Windows.Forms.ToolStripMenuItem();
            this.main_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrip_Options = new System.Windows.Forms.MenuStrip();
            this.tm_ModeCheck = new System.Windows.Forms.Timer(this.components);
            this.clb_XNMs = new System.Windows.Forms.CheckedListBox();
            this.btn_Process = new System.Windows.Forms.Button();
            this.btn_DeselectAll = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.clb_XNOs = new System.Windows.Forms.CheckedListBox();
            this.split_XNMStudio = new System.Windows.Forms.SplitContainer();
            this.clb_XNOs_XNM = new System.Windows.Forms.CheckedListBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_Backdrop = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_DeselectAllXNMs = new System.Windows.Forms.Button();
            this.btn_SelectAllXNMs = new System.Windows.Forms.Button();
            this.mstrip_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_XNMStudio)).BeginInit();
            this.split_XNMStudio.Panel1.SuspendLayout();
            this.split_XNMStudio.Panel2.SuspendLayout();
            this.split_XNMStudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.pnl_Backdrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // option_Culling
            // 
            this.option_Culling.CheckOnClick = true;
            this.option_Culling.Name = "option_Culling";
            this.option_Culling.Size = new System.Drawing.Size(180, 22);
            this.option_Culling.Text = "Enable Culling";
            this.option_Culling.Visible = false;
            // 
            // modes_Separator1
            // 
            this.modes_Separator1.Name = "modes_Separator1";
            this.modes_Separator1.Size = new System.Drawing.Size(175, 6);
            // 
            // modes_ModelAndAnimation
            // 
            this.modes_ModelAndAnimation.CheckOnClick = true;
            this.modes_ModelAndAnimation.Name = "modes_ModelAndAnimation";
            this.modes_ModelAndAnimation.Size = new System.Drawing.Size(178, 22);
            this.modes_ModelAndAnimation.Text = "Model + Animation";
            this.modes_ModelAndAnimation.CheckedChanged += new System.EventHandler(this.Modes_ModelAndAnimation_CheckedChanged);
            // 
            // modes_Model
            // 
            this.modes_Model.CheckOnClick = true;
            this.modes_Model.Name = "modes_Model";
            this.modes_Model.Size = new System.Drawing.Size(178, 22);
            this.modes_Model.Text = "Model";
            this.modes_Model.CheckedChanged += new System.EventHandler(this.Modes_Model_CheckedChanged);
            // 
            // options_Modes
            // 
            this.options_Modes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modes_Model,
            this.modes_ModelAndAnimation,
            this.modes_Separator1,
            this.modes_BackfaceCulling});
            this.options_Modes.Name = "options_Modes";
            this.options_Modes.Size = new System.Drawing.Size(180, 22);
            this.options_Modes.Text = "Modes";
            // 
            // modes_BackfaceCulling
            // 
            this.modes_BackfaceCulling.CheckOnClick = true;
            this.modes_BackfaceCulling.Name = "modes_BackfaceCulling";
            this.modes_BackfaceCulling.Size = new System.Drawing.Size(178, 22);
            this.modes_BackfaceCulling.Text = "Backface Tool";
            this.modes_BackfaceCulling.CheckedChanged += new System.EventHandler(this.Modes_BackfaceCulling_CheckedChanged);
            // 
            // main_Options
            // 
            this.main_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_Modes,
            this.option_Culling});
            this.main_Options.Name = "main_Options";
            this.main_Options.Size = new System.Drawing.Size(61, 20);
            this.main_Options.Text = "Options";
            // 
            // mstrip_Options
            // 
            this.mstrip_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mstrip_Options.BackColor = System.Drawing.SystemColors.Control;
            this.mstrip_Options.Dock = System.Windows.Forms.DockStyle.None;
            this.mstrip_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main_Options});
            this.mstrip_Options.Location = new System.Drawing.Point(473, 387);
            this.mstrip_Options.Name = "mstrip_Options";
            this.mstrip_Options.Size = new System.Drawing.Size(69, 24);
            this.mstrip_Options.TabIndex = 57;
            this.mstrip_Options.Text = "menuStrip1";
            // 
            // tm_ModeCheck
            // 
            this.tm_ModeCheck.Tick += new System.EventHandler(this.Tm_ModeCheck_Tick);
            // 
            // clb_XNMs
            // 
            this.clb_XNMs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_XNMs.CheckOnClick = true;
            this.clb_XNMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_XNMs.FormattingEnabled = true;
            this.clb_XNMs.Location = new System.Drawing.Point(0, 0);
            this.clb_XNMs.Name = "clb_XNMs";
            this.clb_XNMs.Size = new System.Drawing.Size(302, 302);
            this.clb_XNMs.TabIndex = 0;
            this.clb_XNMs.SelectedIndexChanged += new System.EventHandler(this.Clb_XNMs_SelectedIndexChanged);
            // 
            // btn_Process
            // 
            this.btn_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(43)))));
            this.btn_Process.Enabled = false;
            this.btn_Process.FlatAppearance.BorderSize = 0;
            this.btn_Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.Location = new System.Drawing.Point(545, 388);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(75, 23);
            this.btn_Process.TabIndex = 55;
            this.btn_Process.Text = "Convert";
            this.btn_Process.UseVisualStyleBackColor = false;
            this.btn_Process.Click += new System.EventHandler(this.Btn_Process_Click);
            // 
            // btn_DeselectAll
            // 
            this.btn_DeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeselectAll.BackColor = System.Drawing.Color.Tomato;
            this.btn_DeselectAll.FlatAppearance.BorderSize = 0;
            this.btn_DeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeselectAll.Location = new System.Drawing.Point(91, 388);
            this.btn_DeselectAll.Name = "btn_DeselectAll";
            this.btn_DeselectAll.Size = new System.Drawing.Size(75, 23);
            this.btn_DeselectAll.TabIndex = 54;
            this.btn_DeselectAll.Text = "Deselect All";
            this.btn_DeselectAll.UseVisualStyleBackColor = false;
            this.btn_DeselectAll.Click += new System.EventHandler(this.Btn_DeselectAll_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SelectAll.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_SelectAll.FlatAppearance.BorderSize = 0;
            this.btn_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectAll.Location = new System.Drawing.Point(9, 388);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectAll.TabIndex = 53;
            this.btn_SelectAll.Text = "Select All";
            this.btn_SelectAll.UseVisualStyleBackColor = false;
            this.btn_SelectAll.Click += new System.EventHandler(this.Btn_SelectAll_Click);
            // 
            // clb_XNOs
            // 
            this.clb_XNOs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_XNOs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clb_XNOs.CheckOnClick = true;
            this.clb_XNOs.FormattingEnabled = true;
            this.clb_XNOs.Location = new System.Drawing.Point(9, 77);
            this.clb_XNOs.Name = "clb_XNOs";
            this.clb_XNOs.Size = new System.Drawing.Size(611, 304);
            this.clb_XNOs.TabIndex = 52;
            this.clb_XNOs.SelectedIndexChanged += new System.EventHandler(this.Clb_XNOs_SelectedIndexChanged);
            // 
            // split_XNMStudio
            // 
            this.split_XNMStudio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.split_XNMStudio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.split_XNMStudio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_XNMStudio.Location = new System.Drawing.Point(9, 77);
            this.split_XNMStudio.Name = "split_XNMStudio";
            // 
            // split_XNMStudio.Panel1
            // 
            this.split_XNMStudio.Panel1.Controls.Add(this.clb_XNOs_XNM);
            // 
            // split_XNMStudio.Panel2
            // 
            this.split_XNMStudio.Panel2.Controls.Add(this.clb_XNMs);
            this.split_XNMStudio.Size = new System.Drawing.Size(611, 304);
            this.split_XNMStudio.SplitterDistance = 303;
            this.split_XNMStudio.TabIndex = 56;
            // 
            // clb_XNOs_XNM
            // 
            this.clb_XNOs_XNM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_XNOs_XNM.CheckOnClick = true;
            this.clb_XNOs_XNM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_XNOs_XNM.FormattingEnabled = true;
            this.clb_XNOs_XNM.Location = new System.Drawing.Point(0, 0);
            this.clb_XNOs_XNM.Name = "clb_XNOs_XNM";
            this.clb_XNOs_XNM.Size = new System.Drawing.Size(301, 302);
            this.clb_XNOs_XNM.TabIndex = 0;
            this.clb_XNOs_XNM.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Clb_XNOs_XNM_ItemCheck);
            this.clb_XNOs_XNM.SelectedIndexChanged += new System.EventHandler(this.Clb_XNOs_XNM_SelectedIndexChanged);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Logo.BackgroundImage")));
            this.pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Logo.Location = new System.Drawing.Point(556, 1);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(67, 67);
            this.pic_Logo.TabIndex = 11;
            this.pic_Logo.TabStop = false;
            // 
            // pnl_Backdrop
            // 
            this.pnl_Backdrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Backdrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(164)))), ((int)(((byte)(43)))));
            this.pnl_Backdrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Backdrop.BackgroundImage")));
            this.pnl_Backdrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Backdrop.Controls.Add(this.pic_Logo);
            this.pnl_Backdrop.Controls.Add(this.lbl_Title);
            this.pnl_Backdrop.Location = new System.Drawing.Point(-2, -1);
            this.pnl_Backdrop.Name = "pnl_Backdrop";
            this.pnl_Backdrop.Size = new System.Drawing.Size(633, 69);
            this.pnl_Backdrop.TabIndex = 51;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Title.Location = new System.Drawing.Point(14, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(468, 47);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Model/Animation Exporter";
            // 
            // btn_DeselectAllXNMs
            // 
            this.btn_DeselectAllXNMs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_DeselectAllXNMs.BackColor = System.Drawing.Color.Tomato;
            this.btn_DeselectAllXNMs.FlatAppearance.BorderSize = 0;
            this.btn_DeselectAllXNMs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeselectAllXNMs.Location = new System.Drawing.Point(398, 388);
            this.btn_DeselectAllXNMs.Name = "btn_DeselectAllXNMs";
            this.btn_DeselectAllXNMs.Size = new System.Drawing.Size(75, 23);
            this.btn_DeselectAllXNMs.TabIndex = 59;
            this.btn_DeselectAllXNMs.Text = "Deselect All";
            this.btn_DeselectAllXNMs.UseVisualStyleBackColor = false;
            this.btn_DeselectAllXNMs.Visible = false;
            this.btn_DeselectAllXNMs.Click += new System.EventHandler(this.btn_DeselectAllXNMs_Click);
            // 
            // btn_SelectAllXNMs
            // 
            this.btn_SelectAllXNMs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_SelectAllXNMs.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_SelectAllXNMs.FlatAppearance.BorderSize = 0;
            this.btn_SelectAllXNMs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectAllXNMs.Location = new System.Drawing.Point(316, 388);
            this.btn_SelectAllXNMs.Name = "btn_SelectAllXNMs";
            this.btn_SelectAllXNMs.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectAllXNMs.TabIndex = 58;
            this.btn_SelectAllXNMs.Text = "Select All";
            this.btn_SelectAllXNMs.UseVisualStyleBackColor = false;
            this.btn_SelectAllXNMs.Visible = false;
            this.btn_SelectAllXNMs.Click += new System.EventHandler(this.btn_SelectAllXNMs_Click);
            // 
            // XNOTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 419);
            this.Controls.Add(this.btn_DeselectAllXNMs);
            this.Controls.Add(this.btn_SelectAllXNMs);
            this.Controls.Add(this.split_XNMStudio);
            this.Controls.Add(this.mstrip_Options);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.btn_DeselectAll);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.pnl_Backdrop);
            this.Controls.Add(this.clb_XNOs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(644, 458);
            this.Name = "XNOTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Model/Animation Exporter";
            this.Load += new System.EventHandler(this.ModelAnimationExporter_Load);
            this.mstrip_Options.ResumeLayout(false);
            this.mstrip_Options.PerformLayout();
            this.split_XNMStudio.Panel1.ResumeLayout(false);
            this.split_XNMStudio.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_XNMStudio)).EndInit();
            this.split_XNMStudio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.pnl_Backdrop.ResumeLayout(false);
            this.pnl_Backdrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem option_Culling;
        private System.Windows.Forms.ToolStripSeparator modes_Separator1;
        private System.Windows.Forms.ToolStripMenuItem modes_ModelAndAnimation;
        private System.Windows.Forms.ToolStripMenuItem modes_Model;
        private System.Windows.Forms.ToolStripMenuItem options_Modes;
        private System.Windows.Forms.ToolStripMenuItem modes_BackfaceCulling;
        private System.Windows.Forms.ToolStripMenuItem main_Options;
        private System.Windows.Forms.MenuStrip mstrip_Options;
        private System.Windows.Forms.Timer tm_ModeCheck;
        private System.Windows.Forms.CheckedListBox clb_XNMs;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Button btn_DeselectAll;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.CheckedListBox clb_XNOs;
        private System.Windows.Forms.SplitContainer split_XNMStudio;
        private System.Windows.Forms.CheckedListBox clb_XNOs_XNM;
        internal System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Panel pnl_Backdrop;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_DeselectAllXNMs;
        private System.Windows.Forms.Button btn_SelectAllXNMs;
    }
}