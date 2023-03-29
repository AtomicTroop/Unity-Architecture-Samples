using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] private float cycleDuration;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    
    private float   _counter;
    private Vector3 _originalPosition;
    private Vector3 _minPosition;
    private Vector3 _maxPosition;

    private void Awake()
    {
        _originalPosition = transform.position;
        _minPosition      = new Vector3(minX, 0, 0);
        _maxPosition      = new Vector3(maxX, 0, 0);
    }

    private void Update()
    {
        _counter = (_counter + Time.deltaTime) % cycleDuration;
        float normalizedPhase = (_counter / cycleDuration) * (Mathf.PI * 2);
        float sinPhase        = (Mathf.Sin(normalizedPhase) + 1) * 0.5f;
        transform.position = _originalPosition + Vector3.Lerp(_minPosition, _maxPosition, sinPhase);
    }
}
