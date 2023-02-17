using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedHMICS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void digitalPanelMeter1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = digitalPanelMeter1.Value.ToString();
        }

      
    }
}
