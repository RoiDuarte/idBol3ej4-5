using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol3ej5
{
    public partial class Form3 : Form
    {

        
        public Form3()
        {
            InitializeComponent();
            String fullname= "D:\\DAM\\segundo\\ID\\ejercicio5.txt";

            if (File.Exists(fullname))
            {
                StreamReader sr = new StreamReader(fullname);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
