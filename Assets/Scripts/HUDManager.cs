using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]


public class HUDManager : MonoBehaviour
{
    public Timer timer;
    public PlayerManager playerManager;
    [SerializeField] GameObject youDiedTextObject;
    public GameObject HUDCanvas;
    public StartCanvas startCanvas;
    public GameObject startCanvasGO;
    public HighScorePanel highScorePanel;
    public GameObject highScorePanelGO;
    public BoostBar boostBar;
    public Transform hUDManagerTransform;

    public void Awake()
    {
        //DontDestroyOnLoad(startCanvas.gameObject);
        //startCanvas = FindObjectOfType<StartCanvas>(gameObject);
        //startCanvasGO = startCanvas.gameObject;
        //startCanvasGO.SetActive(true);
        //if (!startCanvas.gameObject.activeInHierarchy)
        //{
        //    startCanvas.gameObject.SetActive(true);
        //}
        //boostBar = FindObjectOfType<BoostBar>(gameObject);

    }
    public void HighScorePanelToggle()
    {
        if (!highScorePanelGO.activeInHierarchy) { highScorePanelGO.SetActive(true); }
        else if (highScorePanelGO.activeInHierarchy) { highScorePanelGO.SetActive(false); }
    }
    public void Restart()
    {
        youDiedTextObject.SetActive(false);
        startCanvas.gameObject.SetActive(true);
        // Instantiate(boostBar, hUDManagerTransform);
        // DontDestroyOnLoad(HUDCanvas);
        if (playerManager != null) { playerManager.points = 0; }
        if (playerManager != null) { playerManager.hP = 50; }
        if (playerManager != null) { playerManager.time = timer.startTime; }

        SceneManager.LoadScene(0);
        
    }

public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Quit");
    }
    //public void StartButton()
    //{
    //    if (startCanvasGO.activeInHierarchy && startCanvasGO != null) { startCanvas.gameObject.SetActive(false); }
    //    Time.timeScale = 1;
    //    if (Time.time >= 5)
    //    {
    //        DontDestroyOnLoad(startCanvasGO);
    //        DontDestroyOnLoad(gameObject);
    //        SceneManager.LoadScene(0);
    //        if (boostBar = null) { Instantiate(boostBar, hUDManagerTransform); }
    //        //boostBar = FindObjectOfType<BoostBar>().gameObject;
    //        DontDestroyOnLoad(boostBar);

    //    }

    //}

    private void Update()
    { 

        
    
        if (Input.GetKey(KeyCode.Escape)  && !startCanvas.gameObject.activeInHierarchy)
        {
               startCanvas.gameObject.SetActive(true);
                Time.timeScale = 0;
         
            
                
                        
        }
        else if(Input.GetKey(KeyCode.Escape)  && startCanvas.gameObject.activeInHierarchy)
        {
           
               startCanvas.gameObject.SetActive(false);
                Time.timeScale = 1;

        }

    }
}
