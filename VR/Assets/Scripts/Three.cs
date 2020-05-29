using UnityEngine;

public class Three : MonoBehaviour
{
    public bool threeSwitch = false;


    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "MK")
        {
            threeSwitch = true;
        }
    }

}
