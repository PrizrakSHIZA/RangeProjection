using UnityEngine;

public class RangeProjection
{
    public static float Project(float value, float min1, float max1, float min2, float max2)
    {
        return (max2 - min2) * ((value - min1) / (max1 - min1)) + min2;
    }

    public static float ProjectWithClamp(float value, float min1, float max1, float min2, float max2)
    {
        value = Mathf.Clamp(value, min1, max1);
        return (max2 - min2) * ((value - min1) / (max1 - min1)) + min2;
    }
}