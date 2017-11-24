using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop1_Click(object sender, EventArgs e)
            //for
        {   // remove the intructions from the label
            lblMessage1.Text = "";

            // use a loop to display #'s from 100 to 120 on our label
            // for lopp structure: Start #, condition for continuing, increment
        
            for (Int32 counter = 100; counter <= 120; counter++)

            { 
                //add the current # on to the end of the label text
                lblMessage1.Text += counter + " "; 


            } 
        }
        //while
        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            // remove the intructions from the label
            lblMessage1.Text = "";

            // use a loop to display #'s from 100 to 120 on our label
            // for lopp structure: Start #, condition for continuing, increment
            Int32 counter = 100;

            while (counter <= 120)
            {
                //add the current # on to the end of the label text
                lblMessage1.Text += counter + " ";

                //add 1 to the counter 
                counter++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // capture x and y as variables
            Int32 x = Convert.ToInt32(txtX.Text);
            Int32 y = Convert.ToInt32(txtY.Text);

            // send x and y to the AddNumbers method & display the result
            Int32 result = AddNumbers(x,y);
            lblSum.Text = Convert.ToString(result); 

        }
        // method accepts 2 integer inputs and returns another integer back
        private Int32 AddNumbers(Int32 x, Int32 y)
        {
            // add the 2 input parameter values together 
            Int32 sum = x + y;

            // send back result
            return sum; 


        }
    }
}
