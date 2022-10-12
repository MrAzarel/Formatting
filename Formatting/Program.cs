using System;

namespace Formatting {
    class Formatting
    {
        string name = "Vanya";
        int number = 20;       
        double doub = 1.11;
        int value = 123;
        string fmt2 = "##;(##)";

        public string FormSrt()
        {
            return string.Format("Имя: {0}  Возраст: {1}", name, number);
        }
        public string FormSrt2()
        {
            return string.Format("{0:d}", number);
        }
        public string FormSrt3()
        {
            return string.Format("{0:f4}", doub);
        }

        public string FormInt()
        {           
            return value.ToString("\\#\\#\\# ##0 dollars and \\0\\0 cents \\#\\#\\#");           
        }
        public string FormInt2()
        {
            return String.Format("{0:\\#\\#\\# ##0 dollars and \\0\\0 cents \\#\\#\\#}",
                                            value);
        }

        public string FormDoubl()
        {
            return doub.ToString(fmt2);
        }

        public string FormDoubl2()
        {
            return String.Format("{0:" + fmt2 + "}", doub);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*int monthI = Console.Read();
            int dayI = Console.Read();
            string monthS = Console.ReadLine();
            string dayS = Console.ReadLine();
            double monthD = Console.Read();
            double dayD = Console.Read();*/
            Formatting formatting = new Formatting();
            Console.WriteLine(formatting.FormSrt());
            Console.WriteLine(formatting.FormSrt2());
            Console.WriteLine(formatting.FormSrt3());
            Console.WriteLine(formatting.FormInt());
            Console.WriteLine(formatting.FormInt2());
            Console.WriteLine(formatting.FormDoubl());
            Console.WriteLine(formatting.FormDoubl2());
        }
    }
}

