using System;

public class Application
{
	ConsoleManager console = new ConsoleManager();
	WeaponListManager weaponListManager = new WeaponListManager();

	public void fonctionPrincipale ()
	{
		console.println("Quel est votre pseudo ?");
		string username = Utilisateur.saisirTexte();
		Player p1 = new Player(username);
		Console.WriteLine(p1);
		int nbBotsVaincus = 0;
		do {	
			Bot b1 = new Bot((nbBotsVaincus + 1) * 2);
			p1.rest();
			fight(p1, b1);
			if (p1.isAlive()) {
				nbBotsVaincus++;
			}
		} while (p1.isAlive());
		console.println($"Vous avez vaincu {nbBotsVaincus} avant de succomber");
	}
	
	void fight(Player p1, Bot b1) {
		console.println("Lancer les dés pour savoir qui attaque en premier");
		int dicesValue = p1.rollDices();
		while (b1.isAlive() && p1.isAlive()) {
			if (dicesValue % 2 == 0) {
				p1.chooseNextMove(b1);
				b1.attackPlayer(p1);
			} else {
				b1.attackPlayer(p1);
				p1.chooseNextMove(b1);
			}
			
			b1.display();
			p1.display();
		}
		
		if (p1.isAlive()) {
			console.println("Vous avez gagné! GG!");
			p1.didWinBot(b1);
			Weapon nextWeapon = weaponListManager.getNextWeaponToLoot();
			if (nextWeapon != null && console.askYesNo("Une nouvelle arme est disponible : "+nextWeapon+"\nVoulez-vous la récupérer ?") == true) {
				p1.pickUpWeapon(nextWeapon);
			}
		} else {
			console.println("Vous avez été vaincu par le Bot :(");
		}
	}
}


