using UnityEngine;

public class RotationScript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float minRotationSpeed = 100f;
    [SerializeField] private float maxRotationSpeed = 200f;
    [SerializeField] private float rotationDirection;


    private void Start()
    {
        rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
        if (Random.Range(0, 2) > 0) rotationDirection = 1f;
        else rotationDirection = -1f;
    }
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * rotationDirection * Time.deltaTime);
    }
}
