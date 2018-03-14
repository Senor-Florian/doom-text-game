using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doom {

    class Doomguy : Entity {

        static Random r = new Random();
        private static int baseDamage = 50;
        private int damage;
        private int ammo = 1000;

        public Doomguy(String name, int health) : base(name, health) {
          
        }
       
        public void Attack(Weapon w) {
            switch (w) {
                case Weapon.Shotgun:
                    if (r.Next(1, 101) > 30) { //70% chance to hit
                        Damage =  4 * baseDamage + r.Next(0, 51); //Damage: 200-250
                    }
                    else {
                        Damage = 0;
                    }
                    if (ammo >= 60) {
                        Ammo -= 60;
                    }                    
                    break;
                case Weapon.Chaingun:
                    if (r.Next(1, 101) > 10) { //90% chance to hit
                        Damage = 2 * baseDamage + r.Next(-10, 11); //Damage: 90-110
                    }
                    else {
                        Damage = 0;
                    }
                    if (ammo >= 50) {
                        Ammo -= 50;
                    }                          
                    break;
                case Weapon.RocketLauncher:
                    if (r.Next(1, 101) > 50) { //50% chance to hit
                        Damage = 10 * baseDamage + r.Next(-50, 51); //Damage: 450-550
                    }
                    else {
                        Damage = 0;
                    }
                    if (ammo >= 150) {
                        Ammo -= 150;
                    }
                    break;
                case Weapon.PlasmaGun:
                    if (r.Next(1, 101) > 15) { //85% chance to hit
                        Damage = 3 * baseDamage + r.Next(0, 51); // Damage: 150-200
                    }
                    else {
                        Damage = 0;
                    }
                    if (ammo >= 70) {
                        Ammo -= 70;
                    }
                    break;
                case Weapon.BFG9000:
                    Damage = 20 * baseDamage; //You can't miss with the BFG9000! Damage: 1000
                    if (ammo >= 500) {
                        Ammo -= 500;
                    }
                    break;
            }
           
        }

        public int Damage {
            get {
                return damage;
            }
            set {
                damage = value;
            }
        }

        public int Ammo {
            get {
                return ammo;
            }
            set {
                ammo = value;
            }
        }

        public override String ToString() {
            return base.ToString() + ", damage: " + damage + ", ammo: " + ammo;
        }
    }
}
