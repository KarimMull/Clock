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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DateTime clock = Convert.ToDateTime(textBox_time_set.Text);
            string description = textBox_description.Text;
            bool repeat = radioButton_repeat.Checked;
            Help_class.dateTime = clock;
            Help_class.description = description;
            Help_class.repeat = repeat;
            this.Close();


        }
    }
}
