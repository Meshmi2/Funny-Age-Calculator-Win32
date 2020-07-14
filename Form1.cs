using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funnny_Age_Calculator_Win32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Read The Birthday
            int year = Convert.ToInt32(dateTimePicker1.Value.Year.ToString());
            int month = Convert.ToInt32(dateTimePicker1.Value.Month.ToString());
            int day = Convert.ToInt32(dateTimePicker1.Value.Day.ToString());
        
            //Now Time


            int yearn = Convert.ToInt32(dateTimePicker2.Value.Year.ToString());
            int monthn = Convert.ToInt32(dateTimePicker2.Value.Month.ToString());
            int dayn = Convert.ToInt32(dateTimePicker2.Value.Day.ToString());
            //Calculate Between 2 Dates
            int years = (yearn - year);
            int months = (years * 12 + (monthn - month));
            int days = (months * 30 + (years * 12) +(dayn - day));
            //Display Year,Month,Days...

            string message = "You Have "+ years + " Year";
            const string caption = "Year";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            string messageh = "You Have" + months +" Month";
            const string captionh = "Month";
            var resulth = MessageBox.Show(messageh, captionh,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            string messagem = "You Have"+ days +" Days";
            const string captionm = "Days";
            var resultm = MessageBox.Show(messagem, captionm,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }
    }
}
