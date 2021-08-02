using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BoostBar : MonoBehaviour
{
    public Image boostBar;
    public PlayerManager playerManager;
    private Boost boost;
   public  GameObject boostBarGO;
    
    // Start is called before the first frame update

    private void Awake()
    {
        boostBar.GetComponent<Image>();

        //boostBar.fillAmount = .5f;

        boost = new Boost();
        boostBarGO = FindObjectOfType<BoostBar>().gameObject;
        //DontDestroyOnLoad(boostBar);
        DontDestroyOnLoad(boostBarGO);
    }
    void Start()
    {
        //Transform boostBar = transform.Find("Bar");
        //boostBar.localScale = new Vector3(.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

        
        boost.Update();

        boostBar.fillAmount = boost.GetBoostNormalized();
    }

    //public void SetSize(float sizeNormalized)
    //{
    //    boostBar.localScale = new Vector3(sizeNormalized, 1f);
    //}

    public class Boost
    {
        public const float boostTotal = 10000f;

        [SerializeField] float boostAmount;
        [SerializeField] float boostRegen;

        public Boost()
        {
            boostAmount = 0f;
            boostRegen = 2000f;
        }

        public void Update()
        {
            boostAmount += boostRegen * Time.deltaTime;
            boostAmount = Toolbox.Instance.playerManagerScript.boost;
        }

        public void SpendBoost(float amount)
        {
            if (boostAmount >= amount)
            {
                boostAmount -= amount;
            }
        }
        public float GetBoostNormalized()
        {
            return Toolbox.Instance.playerManagerScript.boost / boostTotal;
        }
    }
}
