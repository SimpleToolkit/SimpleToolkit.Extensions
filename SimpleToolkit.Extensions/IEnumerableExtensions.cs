namespace SimpleToolkit.Extensions;

public static class IEnumerableExtensions
{
    public static T? Random<T>(this IEnumerable<T> enumerable)
    {
        if (!enumerable.Any())
        {
            return default;
        }
        Random random = new Random();
        int size = enumerable.Count();
        int index = random.Next(size);
        return enumerable.ElementAt(index);
    }
}