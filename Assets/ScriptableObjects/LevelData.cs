using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "NewLevelData", menuName = "ScriptableObjects/LevelData", order = 1)]
public class LevelData : ScriptableObject
{
    public int levelID;
    public MapDifficulty difficulty;

    public enum MapDifficulty
    {
        Unknown = -1,
        Easy = 0,
        Advanced = 1,
        Hard = 2
    }
}
