namespace CookParse
{
    partial class ApartamentInput
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
            this.sambitButton = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfApart = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numOfsp = new System.Windows.Forms.MaskedTextBox();
            this.numOfRooms = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sambitButton
            // 
            this.sambitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sambitButton.Location = new System.Drawing.Point(12, 289);
            this.sambitButton.Name = "sambitButton";
            this.sambitButton.Size = new System.Drawing.Size(125, 29);
            this.sambitButton.TabIndex = 6;
            this.sambitButton.Text = "Подтвердить";
            this.sambitButton.UseVisualStyleBackColor = true;
            this.sambitButton.Click += new System.EventHandler(this.sambitButton_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonExit.Location = new System.Drawing.Point(180, 290);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(125, 28);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "Выйти";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество спальных мест";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер квартиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Улица";
            // 
            // numOfApart
            // 
            this.numOfApart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfApart.Location = new System.Drawing.Point(162, 87);
            this.numOfApart.Mask = "0000";
            this.numOfApart.Name = "numOfApart";
            this.numOfApart.Size = new System.Drawing.Size(33, 22);
            this.numOfApart.TabIndex = 8;
            this.numOfApart.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество комнат";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(6, 39);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(232, 20);
            this.streetBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.levelBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numOfsp);
            this.groupBox2.Controls.Add(this.numOfRooms);
            this.groupBox2.Controls.Add(this.streetBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numOfApart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 226);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // numOfsp
            // 
            this.numOfsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfsp.Location = new System.Drawing.Point(253, 144);
            this.numOfsp.Mask = "0000";
            this.numOfsp.Name = "numOfsp";
            this.numOfsp.Size = new System.Drawing.Size(33, 22);
            this.numOfsp.TabIndex = 14;
            this.numOfsp.ValidatingType = typeof(int);
            // 
            // numOfRooms
            // 
            this.numOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfRooms.Location = new System.Drawing.Point(188, 119);
            this.numOfRooms.Mask = "0000";
            this.numOfRooms.Name = "numOfRooms";
            this.numOfRooms.Size = new System.Drawing.Size(33, 22);
            this.numOfRooms.TabIndex = 13;
            this.numOfRooms.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Этаж";
            // 
            // levelBox
            // 
            this.levelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelBox.Location = new System.Drawing.Point(66, 62);
            this.levelBox.Mask = "0000";
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(33, 22);
            this.levelBox.TabIndex = 16;
            this.levelBox.ValidatingType = typeof(int);
            // 
            // ApartamentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 330);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.sambitButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "ApartamentInput";
            this.Text = "ApartamentInput";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sambitButton;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox numOfApart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox numOfsp;
        private System.Windows.Forms.MaskedTextBox numOfRooms;
        private System.Windows.Forms.MaskedTextBox levelBox;
        private System.Windows.Forms.Label label5;
    }
}