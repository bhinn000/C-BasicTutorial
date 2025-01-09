//"property" concept
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    public class Customer
    {
        string _custID; //private field
        bool _status;
        string _cname;
        double _balance;
        Cities _city;//enum - userDefined
        States _state;


        public Customer(string custID, bool status, string cname, double balance, Cities city, string country)
        {
            _custID = custID;
            _status = status;
            _cname = cname;
            _balance = balance;
            _city = city;
            Country = country; // we dont need to define in the class 
        }

        public string custID
        {
            get { return _custID; }
        }

        public string cname
        {
            get { return _cname; }
            set { _cname = value; }
        }


        public bool status {
            get { return _status; }
        }

        public double balance
        {
            get { return _balance; }
            set
            {
                if (status == true)//only modify the status when its active
                {
                    if (value > 100) //refering to "customer.balance"
                    {
                        _balance = value;//then update to "_balance"
                    }

                }
            }
        }

        public Cities City
        {
            get { return _city; }
            set
            {
                if (status == true)
                {
                    _city = value;//value is string here as _city is string
                }
            }
        }

        //"above properties are set to "public" hence can be access by any class
        //but to allow only child class to modify or access it we can use "protected" modifier in accesser(get and set)
        //eg: setState , getState
        public States state
        {
            get { return _state; }
            protected set //now it can only be modified by its child class
            {
                if (status == true)
                {
                    _state = value;
                }
            }
        }

        public string Country//auto implemented property
            {
                get;
                set;
            }



        



    }
}
