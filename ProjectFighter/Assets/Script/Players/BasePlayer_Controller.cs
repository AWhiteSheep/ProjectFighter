using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BasePlayer_Movement), typeof(BasePlayer_Attacks))]
public class BasePlayer_Controller : MonoBehaviour
{
    BasePlayer_Movement PlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GetComponent<BasePlayer_Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
