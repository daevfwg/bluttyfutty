
using UnityEngine;

class circle : MonoBehaviour
{
    [Header("Input Numbers")]
    [SerializeField] float radius;
    [SerializeField] float pi;
    [Space]
    [Header("Output Numbers")]
    [SerializeField] float area;
    [SerializeField] float circumference;

    void OnValidate()
    {
        area = radius * radius * Mathf.PI;
        circumference = 2 * radius * Mathf.PI;

    }

}
