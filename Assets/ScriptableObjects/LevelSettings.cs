using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "NewLevelSettings", menuName = "Levels", order = 0)]
public class LevelSettings : ScriptableObject
{ 
    public MapDifficulty difficulty;
    public string discription;
    public int id;
}
