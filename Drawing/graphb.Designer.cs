
namespace Drawing
{
    partial class graphb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graphb));
            this.panelGraphFunction = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelGraphFunction
            // 
            this.panelGraphFunction.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelGraphFunction.Location = new System.Drawing.Point(156, 4);
            this.panelGraphFunction.Name = "panelGraphFunction";
            this.panelGraphFunction.Size = new System.Drawing.Size(600, 600);
            this.panelGraphFunction.TabIndex = 0;
            this.panelGraphFunction.Click += new System.EventHandler(this.panelGraphFunction_Click);
            this.panelGraphFunction.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelGraphFunction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGraphFunction_MouseDown);
            this.panelGraphFunction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGraphFunction_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(802, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textbox1.Location = new System.Drawing.Point(772, 152);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(104, 20);
            this.textbox1.TabIndex = 3;
            this.textbox1.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(769, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iterations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // graphb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(884, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelGraphFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "graphb";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGraphFunction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Label label1;
    }
}

