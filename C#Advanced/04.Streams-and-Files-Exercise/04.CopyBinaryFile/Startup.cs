using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    public class Startup
    {
        public static void Main()
        {
            FileStream binaryOpen = new FileStream(@"../../LaLaLand.jpg", FileMode.Open, FileAccess.Read);
            FileStream binaryCreate = new FileStream(@"../../LaLaLandCopy.jpg", FileMode.Create, FileAccess.ReadWrite);
            
            using (binaryOpen)
            {
                using (binaryCreate)
                {
                    while (binaryOpen.Position < binaryOpen.Length)
                    {
                        binaryCreate.WriteByte((byte)binaryOpen.ReadByte());
                    }
                }
            }

            // Alternative Solution (with buffer)
            bool isCopyMade = CopyBinaryFile(@"../../LaLaLand.jpg", @"../../LaLaLandCopyAlternative.jpg");
            Console.WriteLine(isCopyMade);
        }

        static bool CopyBinaryFile(string srcfilename, string destfilename)
        {

            if (File.Exists(srcfilename) == false)
            {
                Console.WriteLine("Could not find the Source file");
                return false;
            }

            Stream binaryOpen = File.Open(srcfilename, FileMode.Open);
            Stream binaryCreate = File.Open(destfilename, FileMode.Create);

            BinaryReader f1 = new BinaryReader(binaryOpen);
            BinaryWriter f2 = new BinaryWriter(binaryCreate);

            while (true)
            {
                byte[] buffer = new byte[10240];
                int sz = f1.Read(buffer, 0, 10240);
                if (sz <= 0)
                    break;
                f2.Write(buffer, 0, sz);
                if (sz < 10240)
                    break; // eof reached
            }
            f1.Close();
            f2.Close();
            return true;
        }
    }
}
