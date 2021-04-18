using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    private Animator anim;
    [SerializeField] AudioClip openSound;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        OpenOrCloseDoor(true);
        /*source.PlayOneShot(openSound);
        anim.SetBool("opening", true);*/
    }
    private void OnTriggerExit(Collider other)
    {
        OpenOrCloseDoor(false);
        /*source.PlayOneShot(openSound);
        anim.SetBool("opening", false);*/
    }

    void OpenOrCloseDoor(bool open)
    {
        source.PlayOneShot(openSound);
        anim.SetBool("opening", open);
    }
}
