using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptEngineBase
{
    public class Reader
    {

        StreamReader SReader;
        ArrayList Datas;
        string Line;

        public Reader()
        {
            Initializer();
        } 

        public Reader(string filePath)
        {
            Initializer(filePath);
        }

        public int Initializer()
        {
            Initializer("first.txt");
            return 0;
        }

        public int Initializer(string filePath)
        {
            Line = "";
            Datas = new ArrayList();

            using (SReader = new StreamReader(filePath, Encoding.GetEncoding("UTF-8")))
            {
                while ((Line = SReader.ReadLine()) != null)
                {
                    Datas.Add(Line);
                }
            }
            return 0;
        }

        public ArrayList GetList()
        {
            return Datas;
        }
    }
}
