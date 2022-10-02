using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    enum CarBrand //汽車廠牌
    {
        AUDI,
        BMW,
        KIA,
        TOYOTA,
        HONDA
    }
    internal class Car
    {
       public CarBrand CarBrand { get; private set; }
       public string Color { get; private set; }
        public Car(CarBrand carBrand, string color)
        {
            CarBrand = carBrand;
            Color = color;
        }
        public string Description
        {
            get { return $"A {Color} {CarBrand}"; }
        }
    }
    class CarExhibit
    {
        private readonly List<Car> cars = new List<Car>();//產生一個Car型別的List
        public void PrintCars() //判斷List裡是否有Car的物件
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("\nThe car exhibit is empty.");
            }
            else
            {
                Console.WriteLine("\nThe car exhibit contains:");
                int i = 1;
                foreach(Car car in cars)
                {
                    Console.WriteLine($"Car #{i++}: {car.Description}");
                }
            }
        }
        public void AddCar()
        {
            Console.WriteLine("\nAdd a car");
            for(int i=0; i < 5; i++)
            {
                Console.WriteLine($"Press {i} to add a {(CarBrand)i}"); //讀取enum清單
            }
            Console.Write("Enter a style: ");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(),out int style))
            {
                Console.WriteLine("\nEnter the color: ");
                string color = Console.ReadLine();
                Car shoe = new Car((CarBrand)style, color);
                cars.Add(shoe);
            }
        }
        public void RemoveCar()
        {
            Console.Write("\nEnter the number of the shoe to remove: ");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(),out int carNumber)&&
                (carNumber >= 1) && (carNumber <= cars.Count))
            {
                Console.WriteLine($"\nRemoving {cars[carNumber - 1].Description}");
                cars.RemoveAt(carNumber - 1); //在PrintCars方法，汽車的索引有+1，所以這裡要-1才能得到正確的內容


            }
        }
    }
}
