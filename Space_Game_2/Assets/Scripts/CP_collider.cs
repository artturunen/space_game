using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CP_collider : MonoBehaviour {

    public GameObject Player;

    private Collide collideScript;

    public Vector3 new_cp;
    public Vector3 offset = new Vector3(0, 4, 0);
    public SpriteRenderer sprite;
    public Color32 active_color; 
    public Color32 unactive_color;

    
    private void Awake()
    {

        collideScript = Player.GetComponent<Collide>();

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        new_cp = transform.position + offset;

        if (col.collider.tag == "Player")
        {

            collideScript.cp = new_cp;
            
           

        }
    }

    void Update()
    {

        if (new_cp == collideScript.cp)
        {
            sprite.color = active_color;
        }
        else {

            sprite.color = unactive_color;
        }

    }

}
