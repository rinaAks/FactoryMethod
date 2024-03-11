namespace lab1withPattern;

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
        panel1 = new Panel();
        cbType = new ComboBox();
        cbStyle = new ComboBox();
        label1 = new Label();
        btStart = new Button();
        label3 = new Label();
        label2 = new Label();
        label4 = new Label();
        tbResult = new RichTextBox();
        panel2 = new Panel();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(cbType);
        panel1.Controls.Add(cbStyle);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(btStart);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(3, 4, 3, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(601, 751);
        panel1.TabIndex = 0;
        // 
        // cbType
        // 
        cbType.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
        cbType.FormattingEnabled = true;
        cbType.Items.AddRange(new object[] { "Cheese", "Pepperoni", "Mandarin" });
        cbType.Location = new Point(169, 296);
        cbType.Margin = new Padding(3, 4, 3, 4);
        cbType.Name = "cbType";
        cbType.Size = new Size(165, 30);
        cbType.TabIndex = 18;
        // 
        // cbStyle
        // 
        cbStyle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
        cbStyle.FormattingEnabled = true;
        cbStyle.Items.AddRange(new object[] { "Tomsk", "Novosibirsk" });
        cbStyle.Location = new Point(169, 208);
        cbStyle.Margin = new Padding(3, 4, 3, 4);
        cbStyle.Name = "cbStyle";
        cbStyle.Size = new Size(165, 30);
        cbStyle.TabIndex = 17;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.Location = new Point(139, 58);
        label1.Name = "label1";
        label1.Size = new Size(328, 29);
        label1.TabIndex = 16;
        label1.Text = "Задайте параметры пиццы";
        // 
        // btStart
        // 
        btStart.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
        btStart.Location = new Point(234, 484);
        btStart.Margin = new Padding(3, 4, 3, 4);
        btStart.Name = "btStart";
        btStart.Size = new Size(144, 62);
        btStart.TabIndex = 6;
        btStart.Text = "Запустить";
        btStart.UseVisualStyleBackColor = true;
        btStart.Click += btStart_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label3.Location = new Point(34, 300);
        label3.Name = "label3";
        label3.Size = new Size(107, 24);
        label3.TabIndex = 2;
        label3.Text = "Pizza's type";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label2.Location = new Point(34, 211);
        label2.Name = "label2";
        label2.Size = new Size(109, 24);
        label2.TabIndex = 1;
        label2.Text = "Pizza's style";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label4.Location = new Point(233, 89);
        label4.Name = "label4";
        label4.Size = new Size(132, 29);
        label4.TabIndex = 15;
        label4.Text = "Результат";
        // 
        // tbResult
        // 
        tbResult.BackColor = SystemColors.ControlLightLight;
        tbResult.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
        tbResult.Location = new Point(93, 154);
        tbResult.Margin = new Padding(3, 4, 3, 4);
        tbResult.Name = "tbResult";
        tbResult.ReadOnly = true;
        tbResult.Size = new Size(411, 376);
        tbResult.TabIndex = 12;
        tbResult.Text = "";
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.Control;
        panel2.Controls.Add(label4);
        panel2.Controls.Add(tbResult);
        panel2.Dock = DockStyle.Right;
        panel2.Location = new Point(597, 0);
        panel2.Margin = new Padding(3, 4, 3, 4);
        panel2.Name = "panel2";
        panel2.Size = new Size(587, 751);
        panel2.TabIndex = 16;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1184, 751);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Пицца с паттерном";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btStart;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RichTextBox tbResult;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.ComboBox cbType;
    private System.Windows.Forms.ComboBox cbStyle;
}

