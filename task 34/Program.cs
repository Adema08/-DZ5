// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Fill(int size) {
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++) {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}
Console.WriteLine("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = Fill(size);
Console.WriteLine(string.Join(", ", array));
int count = 0;
for(int i = 0; i < size; i++) {
    if(array[i] % 2 == 0) {
        count++;
    }
}
if(count == 0) {
    Console.WriteLine("В данном массиве нет четных чисел");
}
else {
    Console.WriteLine($"В данном массиве четных числа: {count}");
}