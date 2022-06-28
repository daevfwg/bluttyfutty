
using UnityEngine;

class types : MonoBehaviour
{
    void Start()
    {
        int i = 6;
        float f = 5.76f; // floating point numbers . kinda tizedespontos
        float f2 = 4;
        string s = "my text"; // szöveget írni
        Debug.Log(s);

        bool b1 = true;
        bool b2 = false;

        float f3 = 3.5f + 3;
        float f4 = 4 / 3; // nem float, hanem int az eredmény
        float f5 = 4f / 3; // float, nem int az eredmény

        string st = "hello" + "world"; // összefűz
        Debug.Log(st + "!");

        float a = 2, b = 3, c = 5;
        string s1 = "A", s2 = "B", s3 = "C";
        string q1 = a + b + s1;
        string q2 = a + s1 + b;
        string q3 = s1 + a + b;


        //casting

        int ii = 6;
        float ff = ii; //implicit casting
        ii = (int) ff; // explicit casting
        



    }

}
