using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameSave
{
    [SerializeField]
    private List<LevelProgressionData> _levels = new List<LevelProgressionData>();

    public IReadOnlyList<LevelProgressionData> Levels => _levels;

    public void AddOrReplaceLevelProgressionData(LevelProgressionData levelSettings)
    {
        foreach (var level in _levels)
        {
            if (level.id == levelSettings.id)
            {
                level.OverwriteData(levelSettings);
                return;
            }
        }

        _levels.Add(levelSettings);
    }
}
