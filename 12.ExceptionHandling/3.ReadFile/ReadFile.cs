using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;

namespace _3.ReadFile
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            try
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("File content: \n {0}", content);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path cannot be null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The specified path is not valid");
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("The path is too long");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("The specified directory was not found");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The specified file was not found");
            }
            catch(IOException)
            {
                Console.WriteLine("Error while reading file");
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have permissions to read this file");
            }
            catch(NotSupportedException)
            {
                Console.WriteLine("The reading operation is not supported");
            }
            catch(SecurityException)
            {
                Console.WriteLine("A security error was detected while reading file");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured: {0}", ex.Message);
            }
        }
    }
}
