class Weapon
{
    private string name;
    private int power;
    private int accuracy;

    public Weapon(string name, int power, int accuracy) {
        this.name = name;
        this.power = power;
        this.accuracy = accuracy;
    }

    public int getPower() {
        return power;
    }

    public double getAccuracy() {
        return accuracy;
    }

    public override string ToString() {
        return $"{this.name} - Puissance: {this.power} | Précision: {this.accuracy}%";
    }
}