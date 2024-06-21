
namespace WorkToDB.Forms
{
    partial class ContractForm
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
            System.Windows.Forms.Label contractIDLabel;
            System.Windows.Forms.Label executionWorkIDLabel;
            System.Windows.Forms.Label develeryIDLabel;
            System.Windows.Forms.Label buyerIDLabel;
            System.Windows.Forms.Label dateConclusionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contractIDTextBox = new System.Windows.Forms.TextBox();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PlasticWindowsDataSet = new WorkToDB.DB_PlasticWindowsDataSet();
            this.LastButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateConclusionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FirstButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buyerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.develeryIDTextBox = new System.Windows.Forms.TextBox();
            this.executionWorkIDTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.contractTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.ContractTableAdapter();
            this.tableAdapterManager = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager();
            this.contractBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyerTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.BuyerTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            contractIDLabel = new System.Windows.Forms.Label();
            executionWorkIDLabel = new System.Windows.Forms.Label();
            develeryIDLabel = new System.Windows.Forms.Label();
            buyerIDLabel = new System.Windows.Forms.Label();
            dateConclusionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).BeginInit();
            this.contractBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contractIDLabel
            // 
            contractIDLabel.AutoSize = true;
            contractIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contractIDLabel.Location = new System.Drawing.Point(28, 6);
            contractIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contractIDLabel.Name = "contractIDLabel";
            contractIDLabel.Size = new System.Drawing.Size(107, 13);
            contractIDLabel.TabIndex = 15;
            contractIDLabel.Text = "Номер договора:";
            // 
            // executionWorkIDLabel
            // 
            executionWorkIDLabel.AutoSize = true;
            executionWorkIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            executionWorkIDLabel.Location = new System.Drawing.Point(38, 56);
            executionWorkIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            executionWorkIDLabel.Name = "executionWorkIDLabel";
            executionWorkIDLabel.Size = new System.Drawing.Size(85, 13);
            executionWorkIDLabel.TabIndex = 0;
            executionWorkIDLabel.Text = "Номер работ:";
            // 
            // develeryIDLabel
            // 
            develeryIDLabel.AutoSize = true;
            develeryIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            develeryIDLabel.Location = new System.Drawing.Point(17, 33);
            develeryIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            develeryIDLabel.Name = "develeryIDLabel";
            develeryIDLabel.Size = new System.Drawing.Size(106, 13);
            develeryIDLabel.TabIndex = 2;
            develeryIDLabel.Text = "Номер доставки:";
            // 
            // buyerIDLabel
            // 
            buyerIDLabel.AutoSize = true;
            buyerIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            buyerIDLabel.Location = new System.Drawing.Point(3, 10);
            buyerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            buyerIDLabel.Name = "buyerIDLabel";
            buyerIDLabel.Size = new System.Drawing.Size(120, 13);
            buyerIDLabel.TabIndex = 16;
            buyerIDLabel.Text = "Номер покупателя:";
            // 
            // dateConclusionLabel
            // 
            dateConclusionLabel.AutoSize = true;
            dateConclusionLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateConclusionLabel.Location = new System.Drawing.Point(3, 13);
            dateConclusionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateConclusionLabel.Name = "dateConclusionLabel";
            dateConclusionLabel.Size = new System.Drawing.Size(115, 13);
            dateConclusionLabel.TabIndex = 17;
            dateConclusionLabel.Text = "Дата заключения:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WorkToDB.Properties.Resources.Window;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.DeleteRecordButton);
            this.panel1.Controls.Add(this.AddRecordButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LastButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.FirstButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 325);
            this.panel1.TabIndex = 4;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(83, 193);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(88, 23);
            this.DeleteRecordButton.TabIndex = 29;
            this.DeleteRecordButton.Text = "Удалить";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(83, 164);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(88, 23);
            this.AddRecordButton.TabIndex = 28;
            this.AddRecordButton.Text = "Добавить";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.contractIDTextBox);
            this.panel3.Controls.Add(contractIDLabel);
            this.panel3.Location = new System.Drawing.Point(12, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 30);
            this.panel3.TabIndex = 19;
            // 
            // contractIDTextBox
            // 
            this.contractIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "contractID", true));
            this.contractIDTextBox.Location = new System.Drawing.Point(133, 4);
            this.contractIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractIDTextBox.Name = "contractIDTextBox";
            this.contractIDTextBox.Size = new System.Drawing.Size(50, 20);
            this.contractIDTextBox.TabIndex = 16;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.dB_PlasticWindowsDataSet;
            // 
            // dB_PlasticWindowsDataSet
            // 
            this.dB_PlasticWindowsDataSet.DataSetName = "DB_PlasticWindowsDataSet";
            this.dB_PlasticWindowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(214, 266);
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
            this.panel2.Controls.Add(dateConclusionLabel);
            this.panel2.Controls.Add(this.dateConclusionDateTimePicker);
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 39);
            this.panel2.TabIndex = 16;
            // 
            // dateConclusionDateTimePicker
            // 
            this.dateConclusionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "dateConclusion", true));
            this.dateConclusionDateTimePicker.Location = new System.Drawing.Point(122, 9);
            this.dateConclusionDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateConclusionDateTimePicker.Name = "dateConclusionDateTimePicker";
            this.dateConclusionDateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.dateConclusionDateTimePicker.TabIndex = 18;
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(8, 266);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(32, 23);
            this.FirstButton.TabIndex = 26;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(develeryIDLabel);
            this.panel4.Controls.Add(executionWorkIDLabel);
            this.panel4.Controls.Add(this.develeryIDTextBox);
            this.panel4.Controls.Add(this.executionWorkIDTextBox);
            this.panel4.Controls.Add(buyerIDLabel);
            this.panel4.Location = new System.Drawing.Point(12, 39);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 77);
            this.panel4.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "buyerID", true));
            this.comboBox1.DataSource = this.buyerBindingSource1;
            this.comboBox1.DisplayMember = "firstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "buyerID";
            // 
            // buyerBindingSource1
            // 
            this.buyerBindingSource1.DataMember = "Buyer";
            this.buyerBindingSource1.DataSource = this.dB_PlasticWindowsDataSet;
            // 
            // develeryIDTextBox
            // 
            this.develeryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "develeryID", true));
            this.develeryIDTextBox.Location = new System.Drawing.Point(127, 29);
            this.develeryIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.develeryIDTextBox.Name = "develeryIDTextBox";
            this.develeryIDTextBox.Size = new System.Drawing.Size(70, 20);
            this.develeryIDTextBox.TabIndex = 3;
            // 
            // executionWorkIDTextBox
            // 
            this.executionWorkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "executionWorkID", true));
            this.executionWorkIDTextBox.Location = new System.Drawing.Point(127, 52);
            this.executionWorkIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.executionWorkIDTextBox.Name = "executionWorkIDTextBox";
            this.executionWorkIDTextBox.Size = new System.Drawing.Size(61, 20);
            this.executionWorkIDTextBox.TabIndex = 1;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(188, 295);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(58, 23);
            this.NextButton.TabIndex = 25;
            this.NextButton.Text = "След.";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(8, 295);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(58, 23);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Предыд.";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuyerTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.DeveleryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EstimateTableAdapter = null;
            this.tableAdapterManager.ExecutionWorkTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contractBindingNavigator
            // 
            this.contractBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractBindingNavigator.BindingSource = this.contractBindingSource;
            this.contractBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contractBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.contractBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contractBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contractBindingNavigator.Location = new System.Drawing.Point(0, 339);
            this.contractBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractBindingNavigator.Name = "contractBindingNavigator";
            this.contractBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractBindingNavigator.Size = new System.Drawing.Size(600, 27);
            this.contractBindingNavigator.TabIndex = 5;
            this.contractBindingNavigator.Text = "bindingNavigator1";
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
            this.buyerBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractBindingNavigatorSaveItem_Click);
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "Buyer";
            // 
            // buyerTableAdapter
            // 
            this.buyerTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(83, 222);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 23);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.contractBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractForm";
            this.ShowIcon = false;
            this.Text = "Договоры";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).EndInit();
            this.contractBindingNavigator.ResumeLayout(false);
            this.contractBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DB_PlasticWindowsDataSet dB_PlasticWindowsDataSet;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DB_PlasticWindowsDataSetTableAdapters.ContractTableAdapter contractTableAdapter;
        private DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractBindingNavigator;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox contractIDTextBox;
        private System.Windows.Forms.DateTimePicker dateConclusionDateTimePicker;
        private System.Windows.Forms.TextBox develeryIDTextBox;
        private System.Windows.Forms.TextBox executionWorkIDTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private System.Windows.Forms.BindingSource buyerBindingSource1;
        private DB_PlasticWindowsDataSetTableAdapters.BuyerTableAdapter buyerTableAdapter;
        private System.Windows.Forms.ToolStripButton buyerBindingNavigatorSaveItem;
        private System.Windows.Forms.Button saveButton;
    }
}