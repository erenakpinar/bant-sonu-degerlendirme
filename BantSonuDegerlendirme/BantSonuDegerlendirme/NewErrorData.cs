using System;
using System.Windows.Forms;

namespace BantSonuDegerlendirme
{
    public partial class NewErrorData : Form
    {
        public NewErrorData()
        {
            InitializeComponent();
        }
        Datas data = new Datas();
        private void NewError_Load(object sender, EventArgs e)
        {
            var errorList = data.GetAllError();
            foreach (var error in errorList)
            {
                cmbErrorList.Items.Add(error);                
            }
        }

        private void btnNewError_Click(object sender, EventArgs e)
        {
            data.NewErrorData(cmbErrorList.Text, txtDescription.Text);

            txtDescription.Text = "";
        }

        private void btnReturnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
