namespace _3_prakt
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
            this.QBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wrongFormatLabel = new System.Windows.Forms.Label();
            this.PubKeyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PrivKeyBox = new System.Windows.Forms.TextBox();
            this.PubKeyGenButton = new System.Windows.Forms.Button();
            this.PrivKeyGenButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(35, 550);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(101, 51);
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
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(36, 329);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox.Size = new System.Drawing.Size(739, 205);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // QBox
            // 
            this.QBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QBox.Location = new System.Drawing.Point(434, 58);
            this.QBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QBox.Name = "QBox";
            this.QBox.Size = new System.Drawing.Size(345, 27);
            this.QBox.TabIndex = 2;
            this.QBox.TextChanged += new System.EventHandler(this.keyBox_TextChanged);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultBox.Location = new System.Drawing.Point(36, 640);
            this.resultBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultBox.Size = new System.Drawing.Size(739, 205);
            this.resultBox.TabIndex = 3;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // DecipherButton
            // 
            this.DecipherButton.Location = new System.Drawing.Point(161, 550);
            this.DecipherButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(101, 51);
            this.DecipherButton.TabIndex = 4;
            this.DecipherButton.Text = "Decipher";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(430, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "q";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(177, 853);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 51);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(40, 853);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 51);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save file";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(283, 550);
            this.openButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(101, 51);
            this.openButton.TabIndex = 10;
            this.openButton.Text = "Open file";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "p";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PBox
            // 
            this.PBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PBox.Location = new System.Drawing.Point(40, 58);
            this.PBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(345, 27);
            this.PBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(564, 980);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 17;
            this.label5.Visible = false;
            // 
            // wrongFormatLabel
            // 
            this.wrongFormatLabel.AutoSize = true;
            this.wrongFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wrongFormatLabel.Location = new System.Drawing.Point(312, 835);
            this.wrongFormatLabel.Name = "wrongFormatLabel";
            this.wrongFormatLabel.Size = new System.Drawing.Size(0, 20);
            this.wrongFormatLabel.TabIndex = 18;
            this.wrongFormatLabel.Visible = false;
            // 
            // PubKeyBox
            // 
            this.PubKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PubKeyBox.Location = new System.Drawing.Point(40, 150);
            this.PubKeyBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PubKeyBox.Name = "PubKeyBox";
            this.PubKeyBox.Size = new System.Drawing.Size(345, 27);
            this.PubKeyBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Public key:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(430, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Private key:";
            // 
            // PrivKeyBox
            // 
            this.PrivKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrivKeyBox.Location = new System.Drawing.Point(434, 150);
            this.PrivKeyBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrivKeyBox.Name = "PrivKeyBox";
            this.PrivKeyBox.Size = new System.Drawing.Size(345, 27);
            this.PrivKeyBox.TabIndex = 21;
            // 
            // PubKeyGenButton
            // 
            this.PubKeyGenButton.Location = new System.Drawing.Point(40, 191);
            this.PubKeyGenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PubKeyGenButton.Name = "PubKeyGenButton";
            this.PubKeyGenButton.Size = new System.Drawing.Size(107, 51);
            this.PubKeyGenButton.TabIndex = 23;
            this.PubKeyGenButton.Text = "Generate key";
            this.PubKeyGenButton.UseVisualStyleBackColor = true;
            this.PubKeyGenButton.Click += new System.EventHandler(this.PubKeyGenButton_Click);
            // 
            // PrivKeyGenButton
            // 
            this.PrivKeyGenButton.Location = new System.Drawing.Point(434, 191);
            this.PrivKeyGenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrivKeyGenButton.Name = "PrivKeyGenButton";
            this.PrivKeyGenButton.Size = new System.Drawing.Size(116, 51);
            this.PrivKeyGenButton.TabIndex = 24;
            this.PrivKeyGenButton.Text = "Generate key";
            this.PrivKeyGenButton.UseVisualStyleBackColor = true;
            this.PrivKeyGenButton.Click += new System.EventHandler(this.PrivKeyGenButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Save key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 51);
            this.button2.TabIndex = 26;
            this.button2.Text = "Save key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 51);
            this.button3.TabIndex = 27;
            this.button3.Text = "Open file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(678, 191);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 51);
            this.button4.TabIndex = 28;
            this.button4.Text = "Open file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 262);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 39);
            this.button5.TabIndex = 29;
            this.button5.Text = "Find p and q";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 930);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrivKeyGenButton);
            this.Controls.Add(this.PubKeyGenButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PrivKeyBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PubKeyBox);
            this.Controls.Add(this.wrongFormatLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecipherButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.QBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.EncryptButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "DES algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox QBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox PBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wrongFormatLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PrivKeyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PubKeyBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PrivKeyGenButton;
        private System.Windows.Forms.Button PubKeyGenButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}

