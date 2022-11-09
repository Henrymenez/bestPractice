///<summary>
///Naming Convention
///name of varibales should be defined and Understandable
///</summary>
///Good
int age = 10;
///Bad
int a = 10;


///<summary>
///layout consideration correctly format and indent properly your code to look better
///</summary>
///Good
if ( 5 > 2 )
{
    Console.WriteLine(true);
}
///Bad
if (
 5 >  
 2) {
 Console.WriteLine(true); }


///<summary>
///Place the comment on a separate line, not at the end of a line of code.
///Begin comment text with an uppercase letter.End comment text with a period.
///<summary>
//Good commenting.
//baD Commentingcontunies here without being clear enough


///<summary>
///Avoid writing long functions. The typical function should have max 20-40 lines of code. 
 ///If method has more than40 line of code, you must consider re factoring into separate  methods.
 ///</summary>
 ///Good 
  void sayName()
{
    Console.WriteLine("My fucntion is small and good");
} 
///Bad
void sayName1()
{
    int age = 10;
    while(age < 20)
    {
        Console.WriteLine(age);
        age++;
    }
    int age1 = 10;
    while (age < 20)
    {
        Console.WriteLine(age);
        age++;
    }
    int age2 = 10;
    while (age < 20)
    {
        Console.WriteLine(age);
        age++;
    }
    int age3 = 10;
    while (age < 20)
    {
        Console.WriteLine(age);
        age++;
    }
}


///<summary>
///The method name should have meaningful name so that it cannot mislead.
///The meaningful method name doesn’t need code comments.
///</summary>
///Good:
private void SaveAddress(Address address) { }
///Bad:
private void Save(Address address) { }


///<summary>
///The method or function should have only single responsibility (one job).
///Don’t try to combine multiple functionalities into single function.
///</summary>
///Good:
public void UpdateAddress(Address address) { }
public void InsertAddress(Address address) { }
///Bad: 
public void SaveAddress(Address address)
{
    if (address.AddressId == 0) { } else { }
}


///<summary>
/// Controller Actions in MVC should have meaningful names and each action have single responsibility only
///</summary>
///Good: 
public class EmployeeController : Controller
{
    public ActionResult Index() { }
    public ActionResult Create() { }
    [HttpPost]
    public ActionResult Create(EmployeeModel employee) { }
    public ActionResult Edit(int id) { }
    [HttpPut]
    public ActionResult Update(EmployeeModel employee) { }
    [HttpDelete]
    public JsonResult Delete(int id) { }
}
///Bad: 
public class EmployeeController : Controller
{
    public ActionResult GetAll() { }
    public ActionResult CreateEmployee() { }
    [HttpPost]
    public ActionResult CreateEmployee(EmployeeModel employee) { }
    public ActionResult EditEmployee(int id) { }
    [HttpPut]
    public ActionResult UpdateEmployee(EmployeeModel employee) { }
    [HttpDelete]
    public JsonResult EmployeeDelete(int id) { }
}


///<summary>
///Avoid using common type system. Use the language specific aliase
///</summary>
///Good:
int age;
string firstName;
object addressInfo;
///Bad:
System.Int32 age; String firstName;
Object addressInfo;


///<summary>
///Use String.Empty instead of “”
///</summary>
///Good: 
if (firstName == String.Empty) { }
///Bad: 
if (firstName == “”) { }


///<summary>
///While comparing string, convert string variables into Upper or Lower case
///</summary>
///Good:
if (firstName.ToLower() == "yogesh") { }
if (firstName.ToUpper() == “YOGESH”) { }
///Bad:
if (firstName == “rohit”) { }


///<summary>
///Always do null check for objects and complex objects before accessing them.
///</summary>
///Good:
public Contact GetContactDetails(Address address)
{
    if (address != null && address.Contact != null)
    {
        return address.Contact;
    }
}
///Bad: 
public Contact GetContactDetails(Address address)
{
    return address.Contact;
}


///<summary>
///Error message to end use should be user friendly and
///self-explanatory but log the actual exception details using logger.'
///Create constants for this and use them in application
///Good:
“Error occurred while connecting to database. Please contact administrator.” “Your session has been expired. Please login again.”  
///Bad:  
“Error in Application.”  
“There is an error in application.” 


///<summary>
///Avoid passing many parameters to function. If you have more than 4-5 parameters
///use class or structure to pass it.
///Good:
 public void UpdateAddress(Address address) { }
///Bad: 
public void UpdateAddress(int addressId, string country, string state, string phoneNumber, string pinCode, string address1, string address2) { }


///<summary>
///Use object initializers to simplify object creation.
///Good: 
var employee = new Employee
{
    FirstName = “ABC”,
    LastName = “PQR”,
    Manager = “XYZ”,
    Salary = 12346.25
};
//Bad: 
var employee = new Employee();
employee.FirstName = “ABC”;
employee.LastName = “PQR”;
employee.Manager = “XYZ”;
employee.Salary = 12346.25;



///<summary>
///The using statements should be sortby framework namespaces first and then application 
///namespaces in ascending order
///Good:
using System;  
using System.Collections.Generic; using System.IO;  
using System.Text;  
using Company.Product.BusinessLayer; 
///Bad
using System.Text;  
using Company.Product.BusinessLayer; 
using System;  
using System.Collections.Generic; using System.IO;  
