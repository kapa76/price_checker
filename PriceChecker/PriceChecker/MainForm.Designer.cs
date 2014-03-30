namespace PriceChecker
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listSynonim = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listWords = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.supplierList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchString = new System.Windows.Forms.TextBox();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.NameSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findGridList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSupplierFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.addToSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameChange = new System.Windows.Forms.TextBox();
            this.btnChangeFile = new System.Windows.Forms.Button();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.listWordsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWords = new System.Windows.Forms.ToolStripMenuItem();
            this.addWords = new System.Windows.Forms.ToolStripMenuItem();
            this.listSynonimMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSynonim = new System.Windows.Forms.ToolStripMenuItem();
            this.addSynonim = new System.Windows.Forms.ToolStripMenuItem();
            this.listSupplierMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.findGridList.SuspendLayout();
            this.listWordsMenu.SuspendLayout();
            this.listSynonimMenu.SuspendLayout();
            this.listSupplierMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listSynonim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listWords);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка синонимов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Список синонимов";
            // 
            // listSynonim
            // 
            this.listSynonim.FormattingEnabled = true;
            this.listSynonim.Location = new System.Drawing.Point(182, 36);
            this.listSynonim.Name = "listSynonim";
            this.listSynonim.Size = new System.Drawing.Size(164, 186);
            this.listSynonim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Список слов";
            // 
            // listWords
            // 
            this.listWords.FormattingEnabled = true;
            this.listWords.Location = new System.Drawing.Point(6, 36);
            this.listWords.Name = "listWords";
            this.listWords.Size = new System.Drawing.Size(170, 186);
            this.listWords.TabIndex = 0;
            this.listWords.SelectedIndexChanged += new System.EventHandler(this.ListWordsSelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAddSupplier);
            this.groupBox2.Controls.Add(this.supplierList);
            this.groupBox2.Location = new System.Drawing.Point(370, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка поставщиков";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список зарегистрированных поставщиков";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(10, 202);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(222, 23);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "Добавить поставщика";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.BtnAddSupplierClick);
            // 
            // supplierList
            // 
            this.supplierList.FormattingEnabled = true;
            this.supplierList.Location = new System.Drawing.Point(10, 36);
            this.supplierList.Name = "supplierList";
            this.supplierList.Size = new System.Drawing.Size(222, 160);
            this.supplierList.TabIndex = 0;
            this.supplierList.DoubleClick += new System.EventHandler(this.SupplierListDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.searchString);
            this.groupBox3.Controls.Add(this.searchGrid);
            this.groupBox3.Controls.Add(this.addToSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.fileNameChange);
            this.groupBox3.Controls.Add(this.btnChangeFile);
            this.groupBox3.Controls.Add(this.comboBoxSupplier);
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 389);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Набор прайсов";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(595, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Искать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SearchClick);
            // 
            // searchString
            // 
            this.searchString.Location = new System.Drawing.Point(87, 359);
            this.searchString.Name = "searchString";
            this.searchString.Size = new System.Drawing.Size(488, 20);
            this.searchString.TabIndex = 7;
            // 
            // searchGrid
            // 
            this.searchGrid.AllowUserToAddRows = false;
            this.searchGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameSupplier,
            this.FileName});
            this.searchGrid.ContextMenuStrip = this.findGridList;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.searchGrid.Location = new System.Drawing.Point(6, 105);
            this.searchGrid.MultiSelect = false;
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.ReadOnly = true;
            this.searchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchGrid.Size = new System.Drawing.Size(664, 245);
            this.searchGrid.TabIndex = 6;
            // 
            // NameSupplier
            // 
            this.NameSupplier.HeaderText = "Наименование поставщика";
            this.NameSupplier.Name = "NameSupplier";
            this.NameSupplier.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "Прайс лист";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // findGridList
            // 
            this.findGridList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSupplierFromList});
            this.findGridList.Name = "findGridList";
            this.findGridList.Size = new System.Drawing.Size(189, 26);
            // 
            // removeSupplierFromList
            // 
            this.removeSupplierFromList.Name = "removeSupplierFromList";
            this.removeSupplierFromList.Size = new System.Drawing.Size(188, 22);
            this.removeSupplierFromList.Text = "Удалить поставщика";
            this.removeSupplierFromList.Click += new System.EventHandler(this.RemoveSupplierFromListClick);
            // 
            // addToSearch
            // 
            this.addToSearch.Location = new System.Drawing.Point(6, 59);
            this.addToSearch.Name = "addToSearch";
            this.addToSearch.Size = new System.Drawing.Size(170, 40);
            this.addToSearch.TabIndex = 5;
            this.addToSearch.Text = "Добавить в список поиска";
            this.addToSearch.UseVisualStyleBackColor = true;
            this.addToSearch.Click += new System.EventHandler(this.AddSupplierToSearchGrid);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Выбор файла прайс листа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выбор поставщика";
            // 
            // fileNameChange
            // 
            this.fileNameChange.Location = new System.Drawing.Point(258, 33);
            this.fileNameChange.Name = "fileNameChange";
            this.fileNameChange.Size = new System.Drawing.Size(191, 20);
            this.fileNameChange.TabIndex = 2;
            // 
            // btnChangeFile
            // 
            this.btnChangeFile.Location = new System.Drawing.Point(455, 33);
            this.btnChangeFile.Name = "btnChangeFile";
            this.btnChangeFile.Size = new System.Drawing.Size(114, 23);
            this.btnChangeFile.TabIndex = 1;
            this.btnChangeFile.Text = "Выбор файла";
            this.btnChangeFile.UseVisualStyleBackColor = true;
            this.btnChangeFile.Click += new System.EventHandler(this.BtnChangeFileClick);
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(6, 32);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(246, 21);
            this.comboBoxSupplier.TabIndex = 0;
            // 
            // listWordsMenu
            // 
            this.listWordsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWords,
            this.addWords});
            this.listWordsMenu.Name = "listWordsMenu";
            this.listWordsMenu.Size = new System.Drawing.Size(163, 48);
            // 
            // deleteWords
            // 
            this.deleteWords.Name = "deleteWords";
            this.deleteWords.Size = new System.Drawing.Size(162, 22);
            this.deleteWords.Text = "Удалить слово";
            this.deleteWords.Click += new System.EventHandler(this.DeleteWordsClick);
            // 
            // addWords
            // 
            this.addWords.Name = "addWords";
            this.addWords.Size = new System.Drawing.Size(162, 22);
            this.addWords.Text = "Добавить слово";
            this.addWords.Click += new System.EventHandler(this.AddWordsClick);
            // 
            // listSynonimMenu
            // 
            this.listSynonimMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSynonim,
            this.addSynonim});
            this.listSynonimMenu.Name = "listSynonimMenu";
            this.listSynonimMenu.Size = new System.Drawing.Size(180, 48);
            // 
            // deleteSynonim
            // 
            this.deleteSynonim.Name = "deleteSynonim";
            this.deleteSynonim.Size = new System.Drawing.Size(179, 22);
            this.deleteSynonim.Text = "Удалить синоним";
            this.deleteSynonim.Click += new System.EventHandler(this.DeleteSynonimClick);
            // 
            // addSynonim
            // 
            this.addSynonim.Name = "addSynonim";
            this.addSynonim.Size = new System.Drawing.Size(179, 22);
            this.addSynonim.Text = "Добавить синоним";
            this.addSynonim.Click += new System.EventHandler(this.AddSynonimClick);
            // 
            // listSupplierMenu
            // 
            this.listSupplierMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSupplier,
            this.addSupplier});
            this.listSupplierMenu.Name = "listSupplierMenu";
            this.listSupplierMenu.Size = new System.Drawing.Size(197, 48);
            // 
            // deleteSupplier
            // 
            this.deleteSupplier.Name = "deleteSupplier";
            this.deleteSupplier.Size = new System.Drawing.Size(196, 22);
            this.deleteSupplier.Text = "Удалить поставщика";
            this.deleteSupplier.Click += new System.EventHandler(this.DeleteSupplierClick);
            // 
            // addSupplier
            // 
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(196, 22);
            this.addSupplier.Text = "Добавить поставщика";
            this.addSupplier.Click += new System.EventHandler(this.AddSupplierClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Поисковик";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.findGridList.ResumeLayout(false);
            this.listWordsMenu.ResumeLayout(false);
            this.listSynonimMenu.ResumeLayout(false);
            this.listSupplierMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox supplierList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listSynonim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listWords;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addToSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameChange;
        private System.Windows.Forms.Button btnChangeFile;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.DataGridView searchGrid;
        private System.Windows.Forms.TextBox searchString;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip listWordsMenu;
        private System.Windows.Forms.ContextMenuStrip listSynonimMenu;
        private System.Windows.Forms.ContextMenuStrip listSupplierMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteWords;
        private System.Windows.Forms.ToolStripMenuItem addWords;
        private System.Windows.Forms.ToolStripMenuItem deleteSynonim;
        private System.Windows.Forms.ToolStripMenuItem addSynonim;
        private System.Windows.Forms.ToolStripMenuItem deleteSupplier;
        private System.Windows.Forms.ToolStripMenuItem addSupplier;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.ContextMenuStrip findGridList;
        private System.Windows.Forms.ToolStripMenuItem removeSupplierFromList;
    }
}

