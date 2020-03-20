//Pablo Conde - 20-03-2020

using System;
using System.IO;
using System.Collections.Generic;

class PbmFormat
{

    static void Main()
    {
        Console.Write("File name: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
            Console.WriteLine("File does not exist");
        else
        {
            try
            {
             
                List<string> myList = new List<string>(
                File.ReadAllLines(fileName));
                
                if (myList[0][0] == 'P' &&
                    (myList[0][1] >= '1' && myList[0][1] <= '6'))
                {
                    Console.WriteLine("This is a PBM file");
                    Console.WriteLine();
                    
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i].StartsWith("#"))
                        {
                            myList.RemoveAt(i);
                            i--;
                        }
                    }
                    
                    string[] dimensions = myList[1].Split();
                    int width = Convert.ToInt32(dimensions[0]);
                    //int height = Convert.ToInt32(dimensions[1]);
                    
                    string image = "";
                    
                    for (int i = 2; i < myList.Count; i++)
                    {
                        image += myList[i];
                    }
                    
                    image = image.Replace("00", "0 0");
                    image = image.Replace("01", "0 1");
                    image = image.Replace("11", "1 1");
                    image = image.Replace("10", "1 0");
                    
                    int count = 0;
                    for (int i = 0; i < image.Length; i++)
                    {
                       
                       if(image[i] == '1')
                            Console.Write('#');
                        
                        else
                            Console.Write(' ');
                        count++;
                        
                        if(count == width*2)
                        {
                            Console.WriteLine();
                            count = 0;
                        }
                    }
                    
                }
                else
                    Console.WriteLine("This is not a PBM file");

            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Error: Path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O Error");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
