namespace Opa
{
    partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.связьСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.подразделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.начальникиПодразделенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.статусОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.MenuItem3,
            this.MenuItem4,
            this.MenuItem5,
            this.MenuItem6});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
			this.menuStrip1.Size = new System.Drawing.Size(1690, 42);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MenuItem1
			// 
			this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.связьСБДToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.MenuItem1.Name = "MenuItem1";
			this.MenuItem1.Size = new System.Drawing.Size(80, 34);
			this.MenuItem1.Text = "Файл";
			// 
			// связьСБДToolStripMenuItem
			// 
			this.связьСБДToolStripMenuItem.Name = "связьСБДToolStripMenuItem";
			this.связьСБДToolStripMenuItem.Size = new System.Drawing.Size(261, 40);
			this.связьСБДToolStripMenuItem.Text = "Связь с БД";
			this.связьСБДToolStripMenuItem.Click += new System.EventHandler(this.связьСБДToolStripMenuItem_Click);
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(261, 40);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(261, 40);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// MenuItem2
			// 
			this.MenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подразделенияToolStripMenuItem,
            this.начальникиПодразделенийToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.оборудованиеToolStripMenuItem,
            this.статусОборудованияToolStripMenuItem});
			this.MenuItem2.Name = "MenuItem2";
			this.MenuItem2.Size = new System.Drawing.Size(160, 34);
			this.MenuItem2.Text = "Справочники";
			// 
			// подразделенияToolStripMenuItem
			// 
			this.подразделенияToolStripMenuItem.Name = "подразделенияToolStripMenuItem";
			this.подразделенияToolStripMenuItem.Size = new System.Drawing.Size(337, 40);
			this.подразделенияToolStripMenuItem.Text = "Подразделения";
			this.подразделенияToolStripMenuItem.Click += new System.EventHandler(this.подразделенияToolStripMenuItem_Click);
			// 
			// начальникиПодразделенийToolStripMenuItem
			// 
			this.начальникиПодразделенийToolStripMenuItem.Name = "начальникиПодразделенийToolStripMenuItem";
			this.начальникиПодразделенийToolStripMenuItem.Size = new System.Drawing.Size(337, 40);
			this.начальникиПодразделенийToolStripMenuItem.Text = "Начальники";
			this.начальникиПодразделенийToolStripMenuItem.Click += new System.EventHandler(this.начальникиToolStripMenuItem_Click);
			// 
			// сотрудникиToolStripMenuItem
			// 
			this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
			this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(337, 40);
			this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
			this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
			// 
			// оборудованиеToolStripMenuItem
			// 
			this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
			this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(337, 40);
			this.оборудованиеToolStripMenuItem.Text = "Оборудование";
			this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
			// 
			// статусОборудованияToolStripMenuItem
			// 
			this.статусОборудованияToolStripMenuItem.Name = "статусОборудованияToolStripMenuItem";
			this.статусОборудованияToolStripMenuItem.Size = new System.Drawing.Size(337, 40);
			this.статусОборудованияToolStripMenuItem.Text = "Статус оборудования";
			this.статусОборудованияToolStripMenuItem.Click += new System.EventHandler(this.статусОборудованияToolStripMenuItem_Click);
			// 
			// MenuItem3
			// 
			this.MenuItem3.Name = "MenuItem3";
			this.MenuItem3.Size = new System.Drawing.Size(140, 34);
			this.MenuItem3.Text = "Документы";
			// 
			// MenuItem4
			// 
			this.MenuItem4.Name = "MenuItem4";
			this.MenuItem4.Size = new System.Drawing.Size(103, 34);
			this.MenuItem4.Text = "Отчёты";
			// 
			// MenuItem5
			// 
			this.MenuItem5.Name = "MenuItem5";
			this.MenuItem5.Size = new System.Drawing.Size(100, 34);
			this.MenuItem5.Text = "Сервис";
			// 
			// MenuItem6
			// 
			this.MenuItem6.Name = "MenuItem6";
			this.MenuItem6.Size = new System.Drawing.Size(111, 34);
			this.MenuItem6.Text = "Справка";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(833, 88);
			this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(596, 225);
			this.button1.TabIndex = 0;
			this.button1.Text = "Новая кнопка";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1690, 927);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Aurora";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem связьСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MenuItem6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem подразделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начальникиПодразделенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусОборудованияToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

