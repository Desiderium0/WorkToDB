namespace WorkToDB.Forms
{
    partial class GreetingForm
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
            this.toStartForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.requestStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.querySelectStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toStartForm
            // 
            this.toStartForm.Location = new System.Drawing.Point(179, 506);
            this.toStartForm.Margin = new System.Windows.Forms.Padding(4);
            this.toStartForm.Name = "toStartForm";
            this.toStartForm.Size = new System.Drawing.Size(161, 41);
            this.toStartForm.TabIndex = 0;
            this.toStartForm.Text = "Кнопочная форма";
            this.toStartForm.UseVisualStyleBackColor = true;
            this.toStartForm.Click += new System.EventHandler(this.toStartForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информационная система\r\n     \"Пластиковые окна\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkToDB.Properties.Resources._15c231ccd4685757370f6aef4d7b815d;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem4,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(85, 24);
            this.toolStripMenuItem2.Text = "Таблицы";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(269, 26);
            this.toolStripMenuItem5.Text = "Справочник сотрудников";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(269, 26);
            this.toolStripMenuItem3.Text = "Справочник заказчиков";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(269, 26);
            this.toolStripMenuItem6.Text = "Выполнение работ";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(269, 26);
            this.toolStripMenuItem7.Text = "Доставки";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(269, 26);
            this.toolStripMenuItem4.Text = "Договоры";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(269, 26);
            this.toolStripMenuItem8.Text = "Смета";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(269, 26);
            this.toolStripMenuItem9.Text = "Материалы";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // requestStripMenuItem10
            // 
            this.requestStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminStripMenuItem,
            this.querySelectStripMenuItem,
            this.toolStripMenuItem10,
            this.queryDateStripMenuItem});
            this.requestStripMenuItem10.Name = "requestStripMenuItem10";
            this.requestStripMenuItem10.Size = new System.Drawing.Size(84, 24);
            this.requestStripMenuItem10.Text = "Запросы";
            // 
            // AdminStripMenuItem
            // 
            this.AdminStripMenuItem.Name = "AdminStripMenuItem";
            this.AdminStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.AdminStripMenuItem.Text = "Администрирование";
            this.AdminStripMenuItem.Click += new System.EventHandler(this.AdminStripMenuItem_Click);
            // 
            // querySelectStripMenuItem
            // 
            this.querySelectStripMenuItem.Name = "querySelectStripMenuItem";
            this.querySelectStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.querySelectStripMenuItem.Text = "Запрос на выборку";
            this.querySelectStripMenuItem.Click += new System.EventHandler(this.querySelectStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(239, 26);
            this.toolStripMenuItem10.Text = "Запрос (Ручной)";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // queryDateStripMenuItem
            // 
            this.queryDateStripMenuItem.Name = "queryDateStripMenuItem";
            this.queryDateStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.queryDateStripMenuItem.Text = "Запрос (Даты)";
            this.queryDateStripMenuItem.Click += new System.EventHandler(this.requestDateStripMenuItem_Click);
            // 
            // reportToolStripMenu
            // 
            this.reportToolStripMenu.Name = "reportToolStripMenu";
            this.reportToolStripMenu.Size = new System.Drawing.Size(73, 24);
            this.reportToolStripMenu.Text = "Отчеты";
            this.reportToolStripMenu.Click += new System.EventHandler(this.reportToolStripMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 24);
            this.toolStripMenuItem1.Text = "О программе";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.requestStripMenuItem10,
            this.reportToolStripMenu,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toStartForm);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GreetingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GreetingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toStartForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem requestStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem AdminStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem querySelectStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem queryDateStripMenuItem;
    }
}