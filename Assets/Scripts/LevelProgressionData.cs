[System.Serializable]
public struct LevelProgressionData
{
    public float completionTime;
    public bool isCompleted;
    public int id;

    public LevelProgressionData(float completionTime, bool isCompleted, int id) 
    {
        this.completionTime = completionTime;
        this.isCompleted = isCompleted;
        this.id = id;
    }

    public void OverwriteData(LevelProgressionData data)
    {
        completionTime = data.completionTime;
        isCompleted = data.isCompleted;
        id = data.id;
    }
}
