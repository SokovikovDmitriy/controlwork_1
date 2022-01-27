Console.Clear();

String[] array = { "i", "am", "not", "a", "programist", "yet" };
String[] newArray = new String[array.Length];
int j = 0;

Console.Write("[");
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

Console.Write("] => ");
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        newArray[j] = array[i];
        j++;
    }
}

for (int i = 0; i < newArray.Length; i++)
    Console.Write(newArray[i] + " ");
Console.Write("]");