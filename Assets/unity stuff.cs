using UnityEngine;

class unitystuff : MonoBehaviour
{
    int ii = 5; //field változó

    void Start() // game object létrejön
    {
        int i = 6; //lokális változó, egy metóduson belül deklaráljuk
    }

    void OnValidate() // akkor fut le, amikor módosítunk beállításokat inspecben. Fejlesztői tool, a végleges játékban nem fut

    {

    }
}
