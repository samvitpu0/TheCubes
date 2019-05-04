using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used to create scriptable object for box color in which user can choos 5 options of color from which
/// random color will be picked to color the grid
/// </summary>
[CreateAssetMenu(fileName = "BoxColorData", menuName = "BoxGrid/ColorData", order = 1)]
public class GridBlockColors : ScriptableObject
{
    public Color32 colorOption_One;
    public Color32 colorOption_Two;
    public Color32 colorOption_Three;
    public Color32 colorOption_Four;
    public Color32 colorOption_Five;
}
