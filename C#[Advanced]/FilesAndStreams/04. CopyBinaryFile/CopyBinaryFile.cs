using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        FileStream copiedFile = new FileStream("../../file.txt", FileMode.Open);
        FileStream newFile = new FileStream("../../copied.txt", FileMode.Create);

        using(copiedFile)
        {
            using(newFile)
            {
                double fileLength = copiedFile.Length;
                byte[] buffer = new byte[4096];

                while(true)
                {
                    int readBytes = copiedFile.Read(buffer, 0, buffer.Length);
                    if(readBytes == 0)
                    {
                        break;
                    }
                    newFile.Write(buffer, 0, readBytes);
                }
            }
        }

    }
}

