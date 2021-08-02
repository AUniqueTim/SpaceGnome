using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCanvas : MonoBehaviour
{
    //public HUDManager hudManager;
    [SerializeField] GameObject youDiedTextObject;
    public GameObject startCanvas;
    public GameObject boostBar;
    public GameObject HUDCanvas;
    public GameObject controlsPanel;
    [SerializeField] bool gameStarted;

    public SpaceGnome_02_InputActions controls; 
    
    private void Awake()
    {
        controls = new SpaceGnome_02_InputActions();
        controls.UI.StartGame.performed += context => StartButton();

        Time.timeScale = 0;
        startCanvas.SetActive(true);
        HUDCanvas.SetActive(false);
        //DontDestroyOnLoad(startCanvas.gameObject);
        //DontDestroyOnLoad(HUDCanvas.gameObject);

    }
    public void Restart()
    {
        youDiedTextObject.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Quit");
    }
    public void ControlsButton()
    {
        controlsPanel.SetActive(true);
        HUDCanvas.SetActive(false);
        if (controlsPanel.activeInHierarchy)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                controlsPanel.SetActive(false);
                HUDCanvas.SetActive(true);
            }

        }
        else if (startCanvas.activeInHierarchy && !controlsPanel.activeInHierarchy)
        {
            controlsPanel.SetActive(true);
        }
       
    }

    public void ControlsScreenBackButton()
    {
        controlsPanel.SetActive(false);
    }
    
    public void StartButton()
    {
        Debug.Log("GameStarted");
        if (startCanvas.activeInHierarchy /*&& startCanvas != null && Time.time<5*/)
        {
            startCanvas.SetActive(false);
            Time.timeScale = 1;
            gameStarted = true;
        }
        
        //if (gameStarted)
        //{
        //    //startCanvas.SetActive(false);
        //    //startCanvas.SetActive(true);
        //    SceneManager.LoadScene(0);
        //}

        //HUDCanvas.SetActive(false);
        HUDCanvas.SetActive(true);
    }

    private void Update()
    {
        startCanvas = gameObject;
        if (Input.GetKey(KeyCode.Escape) /*&& !startCanvas.activeInHierarchy*/)
        {
            startCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;


        }
        
       else if (Input.GetKey(KeyCode.Escape) && startCanvas.activeInHierarchy)
        {
            startCanvas.SetActive(false);
            Time.timeScale = 1;
            

        }
        if (controlsPanel.activeInHierarchy)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                
                controlsPanel.SetActive(false);
                startCanvas.SetActive(true);

            }

        }
    }

    }
