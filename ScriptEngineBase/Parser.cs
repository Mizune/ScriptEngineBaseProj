using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptEngineBase
{
    public class Parser
    {
        int DataLength;
        ArrayList Datas;
        ViewController Controller;

        public Parser(ArrayList rawData)
        {
            Datas = rawData;
            DataLength = Datas.Count;
            Controller = new ViewController();
        }

        public int Parsing()
        {
            if (DataLength < 0)
                return -1;
            foreach(string data in Datas)
            {
                if (!BranchFunction(data))
                {
                    Console.WriteLine("Error. {0} is unknown function.",data);
                }
            }

            return 0;

            
        }

        public Boolean BranchFunction(string data)
        {
            if (!data.Contains("[") && !data.Contains("]")) 
            {
                Console.WriteLine("通常文章なのでTextRenderer呼び出し");
                Controller.ChangeText(data);
             } else {
                data.Replace("[",""); // 要らないものを消去
                data.Replace("]", "");

                string[] Datas = data.Split(' '); // スペースでsplit
                int DataSize = Datas.Length;

                if (DataSize != 1)
                {
                    Console.WriteLine("Error. 引数が足りません。");
                    return false; // Error. 
                }

                switch (Datas[0])
                {
                    case "CahgeBGI":
                        Controller.ChangeBGI(Datas[1]);
                        break;
                    case "UseSE":
                        Controller.UseSE(Datas[1]);
                        break;
                    case "ChangeCenterCharImg":
                        Controller.ChangeCenterCharImg(Datas[1]);
                        break;
                    case "ChangeRightCharImg":
                        Controller.ChangeRightCharImg(Datas[1]);
                        break;
                    case "ChangeLeftCharImg":
                        Controller.ChangeLeftCharImg(Datas[1]);
                        break;
                    case "ChangeThumbnailCharImg":
                        Controller.ChangeThumbnailCharImg(Datas[1]);
                        break;
                }

            }
            return true;
        }
    }
}
