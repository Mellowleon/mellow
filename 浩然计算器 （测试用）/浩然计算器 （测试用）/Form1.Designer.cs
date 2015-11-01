namespace 浩然计算器__测试用_
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delet = new System.Windows.Forms.Button();
            this.C_error = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.sqrt_ = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.flip = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(23, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(279, 54);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // delet
            // 
            this.delet.Location = new System.Drawing.Point(23, 103);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(60, 40);
            this.delet.TabIndex = 1;
            this.delet.Text = "←";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // C_error
            // 
            this.C_error.Location = new System.Drawing.Point(89, 103);
            this.C_error.Name = "C_error";
            this.C_error.Size = new System.Drawing.Size(59, 40);
            this.C_error.TabIndex = 2;
            this.C_error.Text = "CE";
            this.C_error.UseVisualStyleBackColor = true;
            this.C_error.Click += new System.EventHandler(this.C_error_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(154, 103);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(54, 40);
            this.Clean.TabIndex = 3;
            this.Clean.Text = "C";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(214, 103);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(41, 40);
            this.change.TabIndex = 4;
            this.change.Text = "±";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // sqrt_
            // 
            this.sqrt_.Location = new System.Drawing.Point(261, 103);
            this.sqrt_.Name = "sqrt_";
            this.sqrt_.Size = new System.Drawing.Size(41, 40);
            this.sqrt_.TabIndex = 5;
            this.sqrt_.Text = "√";
            this.sqrt_.UseVisualStyleBackColor = true;
            this.sqrt_.Click += new System.EventHandler(this.sqrt__Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(214, 149);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(41, 40);
            this.divide.TabIndex = 6;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.work1_Click);
            // 
            // flip
            // 
            this.flip.Location = new System.Drawing.Point(261, 195);
            this.flip.Name = "flip";
            this.flip.Size = new System.Drawing.Size(41, 40);
            this.flip.TabIndex = 7;
            this.flip.Text = "1/x";
            this.flip.UseVisualStyleBackColor = true;
            this.flip.Click += new System.EventHandler(this.flip_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(214, 195);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(41, 40);
            this.multi.TabIndex = 8;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.work1_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(214, 241);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(41, 40);
            this.minus.TabIndex = 9;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.work1_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(214, 287);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(41, 40);
            this.plus.TabIndex = 10;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.work1_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(260, 241);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(42, 86);
            this.equal.TabIndex = 11;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Num3
            // 
            this.Num3.Location = new System.Drawing.Point(154, 149);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(49, 40);
            this.Num3.TabIndex = 12;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(89, 149);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(49, 40);
            this.Num2.TabIndex = 13;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(23, 149);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(51, 40);
            this.Num1.TabIndex = 14;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num4
            // 
            this.Num4.Location = new System.Drawing.Point(23, 195);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(51, 40);
            this.Num4.TabIndex = 15;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num5
            // 
            this.Num5.Location = new System.Drawing.Point(89, 195);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(49, 40);
            this.Num5.TabIndex = 16;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num6
            // 
            this.Num6.Location = new System.Drawing.Point(154, 195);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(49, 40);
            this.Num6.TabIndex = 17;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num7
            // 
            this.Num7.Location = new System.Drawing.Point(23, 241);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(51, 40);
            this.Num7.TabIndex = 18;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num8
            // 
            this.Num8.Location = new System.Drawing.Point(89, 241);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(49, 40);
            this.Num8.TabIndex = 19;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num9
            // 
            this.Num9.Location = new System.Drawing.Point(154, 241);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(49, 40);
            this.Num9.TabIndex = 20;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.scanf_Click);
            // 
            // Num0
            // 
            this.Num0.Location = new System.Drawing.Point(23, 287);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(115, 40);
            this.Num0.TabIndex = 21;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(154, 287);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(49, 40);
            this.Dot.TabIndex = 22;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "标准型";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.flip);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.sqrt_);
            this.Controls.Add(this.change);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.C_error);
            this.Controls.Add(this.delet);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(341, 393);
            this.MinimumSize = new System.Drawing.Size(341, 393);
            this.Name = "Form1";
            this.Text = "浩然的计算器 测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button C_error;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button sqrt_;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button flip;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Label label1;
    }
}

