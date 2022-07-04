
using UnityEngine;

class Exponent : MonoBehaviour
{
	[SerializeField] int num;
	[SerializeField] int power;
	[SerializeField] int result;

	void OnValidate()
	{
		int subresult = 1;
		for (int i = 0; i < power; i++)
		{
			subresult = num * subresult;
		}
		result = subresult;
	}

}
