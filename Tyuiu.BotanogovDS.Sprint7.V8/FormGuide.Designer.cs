
namespace Tyuiu.BotanogovDS.Sprint7.V8
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.labelGuide_BDS = new System.Windows.Forms.Label();
            this.buttonOK_BDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGuide_BDS
            // 
            this.labelGuide_BDS.AutoSize = true;
            this.labelGuide_BDS.Location = new System.Drawing.Point(12, 9);
            this.labelGuide_BDS.Name = "labelGuide_BDS";
            this.labelGuide_BDS.Size = new System.Drawing.Size(567, 289);
            this.labelGuide_BDS.TabIndex = 0;
            this.labelGuide_BDS.Text = resources.GetString("labelGuide_BDS.Text");
            // 
            // buttonOK_BDS
            // 
            this.buttonOK_BDS.Location = new System.Drawing.Point(531, 285);
            this.buttonOK_BDS.Name = "buttonOK_BDS";
            this.buttonOK_BDS.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_BDS.TabIndex = 1;
            this.buttonOK_BDS.TabStop = false;
            this.buttonOK_BDS.Text = "OK";
            this.buttonOK_BDS.UseVisualStyleBackColor = true;
            this.buttonOK_BDS.Click += new System.EventHandler(this.buttonOK_BDS_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 320);
            this.Controls.Add(this.buttonOK_BDS);
            this.Controls.Add(this.labelGuide_BDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGuide_BDS;
        private System.Windows.Forms.Button buttonOK_BDS;
    }
}