namespace SubtitlesSync {
    partial class Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Execute = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Cancel = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.DeltaMillis = new System.Windows.Forms.NumericUpDown();
            this.Backward = new System.Windows.Forms.CheckBox();
            this.MillisDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaMillis)).BeginInit();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Execute.Location = new System.Drawing.Point(180, 133);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(98, 32);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(180, 41);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(98, 32);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse Subtitles";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "FileDialog";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(30, 133);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 32);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(180, 92);
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Size = new System.Drawing.Size(98, 20);
            this.FileName.TabIndex = 4;
            this.FileName.Text = "File Name";
            this.FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeltaMillis
            // 
            this.DeltaMillis.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.DeltaMillis.Location = new System.Drawing.Point(30, 60);
            this.DeltaMillis.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.DeltaMillis.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.DeltaMillis.Name = "DeltaMillis";
            this.DeltaMillis.Size = new System.Drawing.Size(100, 20);
            this.DeltaMillis.TabIndex = 5;
            this.DeltaMillis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeltaMillis.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // Backward
            // 
            this.Backward.AutoSize = true;
            this.Backward.Location = new System.Drawing.Point(40, 92);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(74, 17);
            this.Backward.TabIndex = 7;
            this.Backward.Text = "Backward";
            this.Backward.UseVisualStyleBackColor = true;
            // 
            // MillisDesc
            // 
            this.MillisDesc.BackColor = System.Drawing.SystemColors.Menu;
            this.MillisDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MillisDesc.Location = new System.Drawing.Point(30, 41);
            this.MillisDesc.Name = "MillisDesc";
            this.MillisDesc.Size = new System.Drawing.Size(100, 13);
            this.MillisDesc.TabIndex = 8;
            this.MillisDesc.Text = "Milliseconds";
            this.MillisDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form
            // 
            this.AcceptButton = this.Execute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(309, 204);
            this.Controls.Add(this.MillisDesc);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.DeltaMillis);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.Execute);
            this.Name = "Form";
            this.Text = "Subtitles Synchronizer";
            ((System.ComponentModel.ISupportInitialize)(this.DeltaMillis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.NumericUpDown DeltaMillis;
        private System.Windows.Forms.CheckBox Backward;
        private System.Windows.Forms.TextBox MillisDesc;
    }
}
