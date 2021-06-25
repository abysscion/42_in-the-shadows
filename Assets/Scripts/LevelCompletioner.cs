using System.Collections.Generic;
using UnityEngine;

public class LevelCompletioner : MonoBehaviour
{
    public Transform figureTransform = null;
    public List<ConditionalRay> conditions = new List<ConditionalRay>();

    private FigureController _figureController;
    
    private void Start()
    {
        _figureController = figureTransform.GetComponent<FigureController>();
        _figureController.OnMoveEnd += TryToCompleteLevel;
    }

    private void OnDestroy()
    {
        _figureController.OnMoveEnd -= TryToCompleteLevel;
    }

    private void TryToCompleteLevel()
    {
        foreach (var condition in conditions)
        {
            if (!condition.IsConditionMet)
                return;
        }

        var gm = GameManager.Instance;

        gm.CompleteLevel(new LevelProgressionData(0.42f, true, gm.CurrentLevel.id));
    }
}
