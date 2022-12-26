namespace KardashLab4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.inputNumberOfRowToDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNumberTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.deleteConfirm = new System.Windows.Forms.ToolStripMenuItem();
            this.importButton = new System.Windows.Forms.ToolStripButton();
            this.exportButton = new System.Windows.Forms.ToolStripButton();
            this.deserializeButton = new System.Windows.Forms.ToolStripButton();
            this.serializeButton = new System.Windows.Forms.ToolStripButton();
            this.searchMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.pIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCriteriaTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.searchConfirmButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCriteriaTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.searchConfirmButton2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cathedraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCriteriaTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.searchConfirmButton3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSearchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.deleteMenu,
            this.importButton,
            this.exportButton,
            this.deserializeButton,
            this.serializeButton,
            this.searchMenu,
            this.infoButton,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1335, 34);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(202, 29);
            this.addButton.Text = "Додати члена кафедри";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteMenu
            // 
            this.deleteMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputNumberOfRowToDeleteToolStripMenuItem,
            this.deleteConfirm});
            this.deleteMenu.Image = ((System.Drawing.Image)(resources.GetObject("deleteMenu.Image")));
            this.deleteMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(116, 29);
            this.deleteMenu.Text = "Видалення";
            // 
            // inputNumberOfRowToDeleteToolStripMenuItem
            // 
            this.inputNumberOfRowToDeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteNumberTextBox});
            this.inputNumberOfRowToDeleteToolStripMenuItem.Name = "inputNumberOfRowToDeleteToolStripMenuItem";
            this.inputNumberOfRowToDeleteToolStripMenuItem.Size = new System.Drawing.Size(409, 34);
            this.inputNumberOfRowToDeleteToolStripMenuItem.Text = "Введіть номер рядка для видалення";
            // 
            // deleteNumberTextBox
            // 
            this.deleteNumberTextBox.Name = "deleteNumberTextBox";
            this.deleteNumberTextBox.Size = new System.Drawing.Size(100, 31);
            this.deleteNumberTextBox.Text = "1";
            // 
            // deleteConfirm
            // 
            this.deleteConfirm.Name = "deleteConfirm";
            this.deleteConfirm.Size = new System.Drawing.Size(409, 34);
            this.deleteConfirm.Text = "Підтвердження";
            this.deleteConfirm.Click += new System.EventHandler(this.deleteConfirm_Click);
            // 
            // importButton
            // 
            this.importButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importButton.Image = ((System.Drawing.Image)(resources.GetObject("importButton.Image")));
            this.importButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(140, 29);
            this.importButton.Text = "Імпорт з тексту";
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportButton.Image = ((System.Drawing.Image)(resources.GetObject("exportButton.Image")));
            this.exportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(140, 29);
            this.exportButton.Text = "Експорт у текст";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // deserializeButton
            // 
            this.deserializeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deserializeButton.Image = ((System.Drawing.Image)(resources.GetObject("deserializeButton.Image")));
            this.deserializeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(193, 29);
            this.deserializeButton.Text = "Десеріалізація з JSON";
            this.deserializeButton.Click += new System.EventHandler(this.deserializeButton_Click);
            // 
            // serializeButton
            // 
            this.serializeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.serializeButton.Image = ((System.Drawing.Image)(resources.GetObject("serializeButton.Image")));
            this.serializeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(176, 29);
            this.serializeButton.Text = "Серіалізація у JSON";
            this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
            // 
            // searchMenu
            // 
            this.searchMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIPToolStripMenuItem,
            this.facultyTitleToolStripMenuItem,
            this.cathedraToolStripMenuItem,
            this.cancelSearchButton});
            this.searchMenu.Image = ((System.Drawing.Image)(resources.GetObject("searchMenu.Image")));
            this.searchMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchMenu.Name = "searchMenu";
            this.searchMenu.Size = new System.Drawing.Size(113, 29);
            this.searchMenu.Text = "Шукати за";
            // 
            // pIPToolStripMenuItem
            // 
            this.pIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchCriteriaTextBox1,
            this.searchConfirmButton1});
            this.pIPToolStripMenuItem.Name = "pIPToolStripMenuItem";
            this.pIPToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.pIPToolStripMenuItem.Text = "ПІП";
            // 
            // searchCriteriaTextBox1
            // 
            this.searchCriteriaTextBox1.Name = "searchCriteriaTextBox1";
            this.searchCriteriaTextBox1.Size = new System.Drawing.Size(150, 31);
            this.searchCriteriaTextBox1.Text = "Собичак К. А.";
            // 
            // searchConfirmButton1
            // 
            this.searchConfirmButton1.Name = "searchConfirmButton1";
            this.searchConfirmButton1.Size = new System.Drawing.Size(240, 34);
            this.searchConfirmButton1.Text = "Знайти";
            this.searchConfirmButton1.Click += new System.EventHandler(this.searchConfirmButton1_Click);
            // 
            // facultyTitleToolStripMenuItem
            // 
            this.facultyTitleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchCriteriaTextBox2,
            this.searchConfirmButton2});
            this.facultyTitleToolStripMenuItem.Name = "facultyTitleToolStripMenuItem";
            this.facultyTitleToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.facultyTitleToolStripMenuItem.Text = "Темою";
            // 
            // searchCriteriaTextBox2
            // 
            this.searchCriteriaTextBox2.Name = "searchCriteriaTextBox2";
            this.searchCriteriaTextBox2.Size = new System.Drawing.Size(150, 31);
            this.searchCriteriaTextBox2.Text = "Структури даних";
            // 
            // searchConfirmButton2
            // 
            this.searchConfirmButton2.Name = "searchConfirmButton2";
            this.searchConfirmButton2.Size = new System.Drawing.Size(240, 34);
            this.searchConfirmButton2.Text = "Знайти";
            this.searchConfirmButton2.Click += new System.EventHandler(this.searchConfirmButton2_Click);
            // 
            // cathedraToolStripMenuItem
            // 
            this.cathedraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchCriteriaTextBox3,
            this.searchConfirmButton3});
            this.cathedraToolStripMenuItem.Name = "cathedraToolStripMenuItem";
            this.cathedraToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.cathedraToolStripMenuItem.Text = "Виконанням";
            // 
            // searchCriteriaTextBox3
            // 
            this.searchCriteriaTextBox3.Name = "searchCriteriaTextBox3";
            this.searchCriteriaTextBox3.Size = new System.Drawing.Size(150, 31);
            this.searchCriteriaTextBox3.Text = "Задовільно";
            // 
            // searchConfirmButton3
            // 
            this.searchConfirmButton3.Name = "searchConfirmButton3";
            this.searchConfirmButton3.Size = new System.Drawing.Size(240, 34);
            this.searchConfirmButton3.Text = "Знайти";
            this.searchConfirmButton3.Click += new System.EventHandler(this.searchConfirmButton3_Click);
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(237, 34);
            this.cancelSearchButton.Text = "Зкинути пошук";
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(137, 29);
            this.infoButton.Text = "Про програму";
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 29);
            this.exitButton.Text = "Вихід";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(91, 70);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersWidth = 62;
            this.mainDataGridView.RowTemplate.Height = 33;
            this.mainDataGridView.Size = new System.Drawing.Size(1175, 484);
            this.mainDataGridView.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 606);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainDataGridView);
            this.Name = "MainForm";
            this.Text = "Головна";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton addButton;
        private ToolStripDropDownButton deleteMenu;
        private ToolStripMenuItem inputNumberOfRowToDeleteToolStripMenuItem;
        private ToolStripTextBox deleteNumberTextBox;
        private ToolStripMenuItem deleteConfirm;
        private ToolStripButton importButton;
        private ToolStripButton exportButton;
        private ToolStripButton deserializeButton;
        private ToolStripButton serializeButton;
        private ToolStripDropDownButton searchMenu;
        private ToolStripMenuItem pIPToolStripMenuItem;
        private ToolStripTextBox searchCriteriaTextBox1;
        private ToolStripMenuItem searchConfirmButton1;
        private ToolStripMenuItem facultyTitleToolStripMenuItem;
        private ToolStripTextBox searchCriteriaTextBox2;
        private ToolStripMenuItem searchConfirmButton2;
        private ToolStripMenuItem cathedraToolStripMenuItem;
        private ToolStripTextBox searchCriteriaTextBox3;
        private ToolStripMenuItem searchConfirmButton3;
        private ToolStripMenuItem cancelSearchButton;
        private ToolStripButton infoButton;
        private ToolStripButton exitButton;
        private DataGridView mainDataGridView;
    }
}