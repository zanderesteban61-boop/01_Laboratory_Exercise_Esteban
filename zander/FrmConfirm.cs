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
    public partial class FrmConfirm : Form
    {



        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;



        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void FrmConfirm_Load_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public FrmConfirm()
        {
            InitializeComponent();
        }


        private void FrmConfirm_Load(object sender, EventArgs e)
        {


            DelProgram = new DelegateText(GetProgram);
            DelLastName = new DelegateText(GetLastName);
            DelFirstName = new DelegateText(GetFirstName);
            DelMiddleName = new DelegateText(GetMiddleName);
            DelAddress = new DelegateText(GetAddress);
            DelNumAge = new DelegateNumber(GetAge);
            DelNumContactNo = new DelegateNumber(GetContactNo);
            DelStudNo = new DelegateNumber(GetStudentNo);


            labelFirstName.Text = DelFirstName(FirstName);
            labelLastName.Text = DelLastName(LastName);
            labelMiddleName.Text = DelMiddleName(MiddleName);
            labelAddress.Text = DelAddress(Address);
            labelProgram.Text = DelProgram(StudentInfoClass.Program);
            labelAge.Text = DelNumAge(Age).ToString();
            labelContactInfo.Text = DelNumContactNo(ContactNo).ToString();
            labelStudent.Text = DelStudNo(StudentNo).ToString();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}