using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaJanelaFlutuante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point p = new Point(0, 370);
            this.DesktopLocation = p;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = new Point(this.DesktopLocation.X + 1, this.DesktopLocation.Y);
            this.DesktopLocation = p;
            if(p.X==550)
            {
                timer1.Stop();
            }
        }
    }
}
