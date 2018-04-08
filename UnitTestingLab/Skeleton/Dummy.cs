using System;
using Tests.Interfaces;

public class Dummy : ITarget
{
    public int health { get; set; }
    public int experience { get; set; }

    public Dummy(int health, int experience)
    {
        this.health = health;
        this.experience = experience;
    }

    public int Health
    {
        get { return this.health; }
    }

    public void TakeAttack(int attackPoints)
    {
        if (this.IsDead())
        {
            throw new InvalidOperationException("Dummy is dead.");
        }

        this.health -= attackPoints;
    }

    public int GiveExperience()
    {
        if (!this.IsDead())
        {
            throw new InvalidOperationException("Target is not dead.");
        }

        return this.experience;
    }

    public bool IsDead()
    {
        return this.health <= 0;
    }
}