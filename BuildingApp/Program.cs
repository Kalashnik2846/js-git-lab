using System;
using System.Text;

// ==========================================================
// КЛАС СТВОРЕНИЙ ЗА СХЕМАМИ З НОВИХ СТОРІНОК МЕТОДИЧКИ
// ==========================================================
class Building
{
    public int floors;     // Кількість поверхів
    public int area;       // Загальна площа будівлі
    public int occupants;  // Кількість мешканців

    // Приклад 3. Метод, що повертає площу на одну людину
    public int areaPerPerson()
    {
        return area / occupants; // Використовуємо оператор return
    }

    // Приклад 4. Метод з параметром, що обчислює макс. кількість осіб
    public int maxOccupant(int minArea)
    {
        return area / minArea; // Повертає результат розрахунку
    }
}

// Додатковий клас для демонстрації роботи оператора return у void-методах
class MyReturn
{
    // Приклад 2. Припинення виконання void-методу за умови
    public static void myMeth()
    {
        int i;
        for (i = 0; i < 10; i++)
        {
            if (i == 5) return; // Достроковий вихід із методу, коли i досягає 5
            Console.Write(" " + i); // Виведе: 0 1 2 3 4
        }
    }
}

// ==========================================================
// ГОЛОВНИЙ КЛАС ПРОГРАМИ
// ==========================================================
class Program
{
    static void Main(string[] args)
    {
        // Коректне відображення українського тексту в консолі
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("====== ПЕРЕВІРКА ВСІХ ПРИКЛАДІВ З МЕТОДАМИ ======\n");

        // 1. ДЕМОНСТРАЦІЯ ПРИКЛАДУ №2 (Дострокове повернення з void)
        Console.Write("Результат роботи методу myMeth (void return):");
        MyReturn.myMeth(); 
        Console.WriteLine("\n--------------------------------------------------");

        // 2. СТВОРЕННЯ ОБ'ЄКТІВ ДЛЯ ПРИКЛАДІВ 3 ТА 4
        Building house = new Building();
        Building office = new Building();

        // Ініціалізація даних для будинку (house)
        house.occupants = 4;
        house.area = 2500;
        house.floors = 2;

        // Ініціалізація даних для офісу (office)
        office.occupants = 25;
        office.area = 4200;
        office.floors = 3;

        // 3. ВИВЕДЕННЯ РЕЗУЛЬТАТІВ ПРИКЛАДУ №3 (Метод areaPerPerson)
        Console.WriteLine("Будинок має:");
        Console.WriteLine($"{house.floors} поверху");
        Console.WriteLine($"{house.occupants} мешканця");
        Console.WriteLine($"{house.area} кв.м. загальної площі, з них");
        Console.WriteLine($"{house.areaPerPerson()} припадає на одну людину\n"); // Виклик методу

        Console.WriteLine("Офіс має:");
        Console.WriteLine($"{office.floors} поверху");
        Console.WriteLine($"{office.occupants} працівників");
        Console.WriteLine($"{office.area} кв.м. загальної площі, з них");
        Console.WriteLine($"{office.areaPerPerson()} припадає на одну людину"); // Виклик методу
        Console.WriteLine("--------------------------------------------------");

        // 4. ВИВЕДЕННЯ РЕЗУЛЬТАТІВ ПРИКЛАДУ №4 (Метод maxOccupant з параметрами)
        Console.WriteLine($"Максимальне число осіб для дому, \nякщо на кожного повинно доводитися 300 квадратних метрів: {house.maxOccupant(300)}"); // Передаємо параметр 300
        Console.WriteLine($"Максимальне число осіб для офісу, \nякщо на кожного повинно доводитися 200 квадратних метрів: {office.maxOccupant(200)}"); // Передаємо параметр 200

        Console.ReadLine();
    }
}
