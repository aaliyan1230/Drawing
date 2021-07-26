namespace Drawing {
    partial class Mandelbrot {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mandelbrot));
            this.generatePatternButton = new System.Windows.Forms.Button();
            this.pixelStepTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xMinCheckBox = new System.Windows.Forms.TextBox();
            this.xMaxCheckBox = new System.Windows.Forms.TextBox();
            this.zoomCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iterationCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yMinCheckBox = new System.Windows.Forms.TextBox();
            this.yMaxCheckBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.zoomTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.undoButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stopwatchLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.favouritesComboBox = new System.Windows.Forms.ComboBox();
            this.openFavouritesButton = new System.Windows.Forms.Button();
            this.addToFavouritesButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.saveImageTextBox = new System.Windows.Forms.TextBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // generatePatternButton
            // 
            this.generatePatternButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.generatePatternButton.Location = new System.Drawing.Point(57, 274);
            this.generatePatternButton.Name = "generatePatternButton";
            this.generatePatternButton.Size = new System.Drawing.Size(81, 57);
            this.generatePatternButton.TabIndex = 0;
            this.generatePatternButton.Text = "Generate Pattern";
            this.generatePatternButton.UseVisualStyleBackColor = false;
            this.generatePatternButton.Click += new System.EventHandler(this.generate_Click);
            // 
            // pixelStepTextBox
            // 
            this.pixelStepTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pixelStepTextBox.Location = new System.Drawing.Point(18, 37);
            this.pixelStepTextBox.Name = "pixelStepTextBox";
            this.pixelStepTextBox.Size = new System.Drawing.Size(104, 20);
            this.pixelStepTextBox.TabIndex = 1;
            this.pixelStepTextBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pixel step";
            // 
            // xMinCheckBox
            // 
            this.xMinCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xMinCheckBox.Location = new System.Drawing.Point(14, 184);
            this.xMinCheckBox.Name = "xMinCheckBox";
            this.xMinCheckBox.Size = new System.Drawing.Size(56, 20);
            this.xMinCheckBox.TabIndex = 13;
            this.xMinCheckBox.Text = "-2";
            // 
            // xMaxCheckBox
            // 
            this.xMaxCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xMaxCheckBox.Location = new System.Drawing.Point(73, 184);
            this.xMaxCheckBox.Name = "xMaxCheckBox";
            this.xMaxCheckBox.Size = new System.Drawing.Size(56, 20);
            this.xMaxCheckBox.TabIndex = 14;
            this.xMaxCheckBox.Text = "1";
            // 
            // zoomCheckbox
            // 
            this.zoomCheckbox.AutoSize = true;
            this.zoomCheckbox.Location = new System.Drawing.Point(17, 252);
            this.zoomCheckbox.Name = "zoomCheckbox";
            this.zoomCheckbox.Size = new System.Drawing.Size(57, 17);
            this.zoomCheckbox.TabIndex = 15;
            this.zoomCheckbox.Text = "Zoom";
            this.zoomCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iterations";
            // 
            // iterationCountTextBox
            // 
            this.iterationCountTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iterationCountTextBox.Location = new System.Drawing.Point(19, 82);
            this.iterationCountTextBox.Name = "iterationCountTextBox";
            this.iterationCountTextBox.Size = new System.Drawing.Size(103, 20);
            this.iterationCountTextBox.TabIndex = 5;
            this.iterationCountTextBox.Text = "85";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "yMin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "yMax";
            // 
            // yMinCheckBox
            // 
            this.yMinCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yMinCheckBox.Location = new System.Drawing.Point(14, 135);
            this.yMinCheckBox.Name = "yMinCheckBox";
            this.yMinCheckBox.Size = new System.Drawing.Size(56, 20);
            this.yMinCheckBox.TabIndex = 9;
            this.yMinCheckBox.Text = "-1";
            // 
            // yMaxCheckBox
            // 
            this.yMaxCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yMaxCheckBox.Location = new System.Drawing.Point(73, 135);
            this.yMaxCheckBox.Name = "yMaxCheckBox";
            this.yMaxCheckBox.Size = new System.Drawing.Size(56, 20);
            this.yMaxCheckBox.TabIndex = 10;
            this.yMaxCheckBox.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "xMin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "xMax";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox1.Controls.Add(this.exitbtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.zoomTextBox);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.undoButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.generatePatternButton);
            this.groupBox1.Controls.Add(this.pixelStepTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.zoomCheckbox);
            this.groupBox1.Controls.Add(this.iterationCountTextBox);
            this.groupBox1.Controls.Add(this.xMaxCheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.xMinCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.yMinCheckBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.yMaxCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox1.Location = new System.Drawing.Point(844, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 363);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.exitbtn.Location = new System.Drawing.Point(93, 8);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(45, 23);
            this.exitbtn.TabIndex = 24;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Zoom scale";
            // 
            // zoomTextBox
            // 
            this.zoomTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zoomTextBox.Location = new System.Drawing.Point(14, 226);
            this.zoomTextBox.Name = "zoomTextBox";
            this.zoomTextBox.Size = new System.Drawing.Size(108, 20);
            this.zoomTextBox.TabIndex = 25;
            this.zoomTextBox.Text = "7";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(7, 340);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 13);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "Status:";
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.undoButton.BackgroundImage = global::Drawing.Properties.Resources.undo_4_xxl;
            this.undoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undoButton.ImageKey = "(none)";
            this.undoButton.Location = new System.Drawing.Point(10, 282);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(41, 41);
            this.undoButton.TabIndex = 23;
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox2.Controls.Add(this.stopwatchLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox2.Location = new System.Drawing.Point(844, 514);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 50);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.AutoSize = true;
            this.stopwatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchLabel.Location = new System.Drawing.Point(9, 16);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(0, 20);
            this.stopwatchLabel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.favouritesComboBox);
            this.groupBox3.Controls.Add(this.openFavouritesButton);
            this.groupBox3.Controls.Add(this.addToFavouritesButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox3.Location = new System.Drawing.Point(844, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 151);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Favourites";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "List of Favourites";
            // 
            // favouritesComboBox
            // 
            this.favouritesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.favouritesComboBox.FormattingEnabled = true;
            this.favouritesComboBox.Location = new System.Drawing.Point(13, 86);
            this.favouritesComboBox.Name = "favouritesComboBox";
            this.favouritesComboBox.Size = new System.Drawing.Size(121, 21);
            this.favouritesComboBox.TabIndex = 2;
            this.favouritesComboBox.DropDown += new System.EventHandler(this.favouritesComboBox_DropDown);
            // 
            // openFavouritesButton
            // 
            this.openFavouritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.openFavouritesButton.Location = new System.Drawing.Point(28, 116);
            this.openFavouritesButton.Name = "openFavouritesButton";
            this.openFavouritesButton.Size = new System.Drawing.Size(89, 23);
            this.openFavouritesButton.TabIndex = 1;
            this.openFavouritesButton.Text = "Open Favourite";
            this.openFavouritesButton.UseVisualStyleBackColor = false;
            this.openFavouritesButton.Click += new System.EventHandler(this.openFavourites_Click);
            // 
            // addToFavouritesButton
            // 
            this.addToFavouritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.addToFavouritesButton.Location = new System.Drawing.Point(10, 19);
            this.addToFavouritesButton.Name = "addToFavouritesButton";
            this.addToFavouritesButton.Size = new System.Drawing.Size(128, 33);
            this.addToFavouritesButton.TabIndex = 0;
            this.addToFavouritesButton.Text = "Add This to Favourites";
            this.addToFavouritesButton.UseVisualStyleBackColor = false;
            this.addToFavouritesButton.Click += new System.EventHandler(this.addToFavourites_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.groupBox4.Controls.Add(this.fileNameLabel);
            this.groupBox4.Controls.Add(this.saveImageTextBox);
            this.groupBox4.Controls.Add(this.saveImageButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox4.Location = new System.Drawing.Point(844, 563);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 86);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Export";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(21, 18);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(61, 13);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "File name";
            // 
            // saveImageTextBox
            // 
            this.saveImageTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveImageTextBox.ForeColor = System.Drawing.Color.Black;
            this.saveImageTextBox.Location = new System.Drawing.Point(22, 35);
            this.saveImageTextBox.Name = "saveImageTextBox";
            this.saveImageTextBox.Size = new System.Drawing.Size(100, 20);
            this.saveImageTextBox.TabIndex = 1;
            this.saveImageTextBox.Text = "myImage";
            // 
            // saveImageButton
            // 
            this.saveImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.saveImageButton.Location = new System.Drawing.Point(28, 59);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(89, 23);
            this.saveImageButton.TabIndex = 0;
            this.saveImageButton.Text = "Save image";
            this.saveImageButton.UseVisualStyleBackColor = false;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(-1, 636);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(35, 13);
            this.aboutLabel.TabIndex = 23;
            this.aboutLabel.Text = "About";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // Mandelbrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(989, 652);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mandelbrot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mandelbrot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Mandelbrot_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseClickOnForm);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpOnForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generatePatternButton;
        private System.Windows.Forms.TextBox pixelStepTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xMinCheckBox;
        private System.Windows.Forms.TextBox xMaxCheckBox;
        private System.Windows.Forms.CheckBox zoomCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iterationCountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yMinCheckBox;
        private System.Windows.Forms.TextBox yMaxCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label stopwatchLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addToFavouritesButton;
        private System.Windows.Forms.Button openFavouritesButton;
        private System.Windows.Forms.ComboBox favouritesComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox zoomTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox saveImageTextBox;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Button exitbtn;
    }
}

