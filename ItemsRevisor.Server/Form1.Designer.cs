﻿namespace ItemsRevisor.Server
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tooltip_statusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooltip_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooltip_clientsLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooltip_clients = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБДToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиСервераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьСоединенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консольОтладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_editor_count = new System.Windows.Forms.TextBox();
            this.textBox_editor_name = new System.Windows.Forms.TextBox();
            this.textBox_editor_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_create_count = new System.Windows.Forms.TextBox();
            this.textBox_create_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_editor_location = new System.Windows.Forms.ComboBox();
            this.comboBox_creation = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltip_statusLable,
            this.tooltip_status,
            this.tooltip_clientsLable,
            this.tooltip_clients});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1020, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tooltip_statusLable
            // 
            this.tooltip_statusLable.Name = "tooltip_statusLable";
            this.tooltip_statusLable.Size = new System.Drawing.Size(46, 17);
            this.tooltip_statusLable.Text = "Статус:";
            // 
            // tooltip_status
            // 
            this.tooltip_status.Name = "tooltip_status";
            this.tooltip_status.Size = new System.Drawing.Size(125, 17);
            this.tooltip_status.Text = "Не инициализирован";
            this.tooltip_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tooltip_clientsLable
            // 
            this.tooltip_clientsLable.Name = "tooltip_clientsLable";
            this.tooltip_clientsLable.Size = new System.Drawing.Size(62, 17);
            this.tooltip_clientsLable.Text = "Клиентов:";
            // 
            // tooltip_clients
            // 
            this.tooltip_clients.Name = "tooltip_clients";
            this.tooltip_clients.Size = new System.Drawing.Size(13, 17);
            this.tooltip_clients.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Товары на складе:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Товары в магазине:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 392);
            this.panel1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(220, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(199, 368);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 368);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьБДToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // создатьБДToolStripMenuItem
            // 
            this.создатьБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьБДToolStripMenuItem1,
            this.загрузитьБДToolStripMenuItem});
            this.создатьБДToolStripMenuItem.Name = "создатьБДToolStripMenuItem";
            this.создатьБДToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.создатьБДToolStripMenuItem.Text = "Файл";
            // 
            // создатьБДToolStripMenuItem1
            // 
            this.создатьБДToolStripMenuItem1.Name = "создатьБДToolStripMenuItem1";
            this.создатьБДToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.создатьБДToolStripMenuItem1.Text = "Создать БД";
            this.создатьБДToolStripMenuItem1.Click += new System.EventHandler(this.создатьБДToolStripMenuItem1_Click);
            // 
            // загрузитьБДToolStripMenuItem
            // 
            this.загрузитьБДToolStripMenuItem.Name = "загрузитьБДToolStripMenuItem";
            this.загрузитьБДToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.загрузитьБДToolStripMenuItem.Text = "Загрузить БД";
            this.загрузитьБДToolStripMenuItem.Click += new System.EventHandler(this.загрузитьБДToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиБДToolStripMenuItem,
            this.настройкиСервераToolStripMenuItem,
            this.проверитьСоединенияToolStripMenuItem,
            this.консольОтладкиToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиБДToolStripMenuItem
            // 
            this.настройкиБДToolStripMenuItem.Name = "настройкиБДToolStripMenuItem";
            this.настройкиБДToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.настройкиБДToolStripMenuItem.Text = "Настройки БД";
            // 
            // настройкиСервераToolStripMenuItem
            // 
            this.настройкиСервераToolStripMenuItem.Name = "настройкиСервераToolStripMenuItem";
            this.настройкиСервераToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.настройкиСервераToolStripMenuItem.Text = "Настройки сервера";
            // 
            // проверитьСоединенияToolStripMenuItem
            // 
            this.проверитьСоединенияToolStripMenuItem.Name = "проверитьСоединенияToolStripMenuItem";
            this.проверитьСоединенияToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.проверитьСоединенияToolStripMenuItem.Text = "Проверить соединения";
            // 
            // консольОтладкиToolStripMenuItem
            // 
            this.консольОтладкиToolStripMenuItem.Name = "консольОтладкиToolStripMenuItem";
            this.консольОтладкиToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.консольОтладкиToolStripMenuItem.Text = "Консоль отладки";
            this.консольОтладкиToolStripMenuItem.Click += new System.EventHandler(this.консольОтладкиToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.comboBox_editor_location);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox_editor_count);
            this.panel2.Controls.Add(this.textBox_editor_name);
            this.panel2.Controls.Add(this.textBox_editor_id);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(430, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 392);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_editor_count
            // 
            this.textBox_editor_count.Location = new System.Drawing.Point(92, 126);
            this.textBox_editor_count.Name = "textBox_editor_count";
            this.textBox_editor_count.Size = new System.Drawing.Size(149, 20);
            this.textBox_editor_count.TabIndex = 8;
            // 
            // textBox_editor_name
            // 
            this.textBox_editor_name.Location = new System.Drawing.Point(92, 83);
            this.textBox_editor_name.Name = "textBox_editor_name";
            this.textBox_editor_name.Size = new System.Drawing.Size(149, 20);
            this.textBox_editor_name.TabIndex = 7;
            // 
            // textBox_editor_id
            // 
            this.textBox_editor_id.Enabled = false;
            this.textBox_editor_id.Location = new System.Drawing.Point(92, 39);
            this.textBox_editor_id.Name = "textBox_editor_id";
            this.textBox_editor_id.Size = new System.Drawing.Size(149, 20);
            this.textBox_editor_id.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Нахождение:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Редактировать товар:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox_creation);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.textBox_create_count);
            this.panel3.Controls.Add(this.textBox_create_name);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(728, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 392);
            this.panel3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_create_count
            // 
            this.textBox_create_count.Location = new System.Drawing.Point(92, 82);
            this.textBox_create_count.Name = "textBox_create_count";
            this.textBox_create_count.Size = new System.Drawing.Size(149, 20);
            this.textBox_create_count.TabIndex = 17;
            // 
            // textBox_create_name
            // 
            this.textBox_create_name.Location = new System.Drawing.Point(92, 39);
            this.textBox_create_name.Name = "textBox_create_name";
            this.textBox_create_name.Size = new System.Drawing.Size(149, 20);
            this.textBox_create_name.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Нахождение:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Количество:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Название:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Создать товар:";
            // 
            // comboBox_editor_location
            // 
            this.comboBox_editor_location.FormattingEnabled = true;
            this.comboBox_editor_location.Items.AddRange(new object[] {
            "Склад",
            "Магазин"});
            this.comboBox_editor_location.Location = new System.Drawing.Point(92, 169);
            this.comboBox_editor_location.Name = "comboBox_editor_location";
            this.comboBox_editor_location.Size = new System.Drawing.Size(149, 21);
            this.comboBox_editor_location.TabIndex = 11;
            // 
            // comboBox_creation
            // 
            this.comboBox_creation.FormattingEnabled = true;
            this.comboBox_creation.Items.AddRange(new object[] {
            "Склад",
            "Магазин"});
            this.comboBox_creation.Location = new System.Drawing.Point(92, 126);
            this.comboBox_creation.Name = "comboBox_creation";
            this.comboBox_creation.Size = new System.Drawing.Size(149, 21);
            this.comboBox_creation.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 444);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ItemsRevisor Сервер: Ожидание выбора БД";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tooltip_statusLable;
        private System.Windows.Forms.ToolStripStatusLabel tooltip_status;
        private System.Windows.Forms.ToolStripStatusLabel tooltip_clientsLable;
        private System.Windows.Forms.ToolStripStatusLabel tooltip_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьБДToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиСервераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьСоединенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_editor_count;
        private System.Windows.Forms.TextBox textBox_editor_name;
        private System.Windows.Forms.TextBox textBox_editor_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_create_count;
        private System.Windows.Forms.TextBox textBox_create_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem консольОтладкиToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_editor_location;
        private System.Windows.Forms.ComboBox comboBox_creation;
        private System.Windows.Forms.Button button3;
    }
}

