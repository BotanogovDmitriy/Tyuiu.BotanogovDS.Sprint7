
namespace Tyuiu.BotanogovDS.Sprint7.V8
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonStats_BDS = new System.Windows.Forms.Button();
            this.groupBoxFilters_BDS = new System.Windows.Forms.GroupBox();
            this.buttonSearch_BDS = new System.Windows.Forms.Button();
            this.textBoxSearch_BDS = new System.Windows.Forms.TextBox();
            this.groupBoxSort_BDS = new System.Windows.Forms.GroupBox();
            this.menuStripFilters_BDS = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemSortMin_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIDMin_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExperienceMin_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFuelMin_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemKilometersMin_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSortMax_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIDMax_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExperienceMax_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFuelMax_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemKilometersMax_BDS = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSearch_BDS = new System.Windows.Forms.Label();
            this.buttonBack_BDS = new System.Windows.Forms.Button();
            this.buttonGuide_BDS = new System.Windows.Forms.Button();
            this.buttonInfo_BDS = new System.Windows.Forms.Button();
            this.buttonLoadData_BDS = new System.Windows.Forms.Button();
            this.groupBoxData_BDS = new System.Windows.Forms.GroupBox();
            this.dataGridViewData_BDS = new System.Windows.Forms.DataGridView();
            this.openFileDialogData_BDS = new System.Windows.Forms.OpenFileDialog();
            this.toolTipInfo_BDS = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxFilters_BDS.SuspendLayout();
            this.groupBoxSort_BDS.SuspendLayout();
            this.menuStripFilters_BDS.SuspendLayout();
            this.groupBoxData_BDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BDS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStats_BDS
            // 
            this.buttonStats_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStats_BDS.Location = new System.Drawing.Point(1020, 14);
            this.buttonStats_BDS.Name = "buttonStats_BDS";
            this.buttonStats_BDS.Size = new System.Drawing.Size(112, 82);
            this.buttonStats_BDS.TabIndex = 16;
            this.buttonStats_BDS.Text = "Статистика\r\n и добавление новых арендаторов\r\n";
            this.buttonStats_BDS.UseVisualStyleBackColor = true;
            this.buttonStats_BDS.Click += new System.EventHandler(this.buttonStats_BDS_Click);
            // 
            // groupBoxFilters_BDS
            // 
            this.groupBoxFilters_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters_BDS.Controls.Add(this.buttonSearch_BDS);
            this.groupBoxFilters_BDS.Controls.Add(this.textBoxSearch_BDS);
            this.groupBoxFilters_BDS.Controls.Add(this.groupBoxSort_BDS);
            this.groupBoxFilters_BDS.Controls.Add(this.labelSearch_BDS);
            this.groupBoxFilters_BDS.Location = new System.Drawing.Point(281, 14);
            this.groupBoxFilters_BDS.Name = "groupBoxFilters_BDS";
            this.groupBoxFilters_BDS.Size = new System.Drawing.Size(733, 82);
            this.groupBoxFilters_BDS.TabIndex = 15;
            this.groupBoxFilters_BDS.TabStop = false;
            this.groupBoxFilters_BDS.Text = "Фильтры";
            // 
            // buttonSearch_BDS
            // 
            this.buttonSearch_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch_BDS.Enabled = false;
            this.buttonSearch_BDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch_BDS.Image")));
            this.buttonSearch_BDS.Location = new System.Drawing.Point(692, 32);
            this.buttonSearch_BDS.Name = "buttonSearch_BDS";
            this.buttonSearch_BDS.Size = new System.Drawing.Size(41, 36);
            this.buttonSearch_BDS.TabIndex = 9;
            this.toolTipInfo_BDS.SetToolTip(this.buttonSearch_BDS, "Найти");
            this.buttonSearch_BDS.UseVisualStyleBackColor = true;
            this.buttonSearch_BDS.Click += new System.EventHandler(this.buttonSearch_BDS_Click);
            // 
            // textBoxSearch_BDS
            // 
            this.textBoxSearch_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_BDS.Enabled = false;
            this.textBoxSearch_BDS.Location = new System.Drawing.Point(554, 34);
            this.textBoxSearch_BDS.Multiline = true;
            this.textBoxSearch_BDS.Name = "textBoxSearch_BDS";
            this.textBoxSearch_BDS.Size = new System.Drawing.Size(132, 30);
            this.textBoxSearch_BDS.TabIndex = 6;
            // 
            // groupBoxSort_BDS
            // 
            this.groupBoxSort_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSort_BDS.Controls.Add(this.menuStripFilters_BDS);
            this.groupBoxSort_BDS.Location = new System.Drawing.Point(6, 14);
            this.groupBoxSort_BDS.Name = "groupBoxSort_BDS";
            this.groupBoxSort_BDS.Size = new System.Drawing.Size(542, 55);
            this.groupBoxSort_BDS.TabIndex = 5;
            this.groupBoxSort_BDS.TabStop = false;
            // 
            // menuStripFilters_BDS
            // 
            this.menuStripFilters_BDS.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripFilters_BDS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFilters_BDS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSortMin_BDS,
            this.ToolStripMenuItemSortMax_BDS});
            this.menuStripFilters_BDS.Location = new System.Drawing.Point(3, 18);
            this.menuStripFilters_BDS.Name = "menuStripFilters_BDS";
            this.menuStripFilters_BDS.Size = new System.Drawing.Size(631, 28);
            this.menuStripFilters_BDS.TabIndex = 7;
            this.menuStripFilters_BDS.Text = "menuStrip1";
            // 
            // ToolStripMenuItemSortMin_BDS
            // 
            this.ToolStripMenuItemSortMin_BDS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemIDMin_BDS,
            this.ToolStripMenuItemExperienceMin_BDS,
            this.ToolStripMenuItemFuelMin_BDS,
            this.ToolStripMenuItemKilometersMin_BDS});
            this.ToolStripMenuItemSortMin_BDS.Enabled = false;
            this.ToolStripMenuItemSortMin_BDS.Name = "ToolStripMenuItemSortMin_BDS";
            this.ToolStripMenuItemSortMin_BDS.Size = new System.Drawing.Size(227, 24);
            this.ToolStripMenuItemSortMin_BDS.Text = "Отсортировать по убыванию";
            // 
            // ToolStripMenuItemIDMin_BDS
            // 
            this.ToolStripMenuItemIDMin_BDS.Name = "ToolStripMenuItemIDMin_BDS";
            this.ToolStripMenuItemIDMin_BDS.Size = new System.Drawing.Size(212, 26);
            this.ToolStripMenuItemIDMin_BDS.Text = "ID";
            this.ToolStripMenuItemIDMin_BDS.Click += new System.EventHandler(this.ToolStripMenuItemIDMin_BDS_Click);
            // 
            // ToolStripMenuItemExperienceMin_BDS
            // 
            this.ToolStripMenuItemExperienceMin_BDS.Name = "ToolStripMenuItemExperienceMin_BDS";
            this.ToolStripMenuItemExperienceMin_BDS.Size = new System.Drawing.Size(212, 26);
            this.ToolStripMenuItemExperienceMin_BDS.Text = "Стаж арендатора";
            this.ToolStripMenuItemExperienceMin_BDS.Click += new System.EventHandler(this.ToolStripMenuItemExperienceMin_BDS_Click);
            // 
            // ToolStripMenuItemFuelMin_BDS
            // 
            this.ToolStripMenuItemFuelMin_BDS.Name = "ToolStripMenuItemFuelMin_BDS";
            this.ToolStripMenuItemFuelMin_BDS.Size = new System.Drawing.Size(212, 26);
            this.ToolStripMenuItemFuelMin_BDS.Text = "Расход топлива";
            this.ToolStripMenuItemFuelMin_BDS.Click += new System.EventHandler(this.ToolStripMenuItemFuelMin_BDS_Click);
            // 
            // ToolStripMenuItemKilometersMin_BDS
            // 
            this.ToolStripMenuItemKilometersMin_BDS.Name = "ToolStripMenuItemKilometersMin_BDS";
            this.ToolStripMenuItemKilometersMin_BDS.Size = new System.Drawing.Size(212, 26);
            this.ToolStripMenuItemKilometersMin_BDS.Text = "Пробег";
            this.ToolStripMenuItemKilometersMin_BDS.Click += new System.EventHandler(this.ToolStripMenuItemKilometersMin_BDS_Click);
            // 
            // ToolStripMenuItemSortMax_BDS
            // 
            this.ToolStripMenuItemSortMax_BDS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemIDMax_BDS,
            this.ToolStripMenuItemExperienceMax_BDS,
            this.ToolStripMenuItemFuelMax_BDS,
            this.ToolStripMenuItemKilometersMax_BDS});
            this.ToolStripMenuItemSortMax_BDS.Enabled = false;
            this.ToolStripMenuItemSortMax_BDS.Name = "ToolStripMenuItemSortMax_BDS";
            this.ToolStripMenuItemSortMax_BDS.Size = new System.Drawing.Size(246, 24);
            this.ToolStripMenuItemSortMax_BDS.Text = "Отсортировать по возрастанию";
            // 
            // ToolStripMenuItemIDMax_BDS
            // 
            this.ToolStripMenuItemIDMax_BDS.Name = "ToolStripMenuItemIDMax_BDS";
            this.ToolStripMenuItemIDMax_BDS.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemIDMax_BDS.Text = "ID";
            this.ToolStripMenuItemIDMax_BDS.Click += new System.EventHandler(this.ToolStripMenuItemIDMax_BDS_Click);
            // 
            // ToolStripMenuItemExperienceMax_BDS
            // 
            this.ToolStripMenuItemExperienceMax_BDS.Name = "ToolStripMenuItemExperienceMax_BDS";
            this.ToolStripMenuItemExperienceMax_BDS.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemExperienceMax_BDS.Text = "Стаж арендатора";
            this.ToolStripMenuItemExperienceMax_BDS.Click += new System.EventHandler(this.ToolStripMenuItemExperienceMax_BDS_Click);
            // 
            // ToolStripMenuItemFuelMax_BDS
            // 
            this.ToolStripMenuItemFuelMax_BDS.Name = "ToolStripMenuItemFuelMax_BDS";
            this.ToolStripMenuItemFuelMax_BDS.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemFuelMax_BDS.Text = "Расход топлива";
            this.ToolStripMenuItemFuelMax_BDS.Click += new System.EventHandler(this.ToolStripMenuItemFuelMax_BDS_Click);
            // 
            // ToolStripMenuItemKilometersMax_BDS
            // 
            this.ToolStripMenuItemKilometersMax_BDS.Name = "ToolStripMenuItemKilometersMax_BDS";
            this.ToolStripMenuItemKilometersMax_BDS.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemKilometersMax_BDS.Text = "Пробег";
            this.ToolStripMenuItemKilometersMax_BDS.Click += new System.EventHandler(this.ToolStripMenuItemKilometersMax_BDS_Click);
            // 
            // labelSearch_BDS
            // 
            this.labelSearch_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch_BDS.AutoSize = true;
            this.labelSearch_BDS.Location = new System.Drawing.Point(551, 14);
            this.labelSearch_BDS.Name = "labelSearch_BDS";
            this.labelSearch_BDS.Size = new System.Drawing.Size(146, 17);
            this.labelSearch_BDS.TabIndex = 7;
            this.labelSearch_BDS.Text = "Поиск по марке авто";
            // 
            // buttonBack_BDS
            // 
            this.buttonBack_BDS.Enabled = false;
            this.buttonBack_BDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack_BDS.Image")));
            this.buttonBack_BDS.Location = new System.Drawing.Point(213, 14);
            this.buttonBack_BDS.Name = "buttonBack_BDS";
            this.buttonBack_BDS.Size = new System.Drawing.Size(62, 82);
            this.buttonBack_BDS.TabIndex = 14;
            this.toolTipInfo_BDS.SetToolTip(this.buttonBack_BDS, "Вернуть таблицу к начальному виду");
            this.buttonBack_BDS.UseVisualStyleBackColor = true;
            this.buttonBack_BDS.Click += new System.EventHandler(this.buttonBack_BDS_Click);
            // 
            // buttonGuide_BDS
            // 
            this.buttonGuide_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuide_BDS.Location = new System.Drawing.Point(1138, 14);
            this.buttonGuide_BDS.Name = "buttonGuide_BDS";
            this.buttonGuide_BDS.Size = new System.Drawing.Size(109, 82);
            this.buttonGuide_BDS.TabIndex = 13;
            this.buttonGuide_BDS.Text = "Руководство пользователя";
            this.buttonGuide_BDS.UseVisualStyleBackColor = true;
            this.buttonGuide_BDS.Click += new System.EventHandler(this.buttonGuide_BDS_Click);
            // 
            // buttonInfo_BDS
            // 
            this.buttonInfo_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_BDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_BDS.Image")));
            this.buttonInfo_BDS.Location = new System.Drawing.Point(1253, 14);
            this.buttonInfo_BDS.Name = "buttonInfo_BDS";
            this.buttonInfo_BDS.Size = new System.Drawing.Size(62, 82);
            this.buttonInfo_BDS.TabIndex = 12;
            this.toolTipInfo_BDS.SetToolTip(this.buttonInfo_BDS, "О программе");
            this.buttonInfo_BDS.UseVisualStyleBackColor = true;
            this.buttonInfo_BDS.Click += new System.EventHandler(this.buttonInfo_BDS_Click);
            // 
            // buttonLoadData_BDS
            // 
            this.buttonLoadData_BDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadData_BDS.Image")));
            this.buttonLoadData_BDS.Location = new System.Drawing.Point(13, 14);
            this.buttonLoadData_BDS.Name = "buttonLoadData_BDS";
            this.buttonLoadData_BDS.Size = new System.Drawing.Size(194, 82);
            this.buttonLoadData_BDS.TabIndex = 11;
            this.toolTipInfo_BDS.SetToolTip(this.buttonLoadData_BDS, "Выгрузить базу ");
            this.buttonLoadData_BDS.UseVisualStyleBackColor = true;
            this.buttonLoadData_BDS.Click += new System.EventHandler(this.buttonLoadData_BDS_Click);
            // 
            // groupBoxData_BDS
            // 
            this.groupBoxData_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_BDS.Controls.Add(this.dataGridViewData_BDS);
            this.groupBoxData_BDS.Location = new System.Drawing.Point(13, 114);
            this.groupBoxData_BDS.Name = "groupBoxData_BDS";
            this.groupBoxData_BDS.Size = new System.Drawing.Size(1302, 482);
            this.groupBoxData_BDS.TabIndex = 10;
            this.groupBoxData_BDS.TabStop = false;
            this.groupBoxData_BDS.Text = "База авто";
            // 
            // dataGridViewData_BDS
            // 
            this.dataGridViewData_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData_BDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_BDS.ColumnHeadersVisible = false;
            this.dataGridViewData_BDS.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewData_BDS.Name = "dataGridViewData_BDS";
            this.dataGridViewData_BDS.RowHeadersVisible = false;
            this.dataGridViewData_BDS.RowHeadersWidth = 51;
            this.dataGridViewData_BDS.RowTemplate.Height = 24;
            this.dataGridViewData_BDS.Size = new System.Drawing.Size(1290, 458);
            this.dataGridViewData_BDS.TabIndex = 0;
            // 
            // openFileDialogData_BDS
            // 
            this.openFileDialogData_BDS.FileName = "openFileDialog1";
            // 
            // toolTipInfo_BDS
            // 
            this.toolTipInfo_BDS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo_BDS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 610);
            this.Controls.Add(this.buttonStats_BDS);
            this.Controls.Add(this.groupBoxFilters_BDS);
            this.Controls.Add(this.buttonBack_BDS);
            this.Controls.Add(this.buttonGuide_BDS);
            this.Controls.Add(this.buttonInfo_BDS);
            this.Controls.Add(this.buttonLoadData_BDS);
            this.Controls.Add(this.groupBoxData_BDS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автотранспортное предприятие";
            this.groupBoxFilters_BDS.ResumeLayout(false);
            this.groupBoxFilters_BDS.PerformLayout();
            this.groupBoxSort_BDS.ResumeLayout(false);
            this.groupBoxSort_BDS.PerformLayout();
            this.menuStripFilters_BDS.ResumeLayout(false);
            this.menuStripFilters_BDS.PerformLayout();
            this.groupBoxData_BDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStats_BDS;
        private System.Windows.Forms.GroupBox groupBoxFilters_BDS;
        private System.Windows.Forms.Button buttonSearch_BDS;
        private System.Windows.Forms.Label labelSearch_BDS;
        private System.Windows.Forms.TextBox textBoxSearch_BDS;
        private System.Windows.Forms.GroupBox groupBoxSort_BDS;
        private System.Windows.Forms.MenuStrip menuStripFilters_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSortMin_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIDMin_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExperienceMin_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFuelMin_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemKilometersMin_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSortMax_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIDMax_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExperienceMax_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFuelMax_BDS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemKilometersMax_BDS;
        private System.Windows.Forms.Button buttonBack_BDS;
        private System.Windows.Forms.Button buttonGuide_BDS;
        private System.Windows.Forms.Button buttonInfo_BDS;
        private System.Windows.Forms.Button buttonLoadData_BDS;
        private System.Windows.Forms.GroupBox groupBoxData_BDS;
        private System.Windows.Forms.DataGridView dataGridViewData_BDS;
        private System.Windows.Forms.OpenFileDialog openFileDialogData_BDS;
        private System.Windows.Forms.ToolTip toolTipInfo_BDS;
    }
}

