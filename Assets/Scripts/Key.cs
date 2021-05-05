using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public DoorController controller;
    public DialogueTrigger trigger;
    public Outline outline;
    public void PickTheKey()
    {
        trigger.TriggerDialogue();
        controller.lockedByKey = false;
        controller.outline.OutlineColor = Color.green;
        Destroy(gameObject);
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
