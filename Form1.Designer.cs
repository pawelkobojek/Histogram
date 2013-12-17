namespace GKLab4
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerContent = new System.Windows.Forms.SplitContainer();
            this.splitContainerImages = new System.Windows.Forms.SplitContainer();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBoxStretch = new System.Windows.Forms.PictureBox();
            this.splitContainerCharts = new System.Windows.Forms.SplitContainer();
            this.buttonDoIt = new System.Windows.Forms.Button();
            this.chartOrigin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStreched = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.checkBoxG = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImages)).BeginInit();
            this.splitContainerImages.Panel1.SuspendLayout();
            this.splitContainerImages.Panel2.SuspendLayout();
            this.splitContainerImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharts)).BeginInit();
            this.splitContainerCharts.Panel1.SuspendLayout();
            this.splitContainerCharts.Panel2.SuspendLayout();
            this.splitContainerCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStreched)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerContent);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxB);
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxG);
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxR);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonDoIt);
            this.splitContainerMain.Size = new System.Drawing.Size(967, 486);
            this.splitContainerMain.SplitterDistance = 413;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerContent
            // 
            this.splitContainerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerContent.Location = new System.Drawing.Point(0, 0);
            this.splitContainerContent.Name = "splitContainerContent";
            this.splitContainerContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerContent.Panel1
            // 
            this.splitContainerContent.Panel1.Controls.Add(this.splitContainerImages);
            // 
            // splitContainerContent.Panel2
            // 
            this.splitContainerContent.Panel2.Controls.Add(this.splitContainerCharts);
            this.splitContainerContent.Size = new System.Drawing.Size(967, 413);
            this.splitContainerContent.SplitterDistance = 255;
            this.splitContainerContent.TabIndex = 0;
            // 
            // splitContainerImages
            // 
            this.splitContainerImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerImages.Location = new System.Drawing.Point(0, 0);
            this.splitContainerImages.Name = "splitContainerImages";
            // 
            // splitContainerImages.Panel1
            // 
            this.splitContainerImages.Panel1.Controls.Add(this.pictureBoxOrigin);
            // 
            // splitContainerImages.Panel2
            // 
            this.splitContainerImages.Panel2.Controls.Add(this.pictureBoxStretch);
            this.splitContainerImages.Size = new System.Drawing.Size(967, 255);
            this.splitContainerImages.SplitterDistance = 485;
            this.splitContainerImages.TabIndex = 0;
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOrigin.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(485, 255);
            this.pictureBoxOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrigin.TabIndex = 0;
            this.pictureBoxOrigin.TabStop = false;
            // 
            // pictureBoxStretch
            // 
            this.pictureBoxStretch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxStretch.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStretch.Name = "pictureBoxStretch";
            this.pictureBoxStretch.Size = new System.Drawing.Size(478, 255);
            this.pictureBoxStretch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStretch.TabIndex = 0;
            this.pictureBoxStretch.TabStop = false;
            // 
            // splitContainerCharts
            // 
            this.splitContainerCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCharts.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCharts.Name = "splitContainerCharts";
            // 
            // splitContainerCharts.Panel1
            // 
            this.splitContainerCharts.Panel1.Controls.Add(this.chartOrigin);
            // 
            // splitContainerCharts.Panel2
            // 
            this.splitContainerCharts.Panel2.Controls.Add(this.chartStreched);
            this.splitContainerCharts.Size = new System.Drawing.Size(967, 154);
            this.splitContainerCharts.SplitterDistance = 485;
            this.splitContainerCharts.TabIndex = 0;
            // 
            // buttonDoIt
            // 
            this.buttonDoIt.Location = new System.Drawing.Point(13, 14);
            this.buttonDoIt.Name = "buttonDoIt";
            this.buttonDoIt.Size = new System.Drawing.Size(75, 23);
            this.buttonDoIt.TabIndex = 0;
            this.buttonDoIt.Text = "Do it";
            this.buttonDoIt.UseVisualStyleBackColor = true;
            this.buttonDoIt.Click += new System.EventHandler(this.buttonDoIt_Click);
            // 
            // chartOrigin
            // 
            chartArea11.Name = "ChartArea1";
            this.chartOrigin.ChartAreas.Add(chartArea11);
            this.chartOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Name = "Legend1";
            this.chartOrigin.Legends.Add(legend11);
            this.chartOrigin.Location = new System.Drawing.Point(0, 0);
            this.chartOrigin.Name = "chartOrigin";
            this.chartOrigin.Size = new System.Drawing.Size(485, 154);
            this.chartOrigin.TabIndex = 0;
            this.chartOrigin.Text = "chart1";
            // 
            // chartStreched
            // 
            chartArea12.Name = "ChartArea1";
            this.chartStreched.ChartAreas.Add(chartArea12);
            this.chartStreched.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.Name = "Legend1";
            this.chartStreched.Legends.Add(legend12);
            this.chartStreched.Location = new System.Drawing.Point(0, 0);
            this.chartStreched.Name = "chartStreched";
            this.chartStreched.Size = new System.Drawing.Size(478, 154);
            this.chartStreched.TabIndex = 0;
            this.chartStreched.Text = "chart1";
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Checked = true;
            this.checkBoxR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxR.Location = new System.Drawing.Point(136, 15);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(40, 21);
            this.checkBoxR.TabIndex = 1;
            this.checkBoxR.Text = "R";
            this.checkBoxR.UseVisualStyleBackColor = true;
            this.checkBoxR.CheckedChanged += new System.EventHandler(this.checkBoxR_CheckedChanged);
            // 
            // checkBoxG
            // 
            this.checkBoxG.AutoSize = true;
            this.checkBoxG.Checked = true;
            this.checkBoxG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxG.Location = new System.Drawing.Point(241, 14);
            this.checkBoxG.Name = "checkBoxG";
            this.checkBoxG.Size = new System.Drawing.Size(41, 21);
            this.checkBoxG.TabIndex = 2;
            this.checkBoxG.Text = "G";
            this.checkBoxG.UseVisualStyleBackColor = true;
            this.checkBoxG.CheckedChanged += new System.EventHandler(this.checkBoxG_CheckedChanged);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Checked = true;
            this.checkBoxB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxB.Location = new System.Drawing.Point(346, 15);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(39, 21);
            this.checkBoxB.TabIndex = 3;
            this.checkBoxB.Text = "B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            this.checkBoxB.CheckedChanged += new System.EventHandler(this.checkBoxB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 486);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            this.splitContainerImages.Panel1.ResumeLayout(false);
            this.splitContainerImages.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImages)).EndInit();
            this.splitContainerImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretch)).EndInit();
            this.splitContainerCharts.Panel1.ResumeLayout(false);
            this.splitContainerCharts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharts)).EndInit();
            this.splitContainerCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStreched)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerContent;
        private System.Windows.Forms.SplitContainer splitContainerImages;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.PictureBox pictureBoxStretch;
        private System.Windows.Forms.SplitContainer splitContainerCharts;
        private System.Windows.Forms.Button buttonDoIt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrigin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStreched;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxG;
        private System.Windows.Forms.CheckBox checkBoxR;
    }
}

