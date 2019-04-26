using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator animator;

    public void Play() {

        animator.SetBool("IsBack", false);
        animator.SetBool("IsPressed", true);
                 
    }

    public void Back() {

        animator.SetBool("IsPressed", false);
        animator.SetBool("IsBack", true);

    }



}
