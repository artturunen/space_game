
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_select : MonoBehaviour
{

    public string levelToLoad = "mainlevel";


    public void Play() {

        SceneManager.LoadScene(levelToLoad);


     }

}
