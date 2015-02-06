using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace PreProcess
{
    class Program
    {
        static void Main()
        {
            Regex g = new Regex(@"^[a-zA-Z_]+$");
            using (StreamWriter w = new StreamWriter("C:\\Users\\pew pew the coon\\Desktop\\enwiki-20150112-all-titles-in-ns0\\test3.txt"))
            {
                using (StreamReader r = new StreamReader("C:\\Users\\pew pew the coon\\Desktop\\enwiki-20150112-all-titles-in-ns0\\enwiki-20150112-all-titles-in-ns0"))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        Match m = g.Match(line);
                        if (m.Success)
                        {
                            string line2 = line.Replace("_", " ");
                            w.WriteLine(line2);
                        }
                    }
                }
            }
        }
    }
}
