using UnityEngine;

class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int a = 5;
    [SerializeField] int b = 3;
    void Start()
    {

        if (a > b)
        {
            Debug.Log("A is Greater then B");
        }
        else
        {
            Debug.Log("A is NOT Greater than B");

     {

                int i = 1;
                while (i <= 10)
                 {
                    Debug.Log(i);
                    i++;
                    //feladat
                }
            }
        }
    }
}
