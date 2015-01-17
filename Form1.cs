using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary <String,int > d1 = new Dictionary <String,int> ();
            d1.Add("saruchi",1);
            for (int i = 0; i < d1.Count; i++)
            {
                d1.Add("abc"+ i,i);
                
            }


        }
    }
}
