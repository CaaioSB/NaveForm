using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NaveUI.Components
{
    public class naveEmployee : Panel
    {
        public naveEmployee()
        {
            Width = 150;
            Height = 200;

            PictureBox employeeImage = new PictureBox();
            Label employeeName = new Label();
            Label employeeRole = new Label();

            employeeImage.Width = 150;
            employeeImage.Height = 150;
            employeeImage.ImageLocation = "https://avatars.githubusercontent.com/u/34246280?v=4";
            employeeImage.Location = new Point(0, 0);
            employeeImage.SizeMode = PictureBoxSizeMode.Zoom;

            employeeName.Text = "Caio da Silva Batista";
            employeeName.Location = new Point(0, 152);
            employeeName.ForeColor = Color.Black;
            employeeName.Font = new Font("Century Gothic", 10F, FontStyle.Bold);

            employeeRole.Text = "Front-end Developer";
            employeeRole.Width = 150;
            employeeRole.Location = new Point(0, 172);
            employeeRole.ForeColor = Color.Black;
            employeeRole.Font = new Font("Century Gothic", 9F);


            Controls.Add(employeeImage);
            Controls.Add(employeeName);
            Controls.Add(employeeRole);
        }
    }
}
