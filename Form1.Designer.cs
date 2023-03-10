namespace _1_prakt
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
            this.EncryptButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IVBox = new System.Windows.Forms.TextBox();
            this.keyWarningLabel = new System.Windows.Forms.Label();
            this.IVWarningLabel = new System.Windows.Forms.Label();
            this.encryptionComplete = new System.Windows.Forms.Label();
            this.decryptionComplete = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wrongFormatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(40, 463);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(101, 41);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(40, 60);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox.Size = new System.Drawing.Size(739, 201);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // keyBox
            // 
            this.keyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyBox.Location = new System.Drawing.Point(40, 421);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(739, 27);
            this.keyBox.TabIndex = 2;
            this.keyBox.TextChanged += new System.EventHandler(this.keyBox_TextChanged);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(40, 550);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultBox.Size = new System.Drawing.Size(739, 207);
            this.resultBox.TabIndex = 3;
            // 
            // DecipherButton
            // 
            this.DecipherButton.Location = new System.Drawing.Point(178, 463);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(101, 41);
            this.DecipherButton.TabIndex = 4;
            this.DecipherButton.Text = "Decipher";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(178, 763);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 41);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(41, 763);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 41);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save file";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(41, 278);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(101, 41);
            this.openButton.TabIndex = 10;
            this.openButton.Text = "Open file";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "IV:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // IVBox
            // 
            this.IVBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVBox.Location = new System.Drawing.Point(40, 355);
            this.IVBox.Name = "IVBox";
            this.IVBox.Size = new System.Drawing.Size(739, 27);
            this.IVBox.TabIndex = 12;
            // 
            // keyWarningLabel
            // 
            this.keyWarningLabel.AutoSize = true;
            this.keyWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyWarningLabel.Location = new System.Drawing.Point(333, 484);
            this.keyWarningLabel.Name = "keyWarningLabel";
            this.keyWarningLabel.Size = new System.Drawing.Size(384, 20);
            this.keyWarningLabel.TabIndex = 13;
            this.keyWarningLabel.Text = "Key is not correct length! It has to be 8 bytes long!";
            this.keyWarningLabel.Visible = false;
            this.keyWarningLabel.Click += new System.EventHandler(this.keyWarningLabel_Click);
            // 
            // IVWarningLabel
            // 
            this.IVWarningLabel.AutoSize = true;
            this.IVWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVWarningLabel.Location = new System.Drawing.Point(333, 463);
            this.IVWarningLabel.Name = "IVWarningLabel";
            this.IVWarningLabel.Size = new System.Drawing.Size(371, 20);
            this.IVWarningLabel.TabIndex = 14;
            this.IVWarningLabel.Text = "IV is not correct length! It has to be 8 bytes long!";
            this.IVWarningLabel.Visible = false;
            // 
            // encryptionComplete
            // 
            this.encryptionComplete.AutoSize = true;
            this.encryptionComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionComplete.Location = new System.Drawing.Point(613, 763);
            this.encryptionComplete.Name = "encryptionComplete";
            this.encryptionComplete.Size = new System.Drawing.Size(166, 20);
            this.encryptionComplete.TabIndex = 15;
            this.encryptionComplete.Text = "Encryption complete!";
            this.encryptionComplete.Visible = false;
            // 
            // decryptionComplete
            // 
            this.decryptionComplete.AutoSize = true;
            this.decryptionComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptionComplete.Location = new System.Drawing.Point(611, 763);
            this.decryptionComplete.Name = "decryptionComplete";
            this.decryptionComplete.Size = new System.Drawing.Size(168, 20);
            this.decryptionComplete.TabIndex = 16;
            this.decryptionComplete.Text = "Decryption complete!";
            this.decryptionComplete.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 784);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 17;
            this.label5.Visible = false;
            // 
            // wrongFormatLabel
            // 
            this.wrongFormatLabel.AutoSize = true;
            this.wrongFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongFormatLabel.Location = new System.Drawing.Point(295, 764);
            this.wrongFormatLabel.Name = "wrongFormatLabel";
            this.wrongFormatLabel.Size = new System.Drawing.Size(466, 60);
            this.wrongFormatLabel.TabIndex = 18;
            this.wrongFormatLabel.Text = "Decryption error. \r\nThe text you are trying to decrypt was not actually encrypted" +
    ", \r\nor you are using wrong key or iv.\r\n";
            this.wrongFormatLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 834);
            this.Controls.Add(this.wrongFormatLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decryptionComplete);
            this.Controls.Add(this.encryptionComplete);
            this.Controls.Add(this.IVWarningLabel);
            this.Controls.Add(this.keyWarningLabel);
            this.Controls.Add(this.IVBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecipherButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.EncryptButton);
            this.Name = "Form1";
            this.Text = "DES algorithm, CBC mode";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox IVBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IVWarningLabel;
        private System.Windows.Forms.Label keyWarningLabel;
        private System.Windows.Forms.Label decryptionComplete;
        private System.Windows.Forms.Label encryptionComplete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wrongFormatLabel;
    }
}

