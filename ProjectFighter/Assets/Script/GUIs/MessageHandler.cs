using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The MessageHandler will exist in the inGameHandler in the scene
/// </summary>
public class MessageHandler : MonoBehaviour
{
    private static MessageHandler _instance = null;

    public MessageHandler instance
    {
        get
        {
            if (_instance == null)
                _instance = this;

            return _instance;
        }
    }

    public void PlayerKilled(string pKilled)
    {
        Debug.Log(pKilled + " has been killed by " + " pKiller");
    }
}
