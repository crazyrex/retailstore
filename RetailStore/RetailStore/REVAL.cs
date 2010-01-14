using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace RetailStore
{
    class REVAL
    {
        const string exp = "[a-z|A-Z]";
        Regex reg = new Regex(exp);

        public Boolean emptyCheck(string str)
        {
            return (string.IsNullOrEmpty(str));
        }
        
        public Boolean numCheck(string str)
        {
            return (!(Information.IsNumeric(str)));
        }

        public Boolean charCheck(string input)
        {
            return(!(reg.IsMatch(input)));
        }
    }
}
