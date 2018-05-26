using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace d_log.Models
{
    public class CInstance
    {
        public static CUserManager theUserManager;
        public static int bInit = 0;
        public static void Initalize()
        {
            if (bInit == 0)
            {
                theUserManager = new CUserManager();
            }
            bInit = 1;
        }
    }
}