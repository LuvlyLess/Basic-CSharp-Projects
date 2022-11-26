using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class SampleClass
    {
        private int ID;
        private string firstname;
        

        public SampleClass(string firstname) : this(100, "") //defining multiple constructors to chain
        {// assigning firstname to firstname , providing a default ID if none input
            
        }


        public SampleClass(int ID, string firstname)
        {
            this.ID = ID;
            this.firstname = firstname;
        }


        public SampleClass(int ID) : this(ID, "")
        {
           
        }

       
        
          
    }
}
