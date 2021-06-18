namespace TiresCalculator
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
            this.OldFirstValue = new System.Windows.Forms.ComboBox();
            this.NewFirstValue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OldSecondValue = new System.Windows.Forms.ComboBox();
            this.OldThirdValue = new System.Windows.Forms.ComboBox();
            this.NewThirdValue = new System.Windows.Forms.ComboBox();
            this.NewSecondValue = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OutputOld1 = new System.Windows.Forms.Label();
            this.OutputOld2 = new System.Windows.Forms.Label();
            this.OutputOld3 = new System.Windows.Forms.Label();
            this.OutputOld4 = new System.Windows.Forms.Label();
            this.OutputNew1 = new System.Windows.Forms.Label();
            this.OutputNew2 = new System.Windows.Forms.Label();
            this.OutputNew3 = new System.Windows.Forms.Label();
            this.OutputNew4 = new System.Windows.Forms.Label();
            this.OutputClearance = new System.Windows.Forms.Label();
            this.OutputSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OldFirstValue
            // 
            this.OldFirstValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OldFirstValue.FormattingEnabled = true;
            this.OldFirstValue.Location = new System.Drawing.Point(16, 107);
            this.OldFirstValue.Name = "OldFirstValue";
            this.OldFirstValue.Size = new System.Drawing.Size(53, 21);
            this.OldFirstValue.TabIndex = 0;
            // 
            // NewFirstValue
            // 
            this.NewFirstValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewFirstValue.FormattingEnabled = true;
            this.NewFirstValue.Location = new System.Drawing.Point(278, 108);
            this.NewFirstValue.Name = "NewFirstValue";
            this.NewFirstValue.Size = new System.Drawing.Size(53, 21);
            this.NewFirstValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Скористайтеся шинним калькулятором, щоб дізнатися, до чого призведе зміна стандар" +
    "тних розмірів шин вашого авто і як це вплине на експлуатацію автомобіля.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Старий розмір";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Новий розмір";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "/";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(337, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "/";
            // 
            // OldSecondValue
            // 
            this.OldSecondValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OldSecondValue.FormattingEnabled = true;
            this.OldSecondValue.Location = new System.Drawing.Point(98, 106);
            this.OldSecondValue.Name = "OldSecondValue";
            this.OldSecondValue.Size = new System.Drawing.Size(51, 21);
            this.OldSecondValue.TabIndex = 7;
            this.OldSecondValue.SelectedIndexChanged += new System.EventHandler(this.OldSecondValue_SelectedIndexChanged);
            // 
            // OldThirdValue
            // 
            this.OldThirdValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OldThirdValue.FormattingEnabled = true;
            this.OldThirdValue.Location = new System.Drawing.Point(172, 106);
            this.OldThirdValue.Name = "OldThirdValue";
            this.OldThirdValue.Size = new System.Drawing.Size(53, 21);
            this.OldThirdValue.TabIndex = 8;
            // 
            // NewThirdValue
            // 
            this.NewThirdValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewThirdValue.FormattingEnabled = true;
            this.NewThirdValue.Location = new System.Drawing.Point(432, 108);
            this.NewThirdValue.Name = "NewThirdValue";
            this.NewThirdValue.Size = new System.Drawing.Size(54, 21);
            this.NewThirdValue.TabIndex = 10;
            this.NewThirdValue.SelectedIndexChanged += new System.EventHandler(this.NewThirdValue_SelectedIndexChanged);
            // 
            // NewSecondValue
            // 
            this.NewSecondValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewSecondValue.FormattingEnabled = true;
            this.NewSecondValue.Location = new System.Drawing.Point(355, 108);
            this.NewSecondValue.Name = "NewSecondValue";
            this.NewSecondValue.Size = new System.Drawing.Size(51, 21);
            this.NewSecondValue.TabIndex = 9;
            this.NewSecondValue.SelectedIndexChanged += new System.EventHandler(this.NewSecondValue_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Порахувати";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ширина протектора";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(86, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "Висота шини";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(167, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 46);
            this.label8.TabIndex = 15;
            this.label8.Text = " Діаметр отвору для диска";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(433, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 46);
            this.label9.TabIndex = 18;
            this.label9.Text = "Діаметр отвору для диска";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(352, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 35);
            this.label10.TabIndex = 17;
            this.label10.Text = "Висота шини";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(271, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 35);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ширина протектора";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 245);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // OutputOld1
            // 
            this.OutputOld1.AutoSize = true;
            this.OutputOld1.BackColor = System.Drawing.Color.White;
            this.OutputOld1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OutputOld1.Location = new System.Drawing.Point(201, 226);
            this.OutputOld1.Name = "OutputOld1";
            this.OutputOld1.Size = new System.Drawing.Size(41, 13);
            this.OutputOld1.TabIndex = 20;
            this.OutputOld1.Text = "label12";
            // 
            // OutputOld2
            // 
            this.OutputOld2.AutoSize = true;
            this.OutputOld2.BackColor = System.Drawing.Color.White;
            this.OutputOld2.ForeColor = System.Drawing.Color.Blue;
            this.OutputOld2.Location = new System.Drawing.Point(201, 299);
            this.OutputOld2.Name = "OutputOld2";
            this.OutputOld2.Size = new System.Drawing.Size(41, 13);
            this.OutputOld2.TabIndex = 21;
            this.OutputOld2.Text = "label13";
            // 
            // OutputOld3
            // 
            this.OutputOld3.AutoSize = true;
            this.OutputOld3.BackColor = System.Drawing.Color.White;
            this.OutputOld3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OutputOld3.Location = new System.Drawing.Point(201, 371);
            this.OutputOld3.Name = "OutputOld3";
            this.OutputOld3.Size = new System.Drawing.Size(41, 13);
            this.OutputOld3.TabIndex = 22;
            this.OutputOld3.Text = "label14";
            // 
            // OutputOld4
            // 
            this.OutputOld4.AutoSize = true;
            this.OutputOld4.BackColor = System.Drawing.Color.White;
            this.OutputOld4.Location = new System.Drawing.Point(201, 413);
            this.OutputOld4.Name = "OutputOld4";
            this.OutputOld4.Size = new System.Drawing.Size(41, 13);
            this.OutputOld4.TabIndex = 23;
            this.OutputOld4.Text = "label15";
            // 
            // OutputNew1
            // 
            this.OutputNew1.AutoSize = true;
            this.OutputNew1.BackColor = System.Drawing.Color.White;
            this.OutputNew1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OutputNew1.Location = new System.Drawing.Point(273, 226);
            this.OutputNew1.Name = "OutputNew1";
            this.OutputNew1.Size = new System.Drawing.Size(41, 13);
            this.OutputNew1.TabIndex = 24;
            this.OutputNew1.Text = "label16";
            // 
            // OutputNew2
            // 
            this.OutputNew2.AutoSize = true;
            this.OutputNew2.BackColor = System.Drawing.Color.White;
            this.OutputNew2.ForeColor = System.Drawing.Color.Blue;
            this.OutputNew2.Location = new System.Drawing.Point(273, 299);
            this.OutputNew2.Name = "OutputNew2";
            this.OutputNew2.Size = new System.Drawing.Size(41, 13);
            this.OutputNew2.TabIndex = 25;
            this.OutputNew2.Text = "label17";
            // 
            // OutputNew3
            // 
            this.OutputNew3.AutoSize = true;
            this.OutputNew3.BackColor = System.Drawing.Color.White;
            this.OutputNew3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OutputNew3.Location = new System.Drawing.Point(271, 371);
            this.OutputNew3.Name = "OutputNew3";
            this.OutputNew3.Size = new System.Drawing.Size(41, 13);
            this.OutputNew3.TabIndex = 26;
            this.OutputNew3.Text = "label18";
            // 
            // OutputNew4
            // 
            this.OutputNew4.AutoSize = true;
            this.OutputNew4.BackColor = System.Drawing.Color.White;
            this.OutputNew4.Location = new System.Drawing.Point(273, 413);
            this.OutputNew4.Name = "OutputNew4";
            this.OutputNew4.Size = new System.Drawing.Size(41, 13);
            this.OutputNew4.TabIndex = 27;
            this.OutputNew4.Text = "label19";
            // 
            // OutputClearance
            // 
            this.OutputClearance.AutoSize = true;
            this.OutputClearance.BackColor = System.Drawing.Color.White;
            this.OutputClearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputClearance.Location = new System.Drawing.Point(483, 400);
            this.OutputClearance.Name = "OutputClearance";
            this.OutputClearance.Size = new System.Drawing.Size(41, 13);
            this.OutputClearance.TabIndex = 28;
            this.OutputClearance.Text = "label13";
            // 
            // OutputSpeed
            // 
            this.OutputSpeed.AutoSize = true;
            this.OutputSpeed.BackColor = System.Drawing.Color.White;
            this.OutputSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputSpeed.Location = new System.Drawing.Point(527, 286);
            this.OutputSpeed.Name = "OutputSpeed";
            this.OutputSpeed.Size = new System.Drawing.Size(41, 13);
            this.OutputSpeed.TabIndex = 29;
            this.OutputSpeed.Text = "label14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.OutputSpeed);
            this.Controls.Add(this.OutputClearance);
            this.Controls.Add(this.OutputNew4);
            this.Controls.Add(this.OutputNew3);
            this.Controls.Add(this.OutputNew2);
            this.Controls.Add(this.OutputNew1);
            this.Controls.Add(this.OutputOld4);
            this.Controls.Add(this.OutputOld3);
            this.Controls.Add(this.OutputOld2);
            this.Controls.Add(this.OutputOld1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewThirdValue);
            this.Controls.Add(this.NewSecondValue);
            this.Controls.Add(this.OldThirdValue);
            this.Controls.Add(this.OldSecondValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewFirstValue);
            this.Controls.Add(this.OldFirstValue);
            this.Name = "Form1";
            this.Text = "Шинний калькулятор v.0.001";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OldFirstValue;
        private System.Windows.Forms.ComboBox NewFirstValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OldSecondValue;
        private System.Windows.Forms.ComboBox OldThirdValue;
        private System.Windows.Forms.ComboBox NewThirdValue;
        private System.Windows.Forms.ComboBox NewSecondValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label OutputOld1;
        private System.Windows.Forms.Label OutputOld2;
        private System.Windows.Forms.Label OutputOld3;
        private System.Windows.Forms.Label OutputOld4;
        private System.Windows.Forms.Label OutputNew1;
        private System.Windows.Forms.Label OutputNew2;
        private System.Windows.Forms.Label OutputNew3;
        private System.Windows.Forms.Label OutputNew4;
        private System.Windows.Forms.Label OutputClearance;
        private System.Windows.Forms.Label OutputSpeed;
    }
}

