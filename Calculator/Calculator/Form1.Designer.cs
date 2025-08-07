namespace Calculator
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
            this.tBResult = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBResult
            // 
            this.tBResult.Location = new System.Drawing.Point(121, 7);
            this.tBResult.Name = "tBResult";
            this.tBResult.Size = new System.Drawing.Size(169, 22);
            this.tBResult.TabIndex = 0;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(123, 78);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(37, 37);
            this.btnOne.TabIndex = 1;
            this.btnOne.Tag = "1";
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(166, 78);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(37, 37);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Tag = "2";
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(209, 78);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(38, 37);
            this.btnThree.TabIndex = 3;
            this.btnThree.Tag = "3";
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(123, 121);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(37, 37);
            this.btnFour.TabIndex = 4;
            this.btnFour.Tag = "4";
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(166, 121);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(37, 37);
            this.btnFive.TabIndex = 5;
            this.btnFive.Tag = "5";
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(210, 121);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(37, 37);
            this.btnSix.TabIndex = 6;
            this.btnSix.Tag = "6";
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(123, 164);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(37, 37);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Tag = "7";
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(166, 164);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(37, 37);
            this.btnEight.TabIndex = 8;
            this.btnEight.Tag = "8";
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(210, 164);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(37, 37);
            this.btnNine.TabIndex = 9;
            this.btnNine.Tag = "9";
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(123, 207);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(37, 37);
            this.btnZero.TabIndex = 10;
            this.btnZero.Tag = "0";
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(253, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(37, 37);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBC
            // 
            this.btnBC.Location = new System.Drawing.Point(253, 121);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(37, 37);
            this.btnBC.TabIndex = 12;
            this.btnBC.Text = "BS";
            this.btnBC.UseVisualStyleBackColor = true;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(253, 164);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(37, 37);
            this.btnEqual.TabIndex = 13;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(166, 207);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(37, 37);
            this.btnDot.TabIndex = 14;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(166, 35);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(37, 37);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Tag = "*";
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(123, 35);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(37, 37);
            this.btnSum.TabIndex = 16;
            this.btnSum.Tag = "+";
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(210, 35);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(37, 37);
            this.btnDivide.TabIndex = 17;
            this.btnDivide.Tag = "/";
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(253, 35);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(37, 37);
            this.btnSubtract.TabIndex = 18;
            this.btnSubtract.Tag = "-";
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 253);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.tBResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBResult;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSubtract;
    }
}

