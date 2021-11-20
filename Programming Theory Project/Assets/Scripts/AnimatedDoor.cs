using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class AnimatedDoor : Door    // INHERITANCE
{

    private float m_speed = 5.0f;
    private Quaternion targetRotation;


    protected override void Start()     // POLYMORPHISM
    {
        base.Start();
        targetRotation = hinge.transform.rotation;
    }

    protected override void Update()    // POLYMORPHISM
    {
        hinge.transform.rotation = Quaternion.Lerp(hinge.transform.rotation, targetRotation, m_speed * Time.deltaTime);

    }

    public override void Open()     // POLYMORPHISM
    {
        if (isClosed)
        {
            targetRotation *= Quaternion.AngleAxis(90, Vector3.up);
            isClosed = false;
        }
    }

    public void Open(float speed)
    {
        if (isClosed)
        {
            m_speed = speed;
            targetRotation *= Quaternion.AngleAxis(90, Vector3.up);
            isClosed = false;
        }
    }

    public override void Close()        // POLYMORPHISM
    {
        if (!isClosed)
        {
            targetRotation *= Quaternion.AngleAxis(-90, Vector3.up);
            isClosed = true;
        }
    }

    public void  Close(float speed)
    {
        if (!isClosed)
        {
            m_speed = speed;
            targetRotation *= Quaternion.AngleAxis(-90, Vector3.up);
            isClosed = true;
        }
    }

    public void Flip(float speed)   // ABSTRACTION
    {
        m_speed = speed;
        base.Flip();

    }
}
