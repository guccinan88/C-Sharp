using ConsoleApp8;

CarExhibit carExhibit = new CarExhibit();

while (true)
{
    carExhibit.PrintCars();
    Console.WriteLine("\nPress 'a' to add or 'r' to remove a car:");
    char key = Console.ReadKey().KeyChar;
    switch (key)
    {
        case 'a':
        case 'A':
            carExhibit.AddCar();
            break;
        case 'r':
        case 'R':
            carExhibit.RemoveCar();
            break;
        default:
            return;
    }
}