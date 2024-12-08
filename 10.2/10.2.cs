/* Створити текстовий звіт, який містить заголовок, дату та список подій.
*Використайте StringBuilder, щоб зберегти пам’ять та оптимізувати об’єднання рядків.
*Користувач у циклi буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder
*/


using System.Text;

StringBuilder report = new StringBuilder();
report.AppendLine("Football World Cup finals report");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter date of WC match (YYYY/MM/DD) or press 'f' to exit: ");
    string dateInput = Console.ReadLine();

    if (dateInput.Equals("f"))
    {
        break;
    }

    Console.WriteLine("Enter teams played");
    string teamsInput = Console.ReadLine();

    Console.WriteLine("Enter result of the game: ");
    string resultInput = Console.ReadLine();

    report.AppendLine($"Final: {teamsInput}; Date of the game: {dateInput}; Result: {resultInput}");
}
Console.WriteLine(report.ToString());
