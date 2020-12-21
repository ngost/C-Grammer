//using System;
//using _Net_Grammer.Grammer.Basic;
//namespace _Net_Grammer.Grammer.etcs
//{
//    public class Exam_For_Button
//    {
//        public static void Main(string[] args)
//        {
//            ButtonGrammer buttonGrammer = new ButtonGrammer();
//            //before handler add
//            buttonGrammer.ButtonClicked();

//            //after handler add

//            buttonGrammer.handler += new EventHandler(OnClick);
//            buttonGrammer.ButtonClicked();

//            //after remove handler
//            buttonGrammer.handler -= new EventHandler(OnClick);
//            buttonGrammer.ButtonClicked();
//        }

//        public static void OnClick(Object obj,EventArgs e)
//        {
//            Console.WriteLine("Button clicked");
//        }
//    }
//}
