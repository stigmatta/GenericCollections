using GenericCollections;

#region task1
AccountManagement management = new AccountManagement(new[]
{
    new Employee() { Login = "Bill", Password = "123456" },
    new Employee() { Login = "Will", Password = "password" }
});

management.Print();

management.Remove("Bill");
management.Print();

management.ChangeInfo("Will");
management.Print();

management.PrintPassword("Will");

#endregion

#region task2
FrenchDictionary french = new FrenchDictionary(new[]
{
    new Word() { English = "Apple", French = new List<string> { "Pomme" } },
    new Word() { English = "Help", French = new List<string> { "Aider" } }
});

french.Print();

french.Add("Help", "Aide");

french.Remove("Apple");
french.Print();

french.RemoveOneTranslation("Help", "Aide");
french.Print();


french.ChangeEnglishWord("Help");
french.Print();

french.ChangeTranslation("HELP", "Aider");
french.Print();

french.SearchWord("HELP");


#endregion

#region task3

CafeQueue cafe = new CafeQueue(3);

Visitor visitor1 = new Visitor("Alice", false);
Visitor visitor2 = new Visitor("Bob", true);  
Visitor visitor3 = new Visitor("Charlie", false);

cafe.AddVisitor(visitor1);
cafe.Free=1;
cafe.AddVisitor(visitor2);
cafe.AddVisitor(visitor3);

cafe.PrintQueue();

cafe.RemoveVisitor();  
cafe.RemoveVisitor();
cafe.LeftFromCafe();
cafe.RemoveVisitor(); 

cafe.PrintQueue();
#endregion