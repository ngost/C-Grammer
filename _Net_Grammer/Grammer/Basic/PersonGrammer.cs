using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class PersonGrammer : GrammerInterface
    {
        //field
        private int age;
        private string f_name,l_name;
        public event EventHandler nameInfoCheckHandler;
        Address address;
        //structure

        public struct Address
        {
            private string address_name;
            private UInt32 address_number;

            public string GetAddress()
            {
                string outString = "name : [" + this.address_name + ", " + "number : " + this.address_number.ToString() + "]";
                return outString;
            }

            public void SetAddress(string name, UInt32 number)
            {
                this.address_name = name;
                this.address_number = number;
            }

        }

        //property
        public string Name
        {
            get
            {
                //full name
                return f_name + l_name;
            }
            set
            {
                this.f_name = value.Substring(0, 1);
                this.l_name = value.Substring(1);
                if(nameInfoCheckHandler != null)
                {
                    Console.WriteLine("handler not null");
                    nameInfoCheckHandler(this, EventArgs.Empty);
                }
            }
        }
        

        public PersonGrammer()
        {
            //this is Class Grammer , property, method,field, event
            this.address = new Address();
            this.address.SetAddress("전남 광양시 엑스포역5길", 57779);
            this.address.GetAddress();
            Name = "이진영";
        }

        public void PrintConsole()
        {

            Console.WriteLine("--person infomation--");
            //call from property
            Console.WriteLine("name : " + Name);

            //call from struct
            Console.WriteLine("address : " + this.address.GetAddress());

            NameChangeEventHandlerTest();

            //call from property
            Console.WriteLine("name : " + Name);

            //call from struct
            Console.WriteLine("address : " + this.address.GetAddress());
        }

        public void NameChangeEventHandlerTest()
        {
            //init handler
            this.nameInfoCheckHandler += new EventHandler(NameChanged);

            //handler test
            this.Name = "박진영";
        }

        //event handler
        public void NameChanged(object sender,EventArgs e)
        {
            Console.WriteLine("이름이 바뀌었네요 // called event handler");
        }
    }
}
