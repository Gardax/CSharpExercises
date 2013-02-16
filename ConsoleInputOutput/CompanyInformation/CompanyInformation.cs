using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyInformation
{
    class CompanyInformation
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhone = Console.ReadLine();
            string companyFax = Console.ReadLine();
            string companySite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();
            Console.WriteLine("The company name is {0}. The address of the company is: {1}. The phone is: {2}. Fax: {3}.The website is: {4}.",
                companyName,companyAddress,companyPhone,companyFax,companySite);
            Console.WriteLine("The manager of the company is {0} {1}. He is {2} years old. He is phone is: {3}",
                managerFirstName,managerLastName,managerAge,managerPhone);
            
        }
    }
}
