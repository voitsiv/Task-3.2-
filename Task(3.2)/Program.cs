
using Task_3._2_;

Edition firstEdition = new Edition();
Edition secondEdition = new Edition();

Console.WriteLine("Comparison that references are not equal: " +
    (firstEdition == secondEdition));
Console.WriteLine("Data are equal: " + 
    firstEdition.Equals(secondEdition) + "\n");

//try-catch 
//try
//{
//    firstEdition.Circulation = -5;
//}
//catch (Exception ex)
//{

//};
Magazine magazine = new Magazine();
magazine.AddArticles(new Article(new Person("Sthephen King", 55),
    "Times2", 23.4), new Article(new Person("Agata Kristi", 65),
    "ReadansWatch", 45.5));
magazine.AddEditors(new Person("John Baker", 45),
    new Person("Int Jayson", 34), new Person("Ania", 20));

Console.WriteLine( $" ================================ Magazines with additional articles and arrrays: ============================== " +
    $"{magazine.ToString()}\n");

Console.WriteLine("\n ============ From edition: " +
    "Title: " + magazine.Title + "Release Date " + magazine.ReleaseDate
    + " Circulation: " + magazine.Circulation);

Magazine deepCopy = (Magazine)magazine.DeepCopy();
magazine.Circulation = 5;
Console.WriteLine($"\n================================ Sourced-changed magazine: =====================================" +
    $"{magazine.ToString()} \n" +
    $" ====================================== Copy magazine:==================================== {deepCopy.ToString()}");

//string[] magzinesFromFile = File.ReadAllLines(@"C:\Users\Natalia\source\repos\Task(3.2)\Task(3.2)\MagazineText.txt");
string filePath = @"C:\Users\Natalia\source\repos\Task(3.2)\Task(3.2)\MagazineText.txt";

magazine.Save(filePath);
Magazine newMagazine = new Magazine();
newMagazine.Load(filePath);
Console.WriteLine(magazine.ToString());
Console.WriteLine(newMagazine.ToString());





