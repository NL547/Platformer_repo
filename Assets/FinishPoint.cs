using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Debug.Log("Уровень пройден!");
        }
    }
}
