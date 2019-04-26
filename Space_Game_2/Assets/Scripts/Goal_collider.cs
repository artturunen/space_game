using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal_collider : MonoBehaviour
{

    public GameObject Player;

    public SpriteRenderer sprite;
    public Color32 active_color;
    public Color32 unactive_color;
    public GameObject canvas;

    public bool done = false;

    private void Start()
    {

        sprite.color = unactive_color;
        canvas.SetActive(false);

    }


    void OnCollisionEnter2D(Collision2D col)
    {

     

        if (col.collider.tag == "Player")
        {

            canvas.SetActive(true);
            sprite.color = active_color;

            StartCoroutine(TimerRoutine());
           

        }
    }

    IEnumerator TimerRoutine() {

        yield return new WaitForSeconds(3);
        done = true;

    }

    void Update()
    {
        if (done) {
            SceneManager.LoadScene("mainmenu");

        }

    }

}
