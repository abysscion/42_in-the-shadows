using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLevelInteractor : MonoBehaviour
{
    public LevelSettings levelSettings;
    public SpriteRenderer frameRenderer;
    public Light lightSource;
    public Color unlockedColor;
    public Color lockedColor;
    public Color completeColor;
    public float highlightAmount = 3f;

    private Color _currentColor;
    private float _baseLightIntensity;

    private void Start()    
    {
        _baseLightIntensity = lightSource.intensity;
    }

    private void OnMouseDown()
    {
        GameManager.Instance.LoadLevel(levelSettings);
    }

    private void OnMouseEnter()
    {
        lightSource.intensity = _baseLightIntensity + highlightAmount;
    }

    private void OnMouseExit()
    {
        lightSource.intensity = _baseLightIntensity;
    }
}
