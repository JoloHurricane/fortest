namespace WinForm1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладныеИТоваыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.обновитьЧтотоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеТоваровToolStripMenuItem,
            this.удалеToolStripMenuItem,
            this.обновитьЧтотоToolStripMenuItem,
            this.aDDTimeToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // добавлениеТоваровToolStripMenuItem
            // 
            this.добавлениеТоваровToolStripMenuItem.Name = "добавлениеТоваровToolStripMenuItem";
            this.добавлениеТоваровToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.добавлениеТоваровToolStripMenuItem.Text = "Добавление товаров";
            // 
            // удалеToolStripMenuItem
            // 
            this.удалеToolStripMenuItem.Name = "удалеToolStripMenuItem";
            this.удалеToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.удалеToolStripMenuItem.Text = "Удаление товаров";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.накладныеToolStripMenuItem,
            this.накладныеИТоваыToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // накладныеToolStripMenuItem
            // 
            this.накладныеToolStripMenuItem.Name = "накладныеToolStripMenuItem";
            this.накладныеToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.накладныеToolStripMenuItem.Text = "Накладные";
            // 
            // накладныеИТоваыToolStripMenuItem
            // 
            this.накладныеИТоваыToolStripMenuItem.Name = "накладныеИТоваыToolStripMenuItem";
            this.накладныеИТоваыToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.накладныеИТоваыToolStripMenuItem.Text = "Накладные и товаы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // обновитьЧтотоToolStripMenuItem
            // 
            this.обновитьЧтотоToolStripMenuItem.Name = "обновитьЧтотоToolStripMenuItem";
            this.обновитьЧтотоToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.обновитьЧтотоToolStripMenuItem.Text = "Обновить что-то";
            this.обновитьЧтотоToolStripMenuItem.Click += new System.EventHandler(this.обновитьЧтотоToolStripMenuItem_Click);
            // 
            // aDDTimeToolStripMenuItem
            // 
            this.aDDTimeToolStripMenuItem.Name = "aDDTimeToolStripMenuItem";
            this.aDDTimeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aDDTimeToolStripMenuItem.Text = "ADD time";
            this.aDDTimeToolStripMenuItem.Click += new System.EventHandler(this.aDDTimeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладныеИТоваыToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem обновитьЧтотоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDTimeToolStripMenuItem;
    }
}

