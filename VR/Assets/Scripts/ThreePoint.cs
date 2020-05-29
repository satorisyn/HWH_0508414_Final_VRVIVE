using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePoint : MonoBehaviour
{
    public bool inThreePoint = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "30M_F")
        {
            inThreePoint = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "HeadCollider")
        {
            inThreePoint = false;
        }
    }
}
