using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public PlayerManager fDPlayerManager;
    public PlayerMovement fDPlayerMovement;
    public PickUps fDPickUps;
    
    float jumpHeight;
    float landingHeight;
    float fallDistance;

    int fallDamage;
    [SerializeField] int fallDamageThreshHoldMinimum;
    [SerializeField] int fallDamageThreshHold1;
    [SerializeField] int fallDamageThreshHold2;
    [SerializeField] int fallDamageThreshHold3;
    [SerializeField] int fallDamageThreshHold4;
    [SerializeField] int fallDamageThreshHold5;

    [SerializeField] int fallDamage1;
    [SerializeField] int fallDamage2;
    [SerializeField] int fallDamage3;
    [SerializeField] int randomNumber;

    [SerializeField] AudioSource damageSound1;
    [SerializeField] AudioSource damageSound2;
    [SerializeField] AudioSource damageSound3;
    [SerializeField] AudioSource damageSound4;
    [SerializeField] AudioSource damageSound5;

    [SerializeField] ParticleSystem coinLossPE;

    [SerializeField] Animation[] hitAnims;
    private void Update()
    {
        randomNumber = Random.Range(1, 5);
    }

    private void LateUpdate()
    {

        fDPlayerMovement.playerAnimator.ResetTrigger("Fall Flat");
        fDPlayerMovement.playerAnimator.ResetTrigger("Kidney Hit");
        fDPlayerMovement.playerAnimator.ResetTrigger("Slap");
        fDPlayerMovement.playerAnimator.ResetTrigger("Uppercut");
        fDPlayerMovement.playerAnimator.ResetTrigger("Shoved");
     

    }
    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.tag == "Platform")
        {
            jumpHeight = transform.position.y;
        }
   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            landingHeight = transform.position.y;
            HealthDrain();
        }
        
    }

    void HealthDrain()
    {
        fallDistance = jumpHeight - landingHeight;
        if(fallDistance < fallDamageThreshHoldMinimum)
        {
            fallDamage = 0;
        }
        
        else if (fallDistance > fallDamageThreshHold1 && fallDistance < fallDamageThreshHold2)
        {
            fallDamage = fallDamage1;
            damageSound1.Play();
            // hitAnims[Random.Range(0, 4)].Play();
            fDPlayerManager.totalHealthLost += fallDamage;
            fDPlayerManager.boost -= 500f;
            if (randomNumber == 1) { fDPlayerMovement.playerAnimator.SetTrigger("Fall Flat"); }
            else if (randomNumber == 2) { fDPlayerMovement.playerAnimator.SetTrigger("Kidney Hit"); }
            else if (randomNumber == 3) { fDPlayerMovement.playerAnimator.SetTrigger("Slap"); }
            else if (randomNumber == 4) { fDPlayerMovement.playerAnimator.SetTrigger("Uppercut"); }
            else if (randomNumber == 5) { fDPlayerMovement.playerAnimator.SetTrigger("Shoved"); }
           // PlayerManager.boost -= 250f;
            //fDPlayerMovement.playerAnimator.ResetTrigger("Fall Flat");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Kidney Hit");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Slap");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Uppercut");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Shoved");
        }
        else if (fallDistance > fallDamageThreshHold2 && fallDistance < fallDamageThreshHold3)
        {
            fallDamage = fallDamage2;
            damageSound2.Play();
            // hitAnims[Random.Range(0, 4)].Play();
            fDPlayerManager.totalHealthLost += fallDamage;
            fDPlayerManager.boost -= 1000f;
            if (randomNumber == 1) { fDPlayerMovement.playerAnimator.SetTrigger("Fall Flat"); }
            else if (randomNumber == 2) { fDPlayerMovement.playerAnimator.SetTrigger("Kidney Hit"); }
            else if (randomNumber == 3) { fDPlayerMovement.playerAnimator.SetTrigger("Slap"); }
            else if (randomNumber == 4) { fDPlayerMovement.playerAnimator.SetTrigger("Uppercut"); }
            else if (randomNumber == 5) { fDPlayerMovement.playerAnimator.SetTrigger("Shoved"); }

            //fDPlayerMovement.playerAnimator.ResetTrigger("Fall Flat");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Kidney Hit");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Slap");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Uppercut");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Shoved");
        }
        else if ( fallDistance > fallDamageThreshHold3 && fallDistance < fallDamageThreshHold4)
        {
            fallDamage = fallDamage3;
            damageSound3.Play();
            // hitAnims[Random.Range(0, 4)].Play();

            fDPlayerManager.totalHealthLost += fallDamage;
            fDPlayerManager.boost -= 1500f;
            if (randomNumber == 1) { fDPlayerMovement.playerAnimator.SetTrigger("Fall Flat"); }
            else if (randomNumber == 2) { fDPlayerMovement.playerAnimator.SetTrigger("Kidney Hit"); }
            else if (randomNumber == 3) { fDPlayerMovement.playerAnimator.SetTrigger("Slap"); }
            else if (randomNumber == 4) { fDPlayerMovement.playerAnimator.SetTrigger("Uppercut"); }
            else if (randomNumber == 5) { fDPlayerMovement.playerAnimator.SetTrigger("Shoved"); }

            //fDPlayerMovement.playerAnimator.ResetTrigger("Fall Flat");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Kidney Hit");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Slap");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Uppercut");
            //fDPlayerMovement.playerAnimator.ResetTrigger("Shoved");
        }
        else if (fallDistance > fallDamageThreshHold4 && fallDistance < fallDamageThreshHold5)
        {
            fallDamage = fallDamage3;
            damageSound4.Play();
            coinLossPE.Play();
            fDPlayerMovement.hardFall1 = true;
            fDPlayerManager.boost -= 2000f;
            fDPlayerManager.totalHealthLost += fallDamage;

            if (fDPickUps.points > 0) { fDPickUps.points -= 1; fDPlayerManager.pointsLost += 1; }
            
        }
        else if (fallDistance > fallDamageThreshHold5)
        {
            fallDamage = fallDamage3;
            damageSound5.Play();
            fDPlayerMovement.hardFall2 = true;

            coinLossPE.Play();
            if (fDPickUps.points > 1 ){ fDPickUps.points -= 2; fDPlayerManager.pointsLost += 1; }
            else if (fDPickUps.points == 1) {  fDPickUps.points -= 1; fDPlayerManager.pointsLost += 1; }

               
            fDPlayerManager.boost -= 3000f;
            fDPlayerManager.totalHealthLost += fallDamage;

         

        }


            fDPlayerManager.hP -= fallDamage;
       
    }
}
