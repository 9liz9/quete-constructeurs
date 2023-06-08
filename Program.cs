namespace S03_constructeur;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Combien d'étages doit avoir le bâtiment ?");
        int floorCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Quelle doit être sa hauteur (en m) ?");
        int size = Convert.ToInt32(Console.ReadLine());

        Building building1 = new Building(floorCount, size);
        Conso3le.WriteLine("Hauteur du bâtiment : " + building1.GetSize() + "m");
        Console.WriteLine("Nombre d'étages : " + building1.GetFloorCount());
        Console.WriteLine("Estimation de la hauteur par étage : " + building1.GetFloorMaxSize() + "m");

       
    
    }

    
}
