using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace workingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = @"D:\Exemple\test.txt";
            CreateFiles(link);
            ReadFiles(link);
        }
        static void CreateFiles(string link)
        {
           
            if (!File.Exists(link))
            {
             /*kiểm tra file tồn tại hay không ? ( ! là phủ định ) : không tồn tại thì tạo
              * StreamWriter là support tool
              * using : ý nghĩa là dùng 1 lần rùi bỏ 
              * 
              */
                using (StreamWriter sw = File.CreateText(link))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                    sw.WriteLine("tui la vinh dep trai");
                }
            }
        }
        static void ReadFiles(string link)
        {

            using (StreamReader sr = File.OpenText(link))
            {
               
            }
        }
    }
}
