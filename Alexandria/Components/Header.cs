using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Components
{
    public partial class Header : UserControl
    {
        private Point MouseDownPoint;

        public Header()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Mouse_Enter(object sender, EventArgs e)
        {
            this.btnClose.BackColor = Color.FromArgb(100, 255, 0, 0);
        }

        private void btnClose_Mouse_Leave(object sender, EventArgs e)
        {
            this.btnClose.BackColor = Color.Transparent;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Form parent = (Form)this.Parent;
            parent.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_Mouse_Enter(object sender, EventArgs e)
        {
            this.btnMinimize.BackColor = Color.FromArgb(30, 179, 179, 179);
        }

        private void btnMinimize_Mouse_Leave(object sender, EventArgs e)
        {
            this.btnMinimize.BackColor = Color.Transparent;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseDownPoint = new Point(e.X, e.Y);
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.MouseDownPoint.IsEmpty)
                return;
            this.Parent.Location = new Point(this.Parent.Location.X + (e.X - this.MouseDownPoint.X), this.Parent.Location.Y + (e.Y - this.MouseDownPoint.Y));
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseDownPoint = Point.Empty;
        }
    }
}
