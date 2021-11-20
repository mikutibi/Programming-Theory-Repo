using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityDoor : Door    // INHERITANCE
{
    public bool isLocked { get; protected set; }
    private string m_key;

    protected override void Start()     // POLYMORPHISM
    {
        base.Start();
        LockOn("1234");     // ABSTRACTION
    }


    public void LockOn(string key)  // ENCAPSULATION
    {
        m_key = key;
        isLocked = true;
    }

    public void UnLock(string key)  // ENCAPSULATION
    {
        if (m_key.Equals(key))
        {
            isLocked = false;
            Debug.Log("Unlocked");
        }
    }

    public override void Open()     // POLYMORPHISM
    {
        if (!isLocked && isClosed)
        {
            base.Open();        // ABSTRACTION
        }
        else
        {
            Debug.Log("Door is locked!");
        }
    }

    public void Open(string key)    // ABSTRACTION
    {
        UnLock(key);
        Open();
    }

    
}
