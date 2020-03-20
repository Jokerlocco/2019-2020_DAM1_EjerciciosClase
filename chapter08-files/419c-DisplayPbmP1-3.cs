//kiko
using System;
using System.IO;

class P1
{
    static void Main()
    {
        string path;
        Console.WriteLine("Type the path:");
        path = Console.ReadLine();
        Console.Clear();
       
        if (File.Exists(path))
        {                 
            try
            {
                StreamReader data = new StreamReader(path);
                string content;
                bool widthCheck = false;
                int width= 0;
                int newLine = 0;
                content = data.ReadLine();
                
                if (content == "P1")
                {
                    do
                    {
                        content = data.ReadLine();
                        if(content!= null)
                        {
                            if(!content.StartsWith("#") && !widthCheck)
                            {
                                width = Convert.ToInt32(content.Split(' ')[0]);
                                widthCheck = true;
                            }                            
                            else if(widthCheck)
                            {
                                for(int i = 0; i < content.Length;i++)
                                {
                                    if (content[i] == '1')
                                    {
                                        Console.Write("o");
                                        newLine++;
                                    }                                    
                                    else if (content[i] == '0')
                                    {
                                        Console.Write(" ");
                                        newLine++;
                                    }                                    
                                    if(newLine == width)
                                    {
                                        Console.WriteLine();
                                        newLine = 0;
                                    }
                                }
                            }
                        }
                    } while (content != null);
                    
                    data.Close();
                }
            }catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O error");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
