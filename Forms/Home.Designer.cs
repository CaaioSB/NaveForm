
namespace NaveForm.Forms
{
    partial class Home
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
            this.naveButton1 = new NaveUI.Components.naveButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // naveButton1
            // 
            this.naveButton1.FlatAppearance.BorderSize = 0;
            this.naveButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.naveButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.naveButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naveButton1.Location = new System.Drawing.Point(245, 286);
            this.naveButton1.Name = "naveButton1";
            this.naveButton1.NaveBorderColor = System.Drawing.Color.White;
            this.naveButton1.NaveButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(202)))));
            this.naveButton1.NaveOnHoverBorderColor = System.Drawing.Color.White;
            this.naveButton1.NaveOnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.naveButton1.NaveOnHoverTextColor = System.Drawing.Color.White;
            this.naveButton1.Size = new System.Drawing.Size(165, 36);
            this.naveButton1.TabIndex = 0;
            this.naveButton1.Text = "Entrar em contato";
            this.naveButton1.TextColor = System.Drawing.Color.White;
            this.naveButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 80);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NaveForm.Properties.Resources.logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.naveButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar em contato";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NaveUI.Components.naveButton naveButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}