using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingleton : MonoBehaviour
{
    Monster monster;

    private void Start()
    {
        monster = new Monster();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            using (AttackCommand cmd = new AttackCommand(monster, 1))
            {
                cmd.Execute();
            }
        }
    }
}

public class Monster
{
    int currentHP = 10;

    public void GetDamage(int dmg)
    {
        currentHP -= dmg;
    }
}

public class InputHandler
{
    Monster monster;

    public InputHandler()
    {
        monster = new Monster();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AttackCommand cmd = new AttackCommand(monster, 1);
            cmd.Execute();
        }
    }

    public void DoAttack(Monster monster, int dmg)
    {
        monster.GetDamage(dmg);
    }
}
