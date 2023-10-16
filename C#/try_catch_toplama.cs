namespace YZL
{
    class Uygulama
    {
        public static void Main()
        {
            int a, toplam = 0, sayac, sayi;

            System.Console.WriteLine("Kac tane sayi toplamak istiyorsunuz:");
            sayi = int.Parse(System.Console.ReadLine());

            for (int y = 0; y < sayi; y++) // Döngü kullanmamın sebebi her girilen sayıda hatayı tek tek aramamak. 
            {

                try // Bu bölümde girilen sayılar tam sayı ise bir sorun olmadan girilen sayılar tek tek toplanır ve ekrana yazılır.
                {
                    System.Console.Write("\n Toplamak istediginiz sayiyi giriniz:");
                    a = int.Parse(System.Console.ReadLine());
                    toplam = toplam + a;
                    System.Console.WriteLine("\n Suanki toplam deger:" + toplam);
                }


                catch // Bu bölümde girilen sayılar tam sayı değil ise kullanıcıya sayıyı tekrar girmesi istenir.
                {
                    for (sayac = 0; sayac < 2; sayac++) //(toplam 3 sayı girme hakkı verilir bunu kendiniz belirleyebilirsiniz.)
                    {
                        System.Console.Write("\nGeçerli bir sayi giriniz:");
                        string input = System.Console.ReadLine();
                        if (int.TryParse(input, out a))
                        {
                            System.Console.WriteLine("\n Girmis oldugunuz sayi:" + a);
                            toplam = toplam + a;
                            System.Console.WriteLine("\n Suanki toplam deger:" + toplam);
                            break;

                        }

                    }

                    if (sayac == 2) //Bu bölümde kullanıcı eğer hakkını doldurduysa bunu bildiririz ve uygulamamızı sona erdiririz.
                    {
                        System.Console.WriteLine("\n Deneme hakkiniz bitmistir");
                        break;
                    }

                }

            }


        }

    }
}