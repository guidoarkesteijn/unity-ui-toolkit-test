using UnityEngine.UIElements;

public struct StyleConverters
{
    public static StyleEnum<Visibility> ResolveBool(bool handle)
    {
        return handle ? Visibility.Visible : Visibility.Hidden;
    }


    public static StyleEnum<Visibility> ResolveInt(int handle)
    {
        return handle > 0 ? Visibility.Visible : Visibility.Hidden;
    }
}
