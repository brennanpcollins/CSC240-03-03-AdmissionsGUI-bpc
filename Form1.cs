using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_03_03_AdmissionsGUI_bpc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UxCheckButton_Click(object sender, EventArgs e)
        {
            //INPUT
            double GPA;
            int score;

            //STORAGE
            GPA = Convert.ToDouble(UxGPATextBox1.Text);
            score = Convert.ToInt32(UxTestTextBox2.Text);

            //PROCESS
            if ((GPA >= 3.00) && (score >= 60))
            {
                UxResultTextBox3.Text = "Accepted!";
                UxResultTextBox3.Visible = true;
            }
            else
            {
                if ((GPA < 3.00) && (score >= 80))
                {
                    UxResultTextBox3.Text = "Accepted!";
                    UxResultTextBox3.Visible = true;
                }
                else
                {
                    UxResultTextBox3.Text = "Rejected... Sorry!";
                    UxResultTextBox3.Visible = true;
                }
            }
            //OUTPUT

        }
    }
}
