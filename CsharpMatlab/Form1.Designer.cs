namespace CsharpMatlab
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxXmin = new System.Windows.Forms.TextBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.textBoxXmax = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCos);
            this.panel1.Controls.Add(this.btnSin);
            this.panel1.Location = new System.Drawing.Point(1, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 582);
            this.panel1.TabIndex = 0;
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.Black;
            this.btnCos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCos.FlatAppearance.BorderSize = 0;
            this.btnCos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Font = new System.Drawing.Font("华文仿宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCos.Location = new System.Drawing.Point(-3, 46);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(200, 40);
            this.btnCos.TabIndex = 1;
            this.btnCos.Text = "y=cos(x)";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.Black;
            this.btnSin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSin.FlatAppearance.BorderSize = 0;
            this.btnSin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.Font = new System.Drawing.Font("华文仿宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSin.Location = new System.Drawing.Point(-3, 0);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(200, 40);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "y=sin(x)";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(199, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 600);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(381, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 600);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("华文仿宋", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(207, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "函数参数输入";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("华文仿宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(204, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "自变量最小值";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("华文仿宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(204, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "自变量步长";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("华文仿宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(204, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "自变量最大值";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxXmin
            // 
            this.textBoxXmin.Location = new System.Drawing.Point(239, 103);
            this.textBoxXmin.Name = "textBoxXmin";
            this.textBoxXmin.Size = new System.Drawing.Size(100, 25);
            this.textBoxXmin.TabIndex = 8;
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(239, 195);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 25);
            this.textBoxStep.TabIndex = 9;
            // 
            // textBoxXmax
            // 
            this.textBoxXmax.Location = new System.Drawing.Point(239, 288);
            this.textBoxXmax.Name = "textBoxXmax";
            this.textBoxXmax.Size = new System.Drawing.Size(100, 25);
            this.textBoxXmax.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(385, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1107, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxXmax);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.textBoxXmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

