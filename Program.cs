using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int int_Serial_No = 100;
            string str_Acc_No = "";
            float flt_Any_No = 3.5f;

            str_Acc_No = int_Serial_No.ToString();

            Console.WriteLine("str_Acc_No = " + str_Acc_No);

            flt_Any_No = int_Serial_No;
            Console.WriteLine("flt_Any_No = " + flt_Any_No);

            flt_Any_No = 3.5f;
            int_Serial_No = Convert.ToInt32(flt_Any_No);
            Console.WriteLine("New int_Serial_No = " + int_Serial_No);

        }
    }
}
