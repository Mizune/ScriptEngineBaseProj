using System;


namespace ScriptEngineBase
{
    public class ViewController
    {
        // 割り当てられるView捜査を記述する

        private string MainText;
        private string BGIPath;
        private string SEPath;
        private string CenterCharImgPath;
        private string RightCharImgPath;
        private string LeftCharImgPath;


        public int ChangeText(string Text)
        {
            Console.WriteLine("Textを{0}に変更する", Text);
            return 0;
        }

        public int ChangeBGI(string FilePath)
        {
            Console.WriteLine("BGIを変更 {0}",FilePath);
            return 0;
        }

        public int UseSE(string FilePath)
        {
            Console.WriteLine("SEを使用 {0}",FilePath);
            return 0;
        }

        public int ChangeCenterCharImg(string FilePath)
        {
            Console.WriteLine("CenterChar変更 {0}",FilePath);
            return 0;
        }

        public int ChangeRightCharImg(string FilePath)
        {
            Console.WriteLine("LeftChar変更 {0}", FilePath);
            return 0;
        }

        public int ChangeLeftCharImg(string FilePath)
        {
            Console.WriteLine("RightChar変更 {0}", FilePath);
            return 0;
        }

        public int ChangeThumbnailCharImg(string FilePath)
        {
            Console.WriteLine("ThumbnailImage変更 {0}",FilePath);
            return 0;
        }
    }
}