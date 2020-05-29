using UnityEngine;
using Valve.VR.InteractionSystem;

public class Explosion: MonoBehaviour
{
    private int timer_i = 0;
    public ParticleSystem EX;
    public GameObject GGG;

    public AudioClip audEx;
    private AudioSource aud;


    public void IvntimerS()
    {
        InvokeRepeating("timeS", 1f, 1f); 
    }

    public void timeS()
    {
        timer_i += 1;
        Debug.Log(timer_i);
    }
        
    public void EXP()
    {
        EX.Play();
        aud.PlayOneShot(audEx);
    }

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (timer_i == 7)
        {
            EXP();
        }
        if(timer_i == 9)
        {
            Destroy(GGG);
        }
    }

}
