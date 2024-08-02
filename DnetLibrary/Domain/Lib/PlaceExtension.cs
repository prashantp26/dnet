namespace DnetLibrary.Domain.Lib;

public static class PlaceExtension
{
    public static string PlaceNameHash(this EntityBase place)
    {
        return place.Name.GetHashCode().ToString();
    }
    
}