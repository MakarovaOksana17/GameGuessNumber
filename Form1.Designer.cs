namespace GuessNumberGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAttempt = new System.Windows.Forms.MaskedTextBox();
            this.txtTo = new System.Windows.Forms.MaskedTextBox();
            this.txtFrom = new System.Windows.Forms.MaskedTextBox();
            this.btnSpecify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResponse = new System.Windows.Forms.MaskedTextBox();
            this.btnResponse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAttempt);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.btnSpecify);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 93);
            this.panel1.TabIndex = 0;
            // 
            // txtAttempt
            // 
            this.txtAttempt.Location = new System.Drawing.Point(143, 52);
            this.txtAttempt.Mask = "00000";
            this.txtAttempt.Name = "txtAttempt";
            this.txtAttempt.Size = new System.Drawing.Size(56, 20);
            this.txtAttempt.TabIndex = 7;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(222, 18);
            this.txtTo.Mask = "00000";
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(56, 20);
            this.txtTo.TabIndex = 6;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(139, 15);
            this.txtFrom.Mask = "00000";
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(56, 20);
            this.txtFrom.TabIndex = 5;
            // 
            // btnSpecify
            // 
            this.btnSpecify.Location = new System.Drawing.Point(211, 48);
            this.btnSpecify.Name = "btnSpecify";
            this.btnSpecify.Size = new System.Drawing.Size(92, 42);
            this.btnSpecify.TabIndex = 4;
            this.btnSpecify.Text = "Задать";
            this.btnSpecify.UseVisualStyleBackColor = true;
            this.btnSpecify.Click += new System.EventHandler(this.btnSpecify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Количество попыток:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Диапозон чисел:    от";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Правила";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtResponse);
            this.panel2.Controls.Add(this.btnResponse);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 59);
            this.panel2.TabIndex = 4;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(115, 15);
            this.txtResponse.Mask = "00000";
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(80, 20);
            this.txtResponse.TabIndex = 8;
            // 
            // btnResponse
            // 
            this.btnResponse.Location = new System.Drawing.Point(211, 16);
            this.btnResponse.Name = "btnResponse";
            this.btnResponse.Size = new System.Drawing.Size(75, 23);
            this.btnResponse.TabIndex = 2;
            this.btnResponse.Text = "Ответ";
            this.btnResponse.UseVisualStyleBackColor = true;
            this.btnResponse.Click += new System.EventHandler(this.btnResponse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите число: ";
            // 
            // rTB
            // 
            this.rTB.Location = new System.Drawing.Point(12, 216);
            this.rTB.Name = "rTB";
            this.rTB.Size = new System.Drawing.Size(303, 112);
            this.rTB.TabIndex = 5;
            this.rTB.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Новая игра";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 388);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Игра \"Угадай число\"";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpecify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txtFrom;
        private System.Windows.Forms.MaskedTextBox txtAttempt;
        private System.Windows.Forms.MaskedTextBox txtTo;
        private System.Windows.Forms.MaskedTextBox txtResponse;
    }
}

