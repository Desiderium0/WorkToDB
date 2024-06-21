
namespace WorkToDB.Forms
{
    partial class DeveleryForm
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
            System.Windows.Forms.Label develeryIDLabel;
            System.Windows.Forms.Label timeDeveleryLabel;
            System.Windows.Forms.Label dateDeveleryLabel;
            System.Windows.Forms.Label adressDeveleryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveleryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.develeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PlasticWindowsDataSet = new WorkToDB.DB_PlasticWindowsDataSet();
            this.timeDeveleryTextBox = new System.Windows.Forms.TextBox();
            this.dateDeveleryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.develeryIDTextBox = new System.Windows.Forms.TextBox();
            this.FirstButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.develeryTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.DeveleryTableAdapter();
            this.tableAdapterManager = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager();
            this.develeryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contractTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.ContractTableAdapter();
            this.estimateTableAdapter = new WorkToDB.DB_PlasticWindowsDataSetTableAdapters.EstimateTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            develeryIDLabel = new System.Windows.Forms.Label();
            timeDeveleryLabel = new System.Windows.Forms.Label();
            dateDeveleryLabel = new System.Windows.Forms.Label();
            adressDeveleryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.develeryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.develeryBindingNavigator)).BeginInit();
            this.develeryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // develeryIDLabel
            // 
            develeryIDLabel.AutoSize = true;
            develeryIDLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            develeryIDLabel.Location = new System.Drawing.Point(16, 12);
            develeryIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            develeryIDLabel.Name = "develeryIDLabel";
            develeryIDLabel.Size = new System.Drawing.Size(106, 13);
            develeryIDLabel.TabIndex = 15;
            develeryIDLabel.Text = "Номер доставки:";
            // 
            // timeDeveleryLabel
            // 
            timeDeveleryLabel.AutoSize = true;
            timeDeveleryLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            timeDeveleryLabel.Location = new System.Drawing.Point(8, 32);
            timeDeveleryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            timeDeveleryLabel.Name = "timeDeveleryLabel";
            timeDeveleryLabel.Size = new System.Drawing.Size(106, 13);
            timeDeveleryLabel.TabIndex = 16;
            timeDeveleryLabel.Text = "Время доставки:";
            // 
            // dateDeveleryLabel
            // 
            dateDeveleryLabel.AutoSize = true;
            dateDeveleryLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateDeveleryLabel.Location = new System.Drawing.Point(16, 57);
            dateDeveleryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateDeveleryLabel.Name = "dateDeveleryLabel";
            dateDeveleryLabel.Size = new System.Drawing.Size(97, 13);
            dateDeveleryLabel.TabIndex = 17;
            dateDeveleryLabel.Text = "Дата доставки:";
            // 
            // adressDeveleryLabel
            // 
            adressDeveleryLabel.AutoSize = true;
            adressDeveleryLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            adressDeveleryLabel.Location = new System.Drawing.Point(8, 10);
            adressDeveleryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            adressDeveleryLabel.Name = "adressDeveleryLabel";
            adressDeveleryLabel.Size = new System.Drawing.Size(106, 13);
            adressDeveleryLabel.TabIndex = 18;
            adressDeveleryLabel.Text = "Адрес доставки:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WorkToDB.Properties.Resources.Window;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 370);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LastButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.FirstButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 337);
            this.panel1.TabIndex = 4;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(86, 177);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(88, 23);
            this.DeleteRecordButton.TabIndex = 29;
            this.DeleteRecordButton.Text = "Удалить";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(86, 148);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(88, 23);
            this.AddRecordButton.TabIndex = 28;
            this.AddRecordButton.Text = "Добавить";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.timeDeveleryTextBox);
            this.panel2.Controls.Add(dateDeveleryLabel);
            this.panel2.Controls.Add(adressDeveleryLabel);
            this.panel2.Controls.Add(this.dateDeveleryDateTimePicker);
            this.panel2.Controls.Add(timeDeveleryLabel);
            this.panel2.Location = new System.Drawing.Point(10, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 85);
            this.panel2.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.develeryBindingSource, "adressDevelery", true));
            this.comboBox1.DataSource = this.develeryBindingSource;
            this.comboBox1.DisplayMember = "adressDevelery";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // develeryBindingSource
            // 
            this.develeryBindingSource.DataMember = "Develery";
            this.develeryBindingSource.DataSource = this.dB_PlasticWindowsDataSet;
            // 
            // dB_PlasticWindowsDataSet
            // 
            this.dB_PlasticWindowsDataSet.DataSetName = "DB_PlasticWindowsDataSet";
            this.dB_PlasticWindowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeDeveleryTextBox
            // 
            this.timeDeveleryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.develeryBindingSource, "timeDevelery", true));
            this.timeDeveleryTextBox.Location = new System.Drawing.Point(116, 30);
            this.timeDeveleryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeDeveleryTextBox.Name = "timeDeveleryTextBox";
            this.timeDeveleryTextBox.Size = new System.Drawing.Size(86, 20);
            this.timeDeveleryTextBox.TabIndex = 17;
            // 
            // dateDeveleryDateTimePicker
            // 
            this.dateDeveleryDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.develeryBindingSource, "dateDevelery", true));
            this.dateDeveleryDateTimePicker.Location = new System.Drawing.Point(116, 53);
            this.dateDeveleryDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateDeveleryDateTimePicker.Name = "dateDeveleryDateTimePicker";
            this.dateDeveleryDateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.dateDeveleryDateTimePicker.TabIndex = 18;
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(216, 265);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(32, 23);
            this.LastButton.TabIndex = 27;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.develeryIDTextBox);
            this.panel4.Controls.Add(develeryIDLabel);
            this.panel4.Location = new System.Drawing.Point(10, 14);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 39);
            this.panel4.TabIndex = 15;
            // 
            // develeryIDTextBox
            // 
            this.develeryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.develeryBindingSource, "develeryID", true));
            this.develeryIDTextBox.Location = new System.Drawing.Point(127, 10);
            this.develeryIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.develeryIDTextBox.Name = "develeryIDTextBox";
            this.develeryIDTextBox.Size = new System.Drawing.Size(48, 20);
            this.develeryIDTextBox.TabIndex = 16;
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(10, 265);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(32, 23);
            this.FirstButton.TabIndex = 26;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 294);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(58, 23);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Предыд.";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(190, 294);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(58, 23);
            this.NextButton.TabIndex = 25;
            this.NextButton.Text = "След.";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // develeryTableAdapter
            // 
            this.develeryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuyerTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.DeveleryTableAdapter = this.develeryTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EstimateTableAdapter = null;
            this.tableAdapterManager.ExecutionWorkTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorkToDB.DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // develeryBindingNavigator
            // 
            this.develeryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.develeryBindingNavigator.BindingSource = this.develeryBindingSource;
            this.develeryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.develeryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.develeryBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.develeryBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.develeryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.develeryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.develeryBindingNavigator.Location = new System.Drawing.Point(0, 343);
            this.develeryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.develeryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.develeryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.develeryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.develeryBindingNavigator.Name = "develeryBindingNavigator";
            this.develeryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.develeryBindingNavigator.Size = new System.Drawing.Size(600, 27);
            this.develeryBindingNavigator.TabIndex = 5;
            this.develeryBindingNavigator.Text = "bindingNavigator1";
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
            this.buyerBindingNavigatorSaveItem.Click += new System.EventHandler(this.develeryBindingNavigatorSaveItem_Click);
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // estimateTableAdapter
            // 
            this.estimateTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(86, 206);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DeveleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.develeryBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeveleryForm";
            this.ShowIcon = false;
            this.Text = "Доставки";
            this.Load += new System.EventHandler(this.DeveleryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.develeryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlasticWindowsDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.develeryBindingNavigator)).EndInit();
            this.develeryBindingNavigator.ResumeLayout(false);
            this.develeryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DB_PlasticWindowsDataSet dB_PlasticWindowsDataSet;
        private System.Windows.Forms.BindingSource develeryBindingSource;
        private DB_PlasticWindowsDataSetTableAdapters.DeveleryTableAdapter develeryTableAdapter;
        private DB_PlasticWindowsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator develeryBindingNavigator;
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
        private System.Windows.Forms.DateTimePicker dateDeveleryDateTimePicker;
        private System.Windows.Forms.TextBox timeDeveleryTextBox;
        private System.Windows.Forms.TextBox develeryIDTextBox;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private DB_PlasticWindowsDataSetTableAdapters.ContractTableAdapter contractTableAdapter;
        private DB_PlasticWindowsDataSetTableAdapters.EstimateTableAdapter estimateTableAdapter;
        private System.Windows.Forms.ToolStripButton buyerBindingNavigatorSaveItem;
        private System.Windows.Forms.Button saveButton;
    }
}