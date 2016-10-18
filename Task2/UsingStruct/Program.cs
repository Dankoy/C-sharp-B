using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStruct
{
    class Program
    {
        struct AddressBookType      // Struct 
        {
            public string name;
            public string telfax;
        }
        static void Main(string[] args)
        {
            AddressBookType[] myAB = new AddressBookType[100];

            char icount;
            char iloop;

            int i = 0;  //Amount of entries in address book
            int j = 0;  //Counter for loop

            while (true)
            {
                Console.Write("Insert kod (0 - new record, 1 - show all, 2 - exit): ");
                icount = (char)Console.Read();
                while (true)
                {
                    iloop = (char)Console.Read();
                    if (iloop == '\n')
                    {
                        break;
                    }
                }
                if (icount == '2')
                {
                    break;
                }
                switch (icount)
                {
                    case '0': break;
                    case '1': break;
                    default: Console.WriteLine("Reading error!");
                        break;
                }
            }
        }
    }
}
