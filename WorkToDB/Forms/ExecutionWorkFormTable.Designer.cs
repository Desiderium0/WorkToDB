
namespace WorkToDB.Forms
{
    partial class ExecutionWorkFormTable
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
            System.Windows.Forms.Label dateStartLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label executionWorkIDLabel;
            System.Windows.Forms.Label statusExecutionLabel;
            System.Windows.Forms.Label specializationWorkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutionWorkFormTable));
            this.dB_PlasticWindowsDataSet = new WorkToDB.DB_PlasticWindowsDataSet();
            this.executionWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.executionWorkTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.ExecutionWorkTableAdapter();
            this.tableAdapterManager = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager();
            this.contractTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.ContractTableAdapter();
            this.employeeTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.EmployeeTableAdapter();
            this.executionWorkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.executionWorkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.executionWorkIDTextBox = new System.Windows.Forms.TextBox();
            this.specializationWorkTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.FilterByEmployeeButton = new System.Windows.Forms.Button();
            this.FilterByDateButton = new System.Windows.Forms.Button();
            this.FilterByStatusBytton = new System.Windows.Forms.Button();
            this.ClearFilterButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buyerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            dateStartLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            executionWorkIDLabel = new System.Windows.Forms.Label();
            statusExecutionLabel = new System.Windows.Forms.Label();
            specializationWorkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkBindingNavigator)).BeginInit();
            this.executionWorkBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateStartLabel.Location = new System.Drawing.Point(18, 225);
            dateStartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(85, 13);
            dateStartLabel.TabIndex = 2;
            dateStartLabel.Text = "Дата начала:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            employeeIDLabel.Location = new System.Drawing.Point(18, 248);
            employeeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(120, 13);
            employeeIDLabel.TabIndex = 4;
            employeeIDLabel.Text = "Номер сотрудника:";
            // 
            // executionWorkIDLabel
            // 
            executionWorkIDLabel.AutoSize = true;
            executionWorkIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            executionWorkIDLabel.Location = new System.Drawing.Point(18, 202);
            executionWorkIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            executionWorkIDLabel.Name = "executionWorkIDLabel";
            executionWorkIDLabel.Size = new System.Drawing.Size(170, 13);
            executionWorkIDLabel.TabIndex = 6;
            executionWorkIDLabel.Text = "Номер выполненных работ:";
            // 
            // statusExecutionLabel
            // 
            statusExecutionLabel.AutoSize = true;
            statusExecutionLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statusExecutionLabel.Location = new System.Drawing.Point(18, 272);
            statusExecutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusExecutionLabel.Name = "statusExecutionLabel";
            statusExecutionLabel.Size = new System.Drawing.Size(127, 13);
            statusExecutionLabel.TabIndex = 8;
            statusExecutionLabel.Text = "Статус выполнения:";
            // 
            // specializationWorkLabel
            // 
            specializationWorkLabel.AutoSize = true;
            specializationWorkLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            specializationWorkLabel.Location = new System.Drawing.Point(18, 295);
            specializationWorkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            specializationWorkLabel.Name = "specializationWorkLabel";
            specializationWorkLabel.Size = new System.Drawing.Size(143, 13);
            specializationWorkLabel.TabIndex = 10;
            specializationWorkLabel.Text = "Специализация работ:";
            // 
            // dB_PlasticWindowsDataSet
            // 
            this.dB_PlasticWindowsDataSet.DataSetName = "DB_PlasticWindowsDataSet";
            this.dB_PlasticWindowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // executionWorkBindingSource
            // 
            this.executionWorkBindingSource.DataMember = "ExecutionWork";
            this.executionWorkBindingSource.DataSource = this.dB_PlasticWindowsDataSet;
            // 
            // executionWorkTableAdapter
            // 
            this.executionWorkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuyerTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.DeveleryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.EstimateTableAdapter = null;
            this.tableAdapterManager.ExecutionWorkTableAdapter = this.executionWorkTableAdapter;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // executionWorkBindingNavigator
            // 
            this.executionWorkBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.executionWorkBindingNavigator.BindingSource = this.executionWorkBindingSource;
            this.executionWorkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.executionWorkBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.executionWorkBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.executionWorkBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.executionWorkBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.executionWorkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.buyerBindingNavigatorSaveItem});
            this.executionWorkBindingNavigator.Location = new System.Drawing.Point(0, 370);
            this.executionWorkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.executionWorkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.executionWorkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.executionWorkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.executionWorkBindingNavigator.Name = "executionWorkBindingNavigator";
            this.executionWorkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.executionWorkBindingNavigator.Size = new System.Drawing.Size(656, 27);
            this.executionWorkBindingNavigator.TabIndex = 0;
            this.executionWorkBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // executionWorkDataGridView
            // 
            this.executionWorkDataGridView.AllowUserToAddRows = false;
            this.executionWorkDataGridView.AllowUserToDeleteRows = false;
            this.executionWorkDataGridView.AutoGenerateColumns = false;
            this.executionWorkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.executionWorkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.executionWorkDataGridView.DataSource = this.executionWorkBindingSource;
            this.executionWorkDataGridView.Location = new System.Drawing.Point(9, 10);
            this.executionWorkDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.executionWorkDataGridView.Name = "executionWorkDataGridView";
            this.executionWorkDataGridView.ReadOnly = true;
            this.executionWorkDataGridView.RowHeadersWidth = 51;
            this.executionWorkDataGridView.RowTemplate.Height = 24;
            this.executionWorkDataGridView.Size = new System.Drawing.Size(638, 179);
            this.executionWorkDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "executionWorkID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер выполненных работ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "employeeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер сотрудника";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dateStart";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата начала";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "statusExecution";
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус выполнения";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "specializationWork";
            this.dataGridViewTextBoxColumn5.HeaderText = "Специализация работ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.executionWorkBindingSource, "dateStart", true));
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(110, 223);
            this.dateStartDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(159, 20);
            this.dateStartDateTimePicker.TabIndex = 3;
            // 
            // executionWorkIDTextBox
            // 
            this.executionWorkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executionWorkBindingSource, "executionWorkID", true));
            this.executionWorkIDTextBox.Location = new System.Drawing.Point(194, 200);
            this.executionWorkIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.executionWorkIDTextBox.Name = "executionWorkIDTextBox";
            this.executionWorkIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.executionWorkIDTextBox.TabIndex = 7;
            // 
            // specializationWorkTextBox
            // 
            this.specializationWorkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executionWorkBindingSource, "specializationWork", true));
            this.specializationWorkTextBox.Location = new System.Drawing.Point(165, 292);
            this.specializationWorkTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.specializationWorkTextBox.Name = "specializationWorkTextBox";
            this.specializationWorkTextBox.Size = new System.Drawing.Size(104, 20);
            this.specializationWorkTextBox.TabIndex = 11;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(478, 335);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(135, 31);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // FilterByEmployeeButton
            // 
            this.FilterByEmployeeButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterByEmployeeButton.Location = new System.Drawing.Point(386, 202);
            this.FilterByEmployeeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterByEmployeeButton.Name = "FilterByEmployeeButton";
            this.FilterByEmployeeButton.Size = new System.Drawing.Size(228, 24);
            this.FilterByEmployeeButton.TabIndex = 13;
            this.FilterByEmployeeButton.Text = "Фильтровать по номеру сотрудника";
            this.FilterByEmployeeButton.UseVisualStyleBackColor = true;
            this.FilterByEmployeeButton.Click += new System.EventHandler(this.FilterByEmployeeButton_Click);
            // 
            // FilterByDateButton
            // 
            this.FilterByDateButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterByDateButton.Location = new System.Drawing.Point(386, 230);
            this.FilterByDateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterByDateButton.Name = "FilterByDateButton";
            this.FilterByDateButton.Size = new System.Drawing.Size(228, 24);
            this.FilterByDateButton.TabIndex = 14;
            this.FilterByDateButton.Text = "Фильтровать по дате";
            this.FilterByDateButton.UseVisualStyleBackColor = true;
            this.FilterByDateButton.Click += new System.EventHandler(this.FilterByDateButton_Click);
            // 
            // FilterByStatusBytton
            // 
            this.FilterByStatusBytton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterByStatusBytton.Location = new System.Drawing.Point(386, 258);
            this.FilterByStatusBytton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterByStatusBytton.Name = "FilterByStatusBytton";
            this.FilterByStatusBytton.Size = new System.Drawing.Size(228, 24);
            this.FilterByStatusBytton.TabIndex = 15;
            this.FilterByStatusBytton.Text = "Фильтровать по статусу";
            this.FilterByStatusBytton.UseVisualStyleBackColor = true;
            this.FilterByStatusBytton.Click += new System.EventHandler(this.FilterByStatusBytton_Click);
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearFilterButton.Location = new System.Drawing.Point(386, 287);
            this.ClearFilterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearFilterButton.Name = "ClearFilterButton";
            this.ClearFilterButton.Size = new System.Drawing.Size(228, 24);
            this.ClearFilterButton.TabIndex = 17;
            this.ClearFilterButton.Text = "Снять фильтр";
            this.ClearFilterButton.UseVisualStyleBackColor = true;
            this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.executionWorkBindingSource, "employeeID", true));
            this.comboBox1.DataSource = this.employeeBindingSource;
            this.comboBox1.DisplayMember = "firstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 245);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "employeeID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dB_PlasticWindowsDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.executionWorkBindingSource;
            this.comboBox2.DisplayMember = "statusExecution";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(157, 270);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "statusExecution";
            // 
            // buyerBindingNavigatorSaveItem
            // 
            this.buyerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buyerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("buyerBindingNavigatorSaveItem.Image")));
            this.buyerBindingNavigatorSaveItem.Name = "buyerBindingNavigatorSaveItem";
            this.buyerBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.buyerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.buyerBindingNavigatorSaveItem.Click += new System.EventHandler(this.buyerBindingNavigatorSaveItem_Click);
            // 
            // ExecutionWorkFormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 397);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClearFilterButton);
            this.Controls.Add(this.FilterByStatusBytton);
            this.Controls.Add(this.FilterByDateButton);
            this.Controls.Add(this.FilterByEmployeeButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(specializationWorkLabel);
            this.Controls.Add(this.specializationWorkTextBox);
            this.Controls.Add(statusExecutionLabel);
            this.Controls.Add(executionWorkIDLabel);
            this.Controls.Add(this.executionWorkIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(dateStartLabel);
            this.Controls.Add(this.dateStartDateTimePicker);
            this.Controls.Add(this.executionWorkDataGridView);
            this.Controls.Add(this.executionWorkBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExecutionWorkFormTable";
            this.ShowIcon = false;
            this.Text = "Таблица выполненных работ";
            this.Load += new System.EventHandler(this.ExecutionWorkFormTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkBindingNavigator)).EndInit();
            this.executionWorkBindingNavigator.ResumeLayout(false);
            this.executionWorkBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_PlasticWindowsDataSet dB_PlasticWindowsDataSet;
        private System.Windows.Forms.BindingSource executionWorkBindingSource;
        private DB_PlasticWindowsDataSetTableAdapters.ExecutionWorkTableAdapter executionWorkTableAdapter;
        private DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator executionWorkBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView executionWorkDataGridView;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.TextBox executionWorkIDTextBox;
        private System.Windows.Forms.TextBox specializationWorkTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button RefreshButton;
        private DB_PlasticWindowsDataSetTableAdapters.ContractTableAdapter contractTableAdapter;
        private System.Windows.Forms.Button FilterByEmployeeButton;
        private System.Windows.Forms.Button FilterByDateButton;
        private System.Windows.Forms.Button FilterByStatusBytton;
        private System.Windows.Forms.Button ClearFilterButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private DB_PlasticWindowsDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripButton buyerBindingNavigatorSaveItem;
    }
}