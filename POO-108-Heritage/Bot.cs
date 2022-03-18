using System;
class Bot : Fighter
{
    public Bot(int s) {
        setStrength(s);
        Console.WriteLine("Un Bot vient vous affronter");
        this.display();
    }

    public Bot() : this(1) {
        
    }

    public override string ToString() {
		string parentDescription = base.ToString();
        return $"Bot - {parentDescription}";
    }

    public void attackPlayer(Player player) {
		if (this.isAlive() && player.isAlive()) {
			var generator = new Random();
			int hitStrength = generator.Next(1, 11) * this.getStrength();
			Console.WriteLine($"Le Bot vous frappe avec une force de {hitStrength}");
			player.receiveDamage(hitStrength);
		}
		
	}
}