using System;
using System.Text;

class Program
{
    // === СТРУКТУРИ ДЛЯ ВСІХ ЗАВДАНЬ ===
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

    // === ГОЛОВНИЙ КЕРУЮЧИЙ МЕТОД ===
    static void Main(string[] args)
    {
        // Вмикаємо українську мову в терміналі VS Code
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // --- КЕРУВАННЯ ЗАПУСКОМ ---
        // Приберіть "//" перед тим прикладом, який хочете перевірити:
        
        RunExample1();   // Зараз активний Приклад 1
        // RunExample2(); 
        // RunExample3(); 

        Console.WriteLine("\nПрограма завершилась. Натисніть Enter...");
    }

    // === ПРИКЛАД №1 ===
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

    // === ПРИКЛАД №2 ===
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

    // === ПРИКЛАД №3 ===
    static void RunExample3()
    {
        Console.WriteLine("====== ЗАПУЩЕНО: ПРИКЛАД 3 (Таблиця) ======\n");

        Stroka[] Tabl = new Stroka[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Введіть дані для товару №{i + 1}:");
            Console.Write("Назва товару: ");
            Tabl[i].name = Console.ReadLine();
            Console.Write("Вартість за од. (грн): ");
            Tabl[i].stoimost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Кількість: ");
            Tabl[i].kolich = Convert.ToInt32(Console.ReadLine());
            
            Tabl[i].sum_stoimost = Tabl[i].stoimost * Tabl[i].kolich;
            Console.WriteLine();
        }

        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("|   Назва товару   | Вартість за од. |  Кількість  |  Загальна вартість |");
        Console.WriteLine("-------------------------------------------------------------------------");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("| {0,-16} | {1,15:F2} | {2,11} | {3,18:F2} |", 
                Tabl[i].name, Tabl[i].stoimost, Tabl[i].kolich, Tabl[i].sum_stoimost);
        }
        Console.WriteLine("-------------------------------------------------------------------------");
    }
}