using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class testFSM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var fsm = GetComponent<StateMachine>();
        fsm.TriggerUnityEvent("InitFinish");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
