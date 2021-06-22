using UnityEngine;

public class FigureController : MonoBehaviour
{
    public System.Action OnMoveEnd;

    public float mouseSpeedMultiplier = 3;
    public float dragThreshold = 0.1f;

    private Transform _camTf;
    private float _mDeltaX;
    private float _mDeltaY;
    private bool _isMousePressed;
    private bool _isRotating;

    private void Start()
    {
        _camTf = Camera.main.transform;
    }

    private void OnMouseDown()
    {
        _isMousePressed = true;
    }

    private void OnMouseUp()
    {
        if (_isRotating)
            OnMoveEnd?.Invoke();
        _isRotating = false;
        _isMousePressed = false;
    }

    private void OnMouseDrag()
    {
        _mDeltaX = Input.GetAxis("Mouse X") * mouseSpeedMultiplier;
        _mDeltaY = Input.GetAxis("Mouse Y") * mouseSpeedMultiplier;
    }

    private void Update()
    {
        HandleRotation();
    }

    private void HandleRotation()
    {
        if (!_isMousePressed)
            return;
        if (Mathf.Abs(_mDeltaX) < dragThreshold && Mathf.Abs(_mDeltaY) < dragThreshold)
            return;

        _isRotating = true;
        if (Input.GetKey(KeyCode.LeftAlt))
            transform.RotateAround(transform.position, _camTf.up, -_mDeltaX);
        else
            transform.RotateAround(transform.position, _camTf.right, _mDeltaY);
    }
}
