using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool lockedByPassword;
    public bool lockedByKey;
    public Collider boxCollider;
    public DialogueTrigger trigger;
    public Animator anim;
    public Outline outline;
    private void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider>();
        outline = gameObject.GetComponent<Outline>();
    }
    public void OpenClose()
    {
        if (lockedByKey)
        {
            trigger.TriggerDialogue();
            return;
        }
        if (lockedByPassword)
        {
            trigger.TriggerDialogue();

          
            return;
        }
       

        anim.SetBool("OpenDoor", true);
        boxCollider.enabled = false;
        outline.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
 
  
        outline.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        outline.enabled = false;
    }
}
