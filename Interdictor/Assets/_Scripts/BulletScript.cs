using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	void FixedUpdate ()
    {
        //Vector3 dir = rb.velocity;
        //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
