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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DecryptText = new System.Windows.Forms.TextBox();
            this.EncryptDecryptButton = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.TextBox();
            this.EncryptText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DecryptTransposition = new System.Windows.Forms.TextBox();
            this.EncryptDecryptTransposition = new System.Windows.Forms.Button();
            this.InputTransposition = new System.Windows.Forms.TextBox();
            this.EncryptTransposition = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 215);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Salmon;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DecryptText);
            this.tabPage1.Controls.Add(this.EncryptDecryptButton);
            this.tabPage1.Controls.Add(this.InputText);
            this.tabPage1.Controls.Add(this.EncryptText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифр подстановки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Расшифрованный текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Зашифрованный текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Исходный текст:";
            // 
            // DecryptText
            // 
            this.DecryptText.Location = new System.Drawing.Point(198, 87);
            this.DecryptText.Name = "DecryptText";
            this.DecryptText.Size = new System.Drawing.Size(253, 20);
            this.DecryptText.TabIndex = 13;
            // 
            // EncryptDecryptButton
            // 
            this.EncryptDecryptButton.Location = new System.Drawing.Point(164, 132);
            this.EncryptDecryptButton.Name = "EncryptDecryptButton";
            this.EncryptDecryptButton.Size = new System.Drawing.Size(169, 23);
            this.EncryptDecryptButton.TabIndex = 12;
            this.EncryptDecryptButton.Text = "Зашифровать/Расшифровать";
            this.EncryptDecryptButton.UseVisualStyleBackColor = true;
            this.EncryptDecryptButton.Click += new System.EventHandler(this.EncryptDecryptButton_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(198, 35);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(253, 20);
            this.InputText.TabIndex = 11;
            this.InputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputText_KeyPress);
            this.InputText.Leave += new System.EventHandler(this.InputText_Leave);
            // 
            // EncryptText
            // 
            this.EncryptText.Location = new System.Drawing.Point(198, 61);
            this.EncryptText.Name = "EncryptText";
            this.EncryptText.Size = new System.Drawing.Size(253, 20);
            this.EncryptText.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.DecryptTransposition);
            this.tabPage2.Controls.Add(this.EncryptDecryptTransposition);
            this.tabPage2.Controls.Add(this.InputTransposition);
            this.tabPage2.Controls.Add(this.EncryptTransposition);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Шифр перестановки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Расшифрованный текст:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Зашифрованный текст:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Исходный текст:";
            // 
            // DecryptTransposition
            // 
            this.DecryptTransposition.Location = new System.Drawing.Point(191, 86);
            this.DecryptTransposition.Name = "DecryptTransposition";
            this.DecryptTransposition.Size = new System.Drawing.Size(253, 20);
            this.DecryptTransposition.TabIndex = 20;
            // 
            // EncryptDecryptTransposition
            // 
            this.EncryptDecryptTransposition.Location = new System.Drawing.Point(157, 131);
            this.EncryptDecryptTransposition.Name = "EncryptDecryptTransposition";
            this.EncryptDecryptTransposition.Size = new System.Drawing.Size(169, 23);
            this.EncryptDecryptTransposition.TabIndex = 19;
            this.EncryptDecryptTransposition.Text = "Зашифровать/Расшифровать";
            this.EncryptDecryptTransposition.UseVisualStyleBackColor = true;
            this.EncryptDecryptTransposition.Click += new System.EventHandler(this.EncryptDecryptTransposition_Click);
            // 
            // InputTransposition
            // 
            this.InputTransposition.Location = new System.Drawing.Point(191, 34);
            this.InputTransposition.Name = "InputTransposition";
            this.InputTransposition.Size = new System.Drawing.Size(253, 20);
            this.InputTransposition.TabIndex = 18;
            // 
            // EncryptTransposition
            // 
            this.EncryptTransposition.Location = new System.Drawing.Point(191, 60);
            this.EncryptTransposition.Name = "EncryptTransposition";
            this.EncryptTransposition.Size = new System.Drawing.Size(253, 20);
            this.EncryptTransposition.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 215);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Алгоритмы шифрования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DecryptText;
        private System.Windows.Forms.Button EncryptDecryptButton;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox EncryptText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DecryptTransposition;
        private System.Windows.Forms.Button EncryptDecryptTransposition;
        private System.Windows.Forms.TextBox InputTransposition;
        private System.Windows.Forms.TextBox EncryptTransposition;
    }
}

