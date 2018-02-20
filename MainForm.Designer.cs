namespace FileChecker
{
    partial class FileChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileChecker));
            this.SearchButton = new System.Windows.Forms.Button();
            this.languagesLabel = new System.Windows.Forms.Label();
            this.languagesField = new System.Windows.Forms.TextBox();
            this.toolTipForLanguagesField = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileNamesField = new System.Windows.Forms.TextBox();
            this.filesLabel = new System.Windows.Forms.Label();
            this.pathToFolderLabel = new System.Windows.Forms.Label();
            this.pathToFolderField = new System.Windows.Forms.TextBox();
            this.resultsField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(392, 216);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(89, 52);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // languagesLabel
            // 
            this.languagesLabel.AutoSize = true;
            this.languagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languagesLabel.Location = new System.Drawing.Point(19, 77);
            this.languagesLabel.Name = "languagesLabel";
            this.languagesLabel.Size = new System.Drawing.Size(135, 24);
            this.languagesLabel.TabIndex = 1;
            this.languagesLabel.Text = "Languages IDs";
            this.languagesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // languagesField
            // 
            this.languagesField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languagesField.Location = new System.Drawing.Point(168, 74);
            this.languagesField.Name = "languagesField";
            this.languagesField.Size = new System.Drawing.Size(301, 29);
            this.languagesField.TabIndex = 2;
            this.languagesField.Text = "0,1,2,3,5,15,63";
            // 
            // toolTipForLanguagesField
            // 
            this.toolTipForLanguagesField.ToolTipTitle = "Languages IDs separated by commas.";
            this.toolTipForLanguagesField.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipForLanguagesField_Popup);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pathToFolderField);
            this.panel1.Controls.Add(this.pathToFolderLabel);
            this.panel1.Controls.Add(this.filesLabel);
            this.panel1.Controls.Add(this.fileNamesField);
            this.panel1.Controls.Add(this.languagesLabel);
            this.panel1.Controls.Add(this.languagesField);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 179);
            this.panel1.TabIndex = 3;
            // 
            // fileNamesField
            // 
            this.fileNamesField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNamesField.Location = new System.Drawing.Point(168, 27);
            this.fileNamesField.Name = "fileNamesField";
            this.fileNamesField.Size = new System.Drawing.Size(301, 29);
            this.fileNamesField.TabIndex = 3;
            this.fileNamesField.Text = "Test, TestSecond";
            this.fileNamesField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // filesLabel
            // 
            this.filesLabel.AutoSize = true;
            this.filesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesLabel.Location = new System.Drawing.Point(19, 32);
            this.filesLabel.Name = "filesLabel";
            this.filesLabel.Size = new System.Drawing.Size(103, 24);
            this.filesLabel.TabIndex = 4;
            this.filesLabel.Text = "File names";
            this.toolTipForLanguagesField.SetToolTip(this.filesLabel, "fdfdfdf");
            // 
            // pathToFolderLabel
            // 
            this.pathToFolderLabel.AutoSize = true;
            this.pathToFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathToFolderLabel.Location = new System.Drawing.Point(19, 122);
            this.pathToFolderLabel.Name = "pathToFolderLabel";
            this.pathToFolderLabel.Size = new System.Drawing.Size(119, 24);
            this.pathToFolderLabel.TabIndex = 5;
            this.pathToFolderLabel.Text = "Path to folder";
            // 
            // pathToFolderField
            // 
            this.pathToFolderField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathToFolderField.Location = new System.Drawing.Point(170, 121);
            this.pathToFolderField.Name = "pathToFolderField";
            this.pathToFolderField.Size = new System.Drawing.Size(299, 29);
            this.pathToFolderField.TabIndex = 6;
            this.pathToFolderField.Text = "D:\\Test";
            // 
            // resultsField
            // 
            this.resultsField.Location = new System.Drawing.Point(35, 216);
            this.resultsField.Multiline = true;
            this.resultsField.Name = "resultsField";
            this.resultsField.Size = new System.Drawing.Size(351, 52);
            this.resultsField.TabIndex = 4;
            // 
            // FileChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 292);
            this.Controls.Add(this.resultsField);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileChecker";
            this.Text = "FileChecker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label languagesLabel;
        private System.Windows.Forms.TextBox languagesField;
        private System.Windows.Forms.ToolTip toolTipForLanguagesField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label filesLabel;
        private System.Windows.Forms.TextBox fileNamesField;
        private System.Windows.Forms.TextBox pathToFolderField;
        private System.Windows.Forms.Label pathToFolderLabel;
        private System.Windows.Forms.TextBox resultsField;
    }
}

