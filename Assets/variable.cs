using UnityEngine;
class VariablePractice : MonoBehaviour
{
    //jajj, de jó lenne, ha jól működne ez a kód.
    void Start()
    {
        int variable; //deklaráljuk
        variable = 5; // definiáljuk
        Debug.Log(variable); //felhasználjuk

        variable = 8; //változtatjuk
        Debug.Log(variable);

        int a = 5;
        int x, y, z;
        int k = 1, l = 2 , m = 3;

        x = a + k;
        y = 2 - l;
        z = 3 * 5;
        z = l / l; // 0 mert egész szám az int

        int mod = 11 % 4; //3 - moduló művelet, a maradékot adja ki

            //egyszerúsített alakok
        x = x + a; // 11
        x += a; //16

        x = x - 3; 
        x -= 3;

        x *= m;
        x /= l;

        x++;


        x = 3 + 4 + a;
        x = 3 * 4 + a;
        x = 3 * (4 + 1);


    }
}
    