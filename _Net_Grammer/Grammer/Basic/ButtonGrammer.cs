using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class ButtonGrammer
    {
        public event EventHandler handler;

        public ButtonGrammer()
        {

        }

        public void ButtonClicked()
        {
            if (handler != null)
                handler(this, EventArgs.Empty);
            else
                Console.WriteLine("! Handler must be inited.");
        }


    }
}
