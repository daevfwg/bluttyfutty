using UnityEngine;
class Odd : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] string pairity;

    void OnValidate()
    {
    if (num % 2 == 0)
            {
            Debug.Log("It's an even number, buddy'");
            pairity = "Even";
            }
            else
            {
            Debug.Log("It's not even even.'");
            pairity = "Odd";
            }
    }
}