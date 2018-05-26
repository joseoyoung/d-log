using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace d_log.Models
{
    public class CUserManager
    {
        private List<Cuser> theUser;
        public CUserManager()
        {
            theUser = new List<Cuser>();
        }
        public int AddUser(ref Cuser aUser)
        {
            Cuser tmpUSer = new Cuser();
            tmpUSer.theUniqueID = 0;
            tmpUSer.theID = aUser.theID;
            tmpUSer.thePW = aUser.thePW;
            tmpUSer.theName = aUser.theName;
            tmpUSer.theEmail= aUser.theEmail;
            
            return 1;
        }
        public List<Cuser> GetUser()
        {
            return theUser;
        }
        public int CheckUser(string aID,string aPW)
        {
            foreach(Cuser iter in theUser)
            {
                if (iter.theName.Equals(aID) == true && iter.thePW.Equals(aPW) == true)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}