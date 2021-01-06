using System;
using _Net_Grammer.Grammer.Basic;
using _Net_Grammer.Grammer.etcs;
namespace _Net_Grammer.Grammer.etcs
{
    

    public class Exams
    {
        ////class values
        //public const int Const_Grammer = 1;
        //public const int Array_Grammer = 2;
        //public const int String_Grammer = 3;
        //public const int StringBuilder_Grammer = 4;

        // changed enum

        public GrammerInterface? grammer;
        //instants function
        public void RunExample(int grammer_name)
        {
            
            grammer = null;
            switch (grammer_name)
            {
                case (int)Example_Code.Const_Grammer :
                    grammer = new ConstGrammer();
                    break;

                case (int)Example_Code.Array_Grammer:
                    grammer = new ArrayGrammer();
                    break;

                case (int)Example_Code.String_Grammer:
                    grammer = new StringGrammer();
                    break;

                case (int)Example_Code.StringBuilder_Grammer:
                    grammer = new StringBuilderGrammer();
                    break;

                case (int)Example_Code.Enum_Grammer:
                    grammer = new EnumGrammer();
                    break;

                case (int)Example_Code.Loop_Grammer:
                    grammer = new LoopGrammer();
                    break;

                case (int)Example_Code.IEnumerator_Grammer:
                    grammer = new IEnumeratorGrammer();
                    break;

                case (int)Example_Code.Person_Grammer:
                    grammer = new PersonGrammer();
                    break;

                case (int)Example_Code.PreProcessor_Grammer:
                    grammer = new PreprocessorGrammer();
                    break;
                case (int)Example_Code.Indexer_Grammer:
                    grammer = new IndexerGrammer();
                    break;
                case (int)Example_Code.Inheritance_Grammer:
                    grammer = new InheritanceGrammer();
                    break;
                case (int)Example_Code.Generic_Grammer:
                    grammer = new GenericGrammer();
                    break;
                case (int)Example_Code.Interface_Grammer:
                    grammer = new InterfaceGrammer();
                    break;
                case (int)Example_Code.Delegate_Grammer:
                    grammer = new DelegateGrammer();
                    break;
                case (int)Example_Code.Form_Grammer:
                    grammer = new FormGrammer();
                    break;
                case (int)Example_Code.Lambda_Grammer:
                    grammer = new LambdaGrammer();
                    break;
                case (int)Example_Code.Anonymous_Grammer:
                    grammer = new AnonymousGrammer();
                    break;
                case (int)Example_Code.ExtendMehtod_Grammer:
                    grammer = new ExtendMethodGrammer();
                    break;
                default:
                    //grammer null
                    System.Console.WriteLine("Not exist example. Please using another Example");
                    return;
            }
            grammer.PrintConsole();
        }
    }
}
