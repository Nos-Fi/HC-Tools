namespace XMLScriptMerger
{
    partial class Form1
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
            this.pfadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPathButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.noDeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pfadTextBox
            // 
            this.pfadTextBox.Location = new System.Drawing.Point(97, 9);
            this.pfadTextBox.Name = "pfadTextBox";
            this.pfadTextBox.Size = new System.Drawing.Size(438, 20);
            this.pfadTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Script-xml Pfad";
            // 
            // searchPathButton
            // 
            this.searchPathButton.Location = new System.Drawing.Point(541, 8);
            this.searchPathButton.Name = "searchPathButton";
            this.searchPathButton.Size = new System.Drawing.Size(25, 23);
            this.searchPathButton.TabIndex = 2;
            this.searchPathButton.Text = "...";
            this.searchPathButton.UseVisualStyleBackColor = true;
            this.searchPathButton.Click += new System.EventHandler(this.searchPathButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(491, 49);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(75, 23);
            this.mergeButton.TabIndex = 3;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // noDeleteCheckBox
            // 
            this.noDeleteCheckBox.AutoSize = true;
            this.noDeleteCheckBox.Location = new System.Drawing.Point(15, 49);
            this.noDeleteCheckBox.Name = "noDeleteCheckBox";
            this.noDeleteCheckBox.Size = new System.Drawing.Size(154, 17);
            this.noDeleteCheckBox.TabIndex = 4;
            this.noDeleteCheckBox.Text = "XML Dateien nicht löschen";
            this.noDeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "script.xml|script.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 79);
            this.Controls.Add(this.noDeleteCheckBox);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.searchPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pfadTextBox);
            this.Name = "Form1";
            this.Text = "XMLScriptMerger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pfadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPathButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.CheckBox noDeleteCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

