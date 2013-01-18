using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace _4.DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string url = "http://www.devbg.org/img/Logo-BASD.jpg";
            string filename = url.Split('/').Last();

            try
            {
                client.DownloadFile(url, filename);
                Console.WriteLine("File downloaded successfully!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error while accessing the network");
            }
            catch(NotSupportedException)
            {
                Console.WriteLine("The downloading or saving operation is not supported");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured while downloading the file: {0}", ex.Message);
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
