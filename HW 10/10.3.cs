/* Ви отримали рядок, який містить декілька слів, розділених комами. 
 * Ваша мета - видалити всі пробіли з цього рядка та вивести результат.
*/
using System.Text;

Console.Write("Enter words using punctuation mark ',': ");
string input = Console.ReadLine();

StringBuilder sbInput = new StringBuilder();

foreach (char ch in input)
{
    if (ch != ' ')
    {
        sbInput.Append(ch);
    }
}
    string result = sbInput.ToString();
    Console.WriteLine(result);
