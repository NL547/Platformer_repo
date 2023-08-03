using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateUnlocker : MonoBehaviour
{
    public string targetTag;

    void Update()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);
        if (targetObject == null)
        {
            Destroy(gameObject);
        }
    }
}
