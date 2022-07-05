using UnityEngine;

class MethodMan : MonoBehaviour
{
    void Start()
    {
        int count = 0;
        int number = 2;
        while (count < 100)
        {
            bool isPrime = IsPrimed(number);
            if (number < 2)
                isPrime = false;
            else
            {
                isPrime = true;
                for (int i = 2; i < number; i++)
                {
                    bool d = number % i == 0;
                    if (d)
                        isPrime = false;
                }
                if (isPrime)
                {
                    Debug.Log(number);
                    count++;
                }
                number++;
            }
        }
    }
    bool IsPrimed(float number)
    {
        bool isPrime = true;
        if (number < 2)
            isPrime = false;
        else
        {
            isPrime = true;
            for (int i = 2; i < number; i++)
            {
                bool d = number % i == 0;
                if (d)
                    isPrime = false;
            }
        }
        return isPrime;
    }
}