using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_MENU1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(topLevelMenu.Text))
            {
                ToolStripItem mainMenuItem = new ToolStripDropDownButton(topLevelMenu.Text);
                menuStrip1.Items.Add(mainMenuItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(subItem.Text))
            {
                foreach(ToolStripDropDownButton item in menuStrip1.Items)
                {
                    if (item.Text == topLevelMenu.Text)
                        item.DropDownItems.Add(subItem.Text);
                }
            }
        }
    }
}
