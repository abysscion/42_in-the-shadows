using Newtonsoft.Json;
using System.IO;
using UnityEngine;

public static class GameSaveManager
{
    private static GameSave _currentSave;

    public static GameSave CurrentSave 
    { 
        get
        {
            if (_currentSave == null)
            {
                if (!LoadGameSave())
                    _currentSave = new GameSave();
            }

            return _currentSave;
        }

        private set
        {
            _currentSave = value;
        }
    }

    private static string DefaultPath => Application.persistentDataPath + "/in-the-shadows_game_save.json";

    public static bool LoadGameSave()
    {
        if (File.Exists(DefaultPath))
        {
            CurrentSave = JsonConvert.DeserializeObject<GameSave>(File.ReadAllText(DefaultPath));
            Debug.Log($"Successfully loaded game from {DefaultPath}");
            return true;
        }

        return false;
    }

    public static void Save()
    {
        File.WriteAllText(DefaultPath, JsonConvert.SerializeObject(CurrentSave));
        Debug.Log($"Successfully saved game as {DefaultPath}");
    }
}
