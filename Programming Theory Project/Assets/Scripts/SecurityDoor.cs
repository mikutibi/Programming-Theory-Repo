using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityDoor : Door
{
    public bool isLocked { get; protected set; }
    private string m_key;

    protected override void Start()
    {
        base.Start();
        LockOn("1234");
    }


    public void LockOn(string key)
    {
        m_key = key;
        isLocked = true;
    }

    public void UnLock(string key)
    {
        if (m_key.Equals(key))
        {
            isLocked = false;
            Debug.Log("Unlocked");
        }
    }

    public override void Open()
    {
        if (!isLocked && isClosed)
        {
            base.Open();
        }
        else
        {
            Debug.Log("Door is locked!");
        }
    }

    public void Open(string key)
    {
        UnLock(key);
        Open();
    }

    
}
