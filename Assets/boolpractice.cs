using UnityEngine;

class boolpractice : MonoBehaviour
{
    [SerializeField] bool hasRange;

    [SerializeField] int ageOfJohn;
    [SerializeField] int ageOfGreg;

    [SerializeField] bool isJohnOlderThanGreg;
    [SerializeField] bool isJohnAndGregSameAge;

    void OnValidate()
    {
        isJohnOlderThanGreg = ageOfJohn > ageOfGreg;
        isJohnOlderThanGreg = ageOfJohn == ageOfGreg;

        float f1 = 3, f2 = 5;
        bool b1 = f1 >= f2;
        bool b2 = f1 <= f2;

        bool a = true;
        bool b = false;
        bool c = false;



        bool aNegated = !a;
        bool aOrB = a || b;
        bool aAndB = a && b;
        bool x = a || b && c; //false
        bool y = a || b && c; //false
        bool z = a || b && c; // false

    }

}
