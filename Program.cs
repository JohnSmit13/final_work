// т.к. в задании не рекомендуется использовать коллекции, необходимо
// знать размер нашего массива строк до его считывания
Console.WriteLine("Введите размер массива строк: ");
int arr_size = int.Parse(Console.ReadLine());

if (arr_size > 0) {

    string[] str_arr = new string[arr_size];

    // размер нового массива в котором будут храниться только короткие строки
    int new_arr_size = 0;

    Console.WriteLine("Введите строки: ");
    for (int i = 0; i < arr_size; ++i) {
        str_arr[i] = Console.ReadLine();
        if (str_arr[i].Length <= 3) {
            ++new_arr_size;
        }
    }
    string[] new_str_arr = new string[new_arr_size];

    // индекс нового массива строк куда будем сохранять короткую строку
    int index = 0;

    for (int i = 0; i < arr_size; ++i) {
        if (str_arr[i].Length <=3) {
            new_str_arr[index] = str_arr[i];
            ++index;
        }
    }
    // т.к. мы заранее посчитали количество коротких строк, выхода за границы массива непроизойдет
    // сейчас index = new_arr_size, и в new_str_arr нет пустых элементов.

    Console.WriteLine(" ");
    Console.WriteLine("Введённый массив: ");
    Console.WriteLine($"[{String.Join(", ", str_arr)}]");
    Console.WriteLine("Новый массив: ");
    Console.WriteLine($"[{String.Join(", ", new_str_arr)}]");
}