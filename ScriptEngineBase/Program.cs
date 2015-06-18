using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptEngineBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader("FirstScenarios.txt");
            Parser parser = new Parser(reader.GetList());

            parser.Parsing(); // FirstScenariosにレギュレーション通りにTextを作らせて動かす

            // ifの制御とBGMLoop追加
                        
        }
    }
}
