using WorkToDB.Forms;

namespace WorkToDB
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaterialButton = new System.Windows.Forms.Button();
            this.EstimateButton = new System.Windows.Forms.Button();
            this.ContractButton = new System.Windows.Forms.Button();
            this.DeveleryButton = new System.Windows.Forms.Button();
            this.ExecuteWorkButton = new System.Windows.Forms.Button();
            this.BuyerButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlasticWindowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WorkToDB.Properties.Resources.Window;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MaterialButton);
            this.panel1.Controls.Add(this.EstimateButton);
            this.panel1.Controls.Add(this.ContractButton);
            this.panel1.Controls.Add(this.DeveleryButton);
            this.panel1.Controls.Add(this.ExecuteWorkButton);
            this.panel1.Controls.Add(this.BuyerButton);
            this.panel1.Controls.Add(this.EmployeesButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(87, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 402);
            this.panel1.TabIndex = 1;
            // 
            // MaterialButton
            // 
            this.MaterialButton.BackColor = System.Drawing.Color.White;
            this.MaterialButton.Location = new System.Drawing.Point(54, 345);
            this.MaterialButton.Margin = new System.Windows.Forms.Padding(4);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(200, 35);
            this.MaterialButton.TabIndex = 9;
            this.MaterialButton.Text = "Материалы";
            this.MaterialButton.UseVisualStyleBackColor = false;
            this.MaterialButton.Click += new System.EventHandler(this.MaterialButton_Click);
            // 
            // EstimateButton
            // 
            this.EstimateButton.BackColor = System.Drawing.Color.White;
            this.EstimateButton.Location = new System.Drawing.Point(54, 297);
            this.EstimateButton.Margin = new System.Windows.Forms.Padding(4);
            this.EstimateButton.Name = "EstimateButton";
            this.EstimateButton.Size = new System.Drawing.Size(200, 35);
            this.EstimateButton.TabIndex = 8;
            this.EstimateButton.Text = "Смета";
            this.EstimateButton.UseVisualStyleBackColor = false;
            this.EstimateButton.Click += new System.EventHandler(this.EstimateButton_Click);
            // 
            // ContractButton
            // 
            this.ContractButton.BackColor = System.Drawing.Color.White;
            this.ContractButton.Location = new System.Drawing.Point(54, 249);
            this.ContractButton.Margin = new System.Windows.Forms.Padding(4);
            this.ContractButton.Name = "ContractButton";
            this.ContractButton.Size = new System.Drawing.Size(200, 35);
            this.ContractButton.TabIndex = 7;
            this.ContractButton.Text = "Договоры";
            this.ContractButton.UseVisualStyleBackColor = false;
            this.ContractButton.Click += new System.EventHandler(this.ContractButton_Click);
            // 
            // DeveleryButton
            // 
            this.DeveleryButton.BackColor = System.Drawing.Color.White;
            this.DeveleryButton.Location = new System.Drawing.Point(54, 204);
            this.DeveleryButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeveleryButton.Name = "DeveleryButton";
            this.DeveleryButton.Size = new System.Drawing.Size(200, 35);
            this.DeveleryButton.TabIndex = 6;
            this.DeveleryButton.Text = "Доставки";
            this.DeveleryButton.UseVisualStyleBackColor = false;
            this.DeveleryButton.Click += new System.EventHandler(this.DeveleryButton_Click);
            // 
            // ExecuteWorkButton
            // 
            this.ExecuteWorkButton.BackColor = System.Drawing.Color.White;
            this.ExecuteWorkButton.Location = new System.Drawing.Point(54, 159);
            this.ExecuteWorkButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExecuteWorkButton.Name = "ExecuteWorkButton";
            this.ExecuteWorkButton.Size = new System.Drawing.Size(200, 35);
            this.ExecuteWorkButton.TabIndex = 5;
            this.ExecuteWorkButton.Text = "Выполнение работ";
            this.ExecuteWorkButton.UseVisualStyleBackColor = false;
            this.ExecuteWorkButton.Click += new System.EventHandler(this.ExecuteWorkButton_Click);
            // 
            // BuyerButton
            // 
            this.BuyerButton.BackColor = System.Drawing.Color.White;
            this.BuyerButton.Location = new System.Drawing.Point(54, 114);
            this.BuyerButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuyerButton.Name = "BuyerButton";
            this.BuyerButton.Size = new System.Drawing.Size(200, 35);
            this.BuyerButton.TabIndex = 4;
            this.BuyerButton.Text = "Справочник заказчиков";
            this.BuyerButton.UseVisualStyleBackColor = false;
            this.BuyerButton.Click += new System.EventHandler(this.BuyerButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.BackColor = System.Drawing.Color.White;
            this.EmployeesButton.Location = new System.Drawing.Point(54, 69);
            this.EmployeesButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(200, 35);
            this.EmployeesButton.TabIndex = 3;
            this.EmployeesButton.Text = "Справочник сотрудников";
            this.EmployeesButton.UseVisualStyleBackColor = false;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PlasticWindowLabel);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 62);
            this.panel2.TabIndex = 2;
            // 
            // PlasticWindowLabel
            // 
            this.PlasticWindowLabel.AutoSize = true;
            this.PlasticWindowLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlasticWindowLabel.ForeColor = System.Drawing.Color.Black;
            this.PlasticWindowLabel.Location = new System.Drawing.Point(40, 19);
            this.PlasticWindowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlasticWindowLabel.Name = "PlasticWindowLabel";
            this.PlasticWindowLabel.Size = new System.Drawing.Size(227, 25);
            this.PlasticWindowLabel.TabIndex = 0;
            this.PlasticWindowLabel.Text = "Пластиковые окна";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(988, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пластиковые окна";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Form EmployeeForm;
        private System.Windows.Forms.Form BuyerForm;
        private System.Windows.Forms.Form ExecutionWorkForm;
        private System.Windows.Forms.Form DeveleryForm;
        private System.Windows.Forms.Form ContractForm;
        private System.Windows.Forms.Form EstimateForm;
        private System.Windows.Forms.Form MaterialForm;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PlasticWindowLabel;
        private System.Windows.Forms.Button ContractButton;
        private System.Windows.Forms.Button DeveleryButton;
        private System.Windows.Forms.Button ExecuteWorkButton;
        private System.Windows.Forms.Button BuyerButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button EstimateButton;
        private System.Windows.Forms.Button MaterialButton;
    }
}

