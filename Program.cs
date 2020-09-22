using System;
using System.IO;
using System.Text;
namespace read_write_in_any_coding
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"boot.ini");
            
            StreamWriter sw = new StreamWriter(@"boot_utf7.txt", false, Encoding.UTF7); 
            sw.WriteLine(sr.ReadToEnd());
            sw.Close();
            sr.Close();
        }
    }
}
