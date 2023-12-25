
namespace Tyuiu.BotanogovDS.Sprint7.V8
{
    partial class FormStatsAndAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatsAndAdd));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewData_BDS = new System.Windows.Forms.DataGridView();
            this.labelAddSeries_BDS = new System.Windows.Forms.Label();
            this.labelAddExperience_BDS = new System.Windows.Forms.Label();
            this.labelAddFIO_BDS = new System.Windows.Forms.Label();
            this.textBoxAddMark_BDS = new System.Windows.Forms.TextBox();
            this.textBoxAddFuel_BDS = new System.Windows.Forms.TextBox();
            this.textBoxAddKilometers_BDS = new System.Windows.Forms.TextBox();
            this.textBoxAddExperience_BDS = new System.Windows.Forms.TextBox();
            this.textBoxAddSeries_BDS = new System.Windows.Forms.TextBox();
            this.textBoxAddFIO_BDS = new System.Windows.Forms.TextBox();
            this.groupBoxDelete_BDS = new System.Windows.Forms.GroupBox();
            this.buttonDeleteRent_BDS = new System.Windows.Forms.Button();
            this.labelDeleteRent_BDS = new System.Windows.Forms.Label();
            this.textBoxDeleteRent_BDS = new System.Windows.Forms.TextBox();
            this.labelAddKilometers_BDS = new System.Windows.Forms.Label();
            this.labelAddFuel_BDS = new System.Windows.Forms.Label();
            this.labelAddMark_BDS = new System.Windows.Forms.Label();
            this.groupBoxData_BDS = new System.Windows.Forms.GroupBox();
            this.groupBoxReg_BDS = new System.Windows.Forms.GroupBox();
            this.buttonRegRent_BDS = new System.Windows.Forms.Button();
            this.labelAverageExperience_BDS = new System.Windows.Forms.Label();
            this.textBoxAverageExperience_BDS = new System.Windows.Forms.TextBox();
            this.labelAverageKilometers_BDS = new System.Windows.Forms.Label();
            this.textBoxAverageKilometers_BDS = new System.Windows.Forms.TextBox();
            this.labelAverageFuel_BDS = new System.Windows.Forms.Label();
            this.groupBoxStats_BDS = new System.Windows.Forms.GroupBox();
            this.buttonViewStats_BDS = new System.Windows.Forms.Button();
            this.textBoxAverageFuel_BDS = new System.Windows.Forms.TextBox();
            this.buttonViewChart_BDS = new System.Windows.Forms.Button();
            this.chartInfo_BDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveFileDialogData_BDS = new System.Windows.Forms.SaveFileDialog();
            this.toolTipInfo_BDS = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BDS)).BeginInit();
            this.groupBoxDelete_BDS.SuspendLayout();
            this.groupBoxData_BDS.SuspendLayout();
            this.groupBoxReg_BDS.SuspendLayout();
            this.groupBoxStats_BDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_BDS)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewData_BDS.Size = new System.Drawing.Size(682, 361);
            this.dataGridViewData_BDS.TabIndex = 0;
            this.dataGridViewData_BDS.UseWaitCursor = true;
            // 
            // labelAddSeries_BDS
            // 
            this.labelAddSeries_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddSeries_BDS.AutoSize = true;
            this.labelAddSeries_BDS.Location = new System.Drawing.Point(477, 21);
            this.labelAddSeries_BDS.Name = "labelAddSeries_BDS";
            this.labelAddSeries_BDS.Size = new System.Drawing.Size(138, 17);
            this.labelAddSeries_BDS.TabIndex = 10;
            this.labelAddSeries_BDS.Text = "Номер автомобиля:";
            // 
            // labelAddExperience_BDS
            // 
            this.labelAddExperience_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddExperience_BDS.AutoSize = true;
            this.labelAddExperience_BDS.Location = new System.Drawing.Point(250, 21);
            this.labelAddExperience_BDS.Name = "labelAddExperience_BDS";
            this.labelAddExperience_BDS.Size = new System.Drawing.Size(159, 17);
            this.labelAddExperience_BDS.TabIndex = 9;
            this.labelAddExperience_BDS.Text = "Стаж арендатора, лет:";
            // 
            // labelAddFIO_BDS
            // 
            this.labelAddFIO_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddFIO_BDS.AutoSize = true;
            this.labelAddFIO_BDS.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelAddFIO_BDS.Location = new System.Drawing.Point(6, 21);
            this.labelAddFIO_BDS.Name = "labelAddFIO_BDS";
            this.labelAddFIO_BDS.Size = new System.Drawing.Size(129, 17);
            this.labelAddFIO_BDS.TabIndex = 8;
            this.labelAddFIO_BDS.Text = "ФИО арендатора:";
            // 
            // textBoxAddMark_BDS
            // 
            this.textBoxAddMark_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddMark_BDS.Location = new System.Drawing.Point(6, 84);
            this.textBoxAddMark_BDS.Name = "textBoxAddMark_BDS";
            this.textBoxAddMark_BDS.Size = new System.Drawing.Size(238, 22);
            this.textBoxAddMark_BDS.TabIndex = 5;
            // 
            // textBoxAddFuel_BDS
            // 
            this.textBoxAddFuel_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddFuel_BDS.Location = new System.Drawing.Point(250, 84);
            this.textBoxAddFuel_BDS.Name = "textBoxAddFuel_BDS";
            this.textBoxAddFuel_BDS.Size = new System.Drawing.Size(221, 22);
            this.textBoxAddFuel_BDS.TabIndex = 4;
            // 
            // textBoxAddKilometers_BDS
            // 
            this.textBoxAddKilometers_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddKilometers_BDS.Location = new System.Drawing.Point(477, 84);
            this.textBoxAddKilometers_BDS.Name = "textBoxAddKilometers_BDS";
            this.textBoxAddKilometers_BDS.Size = new System.Drawing.Size(207, 22);
            this.textBoxAddKilometers_BDS.TabIndex = 3;
            // 
            // textBoxAddExperience_BDS
            // 
            this.textBoxAddExperience_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddExperience_BDS.Location = new System.Drawing.Point(250, 39);
            this.textBoxAddExperience_BDS.Name = "textBoxAddExperience_BDS";
            this.textBoxAddExperience_BDS.Size = new System.Drawing.Size(221, 22);
            this.textBoxAddExperience_BDS.TabIndex = 2;
            // 
            // textBoxAddSeries_BDS
            // 
            this.textBoxAddSeries_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddSeries_BDS.Location = new System.Drawing.Point(477, 39);
            this.textBoxAddSeries_BDS.Name = "textBoxAddSeries_BDS";
            this.textBoxAddSeries_BDS.Size = new System.Drawing.Size(207, 22);
            this.textBoxAddSeries_BDS.TabIndex = 1;
            // 
            // textBoxAddFIO_BDS
            // 
            this.textBoxAddFIO_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddFIO_BDS.Location = new System.Drawing.Point(6, 39);
            this.textBoxAddFIO_BDS.Name = "textBoxAddFIO_BDS";
            this.textBoxAddFIO_BDS.Size = new System.Drawing.Size(238, 22);
            this.textBoxAddFIO_BDS.TabIndex = 0;
            // 
            // groupBoxDelete_BDS
            // 
            this.groupBoxDelete_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDelete_BDS.Controls.Add(this.buttonDeleteRent_BDS);
            this.groupBoxDelete_BDS.Controls.Add(this.labelDeleteRent_BDS);
            this.groupBoxDelete_BDS.Controls.Add(this.textBoxDeleteRent_BDS);
            this.groupBoxDelete_BDS.Location = new System.Drawing.Point(14, 621);
            this.groupBoxDelete_BDS.Name = "groupBoxDelete_BDS";
            this.groupBoxDelete_BDS.Size = new System.Drawing.Size(694, 94);
            this.groupBoxDelete_BDS.TabIndex = 13;
            this.groupBoxDelete_BDS.TabStop = false;
            this.groupBoxDelete_BDS.Text = "Удаление арендатора из базы данных";
            // 
            // buttonDeleteRent_BDS
            // 
            this.buttonDeleteRent_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteRent_BDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteRent_BDS.Image")));
            this.buttonDeleteRent_BDS.Location = new System.Drawing.Point(563, 13);
            this.buttonDeleteRent_BDS.Name = "buttonDeleteRent_BDS";
            this.buttonDeleteRent_BDS.Size = new System.Drawing.Size(121, 73);
            this.buttonDeleteRent_BDS.TabIndex = 11;
            this.toolTipInfo_BDS.SetToolTip(this.buttonDeleteRent_BDS, "Удалить арендатора из базы данных");
            this.buttonDeleteRent_BDS.UseVisualStyleBackColor = true;
            this.buttonDeleteRent_BDS.Click += new System.EventHandler(this.buttonDeleteRent_BDS_Click);
            // 
            // labelDeleteRent_BDS
            // 
            this.labelDeleteRent_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDeleteRent_BDS.AutoSize = true;
            this.labelDeleteRent_BDS.Location = new System.Drawing.Point(14, 30);
            this.labelDeleteRent_BDS.Name = "labelDeleteRent_BDS";
            this.labelDeleteRent_BDS.Size = new System.Drawing.Size(129, 17);
            this.labelDeleteRent_BDS.TabIndex = 9;
            this.labelDeleteRent_BDS.Text = "ФИО арендатора:";
            // 
            // textBoxDeleteRent_BDS
            // 
            this.textBoxDeleteRent_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDeleteRent_BDS.Location = new System.Drawing.Point(14, 50);
            this.textBoxDeleteRent_BDS.Name = "textBoxDeleteRent_BDS";
            this.textBoxDeleteRent_BDS.Size = new System.Drawing.Size(268, 22);
            this.textBoxDeleteRent_BDS.TabIndex = 2;
            // 
            // labelAddKilometers_BDS
            // 
            this.labelAddKilometers_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddKilometers_BDS.AutoSize = true;
            this.labelAddKilometers_BDS.Location = new System.Drawing.Point(477, 64);
            this.labelAddKilometers_BDS.Name = "labelAddKilometers_BDS";
            this.labelAddKilometers_BDS.Size = new System.Drawing.Size(83, 17);
            this.labelAddKilometers_BDS.TabIndex = 13;
            this.labelAddKilometers_BDS.Text = "Пробег, км:\r\n";
            // 
            // labelAddFuel_BDS
            // 
            this.labelAddFuel_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddFuel_BDS.AutoSize = true;
            this.labelAddFuel_BDS.Location = new System.Drawing.Point(250, 64);
            this.labelAddFuel_BDS.Name = "labelAddFuel_BDS";
            this.labelAddFuel_BDS.Size = new System.Drawing.Size(180, 17);
            this.labelAddFuel_BDS.TabIndex = 12;
            this.labelAddFuel_BDS.Text = "Расход топлива, л/100 км:";
            // 
            // labelAddMark_BDS
            // 
            this.labelAddMark_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddMark_BDS.AutoSize = true;
            this.labelAddMark_BDS.Location = new System.Drawing.Point(6, 64);
            this.labelAddMark_BDS.Name = "labelAddMark_BDS";
            this.labelAddMark_BDS.Size = new System.Drawing.Size(137, 17);
            this.labelAddMark_BDS.TabIndex = 11;
            this.labelAddMark_BDS.Text = "Марка автомобиля:";
            // 
            // groupBoxData_BDS
            // 
            this.groupBoxData_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_BDS.Controls.Add(this.dataGridViewData_BDS);
            this.groupBoxData_BDS.Location = new System.Drawing.Point(14, 12);
            this.groupBoxData_BDS.Name = "groupBoxData_BDS";
            this.groupBoxData_BDS.Size = new System.Drawing.Size(694, 385);
            this.groupBoxData_BDS.TabIndex = 14;
            this.groupBoxData_BDS.TabStop = false;
            this.groupBoxData_BDS.Text = "База авто";
            // 
            // groupBoxReg_BDS
            // 
            this.groupBoxReg_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReg_BDS.Controls.Add(this.buttonRegRent_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.labelAddKilometers_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.labelAddFuel_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.labelAddMark_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.labelAddSeries_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.labelAddExperience_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.labelAddFIO_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.textBoxAddMark_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.textBoxAddFuel_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.textBoxAddKilometers_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.textBoxAddExperience_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.textBoxAddSeries_BDS);
            this.groupBoxReg_BDS.Controls.Add(this.textBoxAddFIO_BDS);
            this.groupBoxReg_BDS.Location = new System.Drawing.Point(14, 403);
            this.groupBoxReg_BDS.Name = "groupBoxReg_BDS";
            this.groupBoxReg_BDS.Size = new System.Drawing.Size(694, 212);
            this.groupBoxReg_BDS.TabIndex = 12;
            this.groupBoxReg_BDS.TabStop = false;
            this.groupBoxReg_BDS.Text = "Регистрация новых арендаторов";
            // 
            // buttonRegRent_BDS
            // 
            this.buttonRegRent_BDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegRent_BDS.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegRent_BDS.Image")));
            this.buttonRegRent_BDS.Location = new System.Drawing.Point(6, 126);
            this.buttonRegRent_BDS.Name = "buttonRegRent_BDS";
            this.buttonRegRent_BDS.Size = new System.Drawing.Size(678, 73);
            this.buttonRegRent_BDS.TabIndex = 2;
            this.toolTipInfo_BDS.SetToolTip(this.buttonRegRent_BDS, "Сохранить арендатора в базу данных");
            this.buttonRegRent_BDS.UseVisualStyleBackColor = true;
            this.buttonRegRent_BDS.Click += new System.EventHandler(this.buttonRegRent_BDS_Click);
            // 
            // labelAverageExperience_BDS
            // 
            this.labelAverageExperience_BDS.AutoSize = true;
            this.labelAverageExperience_BDS.Location = new System.Drawing.Point(332, 114);
            this.labelAverageExperience_BDS.Name = "labelAverageExperience_BDS";
            this.labelAverageExperience_BDS.Size = new System.Drawing.Size(221, 17);
            this.labelAverageExperience_BDS.TabIndex = 8;
            this.labelAverageExperience_BDS.Text = "Средний стаж арендаторов, лет";
            // 
            // textBoxAverageExperience_BDS
            // 
            this.textBoxAverageExperience_BDS.Location = new System.Drawing.Point(332, 134);
            this.textBoxAverageExperience_BDS.Name = "textBoxAverageExperience_BDS";
            this.textBoxAverageExperience_BDS.ReadOnly = true;
            this.textBoxAverageExperience_BDS.Size = new System.Drawing.Size(301, 22);
            this.textBoxAverageExperience_BDS.TabIndex = 7;
            // 
            // labelAverageKilometers_BDS
            // 
            this.labelAverageKilometers_BDS.AutoSize = true;
            this.labelAverageKilometers_BDS.Location = new System.Drawing.Point(332, 69);
            this.labelAverageKilometers_BDS.Name = "labelAverageKilometers_BDS";
            this.labelAverageKilometers_BDS.Size = new System.Drawing.Size(251, 17);
            this.labelAverageKilometers_BDS.TabIndex = 6;
            this.labelAverageKilometers_BDS.Text = "Средний пробег авто в компании, км";
            // 
            // textBoxAverageKilometers_BDS
            // 
            this.textBoxAverageKilometers_BDS.Location = new System.Drawing.Point(332, 89);
            this.textBoxAverageKilometers_BDS.Name = "textBoxAverageKilometers_BDS";
            this.textBoxAverageKilometers_BDS.ReadOnly = true;
            this.textBoxAverageKilometers_BDS.Size = new System.Drawing.Size(301, 22);
            this.textBoxAverageKilometers_BDS.TabIndex = 5;
            // 
            // labelAverageFuel_BDS
            // 
            this.labelAverageFuel_BDS.AutoSize = true;
            this.labelAverageFuel_BDS.Location = new System.Drawing.Point(332, 21);
            this.labelAverageFuel_BDS.Name = "labelAverageFuel_BDS";
            this.labelAverageFuel_BDS.Size = new System.Drawing.Size(301, 17);
            this.labelAverageFuel_BDS.TabIndex = 4;
            this.labelAverageFuel_BDS.Text = "Средний расход топлива авто в компании, л";
            // 
            // groupBoxStats_BDS
            // 
            this.groupBoxStats_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStats_BDS.Controls.Add(this.labelAverageExperience_BDS);
            this.groupBoxStats_BDS.Controls.Add(this.textBoxAverageExperience_BDS);
            this.groupBoxStats_BDS.Controls.Add(this.labelAverageKilometers_BDS);
            this.groupBoxStats_BDS.Controls.Add(this.textBoxAverageKilometers_BDS);
            this.groupBoxStats_BDS.Controls.Add(this.labelAverageFuel_BDS);
            this.groupBoxStats_BDS.Controls.Add(this.buttonViewStats_BDS);
            this.groupBoxStats_BDS.Controls.Add(this.textBoxAverageFuel_BDS);
            this.groupBoxStats_BDS.Location = new System.Drawing.Point(714, 526);
            this.groupBoxStats_BDS.Name = "groupBoxStats_BDS";
            this.groupBoxStats_BDS.Size = new System.Drawing.Size(683, 189);
            this.groupBoxStats_BDS.TabIndex = 11;
            this.groupBoxStats_BDS.TabStop = false;
            this.groupBoxStats_BDS.Text = "Статистика";
            // 
            // buttonViewStats_BDS
            // 
            this.buttonViewStats_BDS.Location = new System.Drawing.Point(6, 21);
            this.buttonViewStats_BDS.Name = "buttonViewStats_BDS";
            this.buttonViewStats_BDS.Size = new System.Drawing.Size(228, 68);
            this.buttonViewStats_BDS.TabIndex = 2;
            this.buttonViewStats_BDS.Text = "Отобразить статистику";
            this.buttonViewStats_BDS.UseVisualStyleBackColor = true;
            this.buttonViewStats_BDS.Click += new System.EventHandler(this.buttonViewStats_BDS_Click);
            // 
            // textBoxAverageFuel_BDS
            // 
            this.textBoxAverageFuel_BDS.Location = new System.Drawing.Point(332, 41);
            this.textBoxAverageFuel_BDS.Name = "textBoxAverageFuel_BDS";
            this.textBoxAverageFuel_BDS.ReadOnly = true;
            this.textBoxAverageFuel_BDS.Size = new System.Drawing.Size(301, 22);
            this.textBoxAverageFuel_BDS.TabIndex = 3;
            // 
            // buttonViewChart_BDS
            // 
            this.buttonViewChart_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewChart_BDS.Location = new System.Drawing.Point(714, 12);
            this.buttonViewChart_BDS.Name = "buttonViewChart_BDS";
            this.buttonViewChart_BDS.Size = new System.Drawing.Size(667, 40);
            this.buttonViewChart_BDS.TabIndex = 10;
            this.buttonViewChart_BDS.Text = "Отобразить график \"Количество машин/Марка\"";
            this.buttonViewChart_BDS.UseVisualStyleBackColor = true;
            this.buttonViewChart_BDS.Click += new System.EventHandler(this.buttonViewChart_BDS_Click);
            // 
            // chartInfo_BDS
            // 
            this.chartInfo_BDS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartInfo_BDS.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartInfo_BDS.Legends.Add(legend1);
            this.chartInfo_BDS.Location = new System.Drawing.Point(714, 58);
            this.chartInfo_BDS.Name = "chartInfo_BDS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo_BDS.Series.Add(series1);
            this.chartInfo_BDS.Size = new System.Drawing.Size(667, 462);
            this.chartInfo_BDS.TabIndex = 9;
            this.chartInfo_BDS.Text = "chart1";
            // 
            // toolTipInfo_BDS
            // 
            this.toolTipInfo_BDS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo_BDS.ToolTipTitle = "Подсказка";
            // 
            // FormStatsAndAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 727);
            this.Controls.Add(this.groupBoxDelete_BDS);
            this.Controls.Add(this.groupBoxData_BDS);
            this.Controls.Add(this.groupBoxReg_BDS);
            this.Controls.Add(this.groupBoxStats_BDS);
            this.Controls.Add(this.buttonViewChart_BDS);
            this.Controls.Add(this.chartInfo_BDS);
            this.Name = "FormStatsAndAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика и добавление новых арендаторов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BDS)).EndInit();
            this.groupBoxDelete_BDS.ResumeLayout(false);
            this.groupBoxDelete_BDS.PerformLayout();
            this.groupBoxData_BDS.ResumeLayout(false);
            this.groupBoxReg_BDS.ResumeLayout(false);
            this.groupBoxReg_BDS.PerformLayout();
            this.groupBoxStats_BDS.ResumeLayout(false);
            this.groupBoxStats_BDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_BDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData_BDS;
        private System.Windows.Forms.Label labelAddSeries_BDS;
        private System.Windows.Forms.Label labelAddExperience_BDS;
        private System.Windows.Forms.Label labelAddFIO_BDS;
        private System.Windows.Forms.TextBox textBoxAddMark_BDS;
        private System.Windows.Forms.TextBox textBoxAddFuel_BDS;
        private System.Windows.Forms.TextBox textBoxAddKilometers_BDS;
        private System.Windows.Forms.TextBox textBoxAddExperience_BDS;
        private System.Windows.Forms.TextBox textBoxAddSeries_BDS;
        private System.Windows.Forms.TextBox textBoxAddFIO_BDS;
        private System.Windows.Forms.GroupBox groupBoxDelete_BDS;
        private System.Windows.Forms.Button buttonDeleteRent_BDS;
        private System.Windows.Forms.Label labelDeleteRent_BDS;
        private System.Windows.Forms.TextBox textBoxDeleteRent_BDS;
        private System.Windows.Forms.Label labelAddKilometers_BDS;
        private System.Windows.Forms.Label labelAddFuel_BDS;
        private System.Windows.Forms.Label labelAddMark_BDS;
        private System.Windows.Forms.GroupBox groupBoxData_BDS;
        private System.Windows.Forms.GroupBox groupBoxReg_BDS;
        private System.Windows.Forms.Button buttonRegRent_BDS;
        private System.Windows.Forms.Label labelAverageExperience_BDS;
        private System.Windows.Forms.TextBox textBoxAverageExperience_BDS;
        private System.Windows.Forms.Label labelAverageKilometers_BDS;
        private System.Windows.Forms.TextBox textBoxAverageKilometers_BDS;
        private System.Windows.Forms.Label labelAverageFuel_BDS;
        private System.Windows.Forms.GroupBox groupBoxStats_BDS;
        private System.Windows.Forms.Button buttonViewStats_BDS;
        private System.Windows.Forms.TextBox textBoxAverageFuel_BDS;
        private System.Windows.Forms.Button buttonViewChart_BDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_BDS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData_BDS;
        private System.Windows.Forms.ToolTip toolTipInfo_BDS;
    }
}