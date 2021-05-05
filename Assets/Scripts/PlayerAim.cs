using UnityEngine;
using UnityEngine.UI;

public class PlayerAim : MonoBehaviour
{
    public Transform headPos;
   
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(headPos.position, headPos.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
  
            float distance = Vector3.Distance(transform.position, hit.transform.position);
            if (distance <= 3f)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (hit.transform.GetComponent<KeypadKey>() != null)
                    {
                        hit.transform.GetComponent<KeypadKey>().SendKey();
                    }
                    else if(hit.transform.name=="Panel1" || hit.transform.name == "Panel2" || hit.transform.name == "Drawer")
                    {
                        hit.transform.GetComponentInParent<DoorController>().OpenClose();
                    }
                    else if (hit.transform.name == "Document")
                    {
                        hit.transform.GetComponent<DocumentController>().OpenDocument();
                    }else if (hit.transform.name == "Key")
                    {
                        hit.transform.GetComponent<Key>().PickTheKey();
                    }
                }
            }
        }
    }
}

