using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTable
{
    public class Employee
    {
        private String fullName;


        public String FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        private String post;

        public String Post
        {
            get { return post; }
            set { post = value; }
        }
    }
}
