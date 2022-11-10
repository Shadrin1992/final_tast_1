// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше 3 символов.

string[] array = { "dfjfjw", "-7", "mmm", "dkjfwljf", "fdfk" };

void FilterArray(string[] array)
{
    string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }

    var str = string.Join(" ", newArray);
    Console.WriteLine(str);
}

FilterArray(array);