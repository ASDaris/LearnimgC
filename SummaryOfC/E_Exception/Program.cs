using System.Text;

namespace E_Exception
{
    public class CreditCardWithdrawException : Exception // кастомное исключение, все должны быть в курсе нового исключения
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //File.Copy("test.txt", @"Q:\tmp\test_copt.txt", overwrite: true);
                File.Copy("test.txt", "test_copt.txt", overwrite: true);

                File.Move("test_copy.txt", "test_copy_renamed.txt");

                File.Delete("test_copy.txt");

                if (File.Exists("test.txt"))
                {
                    File.AppendAllText("test.txt", "bla");
                }

                File.Replace("test_2.txt", "test_3.txt", "test_backup.txt");

                bool existDir = Directory.Exists(@"C:\tmp");
                if (existDir)
                {
                    var files = Directory.EnumerateFiles(@"C:\tmp", "*.txt", SearchOption.AllDirectories);
                    foreach (var file in files)
                        Console.WriteLine(file);
                    
                }
                //string fullPath = Path.Combine(path1, path2, path3);
                //Path.GetExtension.
            }
            catch
            {

            }
        }
        static void FileDemo()
        {
            string[] allLines = File.ReadAllLines("test.txt");

            IEnumerable<string> lines = File.ReadLines("test.txt");

            File.WriteAllText("test_2.txt", "My name is John");
            File.WriteAllLines("test_3.txt", new string[] { "My name", "is John" });
            File.WriteAllBytes("test_4.txt", new byte[] { 72, 101, 108, 108, 111 });

            string allText = File.ReadAllText("test_2.txt");
            Console.WriteLine(allText);

            string[] alltext = File.ReadAllLines("test_3.txt");
            Console.WriteLine(allText[0]);
            Console.WriteLine(allText[1]);

            byte[] bytes = File.ReadAllBytes("test_4.txt");
            Console.WriteLine(Encoding.ASCII.GetString(bytes));

            Console.ReadLine();

            Stream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                string str = "Hell World";
                byte[] strInBytes = Encoding.ASCII.GetBytes(str);

                fs.Write(strInBytes, 0, strInBytes.Length);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.ToString}");
            }
            finally
            {
                fs.Close();
            }

            Console.WriteLine("now reading");

            using (Stream readingStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read)) // в юзинге нету catch, иплиментирует IDispose
            {
                byte[] temp = new byte[readingStream.Length];

                int bytesToRead = (int)readingStream.Length;
                ASCIIEncoding encoding = new ASCIIEncoding();
                int bytesRead = 0;
                while (bytesToRead > 0)
                {
                    int n = readingStream.Read(temp, bytesRead, bytesToRead);

                    if (n == 0)
                        break;

                    bytesRead += n;
                    bytesToRead -= n;
                }
                string str = Encoding.ASCII.GetString(temp, 0, bytesRead);

                Console.WriteLine(str);

                Console.ReadLine();
            }
        }
        static void ExceptionDemo()
        {
            FileStream file = null;
            try
            {
                file = File.Open("temp.txt", FileMode.Open);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally //отрабатывает в любом случае, используется для чистки
            {
                if (file != null)
                    file.Dispose();
            }

            Console.ReadLine();

            Console.WriteLine("Please input a number");
            string result = Console.ReadLine();

            int number = 0;
            try
            {
                number = int.Parse(result);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("A format exception has occured");
                Console.WriteLine("Information is below");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex) //ловит все исключения, на практике применять не рекомендуется, каждое исключение требует своей обработки
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine(number);
        }
    }
}
