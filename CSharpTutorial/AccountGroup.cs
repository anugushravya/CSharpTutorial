using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class AccountGroup
    {
       

        public int Gid
        {
            get;set;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }


            AccountGroup acctGrp = (AccountGroup)obj;

            return Gid == acctGrp.Gid;
        }

        public override int GetHashCode()
        {
            return 1542067571 + Gid.GetHashCode();
        }




    }
}
