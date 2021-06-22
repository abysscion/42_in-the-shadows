using UnityEngine;

public class ConditionalRay : MonoBehaviour
{
    public Orientation orientation;
    public FigureController figureController;
    public Transform targetPlane = null;
    public float targetDotProduct = 1f;
    public float dotProductTolerance = 0.1f;

    public bool IsConditionMet
    {
        get
        {
            var result = targetDotProduct - Mathf.Abs(Vector3.Dot(OrientationVec, targetPlane.up));
            return result <= dotProductTolerance;
        }
    }

    private Vector3 OrientationVec 
    { 
        get
        {
            switch (orientation)
            {
                case Orientation.Forward:
                    return transform.forward;
                case Orientation.Up:
                    return transform.up;
                case Orientation.Right:
                    return transform.right;
                default:
                    return Vector3.zero;
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (IsConditionMet)
            Gizmos.color = Color.green;
        else
            Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, transform.position + OrientationVec * 3);

        Gizmos.color = Color.clear;
    }

    public enum Orientation
    {
        Forward,
        Up,
        Right
    }
}
