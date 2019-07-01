using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        PlayerEvents.OnControllerSource += UpdateOrigin;
        PlayerEvents.OnTouchpadDown += ProcessTouchpadDown;
    }

    private void OnDestroy()
    {
        PlayerEvents.OnControllerSource -= UpdateOrigin;
        PlayerEvents.OnTouchpadDown -= ProcessTouchpadDown;
    }

    private void UpdateOrigin(OVRInput.Controller controller, GameObject controllerObject)
    {

    }

    private void ProcessTouchpadDown()
    {

    }
}
