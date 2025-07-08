using System;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;
    
    public SaveData saveData;
    
    private string filePath;

    private void Awake()
    {
        if (Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        saveData = GetComponent<SaveData>();
        filePath = Application.persistentDataPath + "/saveData.json";
    }

    public bool WriteSaveToFile()
    {
        try
        {
            string saveDataJson = saveData.saveDataSo.SaveDataJson();
            File.WriteAllText(filePath, saveDataJson);
            Debug.Log("Save data written to file" + filePath);
            return true;
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
            return false;
        }
    }
    public bool LoadSaveFromFile()
    {
        try
        {
            if (File.Exists(filePath))
            {
                string saveDataJson = File.ReadAllText(filePath);
                saveData.saveDataSo.LoadDataJson(saveDataJson);
                Debug.Log("Save data loaded from file" + filePath);
                return true;
            }
            else
            {
                Debug.LogWarning("Save file not found: " + filePath);
                return false;
            }
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
            return false;
        }
    }
}
