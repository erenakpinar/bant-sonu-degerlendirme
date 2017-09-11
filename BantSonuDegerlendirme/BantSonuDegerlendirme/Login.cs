using System;
using System.Windows.Forms;

namespace BantSonuDegerlendirme
{
    public partial class Login : Form
    {
        Datas data = new Datas();
        static int value = 0;
        public Login()
        {
            InitializeComponent();
            data.Init();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (userName != "" && password != "")
            {
                bool status = data.UserControl(userName, password);
                value++;
                if (value < 3)
                {
                    if (status)
                    {
                        MessageBox.Show("Başarıyla giriş yaptınız!");
                        data.SetUserName(txtUserName.Text);
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                    }
                }
                else
                {
                    MessageBox.Show("3 defadan fazla deneme yapamazsınız! Çıkış yapılıyor.");
                    Application.Exit();
                }  
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş girilemez!");
            }
        }
    }
}
