using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLevelInteractor : MonoBehaviour
{
    public SpriteRenderer frameRenderer;
    public Light lightSource;
    public Color unlockedColor;
    public Color lockedColor;
    public Color completeColor;
    public float highlightAmount = 3f;

    private Color _currentColor;
    private float _baseLightIntensity;
    
    // Start is called before the first frame update
    void Start()
    {
        _baseLightIntensity = lightSource.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        
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
