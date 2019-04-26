using UnityEngine;

public class controol : MonoBehaviour {
    public Rigidbody2D rb;
    public float controlForce;
    public Vector2 v;
    public float rotspeed = 1f;
    public float angle;
    public Animator animator;

    public AudioSource audioData;

    private void Update()
    {

        if (Input.GetKeyDown("w"))
        {
            audioData.Play(0);
        }

        if (Input.GetKeyUp("w"))
        {
            audioData.Pause();
             
        }




    }

    void FixedUpdate()
    {

        

        if (Input.GetKey("w"))
        {

           
           

            rb.constraints = RigidbodyConstraints2D.None;

            angle = transform.eulerAngles.z;

            v = new Vector2(controlForce * Mathf.Cos(angle * (Mathf.PI / 180) + (Mathf.PI / 2)), controlForce * Mathf.Sin(angle * (Mathf.PI / 180) + (Mathf.PI / 2)));
            rb.AddForce(v * Time.deltaTime, ForceMode2D.Force);

            animator.SetBool("Thrust", true);
        }
        else {

          
           
            animator.SetBool("Thrust", false);

        }

        


        //Debug.Log(Mathf.Cos(transform.eulerAngles.z * (Mathf.PI / 180)));


        if (Input.GetKey("d"))
        {

            rb.AddTorque(-rotspeed * Time.deltaTime, ForceMode2D.Force);

        }


        if (Input.GetKey("a"))
        {

            rb.AddTorque(rotspeed * Time.deltaTime, ForceMode2D.Force);

        }
    }
}


