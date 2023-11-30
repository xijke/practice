namespace pr_9
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtKolvo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolvoMa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(195, 35);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(207, 20);
            this.txtString.TabIndex = 0;
            // 
            // txtKolvo
            // 
            this.txtKolvo.Location = new System.Drawing.Point(195, 75);
            this.txtKolvo.Name = "txtKolvo";
            this.txtKolvo.Size = new System.Drawing.Size(100, 20);
            this.txtKolvo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите строку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество символов \"а\"";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(318, 151);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(84, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Подсчитать";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество сочетаний букв \"ма\"";
            // 
            // txtKolvoMa
            // 
            this.txtKolvoMa.Location = new System.Drawing.Point(195, 115);
            this.txtKolvoMa.Name = "txtKolvoMa";
            this.txtKolvoMa.Size = new System.Drawing.Size(100, 20);
            this.txtKolvoMa.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 183);
            this.Controls.Add(this.txtKolvoMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKolvo);
            this.Controls.Add(this.txtString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtKolvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolvoMa;
    }
}

