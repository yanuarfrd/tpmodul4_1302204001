using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4_1302204001
{
    public class ClassMain
    {
        public static void Main(string[] args)
        {
            String nama = "Yapi";
            HaloGeneric.SapaUser<string>(ref nama);
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<Y>(ref Y nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }
}