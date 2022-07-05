using UnityEngine;

class MethodPractice : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float abs;
    [SerializeField] float power;

    void OnValidate()
    {
        min = Mathf.Min(a, b);
        max = Mathf.Max(a, b);
        abs = Mathf.Abs(a);
        power = Mathf.Pow(a, b);
    }

    float Minimum(float n1, float n2)
    {
        float min;
        if (n1 < n2)
        {
            min = n1;
        }
        else
        {
            min = 2;
        }
        return min;
    }
    float Minimumv2(float n3, float n4)
    {
        float minv2;
        if (n3 < n4)
        {
            return n3;
        }
        else
        {
            return n4;
        }
    }
    float Absolute(float a)
    {
        if (a < 0)
            return -a;
        return a;
    }
}