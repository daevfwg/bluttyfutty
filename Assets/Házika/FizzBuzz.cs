using UnityEngine;

class FizzBuzz : MonoBehaviour
{
    [SerializeField] int number;
    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            bool divide3 = i % 3 == 0;
            bool divide5 = i % 5 == 0;
            bool divide35 = divide3 && divide5;

            if (divide35)
                Debug.Log("fizzbuzz");
        }
    }

}
