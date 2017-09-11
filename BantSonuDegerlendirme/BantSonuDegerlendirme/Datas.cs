using System.Collections.Generic;

namespace BantSonuDegerlendirme
{
    class Datas
    {
        public static List<string> errors = new List<string>();
        public static List<ErrorData> errorDatas = new List<ErrorData>();
        public static List<User> users = new List<User>();
        public static string UserName;

        public void Init()
        {
            errors.Add("test");
            errors.Add("testt");

            User user = new User();
            user.userName = "eren";
            user.password = "1";
            users.Add(user);

            User user2 = new User();
            user2.userName = "irem";
            user2.password = "1";
            users.Add(user2);
        }

        public List<string> GetAllError()
        {
            return errors;
        }

        public void NewErrorData(string error, string hours)
        {
            ErrorData errorData = new ErrorData();
            errorData.error = error;
            errorData.hours = hours;
            errorData.userName = UserName;
            errorDatas.Add(errorData);

            System.Windows.Forms.MessageBox.Show("Hata başarıyla eklendi!");
        }

        public bool UserControl(string userName, string password)
        {
            foreach (var user in users)
            {
                if (user.userName == userName && user.password == password)
                {
                    return true;
                }    
            }

            return false;
        }

        public void SetUserName(string userName)
        {
            UserName = userName;
        }

        public List<string> GetAllErrorDatas()
        {
            List<string> list = new List<string>();
            foreach (var item in errorDatas)
            {
               list.Add("Kullanıcı: " + item.userName + " Hata: " + item.error + " Saat: " + item.hours);
            }

            return list;
        }
    }
}
