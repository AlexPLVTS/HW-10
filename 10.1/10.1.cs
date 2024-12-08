/* Перевірити, чи починається прізвище на ту ж літеру, що й ім’я. 
* Якщо так, вивести повідомлення “Прізвище починається на ту ж літеру, що і ім’я”, інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.
*/

Console.Write("Enter name and lastname: ");

string input = Console.ReadLine();

bool hasSpace = false;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == ' ')
    {
        hasSpace = true;
        break;
    }
}
if (input.Length == 0 || !hasSpace)
{
    Console.WriteLine("Incorrect input");
    return;
}
string firstName = "";
string lastName = "";
bool isLastName = false;

for (int i = 0;i < input.Length;i++)
{
    if (input[i] == ' ')
    {
        isLastName = true;
        continue;
    }
    if (!isLastName)
    {
        firstName += input[i];
    }
    else
    {
        lastName += input[i];
    }
}
if (firstName[0] == lastName[0])
{
    Console.WriteLine($"Name {firstName} and lastname {lastName} starts with same letter!");
}
else
{
    Console.WriteLine($"Name {firstName} and lastname {lastName} does not start with same letter");
}

