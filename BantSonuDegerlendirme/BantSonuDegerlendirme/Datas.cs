using System.Collections.Generic;

namespace BantSonuDegerlendirme
{
    class Datas
    {
        //Hataların türlerini tutmak için static ve string türünde bir liste tanımlanıyor
        public static List<string> errors = new List<string>();
        //Kişilerin hatalarını tutmak için static ve ErrorData türünde bir liste tanımlanıyor
        public static List<ErrorData> errorDatas = new List<ErrorData>();
        //Kullanıcıları tutmak için static ve User türünde bir liste tanımlanıyor
        public static List<User> users = new List<User>();
        //Giriş yapan kullanıcının bilgisini tutmak için static bir string tanımlanıyor
        public static string UserName;

        //Proje içerisine giriş yapıldığında datalar kullanılmak üzere static listelere atanıyor
        public void Init()
        {
            //Hata türleri liste içerisine ekleniyor
            errors.Add("SAAT CEBİ");
            errors.Add("J DİKİŞ");
            errors.Add("BİYE");
            errors.Add("ETİKET");
            errors.Add("ÖN AĞ BİRLEŞTİRME");
            errors.Add("OVERLOK");
            errors.Add("ARKA CEP");
            errors.Add("CONTA");
            errors.Add("ARKA ORTA BACAK ARASI");
            errors.Add("YAN ÇİMA");
            errors.Add("KEMER");
            errors.Add("KEMER UCU");
            errors.Add("PAÇA");
            errors.Add("KÖPRÜ");
            errors.Add("ARKA CEP PUNT.");
            errors.Add("YAN ÇİMA PUNT.");
            errors.Add("İPLİK TEMİZLEME");
            errors.Add("DİĞER");

            //Bir kullanıcı tanımlanıyor
            User user = new User();
            //Kullanıcının adı belirleniyor
            user.userName = "irem";
            //Kullanıcının şifresi tanımlanıyor
            user.password = "1";
            //Kullanıcı kullanıcılar listesi içerisine ekleniyor
            users.Add(user);
        }

        //Tüm hata türleri bu fonksiyon içinden string bir liste olarak geri döndürülüyor
        //Hata türlerinin listelendiği combobox bu fonksiyonu kullanıyor
        public List<string> GetAllError()
        {
            return errors;
        }

        //Yeni bir kullanıcı hatası ekleyen fonksiyon
        //İçerisine değer olarak hatayı ve saati alıyor
        public void NewErrorData(string error, string hours)
        {
            //ErrorData türünde bir nesne yaratılıyor
            ErrorData errorData = new ErrorData();
            //Nesnenin hata kısmına gelen hata atanıyor
            errorData.error = error;
            //Nesnenin saat kısmına gelen saat atanıyor
            errorData.hours = hours;
            //Nesnenin kullanıcı adı kısmına giriş yapan kullanıcının adı atanıyor
            errorData.userName = UserName;
            //Oluşturulan nesene kullanıcı hataları listesine ekleniyor
            errorDatas.Add(errorData);
            //Eklendikten sonra uyarı veriyor
            System.Windows.Forms.MessageBox.Show("Hata başarıyla eklendi!");
        }

        //Kullanıcının var olup olmadığını kontrol ederek true ya da false dönüyor
        //2 tane parametre alıyor kullanıcı adı ve şifre
        //Bu fonksiyon giriş ekranından giriş yapılmak istenildiğinde kullanılıyor
        public bool UserControl(string userName, string password)
        {
            //Varolan kullanıcılar liste olarak döndürülüyor
            foreach (var user in users)
            {
                //Eğer gelen kullanıcı adı ve şifre liste içerisinde varsa return true olarak fonksiyondan çıkılıyor
                if (user.userName == userName && user.password == password)
                {
                    return true;
                }    
            }
            //Eğer hiç return'e girmediyse yani girilen kullanıcı adı ve şifre kullanıcılar arasında yoksa return false olarak dönüyor
            return false;
        }

        //Giriş yapan kullanıcının kim olduğunu belirleyen fonksiyon
        public void SetUserName(string userName)
        {
            //static olarak tanımlanan değişkenin içerisine giriş yapan kullanıcının adı atanıyor
            UserName = userName;
        }

        //Tüm kullanıcı hatalarını çeken fonksiyon string olarak list dönüyor
        public List<string> GetAllErrorDatas()
        {
           //String bir liste oluşturuluyor
            List<string> list = new List<string>();
            //Kullanıcı hataları listesi içerisindeki bilgiler döngü içerisinde dönüyor
            foreach (var item in errorDatas)
            {
                //Gelen bilgiler tek bir string haline getiriliyor
               list.Add("Kullanıcı: " + item.userName + " Hata: " + item.error + " Saat: " + item.hours);
            }
            //en son olarak liste geri döndürülüyor
            return list;
        }
    }
}
