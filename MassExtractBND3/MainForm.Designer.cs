namespace MassExtractBND3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFolder = new Label();
            txtFolder = new TextBox();
            btnBrowse = new Button();
            btnExtract = new Button();
            txtCurrent = new TextBox();
            pbrExtract = new ProgressBar();
            chxOverwriteExistingFiles = new CheckBox();
            SuspendLayout();
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.ForeColor = SystemColors.Control;
            lblFolder.Location = new Point(12, 9);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(43, 15);
            lblFolder.TabIndex = 0;
            lblFolder.Text = "Folder:";
            // 
            // txtFolder
            // 
            txtFolder.AllowDrop = true;
            txtFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFolder.Location = new Point(61, 6);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(499, 23);
            txtFolder.TabIndex = 1;
            txtFolder.DragDrop += txtFolder_DragDrop;
            txtFolder.DragEnter += txtFolder_DragEnter;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(566, 6);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnExtract
            // 
            btnExtract.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExtract.Location = new Point(647, 6);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(75, 23);
            btnExtract.TabIndex = 3;
            btnExtract.Text = "Extract";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // txtCurrent
            // 
            txtCurrent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCurrent.Location = new Point(12, 35);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.ReadOnly = true;
            txtCurrent.Size = new Size(863, 23);
            txtCurrent.TabIndex = 4;
            // 
            // pbrExtract
            // 
            pbrExtract.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbrExtract.Location = new Point(12, 64);
            pbrExtract.Name = "pbrExtract";
            pbrExtract.Size = new Size(863, 23);
            pbrExtract.TabIndex = 5;
            // 
            // chxOverwriteExistingFiles
            // 
            chxOverwriteExistingFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chxOverwriteExistingFiles.AutoSize = true;
            chxOverwriteExistingFiles.Checked = true;
            chxOverwriteExistingFiles.CheckState = CheckState.Checked;
            chxOverwriteExistingFiles.ForeColor = SystemColors.Control;
            chxOverwriteExistingFiles.Location = new Point(728, 8);
            chxOverwriteExistingFiles.Name = "chxOverwriteExistingFiles";
            chxOverwriteExistingFiles.Size = new Size(147, 19);
            chxOverwriteExistingFiles.TabIndex = 6;
            chxOverwriteExistingFiles.Text = "Overwrite Existing Files";
            chxOverwriteExistingFiles.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AcceptButton = btnExtract;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(887, 99);
            Controls.Add(chxOverwriteExistingFiles);
            Controls.Add(pbrExtract);
            Controls.Add(txtCurrent);
            Controls.Add(btnExtract);
            Controls.Add(btnBrowse);
            Controls.Add(txtFolder);
            Controls.Add(lblFolder);
            MaximizeBox = false;
            MinimumSize = new Size(360, 138);
            Name = "MainForm";
            Text = "Mass Extract BND3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFolder;
        private TextBox txtFolder;
        private Button btnBrowse;
        private Button btnExtract;
        private TextBox txtCurrent;
        private ProgressBar pbrExtract;
        private CheckBox chxOverwriteExistingFiles;
    }
}