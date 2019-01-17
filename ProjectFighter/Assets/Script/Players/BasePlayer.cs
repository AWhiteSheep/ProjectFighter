using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


/// <summary>
/// This class is dérived from default and received all the stats given in the default
/// </summary>
public class BasePlayer : Default
{
    enum PlayerStates
    {
        Alive,
        Dead
    };

    PlayerStates PlayerState;

    MessageHandler messageHandler;

    //Directory of all players that plays
    public static List<BasePlayer> Players;

    //This will vbe set in the menu
    protected string _Name;

    //Accessors
    public int CurrentHealth
    {
        get
        {
            return _CurrentHealth;
        }

        set
        {
            //Check for not going upper then the MaxHealth
            if (value < _MaxHealth)
            {
                if (value > 0)
                    _CurrentHealth = value;
                else
                {
                    _CurrentHealth = 0;
                    PlayerState = PlayerStates.Dead;

                    messageHandler.instance.PlayerKilled(this._Name);
                }
            }
            else
                Debug.Log("CurrentHealth of " + _Name + " cant go above " + _MaxHealth);
        }
    }

    private void Start()
    {
        messageHandler = FindObjectOfType<MessageHandler>();

        //Création d'un nouveau dictionnaire si le dictionnaire n'est pas trouvé
        if (Players == null)
            Players = new List<BasePlayer>();

        //add to the directory for all the players
        Players.Add(this);

        PlayerState = PlayerStates.Alive;
    }

    public virtual void PlayerKilled()
    {
        //Message system
        //Base Animation Script 
    }
}
