namespace S03_constructeur;
public class Building
{
    private int floorCount;
    private int height;

    public Building(int floorCount, int height)
    {
        this.floorCount = floorCount;
        this.height = height;
    }

    public Building(int floorCount)
    {
        this.floorCount = floorCount;
        this.height = floorCount * 3; 
    }

    public int GetFloorMaxSize()
    {
        return height / floorCount;
    }

    public int GetFloorCount()
    {
        return floorCount;
    }

    public int GetSize()
    {
        return height;
    }
}