using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2
{
    class Jumin
    {
        static void Main(string[] args)
        {
            string number, current_year, gender_s;
            int year, month, day, gender, age, c_year;

            Console.Write("주민번호 입력('-' 없이) : ");
            number = Console.ReadLine();

            year = Convert.ToInt32(number.Substring(0, 2));
            month = Convert.ToInt32(number.Substring(2, 2));
            day = Convert.ToInt32(number.Substring(4, 2));
            gender = Convert.ToInt32(number.Substring(6, 1));

            current_year = Convert.ToString(DateTime.Now);
            c_year = Convert.ToInt32(current_year.Substring(0, 4));

            year = Calc_Year(year, gender);
            age = Calc_Age(year, gender, c_year);
            gender_s = Calc_Gender(gender);

            Console.WriteLine("년도 : {0}", year);
            Console.WriteLine("월 : {0}", month);
            Console.WriteLine("일 : {0}", day);
            Console.WriteLine("올해 나이 : {0}", age);
            Console.WriteLine("성별 : {0}", gender_s);
        }

        public static int Calc_Year(int year, int gender)
        {
            if (gender == 1 || gender == 2)
            {
                year = year + 1900;
                return year;
            }

            else if (gender == 3 || gender == 4)
            {
                year += 2000;
                return year;
            }

            else
            {
                Console.WriteLine("Error");
                return 0;
            }
        }

        public static int Calc_Age(int year, int gender, int c_year)
        {
            return c_year - year + 1;
        }

        public static string Calc_Gender(int gender)
        {
            string s;
            if (gender == 1 || gender == 3)
            {
                s = "M";
                return s;
            }

            else if (gender == 2 || gender == 4)
            {
                s = "F";
                return s;
            }

            else
            {
                s = "N";
                return s;
            }
        }
    }
}