using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbox : MonoBehaviour
{
    public Timer timerScript;
    public PickUps pickUpScript;
    public PlayerManager playerManagerScript;
    public DanceCombos danceCombos;
    public PlayerMovement playerMovement;
    public HighScorePanel highScorePanel;
    public HighScoreData highScoreData;

    //START SINGLETON

    public static Toolbox instance;
    public static Toolbox Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<Toolbox>();
                if (instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.AddComponent<Toolbox>();
                    singleton.name = "(Singleton) Toolbox";
                }
            }
            return instance;
        }
    }
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
       timerScript.t = playerManagerScript.time;

        
    }
}
