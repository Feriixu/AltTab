using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltTab
{
    public partial class Main : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on WS_EX_TOOLWINDOW style bit
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
        public Main()
        {
            InitializeComponent();
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.Hide();
            this.timerAltTab.Enabled = true;
            MessageBox.Show("Unecpected Runtime Error!\nApplication could not be started!\n0xab2298f2", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("%{TAB}");
        }
    }
}
