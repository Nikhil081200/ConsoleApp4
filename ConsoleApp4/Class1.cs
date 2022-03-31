using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Collections;                //used to store different type of data[non-generic]
using System.Collections.Generic;        //used to store single type of data
using System.Threading;                  //Function delegate
using System.Threading.Tasks;            //Action delegate
using System.Linq;


namespace ConsoleApp4
{
    class Employee
    {
        public string ename { get; set; }
        public string edesig { get; set; }
        public string dept { get; set; }
        public List<string> skillset { get; set; }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Employee[] Elist = new Employee[]
            {
                new Employee(){ename = "john",edesig="s/w engg",dept ="Dev",skillset=new List<string>(){ "HTML","CSS","MYSQL"} },
                new Employee(){ename = "Sam",edesig="s/w engg",dept ="Dev",skillset=new List<string>(){ "HTML","Jquery"} },
                new Employee(){ename = "SCOTT",edesig="s/w engg",dept ="testing",skillset=new List<string>(){ "J-Meter","CSS","MYSQL"} },
                new Employee(){ename = "MARY",edesig="Accountant",dept ="Accounts",skillset=new List<string>(){ "M-Com","CSS","MYSQL"} }
            };
        }
    }
}
