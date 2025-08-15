using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static zander.StudentInfoClass;

namespace zander
{
    public partial class FrmRegistration : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;



        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;



        public FrmRegistration()
        {
            InitializeComponent();


            comboBoxProg.Items.Add("BSIS");
            comboBoxProg.Items.Add("BSIT");
            comboBoxProg.Items.Add("BSED");


        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
  

            StudentInfoClass.FirstName = txtboxFirst.Text;
            StudentInfoClass.LastName = txtboxLast.Text;
            StudentInfoClass.MiddleName = txtboxMiddle.Text;
            StudentInfoClass.Address = txtboxAddress.Text;
            StudentInfoClass.Program = comboBoxProg.Text;
            StudentInfoClass.Age = Convert.ToInt64(txtboxAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txtboxContact.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(txtboxStud.Text);

        }

        private void txtboxStud_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtboxLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
                                                                                                                                                                                                                                                                                                                                                                                                                   