using UnityEngine;

class Vecna : MonoBehaviour
{
    [SerializeField] Vector2 myfirst2dv;

    [SerializeField] Vector3 myfirst3dv;
    [SerializeField] Vector3 mysecond3dv;
    [SerializeField] float multiplier;

    [SerializeField] Vector3 summa;
    [SerializeField] Vector3 difference;
    [SerializeField] Vector3 product;
    [SerializeField] float lenght;
    [SerializeField] Vector2 normalised;

    void OnValidate()
    {
        summa = myfirst3dv + mysecond3dv; //összeadás

        difference = myfirst3dv - mysecond3dv;

        product = myfirst3dv * multiplier;

        lenght = myfirst2dv.magnitude;

        normalised = myfirst2dv.normalized;

        float x = myfirst3dv.x;
        float y = myfirst3dv.y;
        float z = myfirst3dv.z;

        Vector3 vector3LocalVar = new Vector3(1, 2, 3);
        Vector2 vector2LocalVar = new Vector3(1, 2);
    }
}
