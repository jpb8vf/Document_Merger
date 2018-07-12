using System;
using System.IO;
using System.Text;

namespace Document_Merger
{
    class Program
    {

        static void runOnce()
        {
            Console.WriteLine("Document Merger"); 
            Console.WriteLine(); 


            String first = ""; 
            String second = ""; 
            bool FP = true; 
            do
            {
                if (FP) 
                {
                    FP = false; 
                }
                else
                {
                    Console.WriteLine("Wrong filename."); 
                }
                Console.WriteLine("Enter the first file to be merged:"); 
                first = Console.ReadLine(); 
            } while (first.Length > 0 && !File.Exists(first)); 
            FP = true; 
            do
            {
                if (FP) 
                {
                    FP = false; 
                }
                else
                {
                    Console.WriteLine("Wrong filename."); 
                }
                Console.WriteLine("Enter the second file to be merged:"); 
                second = Console.ReadLine(); 
            } while (second.Length > 0 && !File.Exists(second)); 

            String merged = first.Substring(0, first.Length - 4) + second.Substring(0, second.Length - 4) + ".txt"; 

           



            StreamWriter x = null; 
            StreamReader y = null; 
            StreamReader z = null; 

            bool success = false; 

            int count = 0; 

            try
            {
                x = new StreamWriter(merged); 
                y = new StreamReader(first); 
                z = new StreamReader(second); 

                String line = y.ReadLine(); 
                while (line != null) 
                {
                    x.WriteLine(line); 
                    count += line.Length; 
                    line = y.ReadLine(); 
                }
                line = z.ReadLine(); 
                while (line != null) 
                {
                    x.WriteLine(line); 
                    count += line.Length; 
                    line = z.ReadLine(); 
                }
                success = true; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (x != null)
                    x.Close(); 
                if (y != null)
                    y.Close(); 
                if (z != null)
                    z.Close(); 
                if (success)
                    Console.WriteLine(merged + " was successfully saved. The document contains " + count + " characters."); 
            }
        }





        static void Main(string[] args)
        {
            do
            {
                runOnce();
                Console.WriteLine("would you like to run again? y or n"); 
                char a = Console.ReadLine()[0]; 
                if (a == 'n')
                    break; 
            } while (true); 
        }
    }
}
