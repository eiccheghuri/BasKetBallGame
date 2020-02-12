using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChecker : MonoBehaviour
{





    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Ball"))
        {

            ScoreManager.Instance.IncreaseScore();
            ScoreManager.Instance.ScoreTriggered=true;
        }

    }




}
