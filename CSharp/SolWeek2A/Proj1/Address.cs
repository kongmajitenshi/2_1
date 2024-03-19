using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    internal class Address
    {
        static void Main(string[] args)
        {
            Test1(); // 프로그램의 시작과 끝은 Main 메소드임.
            Test2();
        }

        private static void Test2()
        {
            AddressBook addrBook1 = new AddressBook();              
            addrBook1.Name = "김인하";                              
            addrBook1.Address = "인천1";                            
            addrBook1.Phone = "010-1111-1111";                      
            addrBook1.Group = "";                                   
                                                                    
            AddressBook addrBook2 = new AddressBook();              
            addrBook2.Name = "문인하";                              
            addrBook2.Address = "인천2";
            addrBook2.Phone = "010-2222-2222";
            addrBook2.Group = "친구";

            System.Console.WriteLine(addrBook1.Address);
        }

        private static void Test1()
        {
            string name1 = "김인하";
            string addr1 = "인천1";
            string phone1 = "010-1234-5678";
            string group1 = " ";

            string name2 = "문인하";
            string addr2 = "인천2";
            string phone2 = "010-5678-1234";
            string group2 = "친구";

            System.Console.WriteLine(name1 + "/" + addr1);
            System.Console.WriteLine(name2);

            // throw new NotImplementedException();
        }
    }
}
