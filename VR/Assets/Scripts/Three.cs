using UnityEngine;

public class Three : MonoBehaviour
{
    public bool threeSwitch = false;


    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "MK_1" ||
            other.name == "MK_2" ||
            other.name == "MK_3" ||
            other.name == "MK_4" ||
            other.name == "MK_5")
        {
            threeSwitch = true;
        }
    }

}
