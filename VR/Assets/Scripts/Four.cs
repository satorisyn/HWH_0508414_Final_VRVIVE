using UnityEngine;

public class Four : MonoBehaviour
{
    public bool fourSwitch = false;



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "MK_1" ||
            other.name == "MK_2" ||
            other.name == "MK_3" ||
            other.name == "MK_4" ||
            other.name == "MK_5")
        {
            fourSwitch  = true;
        }
    }
}
