using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    public void PLayGame()
    {
        SceneManager.LoadScene("Level_0");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update

}
