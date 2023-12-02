using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace TASK4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //TASK 4.1
            //ki ədəd verilib 
            //əgər bu iki ədədin cəmi cüt ədədirsə "Cəm cüt ədəddir"
            //deyilsə "Cəm tək ədəddir" yazı ekrana yazdırmaq
            //input: 3, 6
            //output:

            int[] ns = { 7, 5 };
            int sum = ns[0] + ns[1];
            if (sum % 2 == 0)
            {
                Console.WriteLine("Cəm cüt ədəddir");
            }
            else
            {
                Console.WriteLine("Cəm tək ədədir");
            }



            //Task 4.2
            //Massivdə 10(on) ədəd saxlanılıb
            //bu ədədlərdən cüt olanları ekrana yazdırmaq

            int[] Reqemler = { 5, 12, 7, 8, 23, 16, 9, 14, 3, 10 };

            Console.WriteLine("Cüt rəqəmlər:");

            foreach (int number in Reqemler)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }

            }

            //Task 4.3
            //Massivdə 10(on) ədəd saxlanılıb
            //bu ədədlərdən tək olanların cəmini tapıb ekrana yazdırmaq

            int[] Reqemus = { 5, 12, 7, 8, 23, 16, 9, 14, 3, 10 };

            int TekEdedlerinCemi = 0;

            foreach (int number in Reqemus)
            {
                if (number % 2 != 0)
                {
                    TekEdedlerinCemi += number;
                }
            }

            Console.WriteLine("Tək ədədlərin cəmi: " + TekEdedlerinCemi);

            //Task 4.4
            //Verilmish 4 reqemli ededin reqemlerinin cemini tap (əgər ədəd 4reqemlidirse yoxlamaq)     
            //input: 3423                                    input: 34231
            //output: 12                                     output: ədəd 4rəqəmli deyil

            int[] Numbeo = { 7814, 45618 };


            if (Numbeo[0] >= 1000 && Numbeo[0] < 10000)
            {
                int cem = 0;
                int qaliq;


                while (Numbeo[0] > 0)
                {
                    cem += Numbeo[0] % 10;   //hasil lazim olanda ise + evezine * vurma ederdik
                    Numbeo[0] /= 10;



                }
                Console.WriteLine($"cem: {cem} ");
            }
            else
            {
                Console.WriteLine("4 rəqəmli ədəd DEYIL");
            }


            //Task 4.5
            //5.Telebe melumatlarini saxlamaq ucun Tip yaratmali
            // - name
            // - surname
            // - age
            // - speciality
            // - groupNo

            Student s1 = new Student();
            s1.name = "Fariz";
            s1.surname = "Məmmədov";
            s1.age = "28";
            s1.speciality = "Logical way finding";
            s1.groupNO = "P444";

            Student s2 = new Student();
            s2.name = "Dante";
            s2.surname = "Redgrave";
             
            Student[] sALL = new Student[2];

            sALL[0] = s1;
            sALL[1] = s2;

            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine($"{sALL[i].name} {sALL[i].surname}");

            }


            




        }





        class Student
        {
            public string name;
            public string surname;
            public string age;
            public string speciality;
            public string groupNO;
            


        }

    }
}