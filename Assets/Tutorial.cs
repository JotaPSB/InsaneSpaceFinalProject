using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public DialogueTrigger trigger;

    private void OnTriggerEnter(Collider other)
    {
        trigger.TriggerDialogue();
        Destroy(gameObject);
    }
}
