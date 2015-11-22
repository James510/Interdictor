using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    public float distance;
	void Update ()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z - distance);
    }
}
