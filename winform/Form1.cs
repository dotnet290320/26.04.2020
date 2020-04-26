using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinForm2604
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            // what to do .. ?
            //MessageBox.Show("form was loaded...");

            Debug.WriteLine("form was loaded...");
        }

        private void timeBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("time button was clicked...");
            timeLbl.Text = DateTime.Now.ToString();
        }

        private void power2Btn_Click(object sender, EventArgs e)
        {
            int number = 0;

            if (int.TryParse(userNumberTxt.Text, out number))
            {
                long result = number * number;
                resultLbl.Text = Convert.ToString(result); // result.ToString();
                resultLbl.Visible = true;
            }
            else
            {
                MessageBox.Show("the number in the text box is not valid!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            userNumberTxt.Text = "";
            //userNumberTxt.Clear();
            resultLbl.Visible = false;
        }
    }
}
