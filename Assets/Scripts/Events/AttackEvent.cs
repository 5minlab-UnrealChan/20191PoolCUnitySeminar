using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEvent : IEvent
{
    public NPC target;

    public AttackEvent(NPC target)
    {
        this.target = target;
    }
}
