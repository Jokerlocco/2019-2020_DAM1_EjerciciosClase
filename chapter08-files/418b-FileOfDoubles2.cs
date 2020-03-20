// Araceli Yáñez Muñoz
using System;
using System.IO;

class ReadWriteNativeData
{
    static void Main()
    {
        Console.Write("File name: ");
        string name = Console.ReadLine();

        if (File.Exists(name))
        {
            try
            {
                string option;
                do
                {
                    Console.WriteLine("A. Add data");
                    Console.WriteLine("V. View data");
                    Console.WriteLine("E. Exit");
                    option = Console.ReadLine();

                    switch (option.ToUpper())
                    {
                        case "A":
                            Console.Write("Data to enter: ");
                            double data = Convert.ToDouble(Console.ReadLine());

                            BinaryWriter output = new BinaryWriter(
                                File.Open(name, FileMode.OpenOrCreate));

                            output.Seek(0, SeekOrigin.End);
                            output.Write(data);
                            output.Close();
                            Console.WriteLine("Data added successfully");
                            break;
                        case "V":
                            BinaryReader input = new BinaryReader(
                                File.Open(name, FileMode.Open));
                            if (input.BaseStream.Length == 0)
                            {
                                Console.WriteLine("No data available");
                            }
                            else
                            {
                                do
                                {
                                    data = input.ReadDouble();
                                    Console.WriteLine(data);
                                } while (input.BaseStream.Length !=
                                         input.BaseStream.Position);
                            }
                            input.Close();
                            break;
                        case "E":
                            Console.WriteLine("Bye");
                            break;
                        default:
                            Console.WriteLine("Incorrect option.");
                            break;
                    }
                } while (option.ToUpper() != "E");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("path too long");
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
        else
            Console.WriteLine("File not found");
    }
}
