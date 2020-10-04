using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSAppSharedFunction
{

    public static class MDSHelperClass
        // Helper Class with function that used by variety of tabs
    {

        public static void c()
        {

            var a = 1;


        }



        public static void MdsAppisDigit(TextBox a)
        {


            var isNumeric = a.Text.All(Char.IsDigit);
            if (!isNumeric)
            {
                //MessageBox.Show("numeric");
                a.Text = "";
                //MessageBox.Show("not numeric");

            }

        }


        public static void MdsAppisFloat(TextBox a)
        {

            float f;
            if (!float.TryParse(a.Text, out f))
            {
                // success! Use f here
                a.Text = "";

            }
        }

        public static long LongRandom  (long min, long max, Random rand)
        {
            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;
        }


    }

}