using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace DataAccess.Streams
{
    public class FileStreamExploration
    {
        public static void TestFileStream()
        {
            using (FileStream fileStream = new FileStream("OutputTet.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                var outputMessageString = "Test";
                byte[] outputMessageBytes = Encoding.UTF8.GetBytes(outputMessageString);
                fileStream.Write(outputMessageBytes, 0, outputMessageBytes.Length);
                fileStream.Close();
            }

            using (FileStream inputStream = new FileStream("OutputTet.txt", FileMode.Open, FileAccess.Read))
            {
                long fileLength = inputStream.Length;
                byte[] readBytes = new byte[fileLength];
                inputStream.Read(readBytes, 0, (int)fileLength);
                string readString = Encoding.UTF8.GetString(readBytes);
                inputStream.Close();
                Console.WriteLine($"Read message: {readString}");
            }
        }

        public static void TestStreamWriterAndReader()
        {
            using (StreamWriter writer = new StreamWriter("OutputText.txt"))
            {
                writer.Write("Test stream writer");
            }

            using (StreamReader reader = new StreamReader("OutputText.txt"))
            {
                var message = reader.ReadToEnd();
                Console.WriteLine(message);
            }
        }

        public static void TestCompressedFiles()
        {
            using (FileStream writeFile = new FileStream("CompText.zip", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (GZipStream writeFileZip = new GZipStream(writeFile, CompressionMode.Compress))
                {
                    using (StreamWriter writer = new StreamWriter(writeFileZip))
                    {
                        writer.Write("Test stream writer");
                    }
                }
            }

            using (FileStream readFile = new FileStream("CompText.zip", FileMode.Open, FileAccess.Read))
            {
                using (GZipStream readFileZip = new GZipStream(readFile, CompressionMode.Decompress))
                {
                    using (StreamReader reader = new StreamReader(readFileZip))
                    {
                        var message = reader.ReadToEnd();
                        Console.WriteLine(message);
                    }
                }
            }
        }

        public static void TestFileClass()
        {
            File.WriteAllText("TextFile.txt", "Początek");
            File.AppendAllText("TextFile.txt", " - Koniec");
        }

        public static void TestFileWithHandleExceptions()
        {
            try
            {
                string contents = File.ReadAllText("TestFile.txt");
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}