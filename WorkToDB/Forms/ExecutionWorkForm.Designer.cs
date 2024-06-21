
namespace WorkToDB.Forms
{
    partial class ExecutionWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutionWorkForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toTableForm = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.specializationWorkTextBox = new System.Windows.Forms.TextBox();
            this.executionWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PlasticWindowsDataSet = new WorkToDB.DB_PlasticWindowsDataSet();
            this.LastButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusExecutionTextBox = new System.Windows.Forms.TextBox();
            this.FirstButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.executionWorkIDTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.executionWorkTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.ExecutionWorkTableAdapter();
            this.tableAdapterManager = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager();
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
            this.buyerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            dateStartLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            executionWorkIDLabel = new System.Windows.Forms.Label();
            statusExecutionLabel = new System.Windows.Forms.Label();
            specializationWorkLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkBindingNavigator)).BeginInit();
            this.executionWorkBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateStartLabel.Location = new System.Drawing.Point(11, 13);
            dateStartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(85, 13);
            dateStartLabel.TabIndex = 14;
            dateStartLabel.Text = "Дата начала:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            employeeIDLabel.Location = new System.Drawing.Point(2, 10);
            employeeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(120, 13);
            employeeIDLabel.TabIndex = 15;
            employeeIDLabel.Text = "Номер сотрудника:";
            // 
            // executionWorkIDLabel
            // 
            executionWorkIDLabel.AutoSize = true;
            executionWorkIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            executionWorkIDLabel.Location = new System.Drawing.Point(34, 36);
            executionWorkIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            executionWorkIDLabel.Name = "executionWorkIDLabel";
            executionWorkIDLabel.Size = new System.Drawing.Size(85, 13);
            executionWorkIDLabel.TabIndex = 16;
            executionWorkIDLabel.Text = "Номер работ:";
            // 
            // statusExecutionLabel
            // 
            statusExecutionLabel.AutoSize = true;
            statusExecutionLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statusExecutionLabel.Location = new System.Drawing.Point(11, 34);
            statusExecutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusExecutionLabel.Name = "statusExecutionLabel";
            statusExecutionLabel.Size = new System.Drawing.Size(127, 13);
            statusExecutionLabel.TabIndex = 17;
            statusExecutionLabel.Text = "Статус выполнения:";
            // 
            // specializationWorkLabel
            // 
            specializationWorkLabel.AutoSize = true;
            specializationWorkLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            specializationWorkLabel.Location = new System.Drawing.Point(11, 9);
            specializationWorkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            specializationWorkLabel.Name = "specializationWorkLabel";
            specializationWorkLabel.Size = new System.Drawing.Size(106, 13);
            specializationWorkLabel.TabIndex = 18;
            specializationWorkLabel.Text = "Специализация:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.toTableForm);
            this.panel1.Controls.Add(this.DeleteRecordButton);
            this.panel1.Controls.Add(this.AddRecordButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.LastButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.FirstButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 369);
            this.panel1.TabIndex = 3;
            // 
            // toTableForm
            // 
            this.toTableForm.Location = new System.Drawing.Point(85, 299);
            this.toTableForm.Name = "toTableForm";
            this.toTableForm.Size = new System.Drawing.Size(88, 52);
            this.toTableForm.TabIndex = 29;
            this.toTableForm.Text = "Табличная форма";
            this.toTableForm.UseVisualStyleBackColor = true;
            this.toTableForm.Click += new System.EventHandler(this.toTableForm_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(85, 215);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(88, 23);
            this.DeleteRecordButton.TabIndex = 29;
            this.DeleteRecordButton.Text = "Удалить";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(85, 186);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(88, 23);
            this.AddRecordButton.TabIndex = 28;
            this.AddRecordButton.Text = "Добавить";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.specializationWorkTextBox);
            this.panel4.Controls.Add(specializationWorkLabel);
            this.panel4.Location = new System.Drawing.Point(10, 150);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 31);
            this.panel4.TabIndex = 14;
            // 
            // specializationWorkTextBox
            // 
            this.specializationWorkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executionWorkBindingSource, "specializationWork", true));
            this.specializationWorkTextBox.Location = new System.Drawing.Point(119, 6);
            this.specializationWorkTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.specializationWorkTextBox.Name = "specializationWorkTextBox";
            this.specializationWorkTextBox.Size = new System.Drawing.Size(107, 20);
            this.specializationWorkTextBox.TabIndex = 19;
            // 
            // executionWorkBindingSource
            // 
            this.executionWorkBindingSource.DataMember = "ExecutionWork";
            this.executionWorkBindingSource.DataSource = this.dB_PlasticWindowsDataSet;
            // 
            // dB_PlasticWindowsDataSet
            // 
            this.dB_PlasticWindowsDataSet.DataSetName = "DB_PlasticWindowsDataSet";
            this.dB_PlasticWindowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(216, 299);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(32, 23);
            this.LastButton.TabIndex = 27;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(dateStartLabel);
            this.panel2.Controls.Add(this.dateStartDateTimePicker);
            this.panel2.Controls.Add(this.statusExecutionTextBox);
            this.panel2.Controls.Add(statusExecutionLabel);
            this.panel2.Location = new System.Drawing.Point(10, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 63);
            this.panel2.TabIndex = 4;
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.executionWorkBindingSource, "dateStart", true));
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(101, 9);
            this.dateStartDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.dateStartDateTimePicker.TabIndex = 15;
            // 
            // statusExecutionTextBox
            // 
            this.statusExecutionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executionWorkBindingSource, "statusExecution", true));
            this.statusExecutionTextBox.Location = new System.Drawing.Point(140, 32);
            this.statusExecutionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusExecutionTextBox.Name = "statusExecutionTextBox";
            this.statusExecutionTextBox.Size = new System.Drawing.Size(86, 20);
            this.statusExecutionTextBox.TabIndex = 18;
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(10, 299);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(32, 23);
            this.FirstButton.TabIndex = 26;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.employeeIDTextBox);
            this.panel3.Controls.Add(employeeIDLabel);
            this.panel3.Controls.Add(this.executionWorkIDTextBox);
            this.panel3.Controls.Add(executionWorkIDLabel);
            this.panel3.Location = new System.Drawing.Point(10, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 65);
            this.panel3.TabIndex = 13;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executionWorkBindingSource, "employeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(128, 7);
            this.employeeIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.employeeIDTextBox.TabIndex = 16;
            // 
            // executionWorkIDTextBox
            // 
            this.executionWorkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.executionWorkBindingSource, "executionWorkID", true));
            this.executionWorkIDTextBox.Location = new System.Drawing.Point(128, 33);
            this.executionWorkIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.executionWorkIDTextBox.Name = "executionWorkIDTextBox";
            this.executionWorkIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.executionWorkIDTextBox.TabIndex = 17;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(190, 328);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(58, 23);
            this.NextButton.TabIndex = 25;
            this.NextButton.Text = "След.";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 328);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(58, 23);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Предыд.";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // executionWorkTableAdapter
            // 
            this.executionWorkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuyerTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.DeveleryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EstimateTableAdapter = null;
            this.tableAdapterManager.ExecutionWorkTableAdapter = this.executionWorkTableAdapter;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.executionWorkBindingNavigator.Location = new System.Drawing.Point(0, 392);
            this.executionWorkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.executionWorkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.executionWorkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.executionWorkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.executionWorkBindingNavigator.Name = "executionWorkBindingNavigator";
            this.executionWorkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.executionWorkBindingNavigator.Size = new System.Drawing.Size(600, 27);
            this.executionWorkBindingNavigator.TabIndex = 4;
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
            // buyerBindingNavigatorSaveItem
            // 
            this.buyerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buyerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("buyerBindingNavigatorSaveItem.Image")));
            this.buyerBindingNavigatorSaveItem.Name = "buyerBindingNavigatorSaveItem";
            this.buyerBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.buyerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.buyerBindingNavigatorSaveItem.Click += new System.EventHandler(this.executBindingNavigatorSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WorkToDB.Properties.Resources.Window;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(85, 244);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ExecutionWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 419);
            this.Controls.Add(this.executionWorkBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExecutionWorkForm";
            this.ShowIcon = false;
            this.Text = "Выполнение работ";
            this.Load += new System.EventHandler(this.ExecutionWorkForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionWorkBindingNavigator)).EndInit();
            this.executionWorkBindingNavigator.ResumeLayout(false);
            this.executionWorkBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.TextBox specializationWorkTextBox;
        private System.Windows.Forms.TextBox statusExecutionTextBox;
        private System.Windows.Forms.TextBox executionWorkIDTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button toTableForm;
        private System.Windows.Forms.ToolStripButton buyerBindingNavigatorSaveItem;
        private System.Windows.Forms.Button saveButton;
    }
}