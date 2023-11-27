namespace Task12Calculator
{
    partial class CalculatorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButton1Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ResultLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonClear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEquals, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPlus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMinus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMultiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDivide, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 349);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(70, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnButton2Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(137, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 68);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnButton3Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 68);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnButton4Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(70, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 68);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OnButton5Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(137, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 68);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OnButton6Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(3, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 68);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OnButton7Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(70, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 68);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OnButton8Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(137, 201);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 68);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OnButton9Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(70, 275);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(61, 71);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.OnButton0Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(265, 50);
            this.ResultLabel.TabIndex = 11;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.Location = new System.Drawing.Point(3, 275);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(61, 71);
            this.ButtonClear.TabIndex = 12;
            this.ButtonClear.Text = "CE";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.OnButtonClearClick);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEquals.Location = new System.Drawing.Point(137, 275);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(61, 71);
            this.ButtonEquals.TabIndex = 13;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.OnButtonEqualsClick);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlus.Location = new System.Drawing.Point(204, 53);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(64, 68);
            this.ButtonPlus.TabIndex = 14;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.OnButtonPlusClick);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinus.Location = new System.Drawing.Point(204, 127);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(64, 68);
            this.ButtonMinus.TabIndex = 15;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.OnButtonMinusClick);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMultiply.Location = new System.Drawing.Point(204, 201);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(64, 68);
            this.ButtonMultiply.TabIndex = 16;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.OnButtonMultiplyClick);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDivide.Location = new System.Drawing.Point(204, 275);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(64, 71);
            this.ButtonDivide.TabIndex = 17;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.OnButtonDivideClick);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(271, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonDivide;
    }
}

