namespace CookParse
{
    partial class InputForm
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
            this.textFIO = new System.Windows.Forms.TextBox();
            this.fioLable = new System.Windows.Forms.Label();
            this.photoLabel = new System.Windows.Forms.Label();
            this.downloadPhotoButton = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conditionGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addNum = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.sendForm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.delNum = new System.Windows.Forms.Button();
            this.textNum = new System.Windows.Forms.MaskedTextBox();
            this.oterNumTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputMoney = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.conditionGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFIO
            // 
            this.textFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFIO.Location = new System.Drawing.Point(9, 44);
            this.textFIO.MaximumSize = new System.Drawing.Size(1166, 1000);
            this.textFIO.Multiline = true;
            this.textFIO.Name = "textFIO";
            this.textFIO.Size = new System.Drawing.Size(256, 30);
            this.textFIO.TabIndex = 2;
            // 
            // fioLable
            // 
            this.fioLable.AutoSize = true;
            this.fioLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLable.Location = new System.Drawing.Point(6, 16);
            this.fioLable.Name = "fioLable";
            this.fioLable.Size = new System.Drawing.Size(61, 25);
            this.fioLable.TabIndex = 0;
            this.fioLable.Text = "ФИО";
            // 
            // photoLabel
            // 
            this.photoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.Location = new System.Drawing.Point(6, 16);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(118, 39);
            this.photoLabel.TabIndex = 4;
            this.photoLabel.Text = "Фото";
            // 
            // downloadPhotoButton
            // 
            this.downloadPhotoButton.Location = new System.Drawing.Point(6, 53);
            this.downloadPhotoButton.Name = "downloadPhotoButton";
            this.downloadPhotoButton.Size = new System.Drawing.Size(368, 41);
            this.downloadPhotoButton.TabIndex = 5;
            this.downloadPhotoButton.Text = "Загрузить фото";
            this.downloadPhotoButton.UseVisualStyleBackColor = true;
            this.downloadPhotoButton.Click += new System.EventHandler(this.downloadPhotoButton_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(9, 100);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(365, 346);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 6;
            this.pictureBoxUser.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downloadPhotoButton);
            this.groupBox1.Controls.Add(this.pictureBoxUser);
            this.groupBox1.Controls.Add(this.photoLabel);
            this.groupBox1.Location = new System.Drawing.Point(315, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 454);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // infoLable
            // 
            this.infoLable.AutoSize = true;
            this.infoLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLable.Location = new System.Drawing.Point(6, 12);
            this.infoLable.Name = "infoLable";
            this.infoLable.Size = new System.Drawing.Size(97, 25);
            this.infoLable.TabIndex = 8;
            this.infoLable.Text = "Заметка";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id квартиры";
            // 
            // conditionGroupBox
            // 
            this.conditionGroupBox.Controls.Add(this.comboBox1);
            this.conditionGroupBox.Controls.Add(this.label1);
            this.conditionGroupBox.Location = new System.Drawing.Point(12, 212);
            this.conditionGroupBox.Name = "conditionGroupBox";
            this.conditionGroupBox.Size = new System.Drawing.Size(271, 89);
            this.conditionGroupBox.TabIndex = 13;
            this.conditionGroupBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // addNum
            // 
            this.addNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNum.Location = new System.Drawing.Point(224, 114);
            this.addNum.Name = "addNum";
            this.addNum.Size = new System.Drawing.Size(20, 22);
            this.addNum.TabIndex = 12;
            this.addNum.Text = "+";
            this.addNum.UseVisualStyleBackColor = true;
            this.addNum.Click += new System.EventHandler(this.addNum_Click);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numLabel.Location = new System.Drawing.Point(6, 86);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(183, 25);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "Номер телефона";
            // 
            // sendForm
            // 
            this.sendForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendForm.Location = new System.Drawing.Point(315, 500);
            this.sendForm.Name = "sendForm";
            this.sendForm.Size = new System.Drawing.Size(124, 61);
            this.sendForm.TabIndex = 14;
            this.sendForm.Text = "Отправить форму";
            this.sendForm.UseVisualStyleBackColor = true;
            this.sendForm.Click += new System.EventHandler(this.sendForm_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(571, 500);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(124, 61);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 291);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker.TabIndex = 16;
            this.dateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNote.Location = new System.Drawing.Point(6, 40);
            this.textBoxNote.MaximumSize = new System.Drawing.Size(1166, 1000);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(226, 154);
            this.textBoxNote.TabIndex = 18;
            // 
            // delNum
            // 
            this.delNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delNum.Location = new System.Drawing.Point(224, 140);
            this.delNum.Name = "delNum";
            this.delNum.Size = new System.Drawing.Size(20, 22);
            this.delNum.TabIndex = 21;
            this.delNum.Text = "-";
            this.delNum.UseVisualStyleBackColor = true;
            this.delNum.Click += new System.EventHandler(this.delNum_Click);
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(9, 114);
            this.textNum.Mask = "(380) 000 000 000";
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(209, 20);
            this.textNum.TabIndex = 22;
            // 
            // oterNumTextBox
            // 
            this.oterNumTextBox.Location = new System.Drawing.Point(9, 140);
            this.oterNumTextBox.Mask = "(380) 000 000 000";
            this.oterNumTextBox.Name = "oterNumTextBox";
            this.oterNumTextBox.Size = new System.Drawing.Size(209, 20);
            this.oterNumTextBox.TabIndex = 23;
            this.oterNumTextBox.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputMoney);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNote);
            this.groupBox2.Controls.Add(this.infoLable);
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 382);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // inputMoney
            // 
            this.inputMoney.Location = new System.Drawing.Point(6, 219);
            this.inputMoney.Mask = "00000";
            this.inputMoney.Name = "inputMoney";
            this.inputMoney.Size = new System.Drawing.Size(123, 20);
            this.inputMoney.TabIndex = 30;
            this.inputMoney.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Сумма";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 348);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата заезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Дата выезда";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fioLable);
            this.groupBox3.Controls.Add(this.textFIO);
            this.groupBox3.Controls.Add(this.oterNumTextBox);
            this.groupBox3.Controls.Add(this.numLabel);
            this.groupBox3.Controls.Add(this.textNum);
            this.groupBox3.Controls.Add(this.addNum);
            this.groupBox3.Controls.Add(this.delNum);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 194);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 712);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.sendForm);
            this.Controls.Add(this.conditionGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.conditionGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fioLable;
        private System.Windows.Forms.Button downloadPhotoButton;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        protected System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label infoLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox conditionGroupBox;
        private System.Windows.Forms.Button addNum;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Button sendForm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.TextBox textFIO;
        public System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button delNum;
        private System.Windows.Forms.MaskedTextBox textNum;
        private System.Windows.Forms.MaskedTextBox oterNumTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox inputMoney;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}