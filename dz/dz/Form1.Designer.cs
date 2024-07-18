namespace dz
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
            this.text1 = new System.Windows.Forms.RichTextBox();
            this.Sort = new System.Windows.Forms.Button();
            this.textVR1 = new System.Windows.Forms.RichTextBox();
            this.textVR2 = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();


            // Блок для ввода

            this.text1.TabIndex = 1;
            this.text1.Location = new System.Drawing.Point(70, 120);
            this.text1.Name = "Ввод";
            this.text1.Size = new System.Drawing.Size(100, 190);
            this.text1.Text = "";
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);


            // Кнопка сортировки

            this.Sort.TabIndex = 2;
            this.Sort.Location = new System.Drawing.Point(220, 180);
            this.Sort.Name = "Отсортировать";
            this.Sort.Size = new System.Drawing.Size(110, 60);
            this.Sort.Text = "Отсортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.button1_Click);


            // Вывод отсортированного массива по возрастанию

            this.textVR1.TabIndex = 3;
            this.textVR1.Enabled = false;
            this.textVR1.Location = new System.Drawing.Point(375, 120);
            this.textVR1.Name = "Вывод отсортированного массива по возрастанию";
            this.textVR1.Size = new System.Drawing.Size(100, 190);
            this.textVR1.Text = "";


            // Вывод отсортированного массива по убыванию

            this.textVR2.TabIndex = 4;
            this.textVR2.Enabled = false;
            this.textVR2.Location = new System.Drawing.Point(535, 120);
            this.textVR2.Name = "Вывод отсортированного массива по убыванию";
            this.textVR2.Size = new System.Drawing.Size(100, 190);
            this.textVR2.Text = "";


            // Блок для сохранения результата в txt

            this.Save.TabIndex = 5;
            this.Save.Location = new System.Drawing.Point(155, 15);
            this.Save.Name = "Сохранить";
            this.Save.Size = new System.Drawing.Size(220, 25);
            this.Save.Text = "Сохранить результат";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button2_Click);


            // label 1

            this.label1.TabIndex = 6;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.Text = "Введите числа ";


            // label 2

            this.label2.TabIndex = 7;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.Text = "Отсортированный массив";


            // Form1

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textVR1);
            this.Controls.Add(this.textVR2);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text1;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.RichTextBox textVR1;
        private System.Windows.Forms.RichTextBox textVR2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

