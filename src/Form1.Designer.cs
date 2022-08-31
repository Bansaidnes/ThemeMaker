namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ImgButt = new System.Windows.Forms.Button();
            this.PictureShow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Build = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdvStg = new System.Windows.Forms.RadioButton();
            this.BrightCount = new System.Windows.Forms.NumericUpDown();
            this.Bright = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightCount)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImgButt
            // 
            this.ImgButt.BackColor = System.Drawing.Color.Transparent;
            this.ImgButt.Location = new System.Drawing.Point(361, 153);
            this.ImgButt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ImgButt.Name = "ImgButt";
            this.ImgButt.Size = new System.Drawing.Size(143, 39);
            this.ImgButt.TabIndex = 0;
            this.ImgButt.Text = "Select image";
            this.ImgButt.UseVisualStyleBackColor = false;
            this.ImgButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // PictureShow
            // 
            this.PictureShow.BackColor = System.Drawing.SystemColors.Control;
            this.PictureShow.Location = new System.Drawing.Point(240, 123);
            this.PictureShow.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PictureShow.Name = "PictureShow";
            this.PictureShow.Size = new System.Drawing.Size(206, 105);
            this.PictureShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureShow.TabIndex = 1;
            this.PictureShow.TabStop = false;
            this.PictureShow.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected image:";
            this.label1.Visible = false;
            // 
            // Build
            // 
            this.Build.BackColor = System.Drawing.Color.Transparent;
            this.Build.Location = new System.Drawing.Point(349, 353);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(167, 65);
            this.Build.TabIndex = 3;
            this.Build.Text = "Build theme!";
            this.Build.UseVisualStyleBackColor = false;
            this.Build.Visible = false;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(290, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Theme name:";
            this.label2.Visible = false;
            // 
            // AdvStg
            // 
            this.AdvStg.AutoSize = true;
            this.AdvStg.BackColor = System.Drawing.Color.Transparent;
            this.AdvStg.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdvStg.Location = new System.Drawing.Point(690, 334);
            this.AdvStg.Name = "AdvStg";
            this.AdvStg.Size = new System.Drawing.Size(198, 25);
            this.AdvStg.TabIndex = 6;
            this.AdvStg.TabStop = true;
            this.AdvStg.Text = "View advanced settings";
            this.AdvStg.UseVisualStyleBackColor = false;
            this.AdvStg.Visible = false;
            this.AdvStg.CheckedChanged += new System.EventHandler(this.AdvStg_CheckedChanged);
            // 
            // BrightCount
            // 
            this.BrightCount.Location = new System.Drawing.Point(787, 377);
            this.BrightCount.Name = "BrightCount";
            this.BrightCount.Size = new System.Drawing.Size(89, 28);
            this.BrightCount.TabIndex = 7;
            this.BrightCount.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.BrightCount.Visible = false;
            // 
            // Bright
            // 
            this.Bright.AutoSize = true;
            this.Bright.BackColor = System.Drawing.Color.Transparent;
            this.Bright.Location = new System.Drawing.Point(631, 382);
            this.Bright.Name = "Bright";
            this.Bright.Size = new System.Drawing.Size(151, 20);
            this.Bright.TabIndex = 8;
            this.Bright.Text = "Gradient brightness:";
            this.Bright.Visible = false;
            this.Bright.Click += new System.EventHandler(this.Bright_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.ForeColor = System.Drawing.Color.AliceBlue;
            this.Reset.Location = new System.Drawing.Point(744, 27);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(132, 54);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset options";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 449);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Bright);
            this.Controls.Add(this.BrightCount);
            this.Controls.Add(this.AdvStg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureShow);
            this.Controls.Add(this.ImgButt);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemeMaker";
            ((System.ComponentModel.ISupportInitialize)(this.PictureShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Button ImgButt;
        private PictureBox PictureShow;
        private Label label1;
        private Button Build;
        private TextBox textBox1;
        private Label label2;
        private RadioButton AdvStg;
        private NumericUpDown BrightCount;
        private Label Bright;
        private Button Reset;
    }
}