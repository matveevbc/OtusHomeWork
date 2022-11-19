using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class AttackController : MonoBehaviour
{
    /*
    [SerializeField]
    private IEnemyDetecter detecter;

    [SerializeField]
    private Entity attacker;


    private void OnEnable()
    {
        detecter += OnDetected;
    }

    private void OnDisable()
    {
        detecter -= OnDetected;
    }

    void OnDetected(Entity target)
    {
        attacker.Get<AttackComponent>().attack(target);
    }
}


public interface IAttackComponent
{
    void Attack(Entity target);
}


public sealed class AttackComponent: MonoBehaviour, IAttackComponent
{
    [SerializeField]
    private EntityEnventReciver attackReciver;

    void Attack(Entity target)
    {
        attackReciver.Call(target);
    }*/
}