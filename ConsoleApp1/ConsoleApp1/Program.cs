/*float baseSalary = 5000;
float hra = 0.30f;
float netsalary = (baseSalary - (baseSalary * hra));
Console.WriteLine(netsalary);

---------------------------------------------------
bool isyes = true;
if(isyes)
{
    Console.WriteLine("you are loggedin");
}
else
{
    Console.WriteLine("error");
}

string result = isyes ? "login" : "false";
Console.WriteLine(result);
int i = 2;
do
{
    Console.WriteLine(i);
    i--;
}while(i>0);

------------------------------------------------------
int i= 0;
int[] num = { 7, 3, 4, 6, 8, 3 };
Console.WriteLine("For loop");
for ( i=0;i<=5;i++)
    Console.WriteLine(num[i]);

Console.WriteLine("While loop");
while (i<num.Length)
{
    Console.WriteLine(num[i]);
    i++;
}


int[] marks=new int[5] { 10,20,30,40,50};
foreach(int i in marks)
    Console.WriteLine(i);   *

using System.Text;

string str = "Umair";
string str2 = "Ishtiaq";

Console.WriteLine(str);
Console.WriteLine(str.Length);
string str3 = string.Concat(str,str2);
Console.WriteLine(str3);
Console.WriteLine(str);
Console.WriteLine(str);


//mutable
string str4 = "C#";
//Immutable
StringBuilder stringBuilder = null;
stringBuilder.Append(str4);

*/

//OOP
using ConsoleApp1;
using System.Linq.Expressions;

/*SAccount SA=new SAccount();
SA.msg();
SA.deposit();
SA.withdraw();
SA.balance();

Savacc savAcc=new Savacc();
Console.WriteLine("\n\n Interface \n\n");
savAcc.openacc();
savAcc.deposit();   
savAcc.withdraw();
savAcc.balance();
savAcc.closeacc();
*/

/*//static 
Console.WriteLine( staticcc.inc());
Console.WriteLine(staticcc.inc());
Console.WriteLine(staticcc.inc());
Console.WriteLine(staticcc.inc());
Console.WriteLine(staticcc.dec());
*/


/*//Extention method

int num = 100;
bool result = num.IsGreaterThan(1000);
Console.WriteLine(result);


//Partial class
var employee = new PartialClass();
employee.DisplayDetails();


//Properties

Properties user = new Properties();
user.Name = "King Richard";
Console.WriteLine(user.Name);
Console.WriteLine(user.Cname);
user.Age = 67;
Console.WriteLine(user.Age);


//Indexers

Indexers indexer=new Indexers();
indexer[0] = "String One";
indexer[1] = "String two";
indexer[2] = "String three";
indexer[3] = "String four";
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(indexer[i]);
}



//Enum

Enums enumdemo = new Enums();
enumdemo.display();


//Exception handling

Calculation calculation = new Calculation();
//calculation.calculate(100,0);
calculation.FromUser_calculate();


//Anonymous type

var obj = new
{
    f_name = "king",
    l_name = "Richard",
    salary = 15000,
    address = new //nested anonymous type
    {
        streetname = "Ali baba",
        city = "London"
    },
    projects = new[]
    {
        new
        {
            Pname="E-Commerace",
            Pduration="40 hours"
        },

        new
        {
            Pname="Website",
            Pduration="20 hours"
        },

        new
        {
            Pname="App",
            Pduration="10 hours"
        }

    }

};
Console.WriteLine(obj.f_name);
Console.WriteLine(obj.l_name);
Console.WriteLine(obj.salary);    
Console.WriteLine(obj.address.streetname +", "+ obj.address.city);
foreach (var project in obj.projects)
{
    Console.WriteLine(project.Pname+", "+project.Pduration);
}



//Delegate

CalculateDelegate c1 = new CalculateDelegate(Deligatess.addition);
CalculateDelegate c2 = new CalculateDelegate(Deligatess.multipy);
c1(190);
Console.WriteLine(Deligatess.getnum());
c2(3);
Console.WriteLine(Deligatess.getnum());


//Types in delegate
CalculateDelegate c1 = new CalculateDelegate(Deligatess.addition);
c1(190);
Console.WriteLine(Deligatess.getnum());
c1 += new CalculateDelegate(Deligatess.multipy);
c1(100);
Console.WriteLine(Deligatess.getnum());


//Events  the subscriber

Events events=new Events();
events.event_odd += new Events.deledate_odd(EventMessage);
events.addition();
Console.ReadLine();
static void EventMessage()
{
    Console.WriteLine("Event executed : Odd number");
}


//Anonymous Method

AnonymousMethod.Invoke_method();

//Expression lambda
var numbers=new int[] {1,2,5,5,5,3,4,5,6};
var count = numbers.Count(x=> x==5);// x = input 
Console.WriteLine("Expression Lambda : "+count);

//Statement lambda
List<int> numbers2 = new List<int> { 1, 2, 5, 5, 5, 3, 4, 5, 6 };
var count2 = numbers2.Count(x => {  return x==5; });
Console.WriteLine("Statement Lambda : " + count2);
*/

//Expression tree

Func<string,string,string> stringJoins=(str1,str2)=>string.Concat(str1,str2);
Expression< Func<string, string, string>> stringJoinsExp = (str1, str2) => string.Concat(str1, str2);


var func = stringJoinsExp.Compile();
var result = func("Hello", " Word");
Console.WriteLine(result);
//OR
result=stringJoinsExp.Compile()("Hello", " Word");
Console.WriteLine(result);

