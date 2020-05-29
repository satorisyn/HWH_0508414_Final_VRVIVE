using UnityEngine;

public class Five : MonoBehaviour
{
    public bool fiveSwitch = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "MK")
        {
            fiveSwitch = true;
        }
    }
}
