namespace Task14TicTacToe;

partial class TicTacToeForm
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
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.button22 = new System.Windows.Forms.Button();
        this.button21 = new System.Windows.Forms.Button();
        this.button20 = new System.Windows.Forms.Button();
        this.button12 = new System.Windows.Forms.Button();
        this.button11 = new System.Windows.Forms.Button();
        this.button10 = new System.Windows.Forms.Button();
        this.button02 = new System.Windows.Forms.Button();
        this.button01 = new System.Windows.Forms.Button();
        this.button00 = new System.Windows.Forms.Button();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
        this.tableLayoutPanel1.Controls.Add(this.button22, 2, 2);
        this.tableLayoutPanel1.Controls.Add(this.button21, 1, 2);
        this.tableLayoutPanel1.Controls.Add(this.button20, 0, 2);
        this.tableLayoutPanel1.Controls.Add(this.button12, 2, 1);
        this.tableLayoutPanel1.Controls.Add(this.button11, 1, 1);
        this.tableLayoutPanel1.Controls.Add(this.button10, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.button02, 2, 0);
        this.tableLayoutPanel1.Controls.Add(this.button01, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.button00, 0, 0);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 3;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 532);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // Button22
        // 
        this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button22.Location = new System.Drawing.Point(380, 357);
        this.button22.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button22.Name = "Button22";
        this.button22.Size = new System.Drawing.Size(181, 172);
        this.button22.TabIndex = 8;
        this.button22.Tag = "2 2";
        this.button22.UseVisualStyleBackColor = true;
        this.button22.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // Button21
        // 
        this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button21.Location = new System.Drawing.Point(192, 357);
        this.button21.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button21.Name = "Button21";
        this.button21.Size = new System.Drawing.Size(180, 172);
        this.button21.TabIndex = 7;
        this.button21.Tag = "2 1";
        this.button21.UseVisualStyleBackColor = true;
        this.button21.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // Button20
        // 
        this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button20.Location = new System.Drawing.Point(4, 357);
        this.button20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button20.Name = "Button20";
        this.button20.Size = new System.Drawing.Size(180, 172);
        this.button20.TabIndex = 6;
        this.button20.Tag = "2 0";
        this.button20.UseVisualStyleBackColor = true;
        this.button20.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // Button12
        // 
        this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button12.Location = new System.Drawing.Point(380, 180);
        this.button12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button12.Name = "Button12";
        this.button12.Size = new System.Drawing.Size(181, 171);
        this.button12.TabIndex = 5;
        this.button12.Tag = "1 2";
        this.button12.UseVisualStyleBackColor = true;
        this.button12.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // Button11
        // 
        this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button11.Location = new System.Drawing.Point(192, 180);
        this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button11.Name = "Button11";
        this.button11.Size = new System.Drawing.Size(180, 171);
        this.button11.TabIndex = 4;
        this.button11.Tag = "1 1";
        this.button11.UseVisualStyleBackColor = true;
        this.button11.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // Button10
        // 
        this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button10.Location = new System.Drawing.Point(4, 180);
        this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button10.Name = "Button10";
        this.button10.Size = new System.Drawing.Size(180, 171);
        this.button10.TabIndex = 3;
        this.button10.Tag = "1 0";
        this.button10.UseVisualStyleBackColor = true;
        this.button10.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // Button02
        // 
        this.button02.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button02.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button02.Location = new System.Drawing.Point(380, 3);
        this.button02.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button02.Name = "Button02";
        this.button02.Size = new System.Drawing.Size(181, 171);
        this.button02.TabIndex = 2;
        this.button02.Tag = "0 2";
        this.button02.UseVisualStyleBackColor = true;
        this.button02.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // Button01
        // 
        this.button01.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button01.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button01.Location = new System.Drawing.Point(192, 3);
        this.button01.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button01.Name = "Button01";
        this.button01.Size = new System.Drawing.Size(180, 171);
        this.button01.TabIndex = 1;
        this.button01.Tag = "0 1";
        this.button01.UseVisualStyleBackColor = true;
        this.button01.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // Button00
        // 
        this.button00.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button00.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.button00.Location = new System.Drawing.Point(4, 3);
        this.button00.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.button00.Name = "Button00";
        this.button00.Size = new System.Drawing.Size(180, 171);
        this.button00.TabIndex = 0;
        this.button00.Tag = "0 0";
        this.button00.UseVisualStyleBackColor = true;
        this.button00.Click += new System.EventHandler(this.OnCellButtonClick);
        // 
        // TicTacToeForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(565, 532);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        this.MinimumSize = new System.Drawing.Size(464, 456);
        this.Name = "TicTacToeForm";
        this.Text = "TicTacToe";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button button22;
    private System.Windows.Forms.Button button21;
    private System.Windows.Forms.Button button20;
    private System.Windows.Forms.Button button12;
    private System.Windows.Forms.Button button11;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.Button button02;
    private System.Windows.Forms.Button button01;
    private System.Windows.Forms.Button button00;
}

