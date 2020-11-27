using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class shallow
    {
        protected internal static string ReadIn(string Pathway, string FileNamed)
        {
            string returnValue = "";
              if (Directory.Exists(Pathway))
              {
                  try
                  {
                    returnValue = File.ReadAllText(Pathway+FileNamed);
                  }
                  catch (Exception lied)
                  {
                      Console.WriteLine("ReadIn errors \ndetails:" + lied.Message.ToString());
                      // MessageBox.Show(lied.Message.ToString());
                  }
              }
              else
              {
                  System.IO.Directory.CreateDirectory(Pathway);
              }
              //Console.WriteLine(dll.connectionString);*/
            return returnValue;
        }
    }
}
