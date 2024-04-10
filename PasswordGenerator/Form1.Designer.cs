namespace PasswordGenerator
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
            this.Note = new System.Windows.Forms.RichTextBox();
            this.generatePass = new System.Windows.Forms.Button();
            this.passLenght = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.removeSimilar = new System.Windows.Forms.CheckBox();
            this.removeSpecSymb = new System.Windows.Forms.CheckBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // Note
            // 
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Note.Location = new System.Drawing.Point(28, 327);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(505, 229);
            this.Note.TabIndex = 1;
            this.Note.Text = "";
            // 
            // generatePass
            // 
            this.generatePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatePass.Location = new System.Drawing.Point(358, 641);
            this.generatePass.Name = "generatePass";
            this.generatePass.Size = new System.Drawing.Size(240, 54);
            this.generatePass.TabIndex = 2;
            this.generatePass.Text = "Сгенерировать";
            this.generatePass.UseVisualStyleBackColor = true;
            this.generatePass.Click += new System.EventHandler(this.generatePass_Click);
            // 
            // passLenght
            // 
            this.passLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLenght.Location = new System.Drawing.Point(12, 35);
            this.passLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passLenght.Name = "passLenght";
            this.passLenght.Size = new System.Drawing.Size(120, 38);
            this.passLenght.TabIndex = 3;
            this.passLenght.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Длина пароля";
            // 
            // removeSimilar
            // 
            this.removeSimilar.AutoSize = true;
            this.removeSimilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSimilar.Location = new System.Drawing.Point(12, 103);
            this.removeSimilar.Name = "removeSimilar";
            this.removeSimilar.Size = new System.Drawing.Size(392, 35);
            this.removeSimilar.TabIndex = 7;
            this.removeSimilar.Text = "Исключить (i, l, 1, L, o, 0, O)";
            this.removeSimilar.UseVisualStyleBackColor = true;
            // 
            // removeSpecSymb
            // 
            this.removeSpecSymb.AutoSize = true;
            this.removeSpecSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSpecSymb.Location = new System.Drawing.Point(12, 162);
            this.removeSpecSymb.Name = "removeSpecSymb";
            this.removeSpecSymb.Size = new System.Drawing.Size(500, 35);
            this.removeSpecSymb.TabIndex = 8;
            this.removeSpecSymb.Text = "Исключить ({ } [ ] ( ) / \\ \' \" ` ~ , ; : . < >)";
            this.removeSpecSymb.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(49, 277);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(194, 44);
            this.login.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Логин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 717);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.removeSpecSymb);
            this.Controls.Add(this.removeSimilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLenght);
            this.Controls.Add(this.generatePass);
            this.Controls.Add(this.Note);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.passLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Note;
        private System.Windows.Forms.Button generatePass;
        private System.Windows.Forms.NumericUpDown passLenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox removeSimilar;
        private System.Windows.Forms.CheckBox removeSpecSymb;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label2;
    }
}

