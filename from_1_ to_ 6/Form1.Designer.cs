namespace from_1__to__6
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.CheckBox();
            this.two = new System.Windows.Forms.CheckBox();
            this.three = new System.Windows.Forms.CheckBox();
            this.four = new System.Windows.Forms.CheckBox();
            this.five = new System.Windows.Forms.CheckBox();
            this.six = new System.Windows.Forms.CheckBox();
            this.fdice = new System.Windows.Forms.Button();
            this.sdice = new System.Windows.Forms.Button();
            this.tdice = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.l1dice = new System.Windows.Forms.Label();
            this.l2dice = new System.Windows.Forms.Label();
            this.l3dice = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(647, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Правила игры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбери число!";
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(286, 78);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(31, 23);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.CheckedChanged += new System.EventHandler(this.one_CheckedChanged);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(323, 78);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(31, 23);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.CheckedChanged += new System.EventHandler(this.one_CheckedChanged);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(360, 78);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(31, 23);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.CheckedChanged += new System.EventHandler(this.one_CheckedChanged);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(397, 78);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(31, 23);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.CheckedChanged += new System.EventHandler(this.one_CheckedChanged);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(434, 78);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(31, 23);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.CheckedChanged += new System.EventHandler(this.one_CheckedChanged);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(469, 78);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(31, 23);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.CheckedChanged += new System.EventHandler(this.one_CheckedChanged);
            // 
            // fdice
            // 
            this.fdice.Enabled = false;
            this.fdice.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fdice.Location = new System.Drawing.Point(12, 119);
            this.fdice.Name = "fdice";
            this.fdice.Size = new System.Drawing.Size(150, 29);
            this.fdice.TabIndex = 8;
            this.fdice.Text = "Бросить кубик №1";
            this.fdice.UseVisualStyleBackColor = true;
            this.fdice.Click += new System.EventHandler(this.fdice_Click);
            // 
            // sdice
            // 
            this.sdice.Enabled = false;
            this.sdice.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sdice.Location = new System.Drawing.Point(323, 119);
            this.sdice.Name = "sdice";
            this.sdice.Size = new System.Drawing.Size(150, 29);
            this.sdice.TabIndex = 9;
            this.sdice.Text = "Бросить кубик №2";
            this.sdice.UseVisualStyleBackColor = true;
            this.sdice.Click += new System.EventHandler(this.sdice_Click);
            // 
            // tdice
            // 
            this.tdice.Enabled = false;
            this.tdice.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tdice.Location = new System.Drawing.Point(638, 119);
            this.tdice.Name = "tdice";
            this.tdice.Size = new System.Drawing.Size(150, 29);
            this.tdice.TabIndex = 10;
            this.tdice.Text = "Бросить кубик №3";
            this.tdice.UseVisualStyleBackColor = true;
            this.tdice.Click += new System.EventHandler(this.tdice_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(10, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(101, 26);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Сброс игры";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.reset_btn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 12;
            // 
            // l1dice
            // 
            this.l1dice.AutoSize = true;
            this.l1dice.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1dice.Location = new System.Drawing.Point(86, 164);
            this.l1dice.Name = "l1dice";
            this.l1dice.Size = new System.Drawing.Size(0, 26);
            this.l1dice.TabIndex = 13;
            // 
            // l2dice
            // 
            this.l2dice.AutoSize = true;
            this.l2dice.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2dice.Location = new System.Drawing.Point(391, 164);
            this.l2dice.Name = "l2dice";
            this.l2dice.Size = new System.Drawing.Size(0, 26);
            this.l2dice.TabIndex = 14;
            // 
            // l3dice
            // 
            this.l3dice.AutoSize = true;
            this.l3dice.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3dice.Location = new System.Drawing.Point(708, 164);
            this.l3dice.Name = "l3dice";
            this.l3dice.Size = new System.Drawing.Size(0, 26);
            this.l3dice.TabIndex = 15;
            // 
            // res
            // 
            this.res.Enabled = false;
            this.res.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(647, 55);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(142, 46);
            this.res.TabIndex = 16;
            this.res.Text = "Результат";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.res_Click);
            this.res.MouseEnter += new System.EventHandler(this.resultat);
            this.res.MouseLeave += new System.EventHandler(this.resultat);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.res);
            this.Controls.Add(this.l3dice);
            this.Controls.Add(this.l2dice);
            this.Controls.Add(this.l1dice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.tdice);
            this.Controls.Add(this.sdice);
            this.Controls.Add(this.fdice);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Проверь свою удачу";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.resultat);
            this.MouseEnter += new System.EventHandler(this.resultat);
            this.MouseLeave += new System.EventHandler(this.resultat);
            this.MouseHover += new System.EventHandler(this.resultat);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox one;
        private System.Windows.Forms.CheckBox two;
        private System.Windows.Forms.CheckBox three;
        private System.Windows.Forms.CheckBox four;
        private System.Windows.Forms.CheckBox five;
        private System.Windows.Forms.CheckBox six;
        private System.Windows.Forms.Button sdice;
        private System.Windows.Forms.Button tdice;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fdice;
        private System.Windows.Forms.Label l1dice;
        private System.Windows.Forms.Label l2dice;
        private System.Windows.Forms.Label l3dice;
        private System.Windows.Forms.Button res;
    }
}

