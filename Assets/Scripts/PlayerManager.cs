using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;


public class PlayerManager : MonoBehaviour
{
    public HighScoreData highScoreData;
    public HighScorePanel highScorePanel;
    [SerializeField] GameObject player;
    public DanceCombos danceCombos;
    public FallDamage fallDamageScript;
    public Timer timerScript;
    public Image boostBar;
    public float boost;
    public int hP;
    [SerializeField] int maxHP;
    public float time;
    public int points;
    public int pointsLost;
    [SerializeField] int totalTimeCoinsCollected;
    [SerializeField] int totalPointsCoinsCollected;
    [SerializeField] int totalHPCoinsCollected;
    public int totalHealthLost;
    public int totalHealthGained;
    [SerializeField] int asteroidCollisions;
    public float score;
    public float score1;
    public float score2;
    public float score3;
    public float score4;
    public float score5;
    public float currentHighScore;
    [SerializeField] float totalTime;
    [SerializeField] int totalCoins;
    public CameraController camController;
    [SerializeField] Camera cam;

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject hUD;
    [SerializeField] TextMeshProUGUI hpText;
    public TextMeshProUGUI pointsText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI pointsCoinsText;
    [SerializeField] TextMeshProUGUI hPCoinsText;
    [SerializeField] TextMeshProUGUI timeCoinsText;
    [SerializeField] TextMeshProUGUI totalCoinsText;
    [SerializeField] TextMeshProUGUI asteroidCollisionText;
    [SerializeField] TextMeshProUGUI healthLostText;
    [SerializeField] TextMeshProUGUI healthGained;
    [SerializeField] TextMeshProUGUI totalTimeText;
    [SerializeField] TextMeshProUGUI totalPointsCoinsLost;

    [SerializeField] GameObject youDiedTextObject;
    private string scoreString;

    public AudioSource goldCoin;
    public AudioSource bronzeCoin;
    public AudioSource blueCoin;
    public AudioSource[] asteroidCollisionSounds;
    private AudioSource asteroidSound;
    public AudioSource landing;
    public bool landingSoundPlayed;
    public AudioSource jumpSoundPlayed;
    public AudioSource platformSpawnSound;
    public AudioSource danceSound1;
    public AudioSource danceSound2;
    public AudioSource[] danceSounds;
    public AudioSource frontFlipSound;
    public AudioSource backFlipSound;
    public AudioSource macacoSound;
    public AudioSource cam2Music;
    

    [SerializeField] bool danceSound1Played;
    [SerializeField] bool danceSound2Played;


    [SerializeField] int basePointsMultiplier;

    [SerializeField] ParticleSystem explosion1;
    [SerializeField] ParticleSystem explosion2;
    [SerializeField] ParticleSystem coinPickUp1;
    [SerializeField] ParticleSystem coinPickUp2;
    [SerializeField] ParticleSystem coinPickUp3;
    [SerializeField] ParticleSystem isHardFall1PE;
    [SerializeField] ParticleSystem isHardFall2PE;
    [SerializeField] ParticleSystem hyperSpace;

    public bool isDustExplosion;
    public bool isCoinPickUp1;
    public bool isCoinPickUp2;
    public bool isCoinPickUp3;
    public bool isHardFall1;
    public bool isHardFall2;

    [SerializeField] bool gotAPoint;
    [SerializeField] bool gotAHP;
    [SerializeField] bool gotATime;

    [SerializeField] SpriteRenderer plus1;
    [SerializeField] SpriteRenderer plus2;
    [SerializeField] SpriteRenderer plus3;
    [SerializeField] SpriteRenderer plus4;
    [SerializeField] SpriteRenderer plus5;

    [SerializeField] SpriteRenderer minus1;
    [SerializeField] SpriteRenderer minus2;
    [SerializeField] SpriteRenderer minus3;
    [SerializeField] SpriteRenderer minus4;
    [SerializeField] SpriteRenderer minus5;
    [SerializeField] GameObject numbersParent;

    [SerializeField] SpriteRenderer healthUIText;
    [SerializeField] SpriteRenderer pointsUIText;
    [SerializeField] SpriteRenderer timeUIText;



    //START SINGLETON
    public static PlayerManager instance;
    public static PlayerManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<PlayerManager>();
                if (instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.AddComponent<PlayerMovement>();
                    singleton.name = "(Singleton) PlayerManager";
                }
            }
            return instance;
        }
    }
    //END SIngleton
    private void Awake()
    {
        points = Toolbox.Instance.pickUpScript.points;
        boost = 10000f;

        instance = this;

        DOTween.Init();

        StartCoroutine(WaitOneSecond());
        numbersParent.transform.position = gameObject.transform.position;
        numbersParent.transform.rotation = cam.transform.rotation;
        gotAPoint = false;
    }
    IEnumerator WaitOneSecond()
    {

        if (gotAPoint && basePointsMultiplier ==1)
        {
            plus1.gameObject.SetActive(true);
            pointsUIText.gameObject.SetActive(true);

            points += 1;

            DOTweenModuleSprite.DOFade(plus1, 1, 0);
            DOTweenModuleSprite.DOFade(pointsUIText, 1, 0);
            
            DOTweenModuleSprite.DOFade(plus1, 0, 2.5f);
            DOTweenModuleSprite.DOFade(pointsUIText, 0, 2.5f);
            yield return
                new WaitForSeconds(1.5f);
            Debug.Log("Waiting Two Seconds...");

            plus1.gameObject.SetActive(false);
            pointsUIText.gameObject.SetActive(false);
            gotAPoint = false;

            
        }
        else if (gotAPoint && basePointsMultiplier == 2)
        {
            plus2.gameObject.SetActive(true);
            pointsUIText.gameObject.SetActive(true);

            points += 2;

            DOTweenModuleSprite.DOFade(plus2, 1, 0);
            DOTweenModuleSprite.DOFade(pointsUIText, 1, 0);

            DOTweenModuleSprite.DOFade(plus2, 0, 2.5f);
            DOTweenModuleSprite.DOFade(pointsUIText, 0, 2.5f);

            yield return
                new WaitForSeconds(1.5f);
            Debug.Log("Waiting 1.5 Seconds...");

            plus2.gameObject.SetActive(false);
            pointsUIText.gameObject.SetActive(false);
            gotAPoint = false;
        }
        else if (gotAPoint && basePointsMultiplier == 3)
        {
            plus3.gameObject.SetActive(true);
            pointsUIText.gameObject.SetActive(true);

            points += 3;

            DOTweenModuleSprite.DOFade(plus3, 1, 0);
            DOTweenModuleSprite.DOFade(pointsUIText, 1, 0);

            DOTweenModuleSprite.DOFade(plus3, 0, 2.5f);
            DOTweenModuleSprite.DOFade(pointsUIText, 0, 2.5f);

            yield return
                new WaitForSeconds(1.5f);
            Debug.Log("Waiting 1.5 Seconds...");

            plus3.gameObject.SetActive(false);
            pointsUIText.gameObject.SetActive(false);
            gotAPoint = false;
        }
        else if (gotAPoint && basePointsMultiplier == 4)
        {
            plus4.gameObject.SetActive(true);
            pointsUIText.gameObject.SetActive(true);

            points += 4;

            DOTweenModuleSprite.DOFade(plus4, 1, 0);
            DOTweenModuleSprite.DOFade(pointsUIText, 1, 0);

            DOTweenModuleSprite.DOFade(plus4, 0, 2.5f);
            DOTweenModuleSprite.DOFade(pointsUIText, 0, 2.5f);

            yield return
                new WaitForSeconds(1.5f);
            Debug.Log("Waiting 1.5 Seconds...");

            plus4.gameObject.SetActive(false);
            pointsUIText.gameObject.SetActive(false);
            gotAPoint = false;
        }
        else if (gotAPoint && basePointsMultiplier == 5)
        {
            plus5.gameObject.SetActive(true);
            pointsUIText.gameObject.SetActive(true);

            points += 5 ;

            DOTweenModuleSprite.DOFade(plus5, 1, 0);
            DOTweenModuleSprite.DOFade(pointsUIText, 1, 0);

            DOTweenModuleSprite.DOFade(plus5, 0, 2.5f);
            DOTweenModuleSprite.DOFade(pointsUIText, 0, 2.5f);

            yield return
                new WaitForSeconds(1.5f);
            Debug.Log("Waiting 1.5 Seconds...");

            plus5.gameObject.SetActive(false);
            pointsUIText.gameObject.SetActive(false);
            gotAPoint = false;
        }
        else if (gotAHP)
        {
            plus1.gameObject.SetActive(true);
            healthUIText.gameObject.SetActive(true);

            DOTweenModuleSprite.DOFade(plus1, 1, 0);
            DOTweenModuleSprite.DOFade(healthUIText, 1, 0);

            DOTweenModuleSprite.DOFade(plus1, 0, 2.5f);
            DOTweenModuleSprite.DOFade(healthUIText, 0, 2.5f);

            yield return
                new WaitForSeconds(1.5f);
            Debug.Log("Waiting Two Seconds...");

            plus1.gameObject.SetActive(false);
            healthUIText.gameObject.SetActive(false);
            gotAHP = false;

        }
        else if (gotATime)
        {
            timeUIText.gameObject.SetActive(true);

            DOTweenModuleSprite.DOFade(timeUIText, 1, 0);
            DOTweenModuleSprite.DOFade(timeUIText, 0, 2.5f);
            
            yield return
                new WaitForSeconds(1.5f);
            Debug.Log("Waiting Two Seconds...");

            timeUIText.gameObject.SetActive(false);
            gotATime = false;
        }
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            hP -= 1;
            boost -= 2000f;
            totalHealthLost += 1;
            if (hP <= 0) { hP = 0; }
            Debug.Log("Collided with " + collision.gameObject.name);
            Destroy(collision.gameObject);
            asteroidSound = asteroidCollisionSounds[Random.Range(0, 2)];
            asteroidSound.Play();
            asteroidCollisions += 1;
            //explosion1.Play();
            explosion2.Play();

        }
        if (collision.gameObject.tag == "Points")
        {
            totalCoins += 1;
            
           // points += 1 * basePointsMultiplier;
            gotAPoint = true;

           StartCoroutine(WaitOneSecond());
            
            Debug.Log("Collided with " + collision.gameObject.name);
            Destroy(collision.gameObject);
            goldCoin.Play();
            totalPointsCoinsCollected += 1;
            //danceCombos.basePointsMultiplier += 1;
            //danceCombos.basePointsMultiplier = 1;
            danceCombos.pointsDance1Performed = false;
            danceCombos.pointsDance2Performed = false;
            danceCombos.pointsDance3Performed = false;
            danceCombos.pointsDance4Performed = false;

            coinPickUp1.Play();
            isCoinPickUp1 = true;
            danceCombos.basePointsMultiplier = 1;

        }
        if (collision.gameObject.tag == "Time")
        {
            totalCoins += 1;
            gotATime = true;

            StartCoroutine(WaitOneSecond());

            totalTimeCoinsCollected += 1;
            if (totalTimeCoinsCollected <= 25) { Toolbox.Instance.timerScript.startTime += 3f; }
            else if (totalTimeCoinsCollected > 25 && totalTimeCoinsCollected <= 50) { Toolbox.Instance.timerScript.startTime += 2f; }
            else if (totalTimeCoinsCollected > 50 && totalTimeCoinsCollected <= 100) { Toolbox.Instance.timerScript.startTime += 1f; }
            else { return; }

            Debug.Log("Collided with " + collision.gameObject.name);
            Destroy(collision.gameObject);
            bronzeCoin.Play();

            coinPickUp2.Play();
            isCoinPickUp2 = true;
        }
        if (collision.gameObject.tag == "HP")
        {
            totalCoins += 1;
            gotAHP = true;

            boost += 1000;

            StartCoroutine(WaitOneSecond());

            totalHealthGained += 1;
            totalHPCoinsCollected += 1;
            hP += 1;
            Debug.Log("Collided with " + collision.gameObject.name);
            Destroy(collision.gameObject);
            blueCoin.Play();

            isCoinPickUp3 = true;
            coinPickUp3.Play();
        }
        if (collision.gameObject.tag== "Platform")
        {
                landing.PlayOneShot(landing.clip);
                
        }

        if (!gameObject.activeInHierarchy)
        {
            cam2Music.Play();
        }
    }
    public void GameOver()
    {
        // score = (points + (hP / 2) * Time.time);
        
        highScorePanel.hS01 = currentHighScore;
        //highScorePanel.SaveHighScore(highScorePanel);
        highScorePanel.LoadHighScoreData();
        score1 = highScoreData.highScore;
        score2 = highScoreData.highScore2;
        score3 = highScoreData.highScore3;
        score4 = highScoreData.highScore4;
        score5 = highScoreData.highScore5;

        if (currentHighScore < score2 && currentHighScore < score3 && currentHighScore < score4 && currentHighScore >= score5)
        {
            score2 = score3; score3 = score4; score4 = score5; score5 = currentHighScore;
        }
        else if (currentHighScore < score2 && currentHighScore < score3 && currentHighScore >= score4)
        {
            score2 = score3; score3 = score4; score4 = currentHighScore;
        }
        else if (currentHighScore < score2 && currentHighScore >= score3)
        {
            score2 = score3; score3 = currentHighScore;
        }
        else if (currentHighScore >= score2)
        {
            score2 = currentHighScore;
        }

        //highScorePanel.SaveHighScore2(highScorePanel);
        //highScorePanel.SaveHighScore3(highScorePanel);
        //highScorePanel.SaveHighScore4(highScorePanel);
        //highScorePanel.SaveHighScore5(highScorePanel);

        //if (highScorePanel.highScore != null) { highScorePanel.highScoreID = score.ToString(); highScorePanel.highScore.text = highScorePanel.hS01.ToString(); ; }  //Need to mark (save?) score here as playerName?
        //if (highScorePanel.highScore2 != null) { highScorePanel.highScoreID2 = score2.ToString(); highScorePanel.highScore2.text = highScorePanel.hS02.ToString(); }
        //if (highScorePanel.highScore3 != null) { highScorePanel.highScoreID3 = score3.ToString(); highScorePanel.highScore3.text = highScorePanel.hS03.ToString(); }
        //if (highScorePanel.highScore4 != null) { highScorePanel.highScoreID4 = score4.ToString(); highScorePanel.highScore4.text = highScorePanel.hS04.ToString(); }
        //if (highScorePanel.highScore5 != null) { highScorePanel.highScoreID5 = score5.ToString(); highScorePanel.highScore5.text = highScorePanel.hS05.ToString(); }





        camController.sideCamera.SetActive(true);
        
        pointsCoinsText.text = totalPointsCoinsCollected.ToString();
        hPCoinsText.text = totalHPCoinsCollected.ToString();
        timeCoinsText.text = totalTimeCoinsCollected.ToString();
        scoreText.text = score.ToString(format: "f0");
        totalCoinsText.text = totalCoins.ToString();
        totalTime = Time.deltaTime + timerScript.startTime;
        asteroidCollisionText.text = asteroidCollisions.ToString();
        healthLostText.text = totalHealthLost.ToString();
        healthGained.text = totalHealthGained.ToString();
        totalTimeText.text = totalTime.ToString();
        totalPointsCoinsLost.text = pointsLost.ToString();


        Debug.Log("Game Over Man!");
        gameOverPanel.SetActive(true);
        hUD.SetActive(false);
        gameObject.SetActive(false);
    }
    private void Update()
    {
        //plus1.transform.position = numbersParent.transform.position;
        //pointsText.text = points.ToString();

        if (danceCombos.basePointsMultiplier >= 5) { danceCombos.basePointsMultiplier = 5; }


        if (Toolbox.Instance.playerMovement.isDancing)
        {
            if ((Toolbox.Instance.danceCombos.danceCombos.DanceCombos.PointsDance1.triggered || Toolbox.Instance.danceCombos.danceCombos.DanceCombos.PointsDance2.triggered) && Toolbox.Instance.playerMovement.macacoPerformed)
            {
                macacoSound.Play();
            }

            else if (Toolbox.Instance.danceCombos.danceCombos.DanceCombos.PointsDance3.triggered && Toolbox.Instance.playerMovement.frontFlipPerformed)
            {
                frontFlipSound.Play();
            }
            else if (Toolbox.Instance.danceCombos.danceCombos.DanceCombos.PointsDance4.triggered && Toolbox.Instance.playerMovement.backFlipPerformed)
            {
                backFlipSound.Play();
            }
        }
        if (Toolbox.Instance.playerMovement.controls.Player.Dance.triggered && Toolbox.Instance.playerMovement.isStanding == true)
        {
            danceSounds[Random.Range(0, 4)].Play();
        }

        if (Toolbox.Instance.playerMovement.controls.Player.PlatformGun.triggered && boost >= 1000f)
        {
            platformSpawnSound.Play();
        }

        if (Toolbox.Instance.playerMovement.isStanding && Toolbox.Instance.playerMovement.controls.Player.Jump.triggered)
        {
            jumpSoundPlayed.Play();
        }
        if (Toolbox.Instance.playerMovement.noseDiving == true)
        {
            hyperSpace.Play();
        }
        else if (Toolbox.Instance.playerMovement.noseDiving == false)
        {
            hyperSpace.Stop();
        }
        if (isHardFall1)
        {
            isHardFall1PE.Play();
        }
        else if (isHardFall2)
        {
            isHardFall2PE.Play();
        }

        if (boost >= 10000)
        {
            boost = 10000;
        }

        basePointsMultiplier = danceCombos.basePointsMultiplier;

        score = (points + (hP / 2) * Time.time);
        currentHighScore = score;


        highScorePanel.SaveHighScore(highScorePanel);

       



        if (score <= 0) { score = 0; }

        points = Toolbox.Instance.pickUpScript.points;
        time = Toolbox.Instance.timerScript.t;
        hpText.text = hP.ToString();
       
        if (hP <= 0)
        {
            youDiedTextObject.SetActive(true);
            GameOver();
        }
        if (boost <= 0)
        {
            boost = 0;
            if (boost >= 10000) { boost = 10000; }
        }
        if (hP >= maxHP) { hP = maxHP; }
    }
    private void LateUpdate()
    {
     //   numbersParent.transform.position = player.transform.position;
        numbersParent.transform.rotation = gameObject.transform.rotation;

    }
}
