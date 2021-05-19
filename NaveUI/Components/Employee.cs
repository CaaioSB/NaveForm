using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NaveUI.Components
{
    public class naveEmployee : Panel
    {
        private string _employeePhotoUrl = "https://www.timeshighereducation.com/sites/default/files/byline_photos/anonymous-user-gravatar_0.png";
        private string _employeeName = "";
        private string _employeeRole = "";

        public naveEmployee()
        {
            Width = 150;
            Height = 200;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            PictureBox employeeImage = new PictureBox();
            Label employeeName = new Label();
            Label employeeRole = new Label();

            employeeImage.Width = 150;
            employeeImage.Height = 150;
            employeeImage.ImageLocation = _employeePhotoUrl;
            employeeImage.Location = new Point(0, 0);
            employeeImage.SizeMode = PictureBoxSizeMode.Zoom;

            employeeName.Text = _employeeName;
            employeeName.Location = new Point(0, 152);
            employeeName.ForeColor = Color.Black;
            employeeName.Font = new Font("Century Gothic", 10F, FontStyle.Bold);

            employeeRole.Text = _employeeRole;
            employeeRole.Width = 150;
            employeeRole.Location = new Point(0, 172);
            employeeRole.ForeColor = Color.Black;
            employeeRole.Font = new Font("Century Gothic", 9F);

            Controls.Add(employeeImage);
            Controls.Add(employeeName);
            Controls.Add(employeeRole);
        }

        public string EmployeePhotoUrl
        {
            get => _employeePhotoUrl;
            set
            {
                _employeePhotoUrl = value;
                Invalidate();
            }
        }

        public string EmployeeName
        {
            get => _employeeName;
            set
            {
                _employeeName = value;
                Invalidate();
            }
        }

        public string EmployeeRole
        {
            get => _employeeRole;
            set
            {
                _employeeRole = value;
                Invalidate();
            }
        }
    }
}
