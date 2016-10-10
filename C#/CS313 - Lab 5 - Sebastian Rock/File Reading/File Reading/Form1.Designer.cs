namespace File_Reading
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
            this.lblStartingTextLine = new System.Windows.Forms.Label();
            this.lblEndingTextLine = new System.Windows.Forms.Label();
            this.txtStartingLineNumber = new System.Windows.Forms.TextBox();
            this.txtEndingLineNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOpenFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnReadTextLines = new System.Windows.Forms.Button();
            this.txtWriteFilePath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStartingTextLine
            // 
            this.lblStartingTextLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartingTextLine.Location = new System.Drawing.Point(216, 59);
            this.lblStartingTextLine.Name = "lblStartingTextLine";
            this.lblStartingTextLine.Size = new System.Drawing.Size(377, 23);
            this.lblStartingTextLine.TabIndex = 0;
            // 
            // lblEndingTextLine
            // 
            this.lblEndingTextLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndingTextLine.Location = new System.Drawing.Point(216, 97);
            this.lblEndingTextLine.Name = "lblEndingTextLine";
            this.lblEndingTextLine.Size = new System.Drawing.Size(377, 23);
            this.lblEndingTextLine.TabIndex = 1;
            // 
            // txtStartingLineNumber
            // 
            this.txtStartingLineNumber.Location = new System.Drawing.Point(97, 62);
            this.txtStartingLineNumber.Name = "txtStartingLineNumber";
            this.txtStartingLineNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStartingLineNumber.TabIndex = 2;
            // 
            // txtEndingLineNumber
            // 
            this.txtEndingLineNumber.Location = new System.Drawing.Point(97, 100);
            this.txtEndingLineNumber.Name = "txtEndingLineNumber";
            this.txtEndingLineNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEndingLineNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Starting Line:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ending Line:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(467, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOpenFilePath
            // 
            this.txtOpenFilePath.Location = new System.Drawing.Point(293, 31);
            this.txtOpenFilePath.Name = "txtOpenFilePath";
            this.txtOpenFilePath.Size = new System.Drawing.Size(167, 20);
            this.txtOpenFilePath.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(467, 28);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(126, 23);
            this.btnOpenFile.TabIndex = 10;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnReadTextLines
            // 
            this.btnReadTextLines.Location = new System.Drawing.Point(467, 135);
            this.btnReadTextLines.Name = "btnReadTextLines";
            this.btnReadTextLines.Size = new System.Drawing.Size(126, 23);
            this.btnReadTextLines.TabIndex = 11;
            this.btnReadTextLines.Text = "Read Text";
            this.btnReadTextLines.UseVisualStyleBackColor = true;
            this.btnReadTextLines.Click += new System.EventHandler(this.btnReadTextLines_Click);
            // 
            // txtWriteFilePath
            // 
            this.txtWriteFilePath.Location = new System.Drawing.Point(30, 137);
            this.txtWriteFilePath.Name = "txtWriteFilePath";
            this.txtWriteFilePath.Size = new System.Drawing.Size(197, 20);
            this.txtWriteFilePath.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(233, 135);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 214);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtWriteFilePath);
            this.Controls.Add(this.btnReadTextLines);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtOpenFilePath);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndingLineNumber);
            this.Controls.Add(this.txtStartingLineNumber);
            this.Controls.Add(this.lblEndingTextLine);
            this.Controls.Add(this.lblStartingTextLine);
            this.Name = "Form1";
            this.Text = "Text Line Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartingTextLine;
        private System.Windows.Forms.Label lblEndingTextLine;
        private System.Windows.Forms.TextBox txtStartingLineNumber;
        private System.Windows.Forms.TextBox txtEndingLineNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOpenFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnReadTextLines;
        private System.Windows.Forms.TextBox txtWriteFilePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowse;
    }
}

