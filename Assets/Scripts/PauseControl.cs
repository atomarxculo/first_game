using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public static bool gameIsPaused;
    Object[] pausedObjects;

    void Start(){
        Time.timeScale = 1;
        pausedObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    void PauseGame(){
        if (gameIsPaused){
            Time.timeScale = 0f;
            showPaused();
        }
        else{
            Time.timeScale = 1;
            hidePaused();
        }
    }

    public void showPaused(){
        foreach(GameObject g in pausedObjects){
            g.SetActive(true);
        }
    }

    public void hidePaused() {
        foreach(GameObject g in pausedObjects){
            g.SetActive(false);
        }
    }
}
