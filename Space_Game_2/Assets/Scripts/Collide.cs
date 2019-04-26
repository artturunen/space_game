using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

    public Vector3 cp;
    public Rigidbody2D rb;
    public Vector3 reset_rotate;
    public Vector2 reset_speed;

    void OnCollisionEnter2D(Collision2D col) { 

        

        if (col.collider.tag == "Bad")
        {
            transform.position = cp;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            transform.eulerAngles = reset_rotate;
            rb.velocity = reset_speed;
        }

       



    }

}
