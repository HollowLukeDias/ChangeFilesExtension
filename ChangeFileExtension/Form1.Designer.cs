﻿namespace ChangeFileExtension
{
    partial class fileExtensionChanger
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileNamesList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Choose the files";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            // 
            // userInputBox
            // 
            this.userInputBox.Location = new System.Drawing.Point(339, 39);
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.Size = new System.Drawing.Size(80, 22);
            this.userInputBox.TabIndex = 1;
            this.userInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userInputBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change the extension to:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "BROWSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(363, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.okButton_Click);
            // 
            // fileNamesList
            // 
            this.fileNamesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.fileNamesList.FullRowSelect = true;
            this.fileNamesList.GridLines = true;
            this.fileNamesList.HideSelection = false;
            this.fileNamesList.Location = new System.Drawing.Point(7, 83);
            this.fileNamesList.Name = "fileNamesList";
            this.fileNamesList.Size = new System.Drawing.Size(217, 163);
            this.fileNamesList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.fileNamesList.TabIndex = 6;
            this.fileNamesList.UseCompatibleStateImageBehavior = false;
            this.fileNamesList.View = System.Windows.Forms.View.Details;
            // 
            // fileExtensionChanger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(431, 257);
            this.Controls.Add(this.fileNamesList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "fileExtensionChanger";
            this.Text = "Change Files Extension";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox userInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView fileNamesList;
    }
}

