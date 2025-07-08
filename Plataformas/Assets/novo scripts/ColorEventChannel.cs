using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorEventChannel", menuName = "Scriptable Objects/ColorEventChannel")]
public class ColorEventChannel : ScriptableObject
{
    public event Action<Color> OnEventRaised;
    public void RaiseEvent(Color color)
    {
        OnEventRaised?.Invoke(color);
    }
}
