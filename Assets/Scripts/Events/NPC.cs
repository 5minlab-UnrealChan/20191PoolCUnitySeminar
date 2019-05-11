using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IEventListener
{
    private void OnEnable()
    {
        EventDispatcher.AddListener(this);
    }

    private void OnDisable()
    {
        EventDispatcher.RemoveListener(this);
    }

    public void OnEvent(IEvent e)
    {
        if (e is AttackEvent)
        {
            if (((AttackEvent)e).target == this)
                Debug.LogError($"와 샌즈!: {gameObject.name}");
        }
    }

}
