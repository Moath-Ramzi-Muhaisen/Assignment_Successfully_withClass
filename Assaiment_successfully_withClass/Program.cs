using Assaiment_successfully_withClass.Classes;

string str = Console.ReadLine();

Class1 user =  new Class1();

Dictionary<char, int> dic = user.printResult(str);


foreach (var item in dic)
{
    Console.WriteLine($"{item.Key}  :  {item.Value}");
}
