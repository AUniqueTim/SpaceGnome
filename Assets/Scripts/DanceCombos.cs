using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceCombos : MonoBehaviour
{
    public SpaceGnome_02_InputActions danceCombos;
    public PickUps combosPickUps;
    public PlayerMovement combosPlayerMovement;
    [SerializeField] PlayerManager combosPlayerManager;
   public int basePointsMultiplier;

    public bool pointsDance1Performed;
    public bool pointsDance2Performed;
    public bool pointsDance3Performed;
    public bool pointsDance4Performed;

    public void Awake()
    {
        danceCombos = new SpaceGnome_02_InputActions();

        danceCombos.DanceCombos.PointsDance1.performed += context => PointsDance1();
        danceCombos.DanceCombos.PointsDance2.performed += context => PointsDance2();
        danceCombos.DanceCombos.PointsDance3.performed += context => PointsDance3();
        danceCombos.DanceCombos.PointsDance4.performed += context => PointsDance4();

    }


    public void PointsDance1()
    {
        combosPlayerManager.totalHealthGained += 1;
       
        if (!pointsDance1Performed)
        {
            basePointsMultiplier += 1;
        }

        pointsDance1Performed = true; //pointsDance2Performed = false; pointsDance3Performed = false; pointsDance4Performed = false;
        

    }
    public void PointsDance2()
    {
        combosPlayerManager.totalHealthGained += 1;
      

        if (!pointsDance2Performed)
        {
            basePointsMultiplier += 1;
        }

        pointsDance2Performed = true;// pointsDance1Performed = false; pointsDance3Performed = false; pointsDance4Performed = false;
    }
    public void PointsDance3() 
    {
        combosPlayerManager.totalHealthGained += 1;

        if (!pointsDance3Performed)
        {
            basePointsMultiplier += 1;
        }
        pointsDance3Performed = true; //pointsDance1Performed = false; pointsDance2Performed = false; pointsDance4Performed = false;
    }
    public void PointsDance4()
    {
        combosPlayerManager.totalHealthGained += 1;

        if (!pointsDance4Performed)
        {
            basePointsMultiplier += 1;
        }
        pointsDance4Performed = true; //pointsDance1Performed = false; pointsDance2Performed = false; pointsDance3Performed = false;
    }
    

    void OnEnable()
    {
        danceCombos.DanceCombos.Enable();

    }
    void OnDisable()
    {
        danceCombos.DanceCombos.Disable();
    }

}
