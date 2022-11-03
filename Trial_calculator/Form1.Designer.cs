
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button_eval = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 61);
            this.label1.TabIndex = 18;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Red;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(99, 247);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 57);
            this.button13.TabIndex = 12;
            this.button13.Tag = "clear";
            this.button13.Text = "C";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button_Click);
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Yellow;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(147, 125);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 55);
            this.button14.TabIndex = 13;
            this.button14.Tag = "substraction";
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button_Click);
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button_eval
            // 
            this.button_eval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_eval.BackColor = System.Drawing.Color.Yellow;
            this.button_eval.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_eval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_eval.Location = new System.Drawing.Point(196, 64);
            this.button_eval.Name = "button_eval";
            this.tableLayoutPanel1.SetRowSpan(this.button_eval, 4);
            this.button_eval.Size = new System.Drawing.Size(52, 240);
            this.button_eval.TabIndex = 16;
            this.button_eval.Tag = "evaluate";
            this.button_eval.Text = "=";
            this.button_eval.UseVisualStyleBackColor = false;
            this.button_eval.Click += new System.EventHandler(this.button_Click);
            this.button_eval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button_eval.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(99, 125);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 55);
            this.button10.TabIndex = 9;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_Click);
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(99, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 55);
            this.button9.TabIndex = 8;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(51, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(51, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button11, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button12, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button16, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button13, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_eval, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 307);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Yellow;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(147, 186);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(42, 55);
            this.button15.TabIndex = 14;
            this.button15.Tag = "multiplication";
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button_Click);
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(51, 247);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 57);
            this.button8.TabIndex = 7;
            this.button8.Tag = "plusandminus";
            this.button8.Text = "+/-";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(51, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(99, 186);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 55);
            this.button11.TabIndex = 10;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Yellow;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(147, 64);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 55);
            this.button12.TabIndex = 10;
            this.button12.Tag = "addition";
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_Click);
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Yellow;
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(147, 247);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(42, 57);
            this.button16.TabIndex = 15;
            this.button16.Tag = "division";
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button_Click);
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "MyCalculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button_eval;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button16;
    }
}

