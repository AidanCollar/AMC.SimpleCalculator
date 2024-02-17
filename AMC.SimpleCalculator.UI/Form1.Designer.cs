namespace AMC.SimpleCalculator.UI
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
            txtMain = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnBack = new Button();
            btnClear = new Button();
            btnNegOrPos = new Button();
            btnDecimal = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnPlus = new Button();
            btnSqrt = new Button();
            btnReciprical = new Button();
            btnEquals = new Button();
            SuspendLayout();
            // 
            // txtMain
            // 
            txtMain.Font = new Font("Segoe UI", 12F);
            txtMain.Location = new Point(55, 23);
            txtMain.Name = "txtMain";
            txtMain.ReadOnly = true;
            txtMain.Size = new Size(263, 29);
            txtMain.TabIndex = 0;
            // 
            // btn0
            // 
            btn0.Location = new Point(55, 266);
            btn0.Name = "btn0";
            btn0.Size = new Size(45, 35);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(55, 214);
            btn1.Name = "btn1";
            btn1.Size = new Size(45, 35);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(106, 214);
            btn2.Name = "btn2";
            btn2.Size = new Size(45, 35);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn0_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(157, 214);
            btn3.Name = "btn3";
            btn3.Size = new Size(45, 35);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn0_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(55, 163);
            btn4.Name = "btn4";
            btn4.Size = new Size(45, 35);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn0_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(106, 163);
            btn5.Name = "btn5";
            btn5.Size = new Size(45, 35);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn0_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(157, 163);
            btn6.Name = "btn6";
            btn6.Size = new Size(45, 35);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(55, 109);
            btn7.Name = "btn7";
            btn7.Size = new Size(45, 35);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(106, 109);
            btn8.Name = "btn8";
            btn8.Size = new Size(45, 35);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(157, 109);
            btn9.Name = "btn9";
            btn9.Size = new Size(45, 35);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn0_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(55, 58);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 44);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(159, 58);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 44);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNegOrPos
            // 
            btnNegOrPos.Location = new Point(106, 266);
            btnNegOrPos.Name = "btnNegOrPos";
            btnNegOrPos.Size = new Size(45, 35);
            btnNegOrPos.TabIndex = 1;
            btnNegOrPos.Text = "+/-";
            btnNegOrPos.UseVisualStyleBackColor = true;
            btnNegOrPos.Click += btn_NegOrPos;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(157, 266);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(45, 35);
            btnDecimal.TabIndex = 1;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimalClick;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(210, 109);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(45, 35);
            btnDivide.TabIndex = 1;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(210, 163);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(45, 35);
            btnMultiply.TabIndex = 1;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(208, 214);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(45, 35);
            btnSubtract.TabIndex = 1;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(208, 266);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(45, 35);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(261, 109);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(45, 35);
            btnSqrt.TabIndex = 1;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_click;
            // 
            // btnReciprical
            // 
            btnReciprical.Location = new Point(261, 163);
            btnReciprical.Name = "btnReciprical";
            btnReciprical.Size = new Size(45, 35);
            btnReciprical.TabIndex = 1;
            btnReciprical.Text = "1/x";
            btnReciprical.UseVisualStyleBackColor = true;
            btnReciprical.Click += btnReciprical_click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(259, 214);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(45, 87);
            btnEquals.TabIndex = 1;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 415);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnPlus);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnEquals);
            Controls.Add(btnReciprical);
            Controls.Add(btnSqrt);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDecimal);
            Controls.Add(btnNegOrPos);
            Controls.Add(btn0);
            Controls.Add(txtMain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMain;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnBack;
        private Button btnClear;
        private Button btnNegOrPos;
        private Button btnDecimal;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnPlus;
        private Button btnSqrt;
        private Button btnReciprical;
        private Button btnEquals;
    }
}
