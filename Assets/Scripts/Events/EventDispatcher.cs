using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventDispatcher
{
    private static List<IEventListener> listeners = new List<IEventListener>();

    public static void AddListener(IEventListener listener)
    {
        listeners.Add(listener);
    }

    public static void RemoveListener(IEventListener listener)
    {
        listeners.Remove(listener);
    }

    public static void Send(IEvent e)
    {
        foreach (var item in listeners)
        {
            item.OnEvent(e);
        }
    }
}
