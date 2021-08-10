
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
[System.Serializable]

public class HighScorePanel : MonoBehaviour
{
   public PlayerManager m_playerManager;

    public TextMeshProUGUI highScore;
    public TextMeshProUGUI highScore2;
    public TextMeshProUGUI highScore3;
    public TextMeshProUGUI highScore4;
    public TextMeshProUGUI highScore5;

    //public string highScoreID;
    //public string highScoreID2;
    //public string highScoreID3;
    //public string highScoreID4;
    //public string highScoreID5;

    public int hsID;

    public float hS01;
    public float hS02;
    public float hS03;
    public float hS04;
    public float hS05;

    //Start Singlton
    public static HighScorePanel instance;
    public static HighScorePanel Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<HighScorePanel>();
                if (instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.AddComponent<HighScorePanel>();
                    singleton.name = "(Singleton) HighScorePanel";
                }
            }
            return instance;
        }
    }
    //End Singleton

    private void Awake()
    {
        instance = this;

        LoadHighScoreData();
    }

    private void Update()
    {
        //        highScore.text = m_playerManager.score.ToString();  //Set on GameOver() in PlayerManager.



        hS01 = m_playerManager.score;
        hS02 = m_playerManager.score2;
        hS03 = m_playerManager.score3;
        hS04 = m_playerManager.score4;
        hS05 = m_playerManager.score5;

        
    }

    public void SaveHighScore(HighScorePanel highScore_01)
    {

        PlayerPrefs.SetFloat(highScore.text, hS01);   /* m_playerManager.score);*/
        PlayerPrefs.SetFloat(highScore2.text, hS02);
        PlayerPrefs.SetFloat(highScore3.text, hS03);
        PlayerPrefs.SetFloat(highScore4.text, hS04);
        PlayerPrefs.SetFloat(highScore5.text, hS05);

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/HighScoreFile.sco";
        
        FileStream fileStream = new FileStream(path, FileMode.Create);
        HighScoreData hS_Data = new HighScoreData(highScore_01);

        binaryFormatter.Serialize(fileStream, hS_Data);
        fileStream.Close();

        if (!File.Exists(path))
        {

            FileStream stream = new FileStream(path, FileMode.Create);
            HighScoreData data = new HighScoreData(highScore_01);
            binaryFormatter.Serialize(stream, data);
            stream.Close();
        }
        //else if (File.Exists(path))
        //{
        //    hsID += 1;
        //    path = Application.persistentDataPath + "/" + highScoreID + hsID.ToString() + ".scr";
        //    FileStream stream = new FileStream(path, FileMode.Create);
        //    HighScoreData data = new HighScoreData(highScore_02);
        //    binaryFormatter.Serialize(stream, data);
        //    stream.Close();
        //}

        


    }
    //public void SaveHighScore2(HighScorePanel highScore_02)
    //{
    //    BinaryFormatter binaryFormatter = new BinaryFormatter();
    //    string path = Application.persistentDataPath + "/" + highScoreID + "1" + ".scr";

    //    FileStream fileStream = new FileStream(path, FileMode.Create);
    //    HighScoreData hS_Data = new HighScoreData(highScore_02);

    //    binaryFormatter.Serialize(fileStream, hS_Data);
    //    fileStream.Close();

    //    if (!File.Exists(path))
    //    {

    //        FileStream stream = new FileStream(path, FileMode.Create);
    //        HighScoreData data = new HighScoreData(highScore_02);
    //        binaryFormatter.Serialize(stream, data);
    //        stream.Close();
    //    }

    //    PlayerPrefs.SetFloat(hS02.ToString(), m_playerManager.score2);

    //}
    //public void SaveHighScore3(HighScorePanel highScore_03)
    //{
    //    BinaryFormatter binaryFormatter = new BinaryFormatter();
    //    string path = Application.persistentDataPath + "/" + highScoreID + "2" + ".scr";

    //    FileStream fileStream = new FileStream(path, FileMode.Create);
    //    HighScoreData hS_Data = new HighScoreData(highScore_03);

    //    binaryFormatter.Serialize(fileStream, hS_Data);
    //    fileStream.Close();

    //    if (!File.Exists(path))
    //    {

    //        FileStream stream = new FileStream(path, FileMode.Create);
    //        HighScoreData data = new HighScoreData(highScore_03);
    //        binaryFormatter.Serialize(stream, data);
    //        stream.Close();
    //    }

    //    PlayerPrefs.SetFloat(hS03.ToString(), m_playerManager.score3);
    //}
    //public void SaveHighScore4(HighScorePanel highScore_04)
    //{
    //    BinaryFormatter binaryFormatter = new BinaryFormatter();
    //    string path = Application.persistentDataPath + "/" + highScoreID + "3" + ".scr";

    //    FileStream fileStream = new FileStream(path, FileMode.Create);
    //    HighScoreData hS_Data = new HighScoreData(highScore_04);

    //    binaryFormatter.Serialize(fileStream, hS_Data);
    //    fileStream.Close();

    //    if (!File.Exists(path))
    //    {

    //        FileStream stream = new FileStream(path, FileMode.Create);
    //        HighScoreData data = new HighScoreData(highScore_04);
    //        binaryFormatter.Serialize(stream, data);
    //        stream.Close();
    //    }

    //    PlayerPrefs.SetFloat(hS04.ToString(), m_playerManager.score4);
    //}
    //public void SaveHighScore5(HighScorePanel highScore_05)
    //{
    //    BinaryFormatter binaryFormatter = new BinaryFormatter();
    //    string path = Application.persistentDataPath + "/" + highScoreID + "4" + ".scr";

    //    FileStream fileStream = new FileStream(path, FileMode.Create);
    //    HighScoreData hS_Data = new HighScoreData(highScore_05);

    //    binaryFormatter.Serialize(fileStream, hS_Data);
    //    fileStream.Close();

    //    if (!File.Exists(path))
    //    {

    //        FileStream stream = new FileStream(path, FileMode.Create);
    //        HighScoreData data = new HighScoreData(highScore_05);
    //        binaryFormatter.Serialize(stream, data);
    //        stream.Close();
    //    }

    //    PlayerPrefs.SetFloat(hS05.ToString(), m_playerManager.score5);

    //}
    public HighScoreData LoadHighScoreData()
    {
        //PlayerPrefs.GetFloat(m_playerManager.score.ToString(), hS01);
        //PlayerPrefs.GetFloat(m_playerManager.score2.ToString(), hS02);
        //PlayerPrefs.GetFloat(m_playerManager.score3.ToString(), hS03);
        //PlayerPrefs.GetFloat(m_playerManager.score4.ToString(), hS04);
        //PlayerPrefs.GetFloat(m_playerManager.score5.ToString(), hS05);


        string path = Application.persistentDataPath + "/HighScoreFile.sco";
        if (File.Exists(path))
        {
            //PlayerPrefs.GetFloat(highScore.text, hS01);
            //PlayerPrefs.GetFloat(highScore2.text, hS02);
            //PlayerPrefs.GetFloat(highScore3.text, hS03);
            //PlayerPrefs.GetFloat(highScore4.text, hS04);
            //PlayerPrefs.GetFloat(highScore5.text, hS05);

            BinaryFormatter formatter = new BinaryFormatter();
            path = Application.persistentDataPath + "/HighScoreFile.sco";
            FileStream stream = new FileStream(path, FileMode.Open);

            

            HighScoreData data = formatter.Deserialize(stream) as HighScoreData;
            stream.Close();
            return data;
        }
        //path = Application.persistentDataPath + "/" + highScoreID + "1" + ".scr";
        //if (File.Exists(path))
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();

        //    path = Application.persistentDataPath + "/" + highScoreID + "1" + ".scr";
        //    FileStream stream = new FileStream(path, FileMode.Open);
        //    HighScoreData data = formatter.Deserialize(stream) as HighScoreData;
        //    stream.Close();
        //    return data;
        //}
        //path = Application.persistentDataPath + "/" + highScoreID + "2" + ".scr";
        //if (File.Exists(path))
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();

        //    path = Application.persistentDataPath + "/" + highScoreID + "2" + ".scr";
        //    FileStream stream = new FileStream(path, FileMode.Open);
        //    HighScoreData data = formatter.Deserialize(stream) as HighScoreData;
        //    stream.Close();
        //    return data;
        //}
        //path = Application.persistentDataPath + "/" + highScoreID + "3" + ".scr";
        //if (File.Exists(path))
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();

        //    path = Application.persistentDataPath + "/" + highScoreID + "3" + ".scr";
        //    FileStream stream = new FileStream(path, FileMode.Open);
        //    HighScoreData data = formatter.Deserialize(stream) as HighScoreData;
        //    stream.Close();
        //    return data;
        //}
        //path = Application.persistentDataPath + "/" + highScoreID + "4" + ".scr";
        //if (File.Exists(path))
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();

        //    path = Application.persistentDataPath + "/" + highScoreID + "4" + ".scr";
        //    FileStream stream = new FileStream(path, FileMode.Open);
        //    HighScoreData data = formatter.Deserialize(stream) as HighScoreData;
        //    stream.Close();
        //    return data;
        //}
        //path = Application.persistentDataPath + "/" + highScoreID + "5" + ".scr";
        //if (File.Exists(path))
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();

        //    path = Application.persistentDataPath + "/" + highScoreID + "5" + ".scr";
        //    FileStream stream = new FileStream(path, FileMode.Open);
        //    HighScoreData data = formatter.Deserialize(stream) as HighScoreData;
        //    stream.Close();
        //    return data;
        //}
        else { Debug.LogError("No .scr found in " + path); return null; }
        //else if (!File.Exists(path))
        //{
        //    Debug.LogError("No .scr found in " + path);
        //    return null;
        //}

    }
}
