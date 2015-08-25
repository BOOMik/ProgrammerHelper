namespace ProgrammerHelperForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hexBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDistanceTravelled = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detecting = new System.Windows.Forms.Label();
            this.startDetect = new System.Windows.Forms.Button();
            this.rgbBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Start);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Stop);
            // 
            // hexBtn
            // 
            this.hexBtn.AutoSize = true;
            this.hexBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexBtn.Location = new System.Drawing.Point(106, 53);
            this.hexBtn.Margin = new System.Windows.Forms.Padding(6);
            this.hexBtn.Name = "hexBtn";
            this.hexBtn.Size = new System.Drawing.Size(160, 42);
            this.hexBtn.TabIndex = 2;
            this.hexBtn.Text = "hex";
            this.hexBtn.UseVisualStyleBackColor = true;
            this.hexBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color:";
            // 
            // intBtn
            // 
            this.intBtn.AutoSize = true;
            this.intBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intBtn.Location = new System.Drawing.Point(278, 53);
            this.intBtn.Margin = new System.Windows.Forms.Padding(6);
            this.intBtn.Name = "intBtn";
            this.intBtn.Size = new System.Drawing.Size(160, 42);
            this.intBtn.TabIndex = 3;
            this.intBtn.Text = "int";
            this.intBtn.UseVisualStyleBackColor = true;
            this.intBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Copy:";
            // 
            // lblDistanceTravelled
            // 
            this.lblDistanceTravelled.AutoSize = true;
            this.lblDistanceTravelled.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDistanceTravelled.Location = new System.Drawing.Point(628, 56);
            this.lblDistanceTravelled.Name = "lblDistanceTravelled";
            this.lblDistanceTravelled.Size = new System.Drawing.Size(30, 32);
            this.lblDistanceTravelled.TabIndex = 7;
            this.lblDistanceTravelled.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Distance";
            // 
            // detecting
            // 
            this.detecting.AutoSize = true;
            this.detecting.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detecting.Location = new System.Drawing.Point(11, 33);
            this.detecting.Name = "detecting";
            this.detecting.Size = new System.Drawing.Size(70, 15);
            this.detecting.TabIndex = 9;
            this.detecting.Text = "Detecting";
            // 
            // startDetect
            // 
            this.startDetect.Location = new System.Drawing.Point(106, 104);
            this.startDetect.Name = "startDetect";
            this.startDetect.Size = new System.Drawing.Size(501, 42);
            this.startDetect.TabIndex = 1;
            this.startDetect.Text = "Start detect color";
            this.startDetect.UseVisualStyleBackColor = true;
            this.startDetect.Visible = false;
            this.startDetect.Click += new System.EventHandler(this.startDetect_Click);
            // 
            // rgbBtn
            // 
            this.rgbBtn.AutoSize = true;
            this.rgbBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rgbBtn.Location = new System.Drawing.Point(447, 53);
            this.rgbBtn.Name = "rgbBtn";
            this.rgbBtn.Size = new System.Drawing.Size(160, 42);
            this.rgbBtn.TabIndex = 4;
            this.rgbBtn.Text = "rgb";
            this.rgbBtn.UseVisualStyleBackColor = true;
            this.rgbBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(106, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 35);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 563);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rgbBtn);
            this.Controls.Add(this.startDetect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detecting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intBtn);
            this.Controls.Add(this.lblDistanceTravelled);
            this.Controls.Add(this.hexBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Programmer Design Helper";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button hexBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button intBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDistanceTravelled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label detecting;
        private System.Windows.Forms.Button startDetect;
        private System.Windows.Forms.Button rgbBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

