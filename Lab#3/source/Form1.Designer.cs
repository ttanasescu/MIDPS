﻿namespace source
{
     partial class Calculator
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
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.button6 = new System.Windows.Forms.Button();
               this.button7 = new System.Windows.Forms.Button();
               this.button8 = new System.Windows.Forms.Button();
               this.button9 = new System.Windows.Forms.Button();
               this.button0 = new System.Windows.Forms.Button();
               this.button_point = new System.Windows.Forms.Button();
               this.button_plus = new System.Windows.Forms.Button();
               this.button_minus = new System.Windows.Forms.Button();
               this.button_mul = new System.Windows.Forms.Button();
               this.button_div = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.button_sign = new System.Windows.Forms.Button();
               this.button_equal = new System.Windows.Forms.Button();
               this.button_ce = new System.Windows.Forms.Button();
               this.button_pow = new System.Windows.Forms.Button();
               this.button_sqr = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // textBox1
               // 
               this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.textBox1.Location = new System.Drawing.Point(48, 34);
               this.textBox1.MaxLength = 31;
               this.textBox1.Name = "textBox1";
               this.textBox1.ReadOnly = true;
               this.textBox1.Size = new System.Drawing.Size(201, 20);
               this.textBox1.TabIndex = 1;
               this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
               this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(84, 162);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(32, 32);
               this.button1.TabIndex = 2;
               this.button1.Text = "1";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(122, 162);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(32, 32);
               this.button2.TabIndex = 3;
               this.button2.Text = "2";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(160, 162);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(32, 32);
               this.button3.TabIndex = 4;
               this.button3.Text = "3";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // button4
               // 
               this.button4.Location = new System.Drawing.Point(84, 124);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(32, 32);
               this.button4.TabIndex = 5;
               this.button4.Text = "4";
               this.button4.UseVisualStyleBackColor = true;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // button5
               // 
               this.button5.Location = new System.Drawing.Point(122, 124);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(32, 32);
               this.button5.TabIndex = 6;
               this.button5.Text = "5";
               this.button5.UseVisualStyleBackColor = true;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // button6
               // 
               this.button6.Location = new System.Drawing.Point(160, 124);
               this.button6.Name = "button6";
               this.button6.Size = new System.Drawing.Size(32, 32);
               this.button6.TabIndex = 7;
               this.button6.Text = "6";
               this.button6.UseVisualStyleBackColor = true;
               this.button6.Click += new System.EventHandler(this.button6_Click);
               // 
               // button7
               // 
               this.button7.Location = new System.Drawing.Point(84, 86);
               this.button7.Name = "button7";
               this.button7.Size = new System.Drawing.Size(32, 32);
               this.button7.TabIndex = 8;
               this.button7.Text = "7";
               this.button7.UseVisualStyleBackColor = true;
               this.button7.Click += new System.EventHandler(this.button7_Click);
               // 
               // button8
               // 
               this.button8.Location = new System.Drawing.Point(122, 86);
               this.button8.Name = "button8";
               this.button8.Size = new System.Drawing.Size(32, 32);
               this.button8.TabIndex = 9;
               this.button8.Text = "8";
               this.button8.UseVisualStyleBackColor = true;
               this.button8.Click += new System.EventHandler(this.button8_Click);
               // 
               // button9
               // 
               this.button9.Location = new System.Drawing.Point(160, 86);
               this.button9.Name = "button9";
               this.button9.Size = new System.Drawing.Size(32, 32);
               this.button9.TabIndex = 10;
               this.button9.Text = "9";
               this.button9.UseVisualStyleBackColor = true;
               this.button9.Click += new System.EventHandler(this.button9_Click);
               // 
               // button0
               // 
               this.button0.Location = new System.Drawing.Point(122, 200);
               this.button0.Name = "button0";
               this.button0.Size = new System.Drawing.Size(32, 32);
               this.button0.TabIndex = 11;
               this.button0.Text = "0";
               this.button0.UseVisualStyleBackColor = true;
               this.button0.Click += new System.EventHandler(this.button0_Click);
               // 
               // button_point
               // 
               this.button_point.Location = new System.Drawing.Point(160, 200);
               this.button_point.Name = "button_point";
               this.button_point.Size = new System.Drawing.Size(32, 32);
               this.button_point.TabIndex = 12;
               this.button_point.Text = ",";
               this.button_point.UseVisualStyleBackColor = true;
               this.button_point.Click += new System.EventHandler(this.button_point_Click);
               // 
               // button_plus
               // 
               this.button_plus.Location = new System.Drawing.Point(198, 86);
               this.button_plus.Name = "button_plus";
               this.button_plus.Size = new System.Drawing.Size(32, 32);
               this.button_plus.TabIndex = 13;
               this.button_plus.Text = "+";
               this.button_plus.UseVisualStyleBackColor = true;
               this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
               // 
               // button_minus
               // 
               this.button_minus.Location = new System.Drawing.Point(198, 124);
               this.button_minus.Name = "button_minus";
               this.button_minus.Size = new System.Drawing.Size(32, 32);
               this.button_minus.TabIndex = 14;
               this.button_minus.Text = "−";
               this.button_minus.UseVisualStyleBackColor = true;
               this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
               // 
               // button_mul
               // 
               this.button_mul.Location = new System.Drawing.Point(198, 162);
               this.button_mul.Name = "button_mul";
               this.button_mul.Size = new System.Drawing.Size(32, 32);
               this.button_mul.TabIndex = 15;
               this.button_mul.Text = "*";
               this.button_mul.UseVisualStyleBackColor = true;
               this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
               // 
               // button_div
               // 
               this.button_div.Location = new System.Drawing.Point(198, 200);
               this.button_div.Name = "button_div";
               this.button_div.Size = new System.Drawing.Size(32, 32);
               this.button_div.TabIndex = 16;
               this.button_div.Text = "/";
               this.button_div.UseVisualStyleBackColor = true;
               this.button_div.Click += new System.EventHandler(this.button_div_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.label1.Location = new System.Drawing.Point(12, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(37, 15);
               this.label1.TabIndex = 0;
               this.label1.Text = "label1";
               // 
               // button_sign
               // 
               this.button_sign.Location = new System.Drawing.Point(84, 200);
               this.button_sign.Name = "button_sign";
               this.button_sign.Size = new System.Drawing.Size(32, 32);
               this.button_sign.TabIndex = 17;
               this.button_sign.Text = "+/-";
               this.button_sign.UseVisualStyleBackColor = true;
               this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
               // 
               // button_equal
               // 
               this.button_equal.Location = new System.Drawing.Point(236, 200);
               this.button_equal.Name = "button_equal";
               this.button_equal.Size = new System.Drawing.Size(32, 32);
               this.button_equal.TabIndex = 17;
               this.button_equal.Text = "=";
               this.button_equal.UseVisualStyleBackColor = true;
               this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
               // 
               // button_ce
               // 
               this.button_ce.Location = new System.Drawing.Point(236, 86);
               this.button_ce.Name = "button_ce";
               this.button_ce.Size = new System.Drawing.Size(32, 32);
               this.button_ce.TabIndex = 18;
               this.button_ce.Text = "CE";
               this.button_ce.UseVisualStyleBackColor = true;
               this.button_ce.Click += new System.EventHandler(this.button_ce_Click);
               // 
               // button_pow
               // 
               this.button_pow.Location = new System.Drawing.Point(236, 124);
               this.button_pow.Name = "button_pow";
               this.button_pow.Size = new System.Drawing.Size(32, 32);
               this.button_pow.TabIndex = 19;
               this.button_pow.Text = "^";
               this.button_pow.UseVisualStyleBackColor = true;
               this.button_pow.Click += new System.EventHandler(this.button_pow_Click);
               // 
               // button_sqr
               // 
               this.button_sqr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button_sqr.Location = new System.Drawing.Point(236, 162);
               this.button_sqr.Name = "button_sqr";
               this.button_sqr.Size = new System.Drawing.Size(32, 32);
               this.button_sqr.TabIndex = 20;
               this.button_sqr.Text = "√¯";
               this.button_sqr.UseVisualStyleBackColor = true;
               this.button_sqr.Click += new System.EventHandler(this.button_sqr_Click);
               // 
               // Calculator
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(292, 266);
               this.Controls.Add(this.button_sqr);
               this.Controls.Add(this.button_pow);
               this.Controls.Add(this.button_sign);
               this.Controls.Add(this.button_ce);
               this.Controls.Add(this.button_equal);
               this.Controls.Add(this.button_div);
               this.Controls.Add(this.button_mul);
               this.Controls.Add(this.button_minus);
               this.Controls.Add(this.button_plus);
               this.Controls.Add(this.button_point);
               this.Controls.Add(this.button0);
               this.Controls.Add(this.button9);
               this.Controls.Add(this.button8);
               this.Controls.Add(this.button7);
               this.Controls.Add(this.button6);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.label1);
               this.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.Location = new System.Drawing.Point(500, 500);
               this.Name = "Calculator";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Calculator";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button5;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.Button button7;
          private System.Windows.Forms.Button button8;
          private System.Windows.Forms.Button button9;
          private System.Windows.Forms.Button button0;
          private System.Windows.Forms.Button button_point;
          private System.Windows.Forms.Button button_plus;
          private System.Windows.Forms.Button button_minus;
          private System.Windows.Forms.Button button_mul;
          private System.Windows.Forms.Button button_div;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button button_sign;
          private System.Windows.Forms.Button button_equal;
          private System.Windows.Forms.Button button_ce;
          private System.Windows.Forms.Button button_pow;
          private System.Windows.Forms.Button button_sqr;
     }
}

