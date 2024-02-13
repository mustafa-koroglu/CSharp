// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;
using Intro1.Entities;

Console.WriteLine("Hello, World!");


string message = "krediler";
int term = 12;
double amount = 10000.54;
bool isAuthenticated = true;

if (isAuthenticated == true)
{
    Console.WriteLine("Giriş başarılı");
}
else
{
    Console.WriteLine("Sisteme giriş yapılmadı");
}

string[] loans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4" }; //db den gelecek.
string[] loans2 = new string[4];
loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManagar courseManager = new CourseManagar();

Course[] courses = courseManager.GetAll();
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name);
}
Console.WriteLine("program bitti");

IndividualCustomer cust = new IndividualCustomer();
cust.Id = 1;
cust.NationalIdentity = "123123123123";
cust.FirstName = "Mustafa";
cust.LastName = "Köroğlu";
cust.CustomerNumber = "123123";

IndividualCustomer cust2 = new IndividualCustomer();
cust2.Id = 2;
cust2.NationalIdentity = "123123123123";
cust2.FirstName = "Mehmet";
cust2.LastName = "Köroğlu";
cust2.CustomerNumber = "123123";

CorporateCustomer cust3 = new CorporateCustomer();
cust3.Id = 3;
cust3.Name = "Kodlamaio";
cust3.CustomerNumber = "123123";
cust3.TaxNumber = "123124";

CorporateCustomer cust4 = new CorporateCustomer();
cust4.Id = 4;
cust4.Name = "btk akademi";
cust4.CustomerNumber = "123132423423";
cust4.TaxNumber = "123123242344";

BaseCustomer[] customers = { cust, cust2, cust3, cust4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

Console.Write("Merhaa");