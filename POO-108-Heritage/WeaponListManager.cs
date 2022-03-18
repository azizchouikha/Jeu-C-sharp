class WeaponListManager {
    private Weapon[] weaponsList = new Weapon[4];
    private int nextWeaponIndex = 0;

    public WeaponListManager() {
        weaponsList[0] = new Weapon("Bazooka", 5, 75);
        weaponsList[1] = new Weapon("Missile Tête Chercheuse", 3, 85);
        weaponsList[2] = new Weapon("Bombe banane", 20, 50);
        weaponsList[3] = new Weapon("Mouton", 50, 20);
    }
    public Weapon getNextWeaponToLoot() {
        Weapon nextWeapon = null;
        if (nextWeaponIndex < weaponsList.Length) {
            nextWeapon = weaponsList[nextWeaponIndex];
            this.nextWeaponIndex++;
        }
        
        return nextWeapon;
    }

    
}