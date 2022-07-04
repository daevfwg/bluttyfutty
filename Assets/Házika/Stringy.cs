using UnityEngine;

class Stringy : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string csabiszamai;
    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            if (i == number)
                csabiszamai = csabiszamai + i;

            else
                csabiszamai = csabiszamai + i + ",";
        }
    }
}

