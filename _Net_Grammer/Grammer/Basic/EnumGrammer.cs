using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class EnumGrammer : GrammerInterface
    {
        [Flags]
        enum HumanFeature
        {
            cute = 1,
            beautyful = 2,
            strong = 4,
            genious = 8,
            powerful = 16,
            sexy = 32,
            strange = 64
        }

        HumanFeature my_feature;
        public EnumGrammer()
        {
            // select your feature.. i will have 3 features.
            my_feature = HumanFeature.cute | HumanFeature.genious | HumanFeature.strange;
        }

        public void PrintConsole()
        {
            //flag checking
            if(my_feature.HasFlag(HumanFeature.cute) && my_feature.HasFlag(HumanFeature.genious))
            {
                //flag checking another case
                if((my_feature & HumanFeature.powerful) == 0)
                {
                    //i'm not strong.
                    Console.WriteLine(my_feature);
                }
                else //if not have powerful feature
                {
                    Console.WriteLine("It's not me.");
                }
            }
        }
    }
}
