using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOCK
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            richTextBox1.Text += "\n--------------------------------------------------------------------------------------------------\n";
            richTextBox1.Text += Help_class.dateTime.ToString() +"\t" + Help_class.description + (Help_class.repeat? "\tповторять": "\tодноразовый");


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now == Help_class.dateTime)
            {
                MessageBox.Show("Сработало");
                if(Help_class.repeat == false)
                {

                }
            }
        }
    }
}
