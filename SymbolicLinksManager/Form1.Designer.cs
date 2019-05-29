namespace SymbolicLinksManager
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblFolder = new MetroFramework.Controls.MetroLabel();
            this.txtFolder = new MetroFramework.Controls.MetroTextBox();
            this.txtTargetFolder = new MetroFramework.Controls.MetroTextBox();
            this.lblTargetFolder = new MetroFramework.Controls.MetroLabel();
            this.btnCreateSymbolicLink = new MetroFramework.Controls.MetroButton();
            this.lblOverwrite = new MetroFramework.Controls.MetroLabel();
            this.toggleOverwrite = new MetroFramework.Controls.MetroToggle();
            this.folderSource = new System.Windows.Forms.FolderBrowserDialog();
            this.folderTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSourceFolder = new MetroFramework.Controls.MetroButton();
            this.btnTargetFolder = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(28, 65);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(91, 19);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Source Folder";
            // 
            // txtFolder
            // 
            // 
            // 
            // 
            this.txtFolder.CustomButton.Image = null;
            this.txtFolder.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtFolder.CustomButton.Name = "";
            this.txtFolder.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolder.CustomButton.TabIndex = 1;
            this.txtFolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolder.CustomButton.UseSelectable = true;
            this.txtFolder.CustomButton.Visible = false;
            this.txtFolder.Lines = new string[0];
            this.txtFolder.Location = new System.Drawing.Point(32, 91);
            this.txtFolder.MaxLength = 32767;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.PasswordChar = '\0';
            this.txtFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolder.SelectedText = "";
            this.txtFolder.SelectionLength = 0;
            this.txtFolder.SelectionStart = 0;
            this.txtFolder.ShortcutsEnabled = true;
            this.txtFolder.Size = new System.Drawing.Size(116, 23);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.UseSelectable = true;
            this.txtFolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTargetFolder
            // 
            // 
            // 
            // 
            this.txtTargetFolder.CustomButton.Image = null;
            this.txtTargetFolder.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtTargetFolder.CustomButton.Name = "";
            this.txtTargetFolder.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTargetFolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTargetFolder.CustomButton.TabIndex = 1;
            this.txtTargetFolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTargetFolder.CustomButton.UseSelectable = true;
            this.txtTargetFolder.CustomButton.Visible = false;
            this.txtTargetFolder.Lines = new string[0];
            this.txtTargetFolder.Location = new System.Drawing.Point(204, 91);
            this.txtTargetFolder.MaxLength = 32767;
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.PasswordChar = '\0';
            this.txtTargetFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTargetFolder.SelectedText = "";
            this.txtTargetFolder.SelectionLength = 0;
            this.txtTargetFolder.SelectionStart = 0;
            this.txtTargetFolder.ShortcutsEnabled = true;
            this.txtTargetFolder.Size = new System.Drawing.Size(116, 23);
            this.txtTargetFolder.TabIndex = 3;
            this.txtTargetFolder.UseSelectable = true;
            this.txtTargetFolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTargetFolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(200, 65);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(87, 19);
            this.lblTargetFolder.TabIndex = 2;
            this.lblTargetFolder.Text = "Target Folder";
            // 
            // btnCreateSymbolicLink
            // 
            this.btnCreateSymbolicLink.Location = new System.Drawing.Point(505, 91);
            this.btnCreateSymbolicLink.Name = "btnCreateSymbolicLink";
            this.btnCreateSymbolicLink.Size = new System.Drawing.Size(117, 35);
            this.btnCreateSymbolicLink.TabIndex = 4;
            this.btnCreateSymbolicLink.Text = "Create SymbLink";
            this.btnCreateSymbolicLink.UseSelectable = true;
            this.btnCreateSymbolicLink.Click += new System.EventHandler(this.btnCreateSymbolicLink_Click);
            // 
            // lblOverwrite
            // 
            this.lblOverwrite.AutoSize = true;
            this.lblOverwrite.Location = new System.Drawing.Point(555, 23);
            this.lblOverwrite.Name = "lblOverwrite";
            this.lblOverwrite.Size = new System.Drawing.Size(67, 19);
            this.lblOverwrite.TabIndex = 6;
            this.lblOverwrite.Text = "Overwrite";
            // 
            // toggleOverwrite
            // 
            this.toggleOverwrite.AutoSize = true;
            this.toggleOverwrite.Location = new System.Drawing.Point(542, 49);
            this.toggleOverwrite.Name = "toggleOverwrite";
            this.toggleOverwrite.Size = new System.Drawing.Size(80, 17);
            this.toggleOverwrite.TabIndex = 5;
            this.toggleOverwrite.Text = "Off";
            this.toggleOverwrite.UseSelectable = true;
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Location = new System.Drawing.Point(154, 91);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(27, 23);
            this.btnSourceFolder.TabIndex = 7;
            this.btnSourceFolder.Text = "...";
            this.btnSourceFolder.UseSelectable = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.Location = new System.Drawing.Point(326, 91);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(27, 23);
            this.btnTargetFolder.TabIndex = 8;
            this.btnTargetFolder.Text = "...";
            this.btnTargetFolder.UseSelectable = true;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 135);
            this.Controls.Add(this.btnTargetFolder);
            this.Controls.Add(this.btnSourceFolder);
            this.Controls.Add(this.lblOverwrite);
            this.Controls.Add(this.toggleOverwrite);
            this.Controls.Add(this.btnCreateSymbolicLink);
            this.Controls.Add(this.txtTargetFolder);
            this.Controls.Add(this.lblTargetFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "SymbolicLink Manager V1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblFolder;
        private MetroFramework.Controls.MetroTextBox txtFolder;
        private MetroFramework.Controls.MetroTextBox txtTargetFolder;
        private MetroFramework.Controls.MetroLabel lblTargetFolder;
        private MetroFramework.Controls.MetroButton btnCreateSymbolicLink;
        private MetroFramework.Controls.MetroLabel lblOverwrite;
        private MetroFramework.Controls.MetroToggle toggleOverwrite;
        private System.Windows.Forms.FolderBrowserDialog folderSource;
        private System.Windows.Forms.FolderBrowserDialog folderTarget;
        private MetroFramework.Controls.MetroButton btnSourceFolder;
        private MetroFramework.Controls.MetroButton btnTargetFolder;
    }
}

