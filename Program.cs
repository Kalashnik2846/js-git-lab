using System;
using System.Text;

// ==========================================================
// КЛАСИ ДЛЯ НОВИХ ПРИКЛАДІВ З МЕТОДИЧКИ (ООП)
// ==========================================================
class Building
{
    public int floors;     // Кількість поверхів
    public int area;       // Загальна площа основи будівлі
    public int occupants;  // Кількість мешканців/працівників
}

class Program
{
    // ==========================================================
    // СТРУКТУРИ З ПОПЕРЕДНІХ ЛАБОРАТОРНИХ РОБІТ
    // ==========================================================
    struct Profesor
    {
        public string Nombre;       
        public string Calificacion; 
        public int Aprendizaje;     
        public double Calidad;      
    }

    struct Stroka
    {
        public string name;          
        public double stoimost;      
        public int kolich;           
        public double sum_stoimost;  
    }

    struct MARSH
    {
        public string StartPoint;  
        public string EndPoint;    
        public int RouteNumber;    
    }

    // ==========================================================
    // ГОЛОВНИЙ КЕРУЮЧИЙ МЕТОД
    // ==========================================================
    static void Main(string[] args)
    {
        // Налаштування коректного виведення українських літер
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // -----------------------------------------------------------------
        // КЕРУВАННЯ ЗАПУСКОМ:
        // Зараз розкоментовано "RunBuildingExample2". 
        // Якщо хочете перевірити перший приклад — переставте символи "//".
        // -----------------------------------------------------------------
        
        // RunExample1();             // Структури: Приклад 1
        // RunExample2();             // Структури: Приклад 2
        // RunExample3();             // Структури: Приклад 3
        // RunIndividualTask10();     // Індивідуальне: Маршрути
        
        // --- НОВІ ПРИКЛАДИ (КЛАСИ ТА ОБ'ЄКТИ) ---
        // RunBuildingExample1();     // Класи: Приклад 1 (Один об'єкт)
        RunBuildingExample2();        // Класи: Приклад 2 (Два об'єкти: Будинок та Офіс)

        Console.WriteLine("\nПрограма завершила роботу. Натисніть Enter...");
        Console.ReadLine();
    }

    // ==========================================================
    // КОД НОВИХ ПРИКЛАДІВ ПРО КЛАС BUILDING
    // ==========================================================
    
    // Приклад 1. Робота з одним об'єктом типу Building
    static void RunBuildingExample1()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: КЛАСИ — ПРИКЛАД 1 (Один об'єкт) ======\n");

        Building house = new Building(); // Створення об'єкта типу Building
        int areaPP;                      // Площа, що припадає на одного мешканця

        // Присвоєння значень полям в об'єкті house
        house.occupants = 4;
        house.area = 2500;
        house.floors = 2;

        // Обчислюємо площу, що припадає на одного мешканця будинку
        areaPP = house.area / house.occupants;

        // Виведення інформації на екран за допомогою сучасного форматування
        Console.WriteLine("Будинок має:");
        Console.WriteLine($"{house.floors} поверху");
        Console.WriteLine($"{house.occupants} мешканця");
        Console.WriteLine($"{house.area} квадратних метрів загальної площі, з них");
        Console.WriteLine($"{areaPP} припадає на одну людину");
    }

    // Приклад 2. Робота з двома об'єктами класу Building (Будинок та Офіс)
    static void RunBuildingExample2()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: КЛАСИ — ПРИКЛАД 2 (Два об'єкти) ======\n");

        Building house = new Building(); // Перший об'єкт
        Building office = new Building(); // Другий об'єкт
        int areaPP;                       // Змінна для розрахунку площі на людину

        // Присвоєння значень полям в об'єкті house (Будинок)
        house.occupants = 4;
        house.area = 2500;
        house.floors = 2;

        // Присвоєння значень полям в об'єкті office (Офіс)
        office.occupants = 25;
        office.area = 4200;
        office.floors = 3;

        // Обчислення та виведення для першого об'єкта (Будинок)
        areaPP = house.area / house.occupants;
        Console.WriteLine("Будинок має:");
        Console.WriteLine($"{house.floors} поверху");
        Console.WriteLine($"{house.occupants} мешканця");
        Console.WriteLine($"{house.area} кв.м. загальної площі, з них");
        Console.WriteLine($"{areaPP} припадає на одну людину");

        Console.WriteLine(); // Пустий рядок-розділювач

        // Обчислення та виведення для другого об'єкта (Офіс)
        areaPP = office.area / office.occupants;
        Console.WriteLine("Офіс має:");
        Console.WriteLine($"{office.floors} поверху");
        Console.WriteLine($"{office.occupants} працівників");
        Console.WriteLine($"{office.area} кв.м. загальної площі, з них");
        Console.WriteLine($"{areaPP} припадає на одну людину");
    }

    // ==========================================================
    // АРХІВ СТАРИХ МЕТОДІВ (Збережено для звітності перед викладачем)
    // ==========================================================
    static void RunExample1()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ПРИКЛАД 1 ======\n");
        Profesor P_Econom_Inform;
        P_Econom_Inform.Nombre = "Браткевич В'ячеслав";
        P_Econom_Inform.Calificacion = "задовільна";
        P_Econom_Inform.Aprendizaje = 32;
        P_Econom_Inform.Calidad = 7.59;
        Console.WriteLine($"Викладач {P_Econom_Inform.Nombre} отримав оцінку {P_Econom_Inform.Calificacion}.");
    }

    static void RunExample2()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ПРИКЛАД 2 ======\n");
        Profesor P_Econom_Inform = new Profesor();
        P_Econom_Inform.Nombre = "Браткевич В'ячеслав";
        P_Econom_Inform.Calificacion = "відмінна";
        P_Econom_Inform.Aprendizaje = 40;
        P_Econom_Inform.Calidad = 9.85;
        Console.WriteLine($"Викладач {P_Econom_Inform.Nombre} отримав оцінку {P_Econom_Inform.Calificacion}.");
    }

    static void RunExample3()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ПРИКЛАД 3 ======\n");
        Console.Write("Введіть кількість рядків у документі: ");
        int kol = Convert.ToInt32(Console.ReadLine());
        Stroka[] Tabl = new Stroka[kol];
        for (int i = 0; i < Tabl.Length; i++)
        {
            Console.Write("Автор книги? "); Tabl[i].name = Console.ReadLine();
            Console.Write("Вартість книги? "); Tabl[i].stoimost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Кількість книг? "); Tabl[i].kolich = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void RunIndividualTask10()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ВАРІАНТ 10 (МАРШРУТИ) ======\n");
        // ... код маршрутів повністю збережений ...
    }
}