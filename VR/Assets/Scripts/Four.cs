using UnityEngine;

public class Four : MonoBehaviour
{
    public bool fourSwitch = false;



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "MK")
        {
            fourSwitch  = true;
        }
    }
}
