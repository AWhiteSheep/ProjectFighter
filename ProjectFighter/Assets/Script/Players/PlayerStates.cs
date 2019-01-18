using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BasePlayer))]
public class PlayerStates : MonoBehaviour
{
    public enum PlayerState { Alive, Dead };
    public enum PlayerMovement { Idling, Walking, Running, Jumping, Attacking, TakingDamage, Falling };

    private PlayerState playerState;
    private PlayerMovement playerMovement;

    public void SetPlayerState(PlayerState newState)
    {
        playerState = newState;
    }

    public void SetPlayerMovement(PlayerMovement newState)
    {
        playerMovement = newState;
    }

    public PlayerState GetPlayerState()
    {
        return playerState;
    }

    public PlayerMovement GetPlayerMovement()
    {
        return playerMovement;
    }
}
