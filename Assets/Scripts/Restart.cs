using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Button button;

    void Start()
    {
        Button Restart = button.GetComponent<Button>();
        Restart.onClick.AddListener(TaskOnClick);
    }
 
    
    
    
    
    
    void TaskOnClick()
    {

        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.maxPokusaj = 15;
    }
}
