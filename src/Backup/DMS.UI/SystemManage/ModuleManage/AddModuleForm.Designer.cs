﻿namespace DMS.UI.SystemManage.ModuleManage
{
    partial class AddModuleForm
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
            this.tbcSave = new DMS.UI.Common.ToolBarCommand();
            this.SuspendLayout();
            // 
            // tbcSave
            // 
            this.tbcSave.CommandName = "保存";
            this.tbcSave.ImagePath = null;
            this.tbcSave.IsEnable = true;
            this.tbcSave.IsVisible = true;
            this.tbcSave.Name = "保存";
            this.tbcSave.Type = DMS.UI.Common.CommandType.Save;
            this.tbcSave.Commanded += new System.EventHandler(this.tbcSave_Commanded);
            // 
            // AddModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(371, 427);
            this.Name = "AddModuleForm";
            this.Load += new System.EventHandler(this.AddModuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMS.UI.Common.ToolBarCommand tbcSave;
    }
}
