using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double boy, kılo, BMI;         
            Console.WriteLine("Kılonuz :");
            kılo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Boyunuz (ÖR:1,65) :");
            boy = Convert.ToDouble(Console.ReadLine());
            BMI = kılo / (boy * boy);
            Console.WriteLine(" Vücut Kitle Endeksiniz {0}", BMI);

            if (0 < BMI && BMI< 18.4)
                {
                Console.WriteLine("Vücut Kitle Endeksin’e göre ZAYIF kategorisindesiniz.Kilo almanız önerilir.");
                }
            else if (18.5 < BMI && BMI < 24.9)
                {
                Console.WriteLine("Vücut Kitle Endeksin’e göre NORMAL kategorisindesiniz.Düzenli, sağlıklı ve dengeli beslenmeye devam etmeniz önerilir");
                }
            else if (25 < BMI && BMI < 29.9)
            {
                Console.WriteLine("Vücut Kitle Endeksin’e göre boyunuza oranla kilonuz fazladır. Kilo vermeniz önerilir");
            }
            else if (30 < BMI && BMI < 34.9)
            {
                Console.WriteLine("Vücut Kitle Endeksin’e göre birinci derece OBEZ kategorisindesiniz. Sağlığınız için kilo vermeniz önerilir");
            }
            else if (35 < BMI && BMI < 44.9)
            {
                Console.WriteLine("Vücut Kitle Endeksin’e göre ikinci derece OBEZ kategorisindesiniz. Kalp ve damar hastalıkları bakımından risk altındasınız. Sağlığınız için kilo vermeniz önerilir");
            }
            else if (BMI >= 45)
            {
                Console.WriteLine("Vücut Kitle Endeksin’e göre üçüncü derece OBEZ kategorisindesiniz.Sağlığınız için kilo vermeniz gerekmektedir");
            }

            Console.ReadKey();

        }
    }
}
