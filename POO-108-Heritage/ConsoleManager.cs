using System;

class ConsoleManager {
    public void println(string message) {
        Console.WriteLine(message);
        string strengthToSave = "" + 20;
    }

    public void confirm(string message) {
		string inputConfirmation;
		do {
			Console.Write(message);
			Console.WriteLine(" (Appuyez sur Entrée pour confirmer)");
			inputConfirmation = Utilisateur.saisirTexte();
		} while(inputConfirmation != "");
	}

    public bool askYesNo(string message) {
		string inputConfirmation;
		do {
			Console.Write(message);
			Console.WriteLine(" (O/n)");
			inputConfirmation = Utilisateur.saisirTexte().ToLower();
		} while(inputConfirmation != "" && inputConfirmation != "o" && inputConfirmation != "n");
        return inputConfirmation == "" || inputConfirmation == "o";
	}

    public int requestUserPick(string msg, int minimum, int maximum) {
        int selectedValue;
        do {
            println(msg);
            println($"Entrez une valeur comprise entre {minimum} et {maximum} : ");
            selectedValue = Utilisateur.saisirEntier();
        } while (selectedValue < minimum || selectedValue > maximum);

        return selectedValue;
    }
}