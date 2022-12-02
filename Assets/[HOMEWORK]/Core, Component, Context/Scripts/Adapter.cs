using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class Panel: MonoBehaviour
{
    public Text text;

    public void Setup(string value)
    {
        text.text = value;
    }

    public void UpdateValue(string value)
    {
        text.text = value;
    }
}
/*
public sealed class HealthPanelAdapter : MonoBehaviour,
    IGameInitElement,
    IGameReadyElement,
    IGameFinishElement
{

    [SerializeField]
    private Panel panel;

    private Health health;

    void IGameInitElement.InitGame(IGameContext context)
    {
        this.health = context.Get<Character>().Get<health>();
        panel.Setup(this.health.value.toString());
    }

    void IGameReadyElement.Start(IGameContext context)
    {
        this.health.OnHealthChanged += UpdateHealth;
    }

    void IGameFinishElement.Start(IGameContext context)
    {
        this.health.OnHealthChanged -= UpdateHealth;
    }

    void UpdateHealth()
    {
        panel.UpdateValue(health.value);
    }
}

public sealed class Health : MonoBehaviour
{
    public int value;

    public Action<int> OnHealthChanged;
}


public sealed class AttackPanelAdapter : MonoBehaviour,
    IGameInitElement,
    IGameReadyElement,
    IGameFinishElement
{

    [SerializeField]
    private Panel panel;

    private Attack attack;

    void IGameInitElement.InitGame(IGameContext context)
    {
        this.attack = context.Get<Character>().Get<attack>();
        panel.Setup(this.attack.value.toString());
    }

    void IGameReadyElement.Start(IGameContext context)
    {
        this.attack.OnHealthChanged += UpdateAttack;
    }

    void IGameFinishElement.Start(IGameContext context)
    {
        this.attack.OnAttackChanged -= UpdateAttack;
    }

    void UpdateAttack()
    {
        panel.UpdateValue(attack.value);
    }
}

public sealed class Attack : MonoBehaviour
{
    public int value;

    public Action<int> OnAttackChanged;
}

public sealed class SpeedPanelAdapter : MonoBehaviour,
    IGameInitElement,
    IGameReadyElement,
    IGameFinishElement
{

    [SerializeField]
    private Panel panel;

    private Speed speed;

    void IGameInitElement.InitGame(IGameContext context)
    {
        this.speed = context.Get<Character>().Get<speed>();
        panel.Setup(this.speed.value.toString());
    }

    void IGameReadyElement.Start(IGameContext context)
    {
        this.speed.OnHealthChanged += UpdateSpeed;
    }

    void IGameFinishElement.Start(IGameContext context)
    {
        this.speed.OnSpeedChanged -= UpdateSpeed;
    }

    void UpdateSpeed()
    {
        panel.UpdateValue(speed.value);
    }
}

public sealed class Speed : MonoBehaviour
{
    public int value;

    public Action<int> OnSpeedChanged;
}
*/