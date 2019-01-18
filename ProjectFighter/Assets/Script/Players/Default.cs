using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// All creature, player and alive things will have those stats
/// we have health here 
/// </summary>
public class Default : MonoBehaviour
{    
    protected int _MaxHealth;
    protected int _CurrentHealth;
    protected int _GroundSpeedWalking;
    protected int _GroundSpeedRunning;
    protected int _AirSpeed;
}
