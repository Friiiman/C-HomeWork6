void Task1(){

    // Пользователь вводит с клавиатуры M чисел. 
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.Write("Введите количество чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    for(int i = 1; i <= size; i++){
        Console.Write("Введите " + i + "-е " + "число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0){
            result++;
        }
    }
    Console.Write($"Количество чисел больше нуля: {result}");
}

void Task2(){

    // Напишите программу, которая найдёт точку пересечения двух прямых, 
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    // значения b1, k1, b2 и k2 задаются пользователем.

    Console.Write("Введите число b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    if(k1 == k2){
        Console.WriteLine("Введены неверные значения");
        Console.Write("Введите число k1: ");
        k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число k2: ");
        k2 = Convert.ToInt32(Console.ReadLine());
    }

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"X {Math.Round(x, 2)};  Y {Math.Round(y, 2)}");
}

// Task1();
Task2();
