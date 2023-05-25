// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Fill(int size) {
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++) {
        array[i] = rand.Next(-10, 46);
    }
    return array;
}
Console.WriteLine("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = Fill(size);
Console.WriteLine(string.Join(", ", array));
int sum = 0;
for(int i = 1; i < size; i += 2) {
    sum += array[i];
}
Console.WriteLine($"Сумма чисел массива, стоящих на нечетных позициях: {sum}");
