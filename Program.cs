// step 1
// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine()!);
// int[] grades = new int[studentsCount];
// int sum = 0;

// for (int i = 0; i < grades.Length; i++) {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine()!);
//     sum += grades[i];
// }

// foreach (int grade in grades) {
//     Console.WriteLine(grade);
// }

// if (grades.Length > 0) {
//     Console.WriteLine($"Средний балл группы: {(double)sum / grades.Length:F2}");
// }

// step 2
// int[] points = { 4, 7, 2, 9, 5 };

// for (int i = 0; i < points.Length; i++) {
//     if (points[i] < 10) {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points) {
//     Console.WriteLine(point);
// }

// step 3
// int[] grades = { 4, 5, 3, 5, 4, 2 };

// // Сортировка по убыванию: знак сравнения заменён с > на <
// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// step 4
// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }

//     return slots;
// }

// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = (i + 1) * 2;
//     }

//     return slots;
// }

// Console.WriteLine("Обычные слоты:");
// foreach (int slot in GenerateScheduleSlots(6))
// {
//     Console.WriteLine(slot);
// }

// Console.WriteLine("Чётные слоты:");
// foreach (int slot in GenerateEvenSlots(6))
// {
//     Console.WriteLine(slot);
// }


// step 5
// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades) {
//     Console.WriteLine(grade);
// }


// g
// int[] GenerateEvenNumbers(int n) {
//     int count = n / 2; // столько чётных чисел от 1 до n
//     int[] result = new int[count];

//     for (int i = 0; i < count; i++) {
//         result[i] = (i + 1) * 2;
//     }

//     return result;
// }

// int[] evens = GenerateEvenNumbers(10);

// foreach (int number in evens) {
//     Console.WriteLine(number);
// }

// v
// int[] numbers = { 5, 2, 8, 1, 9 };

// for (int i = 0; i < numbers.Length - 1; i++) {
//     for (int j = 0; j < numbers.Length - 1 - i; j++) {
//         if (numbers[j] < numbers[j + 1]) {
//             int temp = numbers[j];
//             numbers[j] = numbers[j + 1];
//             numbers[j + 1] = temp;
//         }
//     }
// }

// Console.WriteLine("Массив по убыванию:");
// foreach (int number in numbers) {
//     Console.WriteLine(number);
// }

// variant 2 and 8
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// var 2
// int[] numbers = { 3, 5, 6, 9, 10, 12 };

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 3 == 0)
//     {
//         numbers[i] = -1;
//     }
// }

// foreach (int n in numbers)
// {
//     Console.WriteLine(n);
// }


// var 8
// double[] temperatures = { 12.5, -3.2, 0, -0.5, 7.8 };

// for (int i = 0; i < temperatures.Length; i++)
// {
//     if (temperatures[i] < 0)
//     {
//         temperatures[i] = 0;
//     }
// }

// foreach (double t in temperatures)
// {
//     Console.WriteLine(t);
// }
