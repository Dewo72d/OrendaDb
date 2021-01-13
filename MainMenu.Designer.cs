namespace CookParse
{
    partial class Menu
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
            this.ButtonInputID = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.buttonViewDb = new System.Windows.Forms.Button();
            this.apartButton = new System.Windows.Forms.Button();
            this.ApartVbutton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonInputID
            // 
            this.ButtonInputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInputID.Location = new System.Drawing.Point(12, 12);
            this.ButtonInputID.Name = "ButtonInputID";
            this.ButtonInputID.Size = new System.Drawing.Size(190, 68);
            this.ButtonInputID.TabIndex = 0;
            this.ButtonInputID.Text = "Добавить Клиента";
            this.ButtonInputID.UseVisualStyleBackColor = true;
            this.ButtonInputID.Click += new System.EventHandler(this.buttonInputID_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(237, 281);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 68);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // buttonViewDb
            // 
            this.buttonViewDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewDb.Location = new System.Drawing.Point(237, 12);
            this.buttonViewDb.Name = "buttonViewDb";
            this.buttonViewDb.Size = new System.Drawing.Size(190, 68);
            this.buttonViewDb.TabIndex = 2;
            this.buttonViewDb.Text = "Просмотреть клиентов";
            this.buttonViewDb.UseVisualStyleBackColor = true;
            this.buttonViewDb.Click += new System.EventHandler(this.buttonViewDb_Click);
            // 
            // apartButton
            // 
            this.apartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.apartButton.Location = new System.Drawing.Point(12, 86);
            this.apartButton.Name = "apartButton";
            this.apartButton.Size = new System.Drawing.Size(190, 68);
            this.apartButton.TabIndex = 3;
            this.apartButton.Text = "Добавить квартиру";
            this.apartButton.UseVisualStyleBackColor = true;
            this.apartButton.Click += new System.EventHandler(this.apartButton_Click);
            // 
            // ApartVbutton
            // 
            this.ApartVbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartVbutton.Location = new System.Drawing.Point(237, 86);
            this.ApartVbutton.Name = "ApartVbutton";
            this.ApartVbutton.Size = new System.Drawing.Size(190, 68);
            this.ApartVbutton.TabIndex = 4;
            this.ApartVbutton.Text = "Просмотр квартир";
            this.ApartVbutton.UseVisualStyleBackColor = true;
            this.ApartVbutton.Click += new System.EventHandler(this.ApartVbutton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(12, 281);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(190, 68);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Очистить кэш";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 371);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ApartVbutton);
            this.Controls.Add(this.apartButton);
            this.Controls.Add(this.buttonViewDb);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ButtonInputID);
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonInputID;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button buttonViewDb;
        private System.Windows.Forms.Button apartButton;
        private System.Windows.Forms.Button ApartVbutton;
        private System.Windows.Forms.Button clearButton;
    }
}

