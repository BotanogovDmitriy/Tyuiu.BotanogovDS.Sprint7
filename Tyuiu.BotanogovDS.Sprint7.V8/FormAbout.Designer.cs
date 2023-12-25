
namespace Tyuiu.BotanogovDS.Sprint7.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_BDS = new System.Windows.Forms.Button();
            this.labelInfo_BDS = new System.Windows.Forms.Label();
            this.pictureBoxPhoto_BDS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_BDS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_BDS
            // 
            this.buttonOK_BDS.Location = new System.Drawing.Point(461, 171);
            this.buttonOK_BDS.Name = "buttonOK_BDS";
            this.buttonOK_BDS.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_BDS.TabIndex = 11;
            this.buttonOK_BDS.Text = "OK";
            this.buttonOK_BDS.UseVisualStyleBackColor = true;
            this.buttonOK_BDS.Click += new System.EventHandler(this.buttonOK_FDR_Click);
            // 
            // labelInfo_BDS
            // 
            this.labelInfo_BDS.AutoSize = true;
            this.labelInfo_BDS.Location = new System.Drawing.Point(168, 9);
            this.labelInfo_BDS.Name = "labelInfo_BDS";
            this.labelInfo_BDS.Size = new System.Drawing.Size(368, 170);
            this.labelInfo_BDS.TabIndex = 10;
            this.labelInfo_BDS.Text = resources.GetString("labelInfo_BDS.Text");
            // 
            // pictureBoxPhoto_BDS
            // 
            this.pictureBoxPhoto_BDS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto_BDS.Image")));
            this.pictureBoxPhoto_BDS.Location = new System.Drawing.Point(7, 9);
            this.pictureBoxPhoto_BDS.Name = "pictureBoxPhoto_BDS";
            this.pictureBoxPhoto_BDS.Size = new System.Drawing.Size(120, 152);
            this.pictureBoxPhoto_BDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPhoto_BDS.TabIndex = 9;
            this.pictureBoxPhoto_BDS.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 206);
            this.Controls.Add(this.buttonOK_BDS);
            this.Controls.Add(this.labelInfo_BDS);
            this.Controls.Add(this.pictureBoxPhoto_BDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_BDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_BDS;
        private System.Windows.Forms.Label labelInfo_BDS;
        private System.Windows.Forms.PictureBox pictureBoxPhoto_BDS;
    }
}