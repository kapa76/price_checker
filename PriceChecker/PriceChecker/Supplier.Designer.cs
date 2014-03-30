namespace PriceChecker
{
    partial class Supplier
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.suppName = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DelCell = new System.Windows.Forms.ToolStripMenuItem();
            this.newTypeField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeFieldList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewType = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.col = new System.Windows.Forms.NumericUpDown();
            this.row = new System.Windows.Forms.NumericUpDown();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listWordsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWords = new System.Windows.Forms.ToolStripMenuItem();
            this.addWords = new System.Windows.Forms.ToolStripMenuItem();
            this.listSynonimMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSynonim = new System.Windows.Forms.ToolStripMenuItem();
            this.addSynonim = new System.Windows.Forms.ToolStripMenuItem();
            this.listSynonim = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listWords = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.gridMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.col)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
            this.listWordsMenu.SuspendLayout();
            this.listSynonimMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование поставщика";
            // 
            // suppName
            // 
            this.suppName.Location = new System.Drawing.Point(12, 29);
            this.suppName.Name = "suppName";
            this.suppName.Size = new System.Drawing.Size(340, 20);
            this.suppName.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.Column,
            this.NameField});
            this.grid.ContextMenuStrip = this.gridMenu;
            this.grid.Location = new System.Drawing.Point(12, 304);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(688, 247);
            this.grid.TabIndex = 2;
            // 
            // RowNum
            // 
            this.RowNum.HeaderText = "Номер строки";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            // 
            // Column
            // 
            this.Column.HeaderText = "Номер столбца";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // NameField
            // 
            this.NameField.HeaderText = "Наименование поля";
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            // 
            // gridMenu
            // 
            this.gridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelCell});
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.Size = new System.Drawing.Size(160, 26);
            // 
            // DelCell
            // 
            this.DelCell.Name = "DelCell";
            this.DelCell.Size = new System.Drawing.Size(159, 22);
            this.DelCell.Text = "Удалить ячейку";
            this.DelCell.Click += new System.EventHandler(this.DelCell_Click);
            // 
            // newTypeField
            // 
            this.newTypeField.Location = new System.Drawing.Point(359, 201);
            this.newTypeField.Name = "newTypeField";
            this.newTypeField.Size = new System.Drawing.Size(171, 20);
            this.newTypeField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "номер строки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "номер колонки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип поля";
            // 
            // typeFieldList
            // 
            this.typeFieldList.FormattingEnabled = true;
            this.typeFieldList.Location = new System.Drawing.Point(529, 248);
            this.typeFieldList.Name = "typeFieldList";
            this.typeFieldList.Size = new System.Drawing.Size(171, 21);
            this.typeFieldList.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "добавить новый тип столбца";
            // 
            // btnNewType
            // 
            this.btnNewType.Location = new System.Drawing.Point(536, 198);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(164, 23);
            this.btnNewType.TabIndex = 11;
            this.btnNewType.Text = "Добавить новый столбец";
            this.btnNewType.UseVisualStyleBackColor = true;
            this.btnNewType.Click += new System.EventHandler(this.BtnNewTypeClick);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(583, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(501, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(439, 248);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(84, 20);
            this.col.TabIndex = 14;
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(356, 248);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(77, 20);
            this.row.TabIndex = 15;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(256, 275);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(184, 23);
            this.btnAddColumn.TabIndex = 16;
            this.btnAddColumn.Text = "Добавить ячейку описания";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.BtnAddColumnClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Список синонимов";
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
            this.listSynonimMenu.Size = new System.Drawing.Size(180, 70);
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
            // listSynonim
            // 
            this.listSynonim.FormattingEnabled = true;
            this.listSynonim.Location = new System.Drawing.Point(188, 83);
            this.listSynonim.Name = "listSynonim";
            this.listSynonim.Size = new System.Drawing.Size(164, 186);
            this.listSynonim.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Список слов";
            // 
            // listWords
            // 
            this.listWords.FormattingEnabled = true;
            this.listWords.Location = new System.Drawing.Point(12, 83);
            this.listWords.Name = "listWords";
            this.listWords.Size = new System.Drawing.Size(170, 186);
            this.listWords.TabIndex = 19;
            this.listWords.SelectedIndexChanged += new System.EventHandler(this.ListWordsSelectedIndexChanged);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 564);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listSynonim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listWords);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.row);
            this.Controls.Add(this.col);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeFieldList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newTypeField);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.suppName);
            this.Controls.Add(this.label1);
            this.Name = "Supplier";
            this.Shown += new System.EventHandler(this.Supplier_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.gridMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.col)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
            this.listWordsMenu.ResumeLayout(false);
            this.listSynonimMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox suppName;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox newTypeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeFieldList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown col;
        private System.Windows.Forms.NumericUpDown row;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.ContextMenuStrip gridMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameField;
        private System.Windows.Forms.ToolStripMenuItem DelCell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip listWordsMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteWords;
        private System.Windows.Forms.ToolStripMenuItem addWords;
        private System.Windows.Forms.ContextMenuStrip listSynonimMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteSynonim;
        private System.Windows.Forms.ToolStripMenuItem addSynonim;
        private System.Windows.Forms.ListBox listSynonim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listWords;
    }
}