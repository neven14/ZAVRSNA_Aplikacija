
namespace ZavrsnaAplikacija
{
    partial class Lansiraj
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
            this.buttonLansiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLansiraj
            // 
            this.buttonLansiraj.Location = new System.Drawing.Point(97, 103);
            this.buttonLansiraj.Name = "buttonLansiraj";
            this.buttonLansiraj.Size = new System.Drawing.Size(330, 119);
            this.buttonLansiraj.TabIndex = 0;
            this.buttonLansiraj.Text = "LANSIRAJ";
            this.buttonLansiraj.UseVisualStyleBackColor = true;
            // 
            // Lansiraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 322);
            this.Controls.Add(this.buttonLansiraj);
            this.Name = "Lansiraj";
            this.Text = "Lansiraj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLansiraj;
    }
}