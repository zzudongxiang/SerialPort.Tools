using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortTools
{
    public partial class frmWaiting : Form
    {
        public frmWaiting()
        {
            InitializeComponent();
            frmNew fn = new frmNew();
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            panel1.Controls.Add(fn);
        }

        bool isDown = false;

        Point currentlocation = new Point(0, 0);

        private void frmWaiting_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            currentlocation = MousePosition;
        }

        private void frmWaiting_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                Left += MousePosition.X - currentlocation.X;
                Top += MousePosition.Y - currentlocation.Y;
                currentlocation = MousePosition;
            }
        }

        private void frmWaiting_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }
    }
}
