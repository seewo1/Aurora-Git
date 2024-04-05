namespace Opa
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.depTable = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auroraDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auroraDBDataSet = new Opa.AuroraDBDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.departmentTableAdapter = new Opa.AuroraDBDataSetTableAdapters.DepartmentTableAdapter();
            this.namingPanel = new System.Windows.Forms.Panel();
            this.depEndEdit = new System.Windows.Forms.Button();
            this.depRefresh = new System.Windows.Forms.Button();
            this.depEdit = new System.Windows.Forms.Button();
            this.depDel = new System.Windows.Forms.Button();
            this.depAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.depTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auroraDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auroraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.namingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // depTable
            // 
            this.depTable.AllowUserToDeleteRows = false;
            this.depTable.AutoGenerateColumns = false;
            this.depTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.editDataGridViewCheckBoxColumn});
            this.depTable.DataSource = this.departmentBindingSource;
            this.depTable.Location = new System.Drawing.Point(26, 75);
            this.depTable.Name = "depTable";
            this.depTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depTable.Size = new System.Drawing.Size(343, 317);
            this.depTable.TabIndex = 0;
            this.depTable.SelectionChanged += new System.EventHandler(this.depTable_SelectionChanged);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // editDataGridViewCheckBoxColumn
            // 
            this.editDataGridViewCheckBoxColumn.DataPropertyName = "Edit";
            this.editDataGridViewCheckBoxColumn.HeaderText = "Edit";
            this.editDataGridViewCheckBoxColumn.Name = "editDataGridViewCheckBoxColumn";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.auroraDBDataSetBindingSource;
            // 
            // auroraDBDataSetBindingSource
            // 
            this.auroraDBDataSetBindingSource.DataSource = this.auroraDBDataSet;
            this.auroraDBDataSetBindingSource.Position = 0;
            // 
            // auroraDBDataSet
            // 
            this.auroraDBDataSet.DataSetName = "AuroraDBDataSet";
            this.auroraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.departmentBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // namingPanel
            // 
            this.namingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namingPanel.Controls.Add(this.depEndEdit);
            this.namingPanel.Controls.Add(this.depRefresh);
            this.namingPanel.Controls.Add(this.depEdit);
            this.namingPanel.Controls.Add(this.depDel);
            this.namingPanel.Controls.Add(this.depAdd);
            this.namingPanel.Controls.Add(this.label2);
            this.namingPanel.Controls.Add(this.label1);
            this.namingPanel.Controls.Add(this.type);
            this.namingPanel.Controls.Add(this.title);
            this.namingPanel.Location = new System.Drawing.Point(426, 75);
            this.namingPanel.Name = "namingPanel";
            this.namingPanel.Size = new System.Drawing.Size(297, 317);
            this.namingPanel.TabIndex = 2;
            // 
            // depEndEdit
            // 
            this.depEndEdit.Location = new System.Drawing.Point(24, 239);
            this.depEndEdit.Name = "depEndEdit";
            this.depEndEdit.Size = new System.Drawing.Size(249, 23);
            this.depEndEdit.TabIndex = 8;
            this.depEndEdit.Text = "Закончить редактирование";
            this.depEndEdit.UseVisualStyleBackColor = true;
            this.depEndEdit.Click += new System.EventHandler(this.depEndEdit_Click);
            // 
            // depRefresh
            // 
            this.depRefresh.Location = new System.Drawing.Point(24, 268);
            this.depRefresh.Name = "depRefresh";
            this.depRefresh.Size = new System.Drawing.Size(249, 23);
            this.depRefresh.TabIndex = 7;
            this.depRefresh.Text = "Обновить форму";
            this.depRefresh.UseVisualStyleBackColor = true;
            this.depRefresh.Click += new System.EventHandler(this.depRefresh_Click);
            // 
            // depEdit
            // 
            this.depEdit.Location = new System.Drawing.Point(112, 202);
            this.depEdit.Name = "depEdit";
            this.depEdit.Size = new System.Drawing.Size(75, 23);
            this.depEdit.TabIndex = 6;
            this.depEdit.Text = "Изменить";
            this.depEdit.UseVisualStyleBackColor = true;
            this.depEdit.Click += new System.EventHandler(this.depEdit_Click);
            // 
            // depDel
            // 
            this.depDel.Location = new System.Drawing.Point(198, 202);
            this.depDel.Name = "depDel";
            this.depDel.Size = new System.Drawing.Size(75, 23);
            this.depDel.TabIndex = 5;
            this.depDel.Text = "Удалить";
            this.depDel.UseVisualStyleBackColor = true;
            this.depDel.Click += new System.EventHandler(this.depDel_Click);
            // 
            // depAdd
            // 
            this.depAdd.Location = new System.Drawing.Point(24, 202);
            this.depAdd.Name = "depAdd";
            this.depAdd.Size = new System.Drawing.Size(75, 23);
            this.depAdd.TabIndex = 4;
            this.depAdd.Text = "Добавить";
            this.depAdd.UseVisualStyleBackColor = true;
            this.depAdd.Click += new System.EventHandler(this.depAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вид подразделения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название подраздела";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Сборочный цех",
            "Лаборатория",
            "Склад",
            "Отдел продаж"});
            this.type.Location = new System.Drawing.Point(24, 103);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(249, 21);
            this.type.TabIndex = 1;
            this.type.MouseClick += new System.Windows.Forms.MouseEventHandler(this.type_MouseClick);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(24, 49);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(249, 20);
            this.title.TabIndex = 0;
            this.title.MouseClick += new System.Windows.Forms.MouseEventHandler(this.title_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namingPanel);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.depTable);
            this.Name = "DepartmentForm";
            this.Text = "Подразделения";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auroraDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auroraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.namingPanel.ResumeLayout(false);
            this.namingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView depTable;
        private System.Windows.Forms.BindingSource auroraDBDataSetBindingSource;
        private AuroraDBDataSet auroraDBDataSet;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private AuroraDBDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Panel namingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button depAdd;
        private System.Windows.Forms.Button depEdit;
        private System.Windows.Forms.Button depDel;
        private System.Windows.Forms.Button depRefresh;
        private System.Windows.Forms.Button depEndEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editDataGridViewCheckBoxColumn;
    }
}