using System;
using System.IO;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sreader = null;
            try
            {
                sreader = new StreamReader(@"D:\computers1.txt");
                Console.WriteLine(sreader.ReadToEnd());
                
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Please check whether file {0} exists", ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sreader != null)
                {
                    sreader.Close();
                }
                Console.WriteLine("finally executed");

            }
        }
    }
}
