using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    public DanceCombos danceCombos;
    
    public int points;

    private int basePointsMultiplier;


    public void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "HP")
        //{
        //    Toolbox.Instance.playerManagerScript.hP += 1;
        //}
        //else if (collision.gameObject.tag == "Time")
        //{
        //    Toolbox.Instance.timerScript.t -= 10f;
        //}
        if (collision.gameObject.tag == "Points")
        {
            points += 1 * basePointsMultiplier;
        }
    }

    private void Update()
    {
        if (points <= 0) { points = 0; }
        Toolbox.Instance.playerManagerScript.points = points;
        basePointsMultiplier = danceCombos.basePointsMultiplier;
        Toolbox.Instance.playerManagerScript.pointsText.text = points.ToString();

    }
}
