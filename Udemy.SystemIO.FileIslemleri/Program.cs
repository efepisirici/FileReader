using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.SystemIO.FileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string txt =  FileReadAllText("c:\\something\\text.txt");
            string binary = FileReadAllBinary("c:\\something\\csv.csv");
            string reversetxt = FileReadAllTextReverse("c:\\something\\text.txt");
            string withExtHandle = FileExtensionHandler("c:\\something\\text.txt", true);
            string withDataTypeHandle = FileDataTypeHandler("c:\\something\\text.txt", true,true);

        }

        static string FileDataTypeHandler(string path, Boolean reverse,Boolean dataTypeText)
        {
            string ext = Path.GetExtension(path);


            if (dataTypeText == true && reverse == true)
                return FileReadAllTextReverse(path);
            if (dataTypeText == true && reverse == false)
                return FileReadAllText(path);
            if (reverse == true)
                return FileReadAllBinaryReverse(path);
            else
                return FileReadAllBinary(path); 
        }
        static string FileExtensionHandler(string path,Boolean reverse)
        {
            string ext = Path.GetExtension(path);


            if (ext == ".txt" && reverse == true)
                return FileReadAllTextReverse(path);
            if (ext == ".txt" && reverse == false)
                return FileReadAllText(path);
            if (reverse == false)
                return FileReadAllBinaryReverse(path);
            else
                return FileReadAllBinary(path);
        }

        static string FileReadAllText(string path)
        {
            string metinDegeri =  File.ReadAllText(path);
            return metinDegeri.Substring(0, 5); ;
        }
        static string FileReadAllBinary(string path)
        {
            // Read the file and convert it to Byte Array


            string filename = Path.GetFileName(path);



            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            Byte[] bytes = br.ReadBytes((Int32)fs.Length);

            br.Close();

            fs.Close();
            return bytes.ToString().Substring(0, 5);
            
        }
        static string FileReadAllTextReverse(string path)
        {
            string metinDegeri = FileReadAllText(path);

            
            return ReverseStr(metinDegeri);


        }
        static string FileReadAllBinaryReverse(string path)
        {

            string metinDegeri = FileReadAllBinary(path);

            return ReverseStr(metinDegeri);

        }
        static string ReverseStr(string metinDegeri)
        {
 

            // Converting string to character array
            char[] charArray = metinDegeri.ToCharArray();

            // Declaring an empty string
            string reversedString = String.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {

                // Append each character to the reversedstring.
                reversedString += charArray[i];
            }

            // Return the reversed string.
            return reversedString;


        }



    }
}
