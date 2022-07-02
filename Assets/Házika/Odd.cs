using UnityEngine;
class Odd : MonoBehaviour
{
    [SerializeField] int num;

    void OnValidate()
    {
    if (num % 2 == 0)
            {
            Debug.Log("It's an even number, buddy'");
            }
            else
            {
            Debug.Log("It's not even even.'");
            }
        }
    }
