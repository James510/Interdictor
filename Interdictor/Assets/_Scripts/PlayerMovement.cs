using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed,rotSpeed,rot,fireRate;
    private float horizontal, nextFire,lift;
    public GameObject bullet;
    Rigidbody rb = new Rigidbody();

	void Start ()
    {
        horizontal = 0;
        rb = GetComponent<Rigidbody>(); 
	}
	

	void Update ()
    {
        
        Debug.Log(lift);
        if (Input.GetKey(KeyCode.Z))
        {
            if(Time.time>nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject shot = Instantiate(bullet, transform.position, Quaternion.Euler(0.0f,0.0f,transform.rotation.eulerAngles.z+Random.Range(0.0f,10.0f))) as GameObject;
                Rigidbody srb = shot.GetComponent<Rigidbody>();
                srb.velocity = rb.velocity;
                srb.AddRelativeForce(Vector3.right * 1000);
            }
        }
	}
    void FixedUpdate()
    {
        //lift = rb.velocity.magnitude / 10;
        rb.AddRelativeForce(Vector3.right * speed);
        //rb.AddRelativeForce(Vector3.up * lift);
        horizontal += (-Input.GetAxis("Horizontal"))*rotSpeed;
        //float vertical = Input.GetAxis("Vertical")*rotSpeed;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, horizontal);
        //if (rb.velocity.x > 20.0f)
        //    rb.velocity = new Vector3(20.0f, rb.velocity.y, rb.velocity.z);
        //if (rb.velocity.y > 20.0f)
        //    rb.velocity = new Vector3(rb.velocity.x, 20.0f, rb.velocity.z);
        //if (rb.velocity.z > 20.0f)
        //    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 20.0f);
        //Debug.Log(rb.velocity.x);
        //Debug.Log(transform.rotation.eulerAngles.z);
        //if(transform.rotation.eulerAngles.z > 90&& transform.rotation.eulerAngles.z < 270)
        //{
        //    transform.rotation = Quaternion.Lerp(Quaternion.Euler(0.0f, 0.0f, 90.0f), Quaternion.Euler(180.0f, 0.0f, transform.rotation.eulerAngles.z), Time.time * rot);

        //}
        //if (transform.rotation.eulerAngles.z > 270 && transform.rotation.eulerAngles.z < 90)
        //{
        //    transform.rotation = Quaternion.Lerp(Quaternion.Euler(180.0f, 0.0f, 270.0f), Quaternion.Euler(0.0f, 0.0f, transform.rotation.eulerAngles.z), Time.time * rot);

        //}
    }
    IEnumerator WaitForSecs(float f)
    {
        yield return new WaitForSeconds(f);
    }
}
