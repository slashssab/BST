using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using fibbo;

namespace fibbo
{
    public class Program
    {
        public static State CurrentState = State.Idle;
        static void Menu(State _state)
        {   
            switch (_state)
            {
                case State.Strong:
                    System.Console.Write("Wprowadź rząd silni: ");
                    double x = Convert.ToInt16(System.Console.ReadLine());
                    x = Algorithms.Strong(x);
                    System.Console.Write("\nWynik: {0} ", x);
                    Console.ReadKey();
                    break;
                case State.F:
                    System.Console.Write("Wprowadź indeks elementu ciągu: ");
                    int y = Convert.ToInt16(System.Console.ReadLine());
                    y = Algorithms.F(y - 1);
                    System.Console.Write("\nWynik: {0} ", y);
                    Console.ReadKey();                   
                    break;
                case State.bubbleSort:
                    System.Console.Write("Wprować ścieżkę: ");
                    string pathbubble = System.Console.ReadLine();
                    int[] csv = CSVHandle.ImportCSV(pathbubble + "./Dane.csv");
                    CSVHandle.SaveArrayAsCSV("./noweDane.csv", Algorithms.BubbleSort(csv, csv.Length));
                    System.Console.Write("\nPosortowano! Sprawdź plik noweDane.scv");                   
                    Console.ReadKey();
                    break;
                case State.quickSort:
                    System.Console.Write("Wprować ścieżkę: ");
                    string pathQuick = System.Console.ReadLine();
                    int[] csvQuick = CSVHandle.ImportCSV(pathQuick + "./Dane.csv");
                    Algorithms.Quick_Sort(csvQuick, 0, csvQuick.Length-1);
                    CSVHandle.SaveArrayAsCSV("./noweDane.csv", csvQuick);
                    System.Console.Write("\nPosortowano! Sprawdź plik noweDane.scv");
                    Console.ReadKey();
                    break;
                case State.Create:
                    System.Console.Write("Wprować ścieżkę do katalogu: ");
                    string cereatePath = System.Console.ReadLine();
                    System.Console.Write("Wprowadź ilość elementów w pliku csv: ");
                    int size = Convert.ToInt32(System.Console.ReadLine());
                    CSVHandle.CreatedimArray(size, cereatePath + "./Dane.csv");
                    System.Console.Write("\nWygenerowano CSV");
                    Console.ReadKey();
                    break;
                case State.ConductTimeMeasurement:
                    System.Console.Write("ilość : ");
                    int amountOfElements = Convert.ToInt32(System.Console.ReadLine());
                    CSVHandle.SaveArrayAsCSV("./noweDaneQuick.csv", TimmerHandler.getTimmerArray(amountOfElements));
                    break;
            }
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Naciśnij enter by zacząć");
            ConsoleKeyInfo keyinfo = Console.ReadKey();
            Console.Clear();
            Process currentProc = Process.GetCurrentProcess();
            long memoryUsed = currentProc.PrivateMemorySize64;
            while (CurrentState != State.Exit)
            {
                CurrentState = State.Idle;
                System.Console.Write("Menu:\n1. Silnia \n2. ciąg Fibbonaciego\n3. Bubble Sort liczb z pliku Dane.csv\n4. Quick Sort liczb z pliku Dane.csv\n5. Utwórz plik CSV\n6. Przeprowadź pomiar czasu\n7. Opuść program");
                keyinfo = Console.ReadKey();
                if (keyinfo.KeyChar == '1') CurrentState = State.Strong;
                if (keyinfo.KeyChar == '2') CurrentState = State.F;
                if (keyinfo.KeyChar == '3') CurrentState = State.bubbleSort;
                if (keyinfo.KeyChar == '4') CurrentState = State.quickSort;
                if (keyinfo.KeyChar == '5') CurrentState = State.Create;
                if (keyinfo.KeyChar == '6') CurrentState = State.ConductTimeMeasurement;
                if (keyinfo.KeyChar == '7') CurrentState = State.Exit;
                Menu(CurrentState);
                Console.Clear();
            }    
            
            System.Console.ReadKey();
        }
    }
}

