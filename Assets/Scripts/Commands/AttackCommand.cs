using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AttackCommand : ICommand, IDisposable
{
    Monster monster;
    int dmg;

    public AttackCommand(Monster mob, int d)
    {
        monster = mob;
        dmg = d;
    }

    public void Dispose()
    {
        monster = null;
    }

    public void Execute()
    {
        //실질적인 내용이 들어감
        monster.GetDamage(dmg);
        Debug.LogError($"Get Damaged: {dmg}");
    }
}
