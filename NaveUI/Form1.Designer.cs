
namespace NaveUI
{
    partial class Form1
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
            this.naveButton1 = new NaveUI.Components.naveButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naveButton1
            // 
            this.naveButton1.FlatAppearance.BorderSize = 0;
            this.naveButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.naveButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.naveButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naveButton1.Location = new System.Drawing.Point(156, 151);
            this.naveButton1.Name = "naveButton1";
            this.naveButton1.NaveBorderColor = System.Drawing.Color.White;
            this.naveButton1.NaveButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(202)))));
            this.naveButton1.NaveOnHoverBorderColor = System.Drawing.Color.White;
            this.naveButton1.NaveOnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.naveButton1.NaveOnHoverTextColor = System.Drawing.Color.White;
            this.naveButton1.Size = new System.Drawing.Size(75, 23);
            this.naveButton1.TabIndex = 0;
            this.naveButton1.Text = "naveButton1";
            this.naveButton1.TextColor = System.Drawing.Color.White;
            this.naveButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.naveButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.naveButton naveButton1;
        private System.Windows.Forms.Button button1;
    }
}

