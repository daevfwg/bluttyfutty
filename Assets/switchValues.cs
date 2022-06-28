
using UnityEngine;

class switchValues : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
        int t = num1;
        num1 = num2;
        num2 = t;
    }

}
