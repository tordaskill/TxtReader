using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtReader
{   
    public partial class Form1 : Form
    {
        logic logic = new logic(); //class logic
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            logic.path = txtPath.Text; //two way binding :)
            if (logic.path != "")
            {
                logic.findContent();
                txtContent.Text = logic.content; //show all content in txt filed
            }
            else
            {
                MessageBox.Show("Missing path to folder with TXT files");
            }
        }
    }
}
