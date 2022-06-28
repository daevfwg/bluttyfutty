using UnityEngine;

public class three : MonoBehaviour
{
    int i = 3;

    void Start()
    {
        while (i <= 15)
        {
            Debug.Log(i);
            i = i + 3;

        }
        for (int j = 0; j < 15; j++)
            Debug.Log(j * 3);
        {

        }
        
    }
}
