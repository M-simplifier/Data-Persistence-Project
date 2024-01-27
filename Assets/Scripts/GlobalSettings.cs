using UnityEngine;
using System.IO;

public class GlobalSettings : MonoBehaviour
{
    public static GlobalSettings Instance;

    public string CurrentUsername = "Your Name";

    [SerializeField] private string bestScoreUsername = "Nobody";
    [SerializeField] private int bestScore = 0;

    public string BestScoreUsername => bestScoreUsername;
    public int BestScore => bestScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateBestScore(int score)
    {
        if (bestScore < score)
        {
            bestScoreUsername = CurrentUsername;
            bestScore = score;
        }
    }

    class SaveData
    {
        public string bestScoreUsername;
        public int bestScore;
    }

    public void Save()
    {
        SaveData saveData = new SaveData();
        saveData.bestScoreUsername = bestScoreUsername;
        saveData.bestScore = bestScore;
        string json = JsonUtility.ToJson(saveData);

        File.WriteAllText(Application.persistentDataPath + "savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData saveData = JsonUtility.FromJson<SaveData>(json);
            bestScoreUsername = saveData.bestScoreUsername;
            bestScore = saveData.bestScore;
        }
    }

    public void DeleteSaveData()
    {
        string path = Application.persistentDataPath + "savefile.json";
        if (File.Exists (path))
        {
            File.Delete(path);
        }
    }

    public void ResetBestScore()
    {
        DeleteSaveData();
        bestScore = 0;
        bestScoreUsername = "Nobody";
    }
}

