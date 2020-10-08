using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
   public partial class SamplePartialCustomer
    {
        partial void SamplePartialMethod();

        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod Invoked");
           
        }

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod invoked");
            
            SamplePartialMethod();
            Console.ReadLine();

        }

        

    }
}
