
namespace WorkToDB.Forms
{
    partial class EstimateForm
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
            System.Windows.Forms.Label estimateIDLabel;
            System.Windows.Forms.Label contractIDLabel;
            System.Windows.Forms.Label materialIDLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label amountWorkLabel;
            System.Windows.Forms.Label amountMaterialLabel;
            System.Windows.Forms.Label priceForUnitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstimateForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.priceForUnitTextBox = new System.Windows.Forms.TextBox();
            this.estimateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PlasticWindowsDataSet = new WorkToDB.DB_PlasticWindowsDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.amountMaterialTextBox = new System.Windows.Forms.TextBox();
            this.amountWorkTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.estimateIDTextBox = new System.Windows.Forms.TextBox();
            this.contractIDTextBox = new System.Windows.Forms.TextBox();
            this.materialIDTextBox = new System.Windows.Forms.TextBox();
            this.estimateTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.EstimateTableAdapter();
            this.tableAdapterManager = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager();
            this.estimateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.saveButton = new System.Windows.Forms.Button();
            estimateIDLabel = new System.Windows.Forms.Label();
            contractIDLabel = new System.Windows.Forms.Label();
            materialIDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            amountWorkLabel = new System.Windows.Forms.Label();
            amountMaterialLabel = new System.Windows.Forms.Label();
            priceForUnitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimateBindingNavigator)).BeginInit();
            this.estimateBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // estimateIDLabel
            // 
            estimateIDLabel.AutoSize = true;
            estimateIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            estimateIDLabel.Location = new System.Drawing.Point(33, 12);
            estimateIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            estimateIDLabel.Name = "estimateIDLabel";
            estimateIDLabel.Size = new System.Drawing.Size(86, 13);
            estimateIDLabel.TabIndex = 0;
            estimateIDLabel.Text = "Номер сметы:";
            // 
            // contractIDLabel
            // 
            contractIDLabel.AutoSize = true;
            contractIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contractIDLabel.Location = new System.Drawing.Point(15, 36);
            contractIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contractIDLabel.Name = "contractIDLabel";
            contractIDLabel.Size = new System.Drawing.Size(107, 13);
            contractIDLabel.TabIndex = 2;
            contractIDLabel.Text = "Номер договора:";
            // 
            // materialIDLabel
            // 
            materialIDLabel.AutoSize = true;
            materialIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            materialIDLabel.Location = new System.Drawing.Point(9, 60);
            materialIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            materialIDLabel.Name = "materialIDLabel";
            materialIDLabel.Size = new System.Drawing.Size(113, 13);
            materialIDLabel.TabIndex = 4;
            materialIDLabel.Text = "Номер материала:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            amountLabel.Location = new System.Drawing.Point(38, 54);
            amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(85, 13);
            amountLabel.TabIndex = 6;
            amountLabel.Text = "Общая цена:";
            // 
            // amountWorkLabel
            // 
            amountWorkLabel.AutoSize = true;
            amountWorkLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            amountWorkLabel.Location = new System.Drawing.Point(11, 32);
            amountWorkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            amountWorkLabel.Name = "amountWorkLabel";
            amountWorkLabel.Size = new System.Drawing.Size(109, 13);
            amountWorkLabel.TabIndex = 8;
            amountWorkLabel.Text = "Стоимость работ:";
            // 
            // amountMaterialLabel
            // 
            amountMaterialLabel.AutoSize = true;
            amountMaterialLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            amountMaterialLabel.Location = new System.Drawing.Point(10, 9);
            amountMaterialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            amountMaterialLabel.Name = "amountMaterialLabel";
            amountMaterialLabel.Size = new System.Drawing.Size(114, 13);
            amountMaterialLabel.TabIndex = 10;
            amountMaterialLabel.Text = "Цена материалов:";
            // 
            // priceForUnitLabel
            // 
            priceForUnitLabel.AutoSize = true;
            priceForUnitLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceForUnitLabel.Location = new System.Drawing.Point(8, 6);
            priceForUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            priceForUnitLabel.Name = "priceForUnitLabel";
            priceForUnitLabel.Size = new System.Drawing.Size(114, 13);
            priceForUnitLabel.TabIndex = 12;
            priceForUnitLabel.Text = "Цена за еденицу:";
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
            this.panel1.Controls.Add(this.LastButton);
            this.panel1.Controls.Add(this.FirstButton);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 325);
            this.panel1.TabIndex = 3;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(90, 244);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(88, 23);
            this.DeleteRecordButton.TabIndex = 23;
            this.DeleteRecordButton.Text = "Удалить";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(90, 215);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(88, 23);
            this.AddRecordButton.TabIndex = 22;
            this.AddRecordButton.Text = "Добавить";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(221, 266);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(32, 23);
            this.LastButton.TabIndex = 21;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(15, 266);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(32, 23);
            this.FirstButton.TabIndex = 20;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(195, 295);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(58, 23);
            this.NextButton.TabIndex = 19;
            this.NextButton.Text = "След.";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(15, 295);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(58, 23);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Предыд.";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.priceForUnitTextBox);
            this.panel3.Controls.Add(priceForUnitLabel);
            this.panel3.Location = new System.Drawing.Point(15, 97);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 26);
            this.panel3.TabIndex = 17;
            // 
            // priceForUnitTextBox
            // 
            this.priceForUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estimateBindingSource, "priceForUnit", true));
            this.priceForUnitTextBox.Location = new System.Drawing.Point(126, 2);
            this.priceForUnitTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceForUnitTextBox.Name = "priceForUnitTextBox";
            this.priceForUnitTextBox.Size = new System.Drawing.Size(87, 20);
            this.priceForUnitTextBox.TabIndex = 13;
            // 
            // estimateBindingSource
            // 
            this.estimateBindingSource.DataMember = "Estimate";
            this.estimateBindingSource.DataSource = this.dB_PlasticWindowsDataSet;
            // 
            // dB_PlasticWindowsDataSet
            // 
            this.dB_PlasticWindowsDataSet.DataSetName = "DB_PlasticWindowsDataSet";
            this.dB_PlasticWindowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.amountMaterialTextBox);
            this.panel2.Controls.Add(amountMaterialLabel);
            this.panel2.Controls.Add(this.amountWorkTextBox);
            this.panel2.Controls.Add(amountLabel);
            this.panel2.Controls.Add(amountWorkLabel);
            this.panel2.Controls.Add(this.amountTextBox);
            this.panel2.Location = new System.Drawing.Point(15, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 82);
            this.panel2.TabIndex = 16;
            // 
            // amountMaterialTextBox
            // 
            this.amountMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estimateBindingSource, "amountMaterial", true));
            this.amountMaterialTextBox.Location = new System.Drawing.Point(126, 6);
            this.amountMaterialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountMaterialTextBox.Name = "amountMaterialTextBox";
            this.amountMaterialTextBox.Size = new System.Drawing.Size(101, 20);
            this.amountMaterialTextBox.TabIndex = 11;
            // 
            // amountWorkTextBox
            // 
            this.amountWorkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estimateBindingSource, "amountWork", true));
            this.amountWorkTextBox.Location = new System.Drawing.Point(126, 29);
            this.amountWorkTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountWorkTextBox.Name = "amountWorkTextBox";
            this.amountWorkTextBox.Size = new System.Drawing.Size(101, 20);
            this.amountWorkTextBox.TabIndex = 9;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estimateBindingSource, "amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(126, 52);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(101, 20);
            this.amountTextBox.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.estimateIDTextBox);
            this.panel4.Controls.Add(estimateIDLabel);
            this.panel4.Controls.Add(contractIDLabel);
            this.panel4.Controls.Add(this.contractIDTextBox);
            this.panel4.Controls.Add(materialIDLabel);
            this.panel4.Controls.Add(this.materialIDTextBox);
            this.panel4.Location = new System.Drawing.Point(15, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 85);
            this.panel4.TabIndex = 15;
            // 
            // estimateIDTextBox
            // 
            this.estimateIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estimateBindingSource, "EstimateID", true));
            this.estimateIDTextBox.Location = new System.Drawing.Point(125, 10);
            this.estimateIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.estimateIDTextBox.Name = "estimateIDTextBox";
            this.estimateIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.estimateIDTextBox.TabIndex = 1;
            // 
            // contractIDTextBox
            // 
            this.contractIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estimateBindingSource, "contractID", true));
            this.contractIDTextBox.Location = new System.Drawing.Point(125, 33);
            this.contractIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractIDTextBox.Name = "contractIDTextBox";
            this.contractIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.contractIDTextBox.TabIndex = 3;
            // 
            // materialIDTextBox
            // 
            this.materialIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estimateBindingSource, "materialID", true));
            this.materialIDTextBox.Location = new System.Drawing.Point(125, 58);
            this.materialIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.materialIDTextBox.Name = "materialIDTextBox";
            this.materialIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.materialIDTextBox.TabIndex = 5;
            // 
            // estimateTableAdapter
            // 
            this.estimateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuyerTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.DeveleryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EstimateTableAdapter = this.estimateTableAdapter;
            this.tableAdapterManager.ExecutionWorkTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estimateBindingNavigator
            // 
            this.estimateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estimateBindingNavigator.BackColor = System.Drawing.Color.White;
            this.estimateBindingNavigator.BindingSource = this.estimateBindingSource;
            this.estimateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estimateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estimateBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.estimateBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.estimateBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.estimateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estimateBindingNavigator.Location = new System.Drawing.Point(0, 339);
            this.estimateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estimateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estimateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estimateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estimateBindingNavigator.Name = "estimateBindingNavigator";
            this.estimateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estimateBindingNavigator.Size = new System.Drawing.Size(600, 27);
            this.estimateBindingNavigator.TabIndex = 4;
            this.estimateBindingNavigator.Text = "bindingNavigator1";
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
            this.buyerBindingNavigatorSaveItem.Click += new System.EventHandler(this.estBindingNavigatorSaveItem_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(90, 273);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EstimateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.estimateBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstimateForm";
            this.ShowIcon = false;
            this.Text = "Смета";
            this.Load += new System.EventHandler(this.EstimateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimateBindingNavigator)).EndInit();
            this.estimateBindingNavigator.ResumeLayout(false);
            this.estimateBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private DB_PlasticWindowsDataSet dB_PlasticWindowsDataSet;
        private System.Windows.Forms.BindingSource estimateBindingSource;
        private DB_PlasticWindowsDataSetTableAdapters.EstimateTableAdapter estimateTableAdapter;
        private DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estimateBindingNavigator;
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
        private System.Windows.Forms.TextBox priceForUnitTextBox;
        private System.Windows.Forms.TextBox amountMaterialTextBox;
        private System.Windows.Forms.TextBox amountWorkTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox materialIDTextBox;
        private System.Windows.Forms.TextBox contractIDTextBox;
        private System.Windows.Forms.TextBox estimateIDTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ToolStripButton buyerBindingNavigatorSaveItem;
        private System.Windows.Forms.Button saveButton;
    }
}