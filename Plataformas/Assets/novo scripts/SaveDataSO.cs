using UnityEngine;

[CreateAssetMenu(fileName = "SaveDataSO", menuName = "Scriptable Objects/SaveDataSO")]
public class SaveDataSO : ScriptableObject
{
    public Color circleColor;

    public string SaveDataJson()
    {
        return JsonUtility.ToJson(this);
    }

    public void LoadDataJson(string json)
    {
        JsonUtility.FromJsonOverwrite(json, this);
    }
}
