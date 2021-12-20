namespace calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.arg1TB = new System.Windows.Forms.TextBox();
            this.operationLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.arg2TB = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.addRB = new System.Windows.Forms.RadioButton();
            this.multiplyRB = new System.Windows.Forms.RadioButton();
            this.subRB = new System.Windows.Forms.RadioButton();
            this.divRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // arg1TB
            // 
            this.arg1TB.Location = new System.Drawing.Point(13, 13);
            this.arg1TB.Name = "arg1TB";
            this.arg1TB.Size = new System.Drawing.Size(100, 20);
            this.arg1TB.TabIndex = 0;
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(133, 15);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(0, 13);
            this.operationLabel.TabIndex = 1;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(307, 59);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Посчитать";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // arg2TB
            // 
            this.arg2TB.Location = new System.Drawing.Point(165, 13);
            this.arg2TB.Name = "arg2TB";
            this.arg2TB.Size = new System.Drawing.Size(100, 20);
            this.arg2TB.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(286, 15);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(13, 13);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "=";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // addRB
            // 
            this.addRB.AutoSize = true;
            this.addRB.Location = new System.Drawing.Point(12, 65);
            this.addRB.Name = "addRB";
            this.addRB.Size = new System.Drawing.Size(76, 17);
            this.addRB.TabIndex = 3;
            this.addRB.TabStop = true;
            this.addRB.Text = "Сложение";
            this.addRB.UseVisualStyleBackColor = true;
            this.addRB.CheckedChanged += new System.EventHandler(this.addRB_CheckedChanged);
            // 
            // multiplyRB
            // 
            this.multiplyRB.AutoSize = true;
            this.multiplyRB.Location = new System.Drawing.Point(103, 65);
            this.multiplyRB.Name = "multiplyRB";
            this.multiplyRB.Size = new System.Drawing.Size(79, 17);
            this.multiplyRB.TabIndex = 3;
            this.multiplyRB.TabStop = true;
            this.multiplyRB.Text = "Умножние";
            this.multiplyRB.UseVisualStyleBackColor = true;
            this.multiplyRB.CheckedChanged += new System.EventHandler(this.multiplyRB_CheckedChanged);
            // 
            // subRB
            // 
            this.subRB.AutoSize = true;
            this.subRB.Location = new System.Drawing.Point(12, 42);
            this.subRB.Name = "subRB";
            this.subRB.Size = new System.Drawing.Size(80, 17);
            this.subRB.TabIndex = 4;
            this.subRB.TabStop = true;
            this.subRB.Text = "Вычитание";
            this.subRB.UseVisualStyleBackColor = true;
            this.subRB.CheckedChanged += new System.EventHandler(this.subRB_CheckedChanged);
            // 
            // divRB
            // 
            this.divRB.AutoSize = true;
            this.divRB.Location = new System.Drawing.Point(103, 42);
            this.divRB.Name = "divRB";
            this.divRB.Size = new System.Drawing.Size(70, 17);
            this.divRB.TabIndex = 5;
            this.divRB.TabStop = true;
            this.divRB.Text = "Деление";
            this.divRB.UseVisualStyleBackColor = true;
            this.divRB.CheckedChanged += new System.EventHandler(this.divRB_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(394, 94);
            this.Controls.Add(this.divRB);
            this.Controls.Add(this.subRB);
            this.Controls.Add(this.multiplyRB);
            this.Controls.Add(this.addRB);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.arg2TB);
            this.Controls.Add(this.arg1TB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arg1TB;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox arg2TB;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton addRB;
        private System.Windows.Forms.RadioButton multiplyRB;
        private System.Windows.Forms.RadioButton subRB;
        private System.Windows.Forms.RadioButton divRB;
    }
}

