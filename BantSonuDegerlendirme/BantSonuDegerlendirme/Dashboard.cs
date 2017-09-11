using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BantSonuDegerlendirme
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        Datas data = new Datas();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            List<string> errorDatas = data.GetAllErrorDatas();
            foreach (var item in errorDatas)
            {
                lstErrorDataList.Items.Add(item);
            }
        }

        private void btnOpenNewErrorForm_Click(object sender, EventArgs e)
        {
            NewError newError = new NewError();
            this.Hide();
            newError.Show();
        }

        private void btnDtGridRefresh_Click(object sender, EventArgs e)
        {
        }
    }
}
