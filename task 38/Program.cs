// Задача 38: Задайте массив вещественных(тип double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] Fill(int size) {
    double[] array = new double[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++) {
        array[i] = Math.Round(rand.NextDouble() + rand.Next(1, 11), 2);
    }
    return array;
}
Console.WriteLine("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = Fill(size);
Console.WriteLine(string.Join("; ", array));
double min = array[0];
double max = array[0];
for(int i = 1; i < size; i++) {
    if(array[i] < min) {
        min = array[i];
    }
    if(array[i] > max) {
        max = array[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round(max - min, 2)}");