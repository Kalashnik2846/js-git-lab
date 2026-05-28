using System;
using System.Text;

class Program
{
    // ==========================================================
    // 1. ОГОЛОШЕННЯ СТРУКТУР (Додано нову структуру MARSH)
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

    // Структура для Варіанту 10
    struct MARSH
    {
        public string StartPoint;  // Назва початкового пункту маршруту
        public string EndPoint;    // Назва кінцевого пункту маршруту
        public int RouteNumber;    // Номер маршруту
    }

    // ==========================================================
    // 2. ГОЛОВНИЙ КЕРУЮЧИЙ МЕТОД
    // ==========================================================
    static void Main(string[] args)
    {
        // Вмикаємо підтримку української мови в консолі VS Code
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // -----------------------------------------------------------------
        // КЕРУВАННЯ ЗАПУСКОМ:
        // Зараз активне ваше ІНДИВІДУАЛЬНЕ ЗАВДАННЯ.
        // Щоб запустити приклади 1, 2 чи 3, просто переставте коментарі "//".
        // -----------------------------------------------------------------
        
        // RunExample1();             // Приклад 1 (вимкнено)
        // RunExample2();             // Приклад 2 (вимкнено)
        // RunExample3();             // Приклад 3 (вимкнено)
        RunIndividualTask10();     // АКТИВНО: Варіант 10 (Маршрути)

        Console.WriteLine("\nПрограма завершила роботу. Натисніть Enter...");
        Console.ReadLine();
    }

    // ==========================================================
    // 3. КОД ПРИКЛАДІВ 1, 2 та 3 (Збережено для історії та викладача)
    // ==========================================================
    static void RunExample1()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ПРИКЛАД 1 ======\n");
        Profesor P_Econom_Inform;
        P_Econom_Inform.Nombre = "Браткевич В'ячеслав";
        P_Econom_Inform.Calificacion = "задовільна";
        P_Econom_Inform.Aprendizaje = 32;
        P_Econom_Inform.Calidad = 7.59;

        Console.WriteLine("Викладач {0} отримав оцінку {1} від {2} студентів.", 
            P_Econom_Inform.Nombre, P_Econom_Inform.Calificacion, P_Econom_Inform.Aprendizaje);
    }

    static void RunExample2()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ПРИКЛАД 2 ======\n");
        Profesor P_Econom_Inform = new Profesor();
        P_Econom_Inform.Nombre = "Браткевич В'ячеслав";
        P_Econom_Inform.Calificacion = "відмінна";
        P_Econom_Inform.Aprendizaje = 40;
        P_Econom_Inform.Calidad = 9.85;

        Console.WriteLine("Викладач {0} отримав оцінку {1} від {2} студентів.", 
            P_Econom_Inform.Nombre, P_Econom_Inform.Calificacion, P_Econom_Inform.Aprendizaje);
    }

    static void RunExample3()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ПРИКЛАД 3 ======\n");
        Console.Write("Введіть кількість рядків у документі: ");
        int kol = Convert.ToInt32(Console.ReadLine());
        Stroka[] Tabl = new Stroka[kol];

        for (int i = 0; i < Tabl.Length; i++)
        {
            Console.WriteLine($"\nРядок №{i + 1}:");
            Console.Write("Автор книги? "); Tabl[i].name = Console.ReadLine();
            Console.Write("Вартість книги? "); Tabl[i].stoimost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Кількість книг? "); Tabl[i].kolich = Convert.ToInt32(Console.ReadLine());
        }

        double s1 = 0, s2 = 0, s3 = 0;
        Console.WriteLine("\nВідомості про вартість виданих книг\n");
        Console.WriteLine("|------------------------------------------------------------|");
        Console.WriteLine("| n/n |    Автор    |  Вартість  |  Видано  |    Витрати    |");
        Console.WriteLine("|------------------------------------------------------------|");
        for (int i = 0; i < Tabl.Length; i++)
        {
            Tabl[i].sum_stoimost = Tabl[i].stoimost * Tabl[i].kolich;
            s1 += Tabl[i].stoimost; s2 += Tabl[i].kolich; s3 += Tabl[i].sum_stoimost;
            Console.WriteLine("| {0,3} | {1,-11} | {2,10:F2} | {3,8} | {4,13:F2} |", 
                i + 1, Tabl[i].name, Tabl[i].stoimost, Tabl[i].kolich, Tabl[i].sum_stoimost);
        }
        Console.WriteLine("|------------------------------------------------------------|");
        Console.WriteLine("| Разом:            | {0,10:F2} | {1,8} | {2,13:F2} |", s1, s2, s3);
        Console.WriteLine("|------------------------------------------------------------|");
    }

    // ==========================================================
    // 4. ІНДИВІДУАЛЬНЕ ЗАВДАННЯ — ВАРІАНТ 10 (MARSH)
    // ==========================================================
    static void RunIndividualTask10()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ВАРІАНТ 10 (МАРШРУТИ) ======\n");

        // Створюємо масив із 8 елементів типу MARSH
        MARSH[] routes = new MARSH[8];

        // 1. Введення даних з клавіатури
        for (int i = 0; i < routes.Length; i++)
        {
            Console.WriteLine($"Введіть дані для маршруту №{i + 1}:");
            
            Console.Write("Початковий пункт: ");
            routes[i].StartPoint = Console.ReadLine();
            
            Console.Write("Кінцевий пункт: ");
            routes[i].EndPoint = Console.ReadLine();
            
            Console.Write("Номер маршруту (тільки цифри): ");
            routes[i].RouteNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(); // Пропуск рядка
        }

        // 2. Сортування масиву за номерами маршрутів (Метод бульбашки)
        for (int i = 0; i < routes.Length - 1; i++)
        {
            for (int j = 0; j < routes.Length - i - 1; j++)
            {
                if (routes[j].RouteNumber > routes[j + 1].RouteNumber)
                {
                    // Міняємо місцями елементи структури
                    MARSH temp = routes[j];
                    routes[j] = routes[j + 1];
                    routes[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("--- Список маршрутів успішно впорядковано за номерами. --- \n");

        // 3. Пошук маршруту за номером з клавіатури
        Console.Write("Введіть номер маршруту, який хочете знайти: ");
        int searchNumber = Convert.ToInt32(Console.ReadLine());
        
        bool found = false;
        Console.WriteLine("\nРезультати пошуку:");

        for (int i = 0; i < routes.Length; i++)
        {
            if (routes[i].RouteNumber == searchNumber)
            {
                Console.WriteLine($"Знайдено! Маршрут №{routes[i].RouteNumber}: {routes[i].StartPoint} -> {routes[i].EndPoint}");
                found = true;
            }
        }

        // Якщо жодного збігу не знайдено
        if (!found)
        {
            Console.WriteLine($"Повідомлення: Маршрут з номером {searchNumber} не знайдено в базі даних.");
        }
    }
}