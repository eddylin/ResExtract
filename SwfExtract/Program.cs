using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwfDotNet;
using SwfDotNet.IO;

namespace SwfExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"");

            using (FileStream fs = file.OpenRead())
            {
                SwfReader reader = new SwfReader(fs);

                Swf swf = reader.ReadSwf();
            }
        }
    }
}
