using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExercises
{
    internal class TextIO
    {
        public void Run()
            {
                string path = @"test.txt";

                //write file
                if (!File.Exists(path))
                {
                    try
                    {
                        StreamWriter writer = new StreamWriter(path);
                        writer.WriteLine();
                        writer.WriteLine();
                        writer.WriteLine();
                        writer.Close();
                        try
                        {
                            writer.Dispose();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

                //read file
                try
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string str;
                        while ((str = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(str);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
    }
}
