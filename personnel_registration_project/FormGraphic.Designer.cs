namespace personnel_registration_project
{
    partial class FormGraphic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grfsehir = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grfdurum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grfortmaas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grfmeslek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grfsehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfdurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfortmaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfmeslek)).BeginInit();
            this.SuspendLayout();
            // 
            // grfsehir
            // 
            chartArea1.Name = "ChartArea1";
            this.grfsehir.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grfsehir.Legends.Add(legend1);
            this.grfsehir.Location = new System.Drawing.Point(0, 0);
            this.grfsehir.Name = "grfsehir";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sehir";
            this.grfsehir.Series.Add(series1);
            this.grfsehir.Size = new System.Drawing.Size(398, 242);
            this.grfsehir.TabIndex = 0;
            // 
            // grfdurum
            // 
            chartArea2.Name = "ChartArea1";
            this.grfdurum.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grfdurum.Legends.Add(legend2);
            this.grfdurum.Location = new System.Drawing.Point(404, 0);
            this.grfdurum.Name = "grfdurum";
            this.grfdurum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Durum";
            this.grfdurum.Series.Add(series2);
            this.grfdurum.Size = new System.Drawing.Size(398, 242);
            this.grfdurum.TabIndex = 1;
            // 
            // grfortmaas
            // 
            chartArea3.Name = "ChartArea1";
            this.grfortmaas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grfortmaas.Legends.Add(legend3);
            this.grfortmaas.Location = new System.Drawing.Point(0, 248);
            this.grfortmaas.Name = "grfortmaas";
            this.grfortmaas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "OrtalamaMaas";
            this.grfortmaas.Series.Add(series3);
            this.grfortmaas.Size = new System.Drawing.Size(398, 242);
            this.grfortmaas.TabIndex = 2;
            // 
            // grfmeslek
            // 
            chartArea4.Name = "ChartArea1";
            this.grfmeslek.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.grfmeslek.Legends.Add(legend4);
            this.grfmeslek.Location = new System.Drawing.Point(404, 248);
            this.grfmeslek.Name = "grfmeslek";
            this.grfmeslek.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Meslek";
            series4.ShadowColor = System.Drawing.Color.Red;
            this.grfmeslek.Series.Add(series4);
            this.grfmeslek.Size = new System.Drawing.Size(398, 242);
            this.grfmeslek.TabIndex = 3;
            // 
            // FormGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(802, 487);
            this.Controls.Add(this.grfmeslek);
            this.Controls.Add(this.grfortmaas);
            this.Controls.Add(this.grfdurum);
            this.Controls.Add(this.grfsehir);
            this.Name = "FormGrafikler";
            this.Text = "FormGrafikler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGrafikler_FormClosed);
            this.Load += new System.EventHandler(this.FormGrafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grfsehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfdurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfortmaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfmeslek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grfsehir;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfdurum;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfortmaas;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfmeslek;
    }
}