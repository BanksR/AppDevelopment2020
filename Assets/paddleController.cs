using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{

    private HingeJoint2D _hinge;

    private void Awake()
    {
        _hinge = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _hinge.useMotor = true;
        }

        else
        {
            _hinge.useMotor = false;
        }
    
    }
}
