using System;
using System.Text;

class Program
{
    // ==========================================
    // 1. ОГОЛОШЕННЯ СТРУКТУР ДЛЯ ВСІХ ПРИКЛАДІВ
    // ==========================================
    struct Profesor
    {
        public string Nombre;       // ПІБ викладача
        public string Calificacion; // Оцінка студентами
        public int Aprendizaje;     // Кількість студентів
        public double Calidad;      // Якість навчання
    }

    struct Stroka
    {
        public string name;          // Автор книги
        public double stoimost;      // Вартість однієї книги
        public int kolich;           // Кількість виданих книг
        public double sum_stoimost;  // Загальні витрати на автора
    }

    // ==========================================
    // 2. ГОЛОВНИЙ КЕРУЮЧИЙ МЕТОД
    // ==========================================
    static void Main(string[] args)
    {
        // Вмикаємо підтримку української мови в консолі
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // -----------------------------------------------------------------
        // КЕРУВАННЯ ЗАПУСКОМ:
        // Зараз увімкнено Приклад 3. Якщо захочете повернутися до інших,
        // просто приберіть "//" перед ними та поставте "//" перед RunExample3.
        // -----------------------------------------------------------------
        
        // RunExample1();   // Приклад 1 (вимкнено)
        // RunExample2();   // Приклад 2 (вимкнено)
        RunExample3();      // Приклад 3 (АКТИВНИЙ — Ваша індивідуальна таблиця)

        Console.WriteLine("\nПрограма завершила роботу. Натисніть Enter...");
        Console.ReadLine();
    }

    // ==========================================
    // 3. КОД ПРИКЛАДУ №1
    // ==========================================
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
        
        Console.WriteLine("Якість його навчання оцінено у {0} балів.", P_Econom_Inform.Calidad);
    }

    // ==========================================
    // 4. КОД ПРИКЛАДУ №2
    // ==========================================
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
        
        Console.WriteLine("Якість його навчання оцінено у {0} балів.", P_Econom_Inform.Calidad);
    }

    // ==========================================
    // 5. КОД ПРИКЛАДУ №3 (Відомості про книги)
    // ==========================================
    static void RunExample3()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ПРИКЛАД 3 (Відомості про книги) ======\n");

        Console.Write("Введіть кількість рядків у документі: ");
        int kol = Convert.ToInt32(Console.ReadLine());
        
        Stroka[] Tabl = new Stroka[kol];

        // 1. Введення даних з клавіатури
        for (int i = 0; i < Tabl.Length; i++)
        {
            Console.WriteLine($"\nРядок №{i + 1}:");
            Console.Write("Автор книги? ");
            Tabl[i].name = Console.ReadLine();
            
            Console.Write("Вартість книги? ");
            Tabl[i].stoimost = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Кількість книг? ");
            Tabl[i].kolich = Convert.ToInt32(Console.ReadLine());
        }

        // 2. Розрахунки та накопичення підсумків для "Разом"
        double s1 = 0, s2 = 0, s3 = 0;
        for (int i = 0; i < Tabl.Length; i++)
        {
            Tabl[i].sum_stoimost = Tabl[i].stoimost * Tabl[i].kolich;
            
            s1 += Tabl[i].stoimost;     // Загальна сума цін
            s2 += Tabl[i].kolich;       // Загальна кількість виданих книг
            s3 += Tabl[i].sum_stoimost; // Загальні підсумкові витрати
        }

        // 3. Виведення шапки таблиці
        Console.WriteLine("\nВідомості про вартість виданих книг\n");
        Console.WriteLine("|------------------------------------------------------------|");
        Console.WriteLine("| n/n |    Автор    |  Вартість  |  Видано  |    Витрати    |");
        Console.WriteLine("|------------------------------------------------------------|");

        // 4. Заповнення таблиці даними з масиву
        for (int i = 0; i < Tabl.Length; i++)
        {
            Console.WriteLine("| {0,3} | {1,-11} | {2,10:F2} | {3,8} | {4,13:F2} |", 
                i + 1, Tabl[i].name, Tabl[i].stoimost, Tabl[i].kolich, Tabl[i].sum_stoimost);
        }

        // 5. Виведення підсумкового рядка "Разом"
        Console.WriteLine("|------------------------------------------------------------|");
        Console.WriteLine("| Разом:            | {0,10:F2} | {1,8} | {2,13:F2} |", s1, s2, s3);
        Console.WriteLine("|------------------------------------------------------------|");
    }
}