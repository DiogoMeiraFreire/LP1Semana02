using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables

            // Integers
            byte    bt;
            sbyte   sbt;
            short   sh;
            ushort  ush;
            int     i;
            uint    ui;
            long    ln;
            ulong   uln;

            // Chars
            char    ch;

            // Floats
            double  db;
            float   fl, fl2;
            decimal dc;

            #endregion

            #region Max Integer prints

            Console.WriteLine("Maximum Integer Values:");

            bt = byte.MaxValue;
            Console.WriteLine("Byte: " + bt);
            
            sbt = sbyte.MaxValue;
            Console.WriteLine("Sbyte: " + sbt);
            
            sh = short.MaxValue;
            Console.WriteLine("Short: " + sh);
            
            ush = ushort.MaxValue;
            Console.WriteLine("Ushort: " + ush);
            
            i = int.MaxValue;
            Console.WriteLine("Int: " + i);
            
            ui = uint.MaxValue;
            Console.WriteLine("Uint: " + ui);
            
            ln = long.MaxValue;
            Console.WriteLine("Long: " + ln);
            
            uln = ulong.MaxValue;
            Console.WriteLine("Ulong: " + uln);           
            #endregion
        
            #region Min Integer prints

            Console.WriteLine("\nMinimum Integer Values:");
            bt = byte.MinValue;
            Console.WriteLine("Byte: " + bt);
            
            sbt = sbyte.MinValue;
            Console.WriteLine("Sbyte: " + sbt);
            
            sh = short.MinValue;
            Console.WriteLine("Short: " + sh);
            
            ush = ushort.MinValue;
            Console.WriteLine("Ushort: " + ush);
            
            i = int.MinValue;
            Console.WriteLine("Int: " + i);
            
            ui = uint.MinValue;
            Console.WriteLine("Uint: " + ui);
            
            ln = long.MinValue;
            Console.WriteLine("Long: " + ln);
            
            uln = ulong.MinValue;
            Console.WriteLine("Ulong: " + uln); 
            #endregion
        
            #region Char prints

            Console.WriteLine("\nMaximum Char Value:");
            ch = char.MaxValue;
            Console.WriteLine("Char: " + ch);


            Console.WriteLine("\nMinimum Char Value:");
            ch = char.MinValue;
            Console.WriteLine("Char: " + ch);

            #endregion

            #region Float prints
            
            Console.WriteLine("\nMaximum Float Values:");
            db = double.MaxValue;
            Console.WriteLine("Double: " + db);

            fl = float.MaxValue;
            Console.WriteLine("Float: " + fl);

            dc = decimal.MaxValue;
            Console.WriteLine("Decimal: " + dc);
// -----------------------------------------------------------------
            
            Console.WriteLine("\nMinimum Float Values:");
            db = double.MinValue;
            Console.WriteLine("Double: " + db);

            fl = float.MinValue;
            Console.WriteLine("Float: " + fl);

            dc = decimal.MinValue;
            Console.WriteLine("Decimal: " + dc);

            #endregion

            #region Special prints

            Console.WriteLine("\nPositive infinite: ");
            db = double.PositiveInfinity;
            Console.WriteLine("Double: " + db);

            fl = float.PositiveInfinity;
            Console.WriteLine("Float: " + fl);

            Console.WriteLine("\nNegative infinite: ");
            db = double.NegativeInfinity;
            Console.WriteLine("Double: " + db);

            fl = float.NegativeInfinity;
            Console.WriteLine("Float: " + fl);
            
            Console.WriteLine("\nNaN: ");
            db = double.NaN;
            Console.WriteLine("Double: " + db);

            fl = float.NaN;
            Console.WriteLine("Float: " + fl);

            #endregion


// Exercise 7 ----------------------------------------

            #region Overflows and Underflows

            Console.WriteLine("\nOverflows: ");
            ui = uint.MaxValue;
            Console.WriteLine("Uint: " + (ui + 1));

            db = 2 * double.MaxValue;
            Console.WriteLine("Double (multiplying by 2): " + db);

            db = double.MaxValue + 1;
            Console.WriteLine("Double (adding 1): " + db);


            Console.WriteLine("\nUnderflows: ");
            fl = 100000000.0f;
            fl2 = fl;
            Console.WriteLine("Float(lack of precision): " 
                                + (fl2 == fl + 0.0000001f));

            #endregion
        }
    }
}
