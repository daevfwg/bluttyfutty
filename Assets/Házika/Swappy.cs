using UnityEngine;

class Swappy : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;

    void Start()
    {
        a += b;
        b = a - b;
        a = a - b;
    }

}
