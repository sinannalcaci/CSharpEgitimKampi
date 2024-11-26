using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int sayi;
            //Console.Write("Sayıyı Giriniz: ");
            //sayi=int.Parse(Console.ReadLine());

            //if (sayi == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "";
            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";

            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("hoşgeldiniz");
            //}





            #endregion

            #region mod işlemleri

            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1= int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2= int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("birinci sayının ikinci sayıya bölümünden kalan: "+result);

            //Console.Write("Lütfen sayıyı giriniz : ");
            //int number =int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("sayı tektir");
            //}




            #endregion

            #region Char değişkenler ile karar yapıları

            //char team;

            //Console.Write("lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team =='g'| team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team =='f'| team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team =='b'| team=='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //} 
            #endregion

            #region Örnek proje uygulaması
            //Console.WriteLine("******* C# Eğitim Kampı Restoran ******* ");

            //Console.WriteLine();

            //Console.WriteLine("-------------------------");

            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            //Console.WriteLine("-------------------------");
            //Console.WriteLine();


            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");

            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında somon");
            //    Console.WriteLine("5- Patlıcan musakka");

            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin çorba");


            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz pizza");
            //    Console.WriteLine("2- Margarita");
            //    Console.WriteLine("3- Tavuklu Pizza");


            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- su");


            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");


            //    Console.WriteLine();
            //}


            #endregion

            #region SwitchCase


            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak");break;
            //    case 2: Console.WriteLine("Şubat");break;
            //    case 3: Console.WriteLine("Mart");break;
            //    case 4: Console.WriteLine("Nisan");break;
            //    case 5: Console.WriteLine("Mayıs");break;
            //    case 6: Console.WriteLine("Haziran");break;
            //    case 7: Console.WriteLine("Temmuz");break;
            //    case 8: Console.WriteLine("Ağustos");break;
            //    case 9: Console.WriteLine("Eylül");break;
            //    case 10: Console.WriteLine("Ekim");break;
            //    case 11: Console.WriteLine("Kasım");break;
            //    case 12: Console.WriteLine("Aralık");break;
            //    default: Console.Write("Hatalı Veri Girişi");break;
            //}

            #endregion

            #region Switch Case Hesap makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");

            //symbol=char.Parse(Console.ReadLine());  


            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Toplam: "+result);
            //        break;
            //    case '-':
            //        result=number1 - number2;
            //        Console.WriteLine("Fark: "+result);
            //        break;
            //    case '*':
            //        result=number1 * number2;
            //        Console.WriteLine("Çarpım: "+result);
            //        break;
            //    case '/':
            //        result=number1 / number2;
            //        Console.WriteLine("Bölüm: "+result);
            //        break;
            //}


            #endregion


        }
    }
}
