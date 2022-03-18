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
            DataGeneric<string> dataGeneric = new DataGeneric<string>("1302204001");
            dataGeneric.PrintData();
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<Y>(ref Y nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }

    public class DataGeneric<Y>
    {
        private Y Data;

        public DataGeneric(Y Data)
        {
            this.Data = Data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah " + Data);
        }
    }
}