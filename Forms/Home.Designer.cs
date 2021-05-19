
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
            this.btnGetEmpoloyeers = new NaveUI.Components.naveButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new NaveUI.Components.naveButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetEmpoloyeers
            // 
            this.btnGetEmpoloyeers.FlatAppearance.BorderSize = 0;
            this.btnGetEmpoloyeers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGetEmpoloyeers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGetEmpoloyeers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetEmpoloyeers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetEmpoloyeers.Location = new System.Drawing.Point(12, 321);
            this.btnGetEmpoloyeers.Name = "btnGetEmpoloyeers";
            this.btnGetEmpoloyeers.NaveBorderColor = System.Drawing.Color.White;
            this.btnGetEmpoloyeers.NaveButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(202)))));
            this.btnGetEmpoloyeers.NaveOnHoverBorderColor = System.Drawing.Color.White;
            this.btnGetEmpoloyeers.NaveOnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(187)))));
            this.btnGetEmpoloyeers.NaveOnHoverTextColor = System.Drawing.Color.White;
            this.btnGetEmpoloyeers.Size = new System.Drawing.Size(637, 36);
            this.btnGetEmpoloyeers.TabIndex = 0;
            this.btnGetEmpoloyeers.Text = "Buscar Funcionários";
            this.btnGetEmpoloyeers.TextColor = System.Drawing.Color.White;
            this.btnGetEmpoloyeers.UseVisualStyleBackColor = true;
            this.btnGetEmpoloyeers.Click += new System.EventHandler(this.btnGetEmpoloyeers_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 80);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(606, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.NaveBorderColor = System.Drawing.Color.White;
            this.btnClose.NaveButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(202)))));
            this.btnClose.NaveOnHoverBorderColor = System.Drawing.Color.White;
            this.btnClose.NaveOnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(187)))));
            this.btnClose.NaveOnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(43, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(637, 229);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 367);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetEmpoloyeers);
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

        private NaveUI.Components.naveButton btnGetEmpoloyeers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private NaveUI.Components.naveButton btnClose;
    }
}