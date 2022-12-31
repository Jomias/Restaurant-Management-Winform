using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GenerateID
    {
        public static string GetID(string prefix)
        {
            Random rd = new Random();
            return prefix + DateTime.Now.ToString("ddMMhhmmss") + Convert.ToString((char)rd.Next(65, 122));
        }
    }
}
