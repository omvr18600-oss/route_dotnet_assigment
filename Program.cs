using System.Text;
{
    string title = "clean code";
    string upperTitle =title . ToUpper();
    Console.WriteLine(upperTitle);
    Console.WriteLine(title);

        
}
//Q2
{
    string a = "clean code";
    string b = "clean code";
    Console.WriteLine(ReferenceEquals(a,b));
}

//Q3 Q4
{
    stringBuilder sb = new StringBuilder();
    sb.Append("book list");
    sb.Append(" update");
    Console.WriteLine(sb);
    sb.Replace("book list ", "library");
    Console.WriteLine(sb);
}
//Q5
{
    string title = "clean code";
    int pages = 464;
    string s = "BOOK " + title + "pags" + pages;
    Console.WriteLine(s);
}
//Q6
{
    string title = "clean code";
    int pages = 464;
    string s = "book; {title} , pages: {pages}";
    Console.WriteLine(s);
}
//Q7
{
    string title = "clean code ";
    int pages = 464;
    string s = string.Format("book; {0}, pages: {1}",title ,pages)  ;
    Console.WriteLine(s);
}
//Q8
{
    int pages = 464;
        Console.WriteLine("long book");
    if (pages > 300)
    else
        Console.WriteLine("short book");

}
//Q9
{
    int pages = 464;
    bool isAvailable = true;
    if (pages > 300 && isAvailable)
        Console.WriteLine("you can borrow this book");
}

//Q10
{
    string title = "Refactoring";
    switch (title)
    {
        case "Clean Code":
            Console.WriteLine("Great choice!");
            break;
        case "Refactoring":
            Console.WriteLine("Nice pick!");
            break;
        default:
            Console.WriteLine("Never heard of it");
            break;
    }
}
//Q11
{
    int pages = 464;
    string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
    Console.WriteLine(sizeLabel);
}

string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

// Q12 - for loop
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i + 1}. {books[i]}");
}

// Q13 - while loop
{
    int i = 0;
    while (i < books.Length)
    {
        Console.WriteLine(books[i]);
        i++;
    }
}

// Q14 - do-while loop
{
    int count = 0;
    do
    {
        Console.WriteLine("Checking book...");
        count++;
    } while (count < 3);
}

// Q15 - foreach loop
foreach (string book in books)
{
    Console.WriteLine(book);
}

// Q16 - break
foreach (string book in books)
{
    if (book == "Refactoring")
        break;
    Console.WriteLine(book);
}

// Q17 - continue
foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
        continue;
    Console.WriteLine(book);
}

// Q18 - method with early return
PrintFirstBook(books);
PrintFirstBook(new string[] { });

static void PrintFirstBook(string[] arr)
{
    if (arr.Length == 0)
        return;

    Console.WriteLine(arr[0]);
}
