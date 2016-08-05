using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class NumberGenerator
    {
        public static bool beforeNumber = false;

        public static void printNumber(int number)
        {
            beforeNumber = false;
            Console.WriteLine(getBillion(number));
        }

        public static int slicer(int number, int number2)
        {
            return (number / number2);

        }
        public static string getBillion(int number)
        {
            int hundred = number % 1000000000;
            int thousend = slicer(number, 1000000000);
            if (hundred == 0 && thousend != 0)
            {
                if (thousend == 1 && beforeNumber == false)
                {
                    return " miliardi";
                  }
                return getMillion(thousend) + " miliardi";
            }
            if (hundred != 0 && thousend != 0)
            {
                if (thousend == 1 && beforeNumber == false)
                {
                    beforeNumber = true;
                    return " miliard " + getMillion(hundred);
                }

                return getHundred(thousend) + " miliard " + getMillion(hundred);
            }
            if (hundred != 0 && thousend == 0)
            {

                return getMillion(hundred);
            }

            return "nuli";

        }


        public static string getMillion(int number)
        {
            int hundred = number % 1000000;
            int thousend = slicer(number, 1000000);
            if (hundred == 0 && thousend != 0)
            {
                if (thousend == 1 && !beforeNumber)
                {
                    return " milioni";
                }
                return getThousend(thousend) + " milioni";
            }
            if (hundred != 0 && thousend != 0)
            {
                if (thousend == 1 && !beforeNumber)
                {
                    beforeNumber= true;
                    return " milion " + getThousend(hundred);
                }
                return getHundred(thousend) + " milion " + getThousend(hundred);
            }
            if (hundred != 0 && thousend == 0)
            {
                return getThousend(hundred);
            }

            return "";



        }


        public static string getThousend(int number)
        {
            int hundred = number % 1000;
            int thousend = slicer(number, 1000);
            if (hundred == 0 && thousend != 0)
            {
                if (thousend == 1)
                {
                    return " atasi";
                }
                return getHundred(thousend) + " atasi";
            }
            if (hundred != 0 && thousend != 0)
            {
                if (thousend == 1)
                {
                    return " atas " + getHundred(hundred);
                }
                return getHundred(thousend) + " atas " + getHundred(hundred);
            }
            if (hundred != 0 && thousend == 0)
            {
                return getHundred(hundred);
            }

            return "";
        }

        public static string getHundred(int number)
        {
            int dec = number % 100;
            int hundr = slicer(number, 100);

            if (dec == 0 && hundr != 0)
            {
                return getHundredFirst(hundr) + "asi";
            }
            if (dec != 0 && hundr == 0)
            {
                return getLessHundred(dec);
            }
            if (dec != 0 && hundr != 0)
            {
                return getHundredFirst(hundr) + "as " + getLessHundred(dec);
            }




            return "0";
        }

        public static string getTwenty(int number)
        {
            string result = "";
            switch (number)
            {
                case 1:
                    result = "erti";
                    break;
                case 2:
                    result = "ori";
                    break;

                case 3:
                    result = "sami";
                    break;

                case 4:
                    result = "otxi";
                    break;


                case 5:
                    result = "xuti";
                    break;

                case 6:
                    result = "eqsvi";
                    break;

                case 7:
                    result = "shvidi";
                    break;
                case 8:
                    result = "rva";
                    break;
                case 9:
                    result = "cxra";
                    break;
                case 10:
                    result = "ati";
                    break;
                case 11:
                    result = "tertmeti";
                    break;
                case 12:
                    result = "tormeti";
                    break;
                case 13:
                    result = "cameti";
                    break;

                case 14:
                    result = "totxmeti";
                    break;

                case 15:
                    result = "txutmeti";
                    break;

                case 16:
                    result = "teqvsmeti";
                    break;

                case 17:
                    result = "chvidmeti";
                    break;

                case 18:
                    result = "tvrameti";
                    break;

                case 19:
                    result = "cxrameti";
                    break;


                case 20:
                    result = "oci";
                    break;

                default:
                    break;
            }
            return result;
        }


        public static string getLessHundred(int number)
        {
            int full = slicer(number, 20);
            int less = number % 20;

            if (full == 0 && less != 0)
            {
                return getTwenty(number);
            }

            if (full != 0 && less != 0)
            {
                return getSmallTwenty(full) + getTwenty(less);
            }

            if (full != 0 && less == 0)
            {

                return GetfullTwenty(full);
            };

            return "";

        }

        public static string getSmallTwenty(int numb)
        {
            string result = "";
            switch (numb)
            {
                case 1:
                    result = " ocda";
                    break;
                case 2:
                    result = " ormocda";
                    break;

                case 3:
                    result = " samocda";
                    break;

                case 4:
                    result = " otxmocda";
                    break;
            }
            return result;
        }


        public static string GetfullTwenty(int numb)
        {
            string result = "";
            switch (numb)
            {
                case 1:
                    result = " oci";
                    break;
                case 2:
                    result = " ormoci";
                    break;

                case 3:
                    result = " samoci";
                    break;

                case 4:
                    result = " otxmoci";
                    break;
            }
            return result;
        }

        public static string GetTwentien(int number)
        {
            string result = "";
            switch (number)
            {
                case 1:
                    result = "";
                    break;
                case 2:
                    result = "ori";
                    break;

                case 3:
                    result = "sami";
                    break;

                case 4:
                    result = "otxi";
                    break;


                case 5:
                    result = "xuti";
                    break;

                case 6:
                    result = "eqsvi";
                    break;

                case 7:
                    result = "shvidi";
                    break;
                case 8:
                    result = "rva";
                    break;
                case 9:
                    result = "cxra";
                    break;
                case 10:
                    result = "ati";
                    break;
                case 11:
                    result = "tertmeti";
                    break;
                case 12:
                    result = "tormeti";
                    break;
                case 13:
                    result = "cameti";
                    break;

                case 14:
                    result = "totxmeti";
                    break;

                case 15:
                    result = "txutmeti";
                    break;

                case 16:
                    result = "teqvsmeti";
                    break;

                case 17:
                    result = "chvidmeti";
                    break;

                case 18:
                    result = "tvrameti";
                    break;

                case 19:
                    result = "cxrameti";
                    break;


                case 20:
                    result = "oci";
                    break;

                default:
                    break;
            }
            return result;
        }

        public static string getHundredFirst(int number)
        {
            string result = "";
            switch (number)
            {
                case 1:
                    result = "";
                    break;
                case 2:
                    result = "or";
                    break;

                case 3:
                    result = "sam";
                    break;

                case 4:
                    result = "otx";
                    break;


                case 5:
                    result = "xut";
                    break;

                case 6:
                    result = "eqvs";
                    break;

                case 7:
                    result = "shvid";
                    break;
                case 8:
                    result = "rva";
                    break;
                case 9:
                    result = "cxra";
                    break;
            }
            return result;
        }
        public static void Main()
        {
            bool next = true;
            while(next){
                int num = int.Parse(Console.ReadLine());
                
                
                    NumberGenerator.printNumber(num);
                
            }
        }
    }
}
    

