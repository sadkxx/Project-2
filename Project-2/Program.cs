namespace Project_2
{
    class Program
    {
        static void Main()
        {
                Console.Write("Görmek istediğiniz projeyi seçiniz :\n" +
                "Proje 1 (Girilen sayının çift - tek kontrolü (if))\n" +
                "Proje 2 (1 den 10 a kadar sayıları ekrana yazı değeri olarak yazma işlemi)\n" +
                "Proje 3 (Kullanıcı adı admin ve şifre Admin_32453@ olduğunda " +
                "giriş başarılı değilse başarısız uyarısı veren c# kodu)\n" +
                "Proje 4 (10-20 20-30 30-40 arası sıcaklık durumlarına göre " +
                "ekrana (normal - sıcak - çok sıcak) uyarısı veren veren c# kodu)\n" +
                "Seçiminiz :");
            string girdi = Console.ReadLine();
            if (girdi == "1" || girdi == "2" || girdi == "3" || girdi == "4")
            {
                int deger = Convert.ToInt16(girdi);
                switch (deger)
                {
                    case 1: Console.Clear(); fonk1(); break;
                    case 2: Console.Clear(); fonk2(); break;
                    case 3: Console.Clear(); fonk3(); break;
                    case 4: Console.Clear(); fonk4(); break;
                    default: Console.Clear(); Console.WriteLine("Hatalı Seçim Yaptınız! Lütfen 1-4 arası seçim yapınız."); Main(); break;
                }
            }
            else
            {
                Console.WriteLine("Hatalı Seçim Yaptınız! Lütfen 1-4 arası seçim yapınız.\n");
                Main();
            }
        }

        static void tekrar(Action fonksiyon)
        {
            BASADON2:
            Console.Write("Tekrar işlem yapmak ister misiniz? (e ya da h)  ");
            char tekrar_islem = Convert.ToChar(Console.ReadLine());
            if (tekrar_islem == 'e' || tekrar_islem == 'E')
            {
                Console.Clear(); fonksiyon();
            }
            else if (tekrar_islem == 'h' || tekrar_islem == 'H')
            {
                sorgu();
                return;
            }
            else
            {
                Console.WriteLine("Hatalı cevap!"); goto BASADON2;
            }
        }
        static void sorgu()
        {
            BASADON:
            Console.WriteLine("------------------------------------------------");
            Console.Write("Diğer projelere bakmak ister misiniz? (e / h) ");
            char cevap = Convert.ToChar(Console.ReadLine());
            if (cevap == 'h' || cevap == 'H')
            {
                Console.WriteLine("Program 3 saniye içinde kapanacaktır.\nHoşçakalın ! ");
                Thread.Sleep(3000);  // 3 saniye bekleme fonksiyonu
                return;
            }
            else if (cevap == 'e' || cevap == 'E')
            {
                Console.WriteLine("-------------------------");
                Main();
            }
            else
            {
                Console.WriteLine("Hatalı Giriş!");
                goto BASADON;
            }
        }
        static void fonk1()
        {
            //GİRİLEN SAYININ ÇİFT - TEK KONTROLÜ (İF)
            Console.WriteLine("-----------------------------");
            Console.WriteLine("GİRİLEN SAYININ ÇİFT - TEK KONTROLÜ (İF)");
            Console.WriteLine("-----------------------------");
            Console.Write("Bir tam sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 1) Console.WriteLine("Sayı Tektir!");
            else Console.WriteLine("Sayı Çifttir!");
            Console.WriteLine("-----------------------------");
            tekrar(fonk1);
        }
        static void fonk2()
        {
            //1'DEN 10'A KADAR SAYILARI EKRANA YAZI DEĞERİ OLARAK YAZMA İŞLEMİ
            Console.WriteLine("------------------------------");
            Console.WriteLine("1'DEN 10'A KADAR SAYILARI EKRANA YAZI DEĞERİ OLARAK YAZMA İŞLEMİ");
            Console.WriteLine("------------------------------");
            BASADON:
            Console.WriteLine("------------------------------");
            Console.Write("1 ile 10 arası bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool devam = true;
            if (1 <= sayi || sayi <= 10)
            {
                while (devam)
                {
                    switch (sayi)
                    {
                        case 1: Console.WriteLine("BİR"); devam = false; break;
                        case 2: Console.WriteLine("İKİ"); devam = false; break;
                        case 3: Console.WriteLine("ÜÇ"); devam = false; break;
                        case 4: Console.WriteLine("DÖRT"); devam = false; break;
                        case 5: Console.WriteLine("BEŞ"); devam = false; break;
                        case 6: Console.WriteLine("ALTI"); devam = false; break;
                        case 7: Console.WriteLine("YEDİ"); devam = false; break;
                        case 8: Console.WriteLine("SEKİZ"); devam = false; break;
                        case 9: Console.WriteLine("DOKUZ"); devam = false; break;
                        case 10: Console.WriteLine("ON"); devam = false; break;
                        default: Console.WriteLine("Geçersiz Sayı! Lütfen 1-10 arası seçim yapınız."); devam = false; goto BASADON; break;
                    }
                }
            }
            else Console.WriteLine("Hatalı Giriş!");
            tekrar(fonk2);
        }
        static void fonk3()
        {
            //KULLANICI ADI admin VE ŞİFRE Admin_32453@ OLDUĞUNDA
            //GİRİŞ BAŞARILI DEĞİLSE BAŞARISIZ UYARISI VEREN C# KODU
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Proje 3 (KULLANICI ADI *** VE ŞİFRE *** OLDUĞUNDA " +
                "GİRİŞ BAŞARILI DEĞİLSE BAŞARISIZ UYARISI VEREN C# KODU)\n");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Kullanıcı Adı Giriniz :"); //admin
            string kAdi = Console.ReadLine();
            Console.Write("Şifre Giriniz :"); //Admin_32453@
            string sifre = Console.ReadLine();
            if (kAdi == "admin" && sifre == "Admin_32453@") Console.WriteLine("Giriş Başarılı!");
            else Console.WriteLine("Kullanıcı Adı veya Şifre Yanlış!");
            tekrar(fonk3) ;
        }
        static void fonk4()
        {
            //10-20 20-30 30-40 ARASI SICAKLIK DURUMLARINA GÖRE
            //EKRANA (NORMAL - SICAK - ÇOK SICAK) UYARISI VEREN VEREN C# KODU
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("10-20 20-30 30-40 arası sıcaklık durumlarına göre " +
                "ekrana (normal - sıcak - çok sıcak) uyarısı veren veren c# kodu");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Sıcakllık değerini giriniz :");
            double sicaklik = Convert.ToDouble(Console.ReadLine());
            if (10 <= sicaklik && sicaklik <= 20) Console.WriteLine("Normal");
            else if (20 < sicaklik && sicaklik <= 30) Console.WriteLine("Sıcak");
            else if (30 < sicaklik && sicaklik < 40) Console.WriteLine("Çok Sıcak");
            else Console.WriteLine("Bu değer bilinmiyor.");
            tekrar(fonk4);
        }
        
    }
}