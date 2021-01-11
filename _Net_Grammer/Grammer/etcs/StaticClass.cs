using System;
using _Net_Grammer.Grammer.etcs;
using System.Text;

namespace _Net_Grammer.Grammer.Basic
{
    public static class StaticClass
    {
        public static string CaseConverter(this string str, CaseEnumeration case_enum)
        {
            StringBuilder strBuilder = new StringBuilder();

            //step1 : each case converting and append to builder.
            switch (case_enum)
            {
                case CaseEnumeration.LOWER_CASE_MODE:

                    foreach (char ch in str)
                    {
                        if (ch >= 'A' && ch <= 'Z')
                        {
                            strBuilder.Append((char)(ch - 'A' + 'a'));
                        }
                        else
                        {
                            strBuilder.Append((char)ch);
                        }
                    }
                    break;
                case CaseEnumeration.UPPER_CASE_MODE:

                    foreach (var ch in str)
                    {
                        if (ch >= 'a' && ch <= 'z')
                        {
                            strBuilder.Append((char)(ch - 'a' + 'A'));
                        }
                        else
                        {
                            strBuilder.Append((char)ch);
                        }
                    }
                    break;
            }


            //step 2 : return converted result
            return strBuilder.ToString();
        }


    }
}
