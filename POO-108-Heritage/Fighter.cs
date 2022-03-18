using System;
class Fighter {
    private int strength;
    private int health = 100;

    public override string ToString() {
        return $"santé {this.health}% - Force {this.strength}";
    }

    public void display()
	{
		Console.WriteLine(this);
	}

    public int getHealth() {
        return health;
    }

    public int getStrength() {
        return strength;
    }

    public void setStrength(int newStrength) {
        if (newStrength > 0) {
            this.strength = newStrength;
        }
    }

    public void receiveDamage(int damage) {
		this.health = this.health - Math.Min(this.health, damage);
	}

    public void heal(int addedHealthValue) {
        health = Math.Min(100, health + addedHealthValue);
    }

    public void increaseStrength(int addedStrength) {
        this.strength = this.strength + addedStrength;
    }

    public bool isAlive() {
        return this.health > 0;
    }
}