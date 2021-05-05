using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumentController : MonoBehaviour
{
    public DialogueTrigger trigger;
    public Collider boxCollider;
    public Outline outline;
    private void Start()
    {
        outline = gameObject.GetComponent<Outline>();
    }
    public void OpenDocument()
    {
        trigger.TriggerDialogue();
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
