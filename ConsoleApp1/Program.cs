using ConsoleApp1;

Console.Write("Enter the access level (basic, pro, expert): ");
string accessLevel = Console.ReadLine();

DocumentProgram docProgram;

if (accessLevel == "basic")
    docProgram = new DocumentProgram();
else if (accessLevel == "pro")
    docProgram = new ProDocumentProgram();
else if (accessLevel == "expert")
    docProgram = new ExpertDocument();
else
{
    Console.WriteLine("Invalid access level");
    return;
}

docProgram.OpenDocument();
docProgram.EditDocument();
docProgram.SaveDocument();