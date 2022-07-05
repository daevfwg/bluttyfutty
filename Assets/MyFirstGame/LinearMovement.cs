using UnityEngine;

class LinearMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] KeyCode rightKey;
    [SerializeField] KeyCode leftKey;
    void Update()
    {
        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);
        bool right = Input.GetKey(rightKey);
        bool left = Input.GetKey(leftKey);

        float z = ToAxis(up, down);
        float x = ToAxis(right, left);

        Vector3 velocity = new Vector3(x, 0, z);

        transform.position += velocity.normalized * speed * Time.deltaTime;
    }
    float ToAxis(bool positive, bool negative)
    {
        float value;
        if (positive)
        {
            value = 1;
        }
        else if (negative)
            value = -1;
        else
            value = 0;
        return value;
    }
}
