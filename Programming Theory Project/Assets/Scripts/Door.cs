using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    protected Transform hinge;
    public bool isClosed { get; protected set; }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        hinge = transform.Find("Hinge");
        isClosed = true;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    public virtual void Open()
    {
        if (isClosed)
        {
            hinge.transform.Rotate(Vector3.up, 90.0f);
            isClosed = false;
        }
        
    }

    public virtual void Close()
    {
        if (!isClosed)
        {
            hinge.transform.Rotate(Vector3.up, -90.0f);
            isClosed = true;
        }            
    }


    public virtual void Flip()
    {
        if (isClosed)
        {
            Open();
        }
        else
        {
            Close();
        }
    }



}
