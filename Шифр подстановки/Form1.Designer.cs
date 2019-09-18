namespace Шифр_подстановки
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
            this.EncryptText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.EncryptDecryptButton = new System.Windows.Forms.Button();
            this.DecryptText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncryptText
            // 
            this.EncryptText.Location = new System.Drawing.Point(168, 66);
            this.EncryptText.Name = "EncryptText";
            this.EncryptText.Size = new System.Drawing.Size(253, 20);
            this.EncryptText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Шифр подстановки";
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(168, 40);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(253, 20);
            this.InputText.TabIndex = 3;
            this.InputText.Leave += new System.EventHandler(this.InputText_Leave);
            // 
            // EncryptDecryptButton
            // 
            this.EncryptDecryptButton.Location = new System.Drawing.Point(134, 137);
            this.EncryptDecryptButton.Name = "EncryptDecryptButton";
            this.EncryptDecryptButton.Size = new System.Drawing.Size(169, 23);
            this.EncryptDecryptButton.TabIndex = 4;
            this.EncryptDecryptButton.Text = "Зашифровать/Расшифровать";
            this.EncryptDecryptButton.UseVisualStyleBackColor = true;
            this.EncryptDecryptButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DecryptText
            // 
            this.DecryptText.Location = new System.Drawing.Point(168, 92);
            this.DecryptText.Name = "DecryptText";
            this.DecryptText.Size = new System.Drawing.Size(253, 20);
            this.DecryptText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Исходный текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Зашифрованный текст:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Расшифрованный текст:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 181);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DecryptText);
            this.Controls.Add(this.EncryptDecryptButton);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncryptText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EncryptText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button EncryptDecryptButton;
        private System.Windows.Forms.TextBox DecryptText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

