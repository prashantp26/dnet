namespace DnetLibrary.Domain;

public record CommonTypes
{
    public enum Region
    {
        Himal = 0,
        Pahad,
        Terai
    }

    public enum EntityToken
    {
        Mountains,
        Temples
    }
    
}