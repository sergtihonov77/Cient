using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Client
    {
        string name, sname, addr;
        float deposit;

        public Client(string name,string sname) 
        {
            this.name = name;
            this.sname = sname;
        }

        public Client(string name, string sname,string addr)
        {
            this.name = name;
            this.sname = sname;
            this.addr = addr;
        }

        public Client(string name, string sname, string addr, float dep)
        {
            this.name = name;
            this.sname = sname;
            this.addr = addr;
            this.deposit = dep;
        }

        public string Addr
        {
            get
            {
                if (addr != "") return addr;
                else return "Бомж";
                }
            set { addr = value; }
        }

        public float Deposit 
        {
            get { return deposit; }
            set
            {
                if (value > 0) deposit = value;
            }
        }

        public string Name
        {
            get { return name; }       
        }

        public string Sname
        {
            get { return sname; }      
        }
    }
}
