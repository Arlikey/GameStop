using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameStop
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            GameStop gameStop = new GameStop() { Name = "Game Stop", GamesCount = 3, Game = new Game { Name = "GTA 5", Price = 39.99m  } };
            GameStop gameStop1 = (GameStop)gameStop.Clone();

            gameStop1.Game = new Game() { Name = "RDR 2", Price = 49.99m };
            gameStop1.Name = "Metacritic";
            Console.WriteLine(gameStop);
            Console.WriteLine(gameStop1);
        }

        public class Game : ICloneable
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public object Clone()
            {
                return MemberwiseClone();
            }

            public override string ToString()
            {
                return $"Name - {Name}, Price - {Price}";
            }
        }

        public class GameStop : ICloneable
        {
            public string Name { get; set; }
            public int GamesCount { get; set; }
            public Game Game;
            public object Clone()
            {
                var gameStop = (GameStop)MemberwiseClone();
                gameStop.Game = (Game)gameStop.Game.Clone();
                return gameStop;
            }

            public override string ToString()
            {
                return $"Name - {Name}, Games Count - {GamesCount}, Game - {Game}";
            }
        }
    }*/

    /*public class AdditionalTask1
    {
        static void Main(string[] args)
        {
            IntNumber intNumber = new IntNumber();

            DoubleNumber doubleNumber = new DoubleNumber();

            Console.WriteLine(intNumber.DigitsSum(123));
            Console.WriteLine(intNumber.CountZeros(120300));

            Console.WriteLine(doubleNumber.DigitsSum(3.456));
            Console.WriteLine(doubleNumber.CountZeros(30.04506));
        }

        public interface NumberOperations<T> where T : INumber<T>
        {
            T DigitsSum(T number);
            T CountZeros(T number);
        }

        public class IntNumber : NumberOperations<int>
        {
            public int CountZeros(int number)
            {
                int countOfZeros = 0;
                for (int i = number; i > 0; i/=10)
                {
                    if (i % 10 == 0) countOfZeros++;
                }
                return countOfZeros;
            }

            public int DigitsSum(int number)
            {
                int digitSum = 0;
                for (int i = number; i > 0; i /= 10)
                {
                    digitSum += i % 10;
                }
                return digitSum;
            }
        }

        public class DoubleNumber : NumberOperations<double>
        {
            public double CountZeros(double number)
            {
                int countOfZeros = 0;
                foreach (var elem in number.ToString())
                {
                    if (char.IsDigit(elem) && elem == '0')
                        countOfZeros++; 
                }
                return countOfZeros;
            }

            public double DigitsSum(double number)
            {
                int sum = 0;
                foreach (var elem in number.ToString())
                {
                    if (char.IsDigit(elem))
                        sum += int.Parse(elem.ToString());
                }
                return sum;
            }
        }
    }*/

    /*public class AdditionalTask3
    {
        static void Main(string[] args)
        {
            B.Days dayB = B.Days.Monday;
            A.Days dayA = A.Days.Monday;
            Console.WriteLine((int)dayB);
            Console.WriteLine((int)dayA);
        }

        public interface IEnum
        {
            enum Days { }
        }

        public class A : IEnum
        {
            public enum Days
            {
                Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            }
        }

        public class B : A
        {
            public enum Days
            {
                Monday = 8, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            }
        }
    }*/

    /*public class AdditionalTask5
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 5, 1, 4, 4, 4, 6, 5, 2, 4, 3, 5, 2, -1, 2, -4 };

            Array.Sort(array, new Comparer());

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public class Comparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x == 5 && y == 5 || x == 4 && y == 4) return 0;
                else if (x == 5 || y == 4) return -1;
                else if (y == 5 || x == 4) return 1;
                else
                {
                    if (x < y) return -1;
                    else if (x > y) return 1;
                    return 0;
                }
            }
        }
    }*/

    /*public class AdditionalTask6
    {
        static void Main(string[] args)
        {
            Medal[] medals =
            {
                new Medal{TypeOfMedal = Medal.MedalType.Gold, Year = 1999, WinnerCountry = "Украина"},
                new Medal{TypeOfMedal = Medal.MedalType.Silver, Year = 2024, WinnerCountry = "США"},
                new Medal{TypeOfMedal = Medal.MedalType.Bronze, Year = 2012, WinnerCountry = "Австралия"},
                new Medal{TypeOfMedal = Medal.MedalType.Bronze, Year = 2013, WinnerCountry = "Канада"},
                new Medal{TypeOfMedal = Medal.MedalType.Gold, Year = 1997, WinnerCountry = "Япония"},
                new Medal{TypeOfMedal = Medal.MedalType.Silver, Year = 2023, WinnerCountry = "Греция"}
            };

            Array.Sort(medals);

            for (int i = 0; i < medals.Length; i++)
            {
                Console.WriteLine(medals[i]);
            }
        }

        public class Medal : IComparable<Medal>
        {
            public enum MedalType
            {
                Gold, Silver, Bronze
            }
            public MedalType TypeOfMedal { get; set; }
            public int Year { get; set; }
            public string WinnerCountry { get; set; }

            public override string ToString()
            {
                return $"Тип медали - {TypeOfMedal}, Год - {Year}, Страна - {WinnerCountry}";
            }

            public int CompareTo(Medal? other)
            {
                if (TypeOfMedal > other.TypeOfMedal) { return 1; }
                else if (TypeOfMedal < other.TypeOfMedal) { return -1; }
                else { return Year.CompareTo(other.Year); }
            }
        }
    }*/
}
