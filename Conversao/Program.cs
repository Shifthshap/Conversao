﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversão implicita
            //byte num1 = 100;
            //ushort num2;
            //float num3 = 1245.45f;
            //double num4 = num3;

            //num3 = num1;
            //num2 = num1;

            //int numero = 'C';
            #endregion

            #region Conversão explicita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.768f;
            //int num4 = (int)1985.75f;

            //char letra = (char)97;
            #endregion

            #region Parse
            //string txtNumero = "1985";

            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57");
            //float num3 = float.Parse("457,75");
            #endregion

            #region Class Convert

            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');

            #endregion

            Console.WriteLine(num1);
            Console.ReadKey();

        }
    }
}
