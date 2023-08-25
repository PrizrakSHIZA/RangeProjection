using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RangeProjection
{
    public static float Project(float value, float min1, float max1, float min2, float max2)
    {
        float percent = (value - min1) / (max1 - min1);
        return (max2 * percent) + (min2 * (1 - percent));
    }

    public static float ProjectWithClamp(float value, float min1, float max1, float min2, float max2)
    {
        value = Mathf.Clamp(value, min1, max1);
        float percent = (value - min1) / (max1 - min1);
        return (max2 * percent) + (min2 * (1 - percent));
    }
}