using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doom {

    class Monster : Entity {

        static Random r = new Random();
        private int damage;

        public Monster (Monsters m) {
            MonsterTypes(m);
        }

        void MonsterTypes(Monsters m) {
            switch(m) {
                case Monsters.Imp:
                    Name = "Imp";
                    Health = 100;
                    break;
                case Monsters.Demon:
                    Name = "Demon";
                    Health = 200;
                    break;
                case Monsters.Cacodemon:
                    Name = "Cacodemon";
                    Health = 300;
                    break;
                case Monsters.BaronOfHell:
                    Name = "BaronOfHell";
                    Health = 400;
                    break;
                case Monsters.Cyberdemon:
                    Name = "Cyberdemon";
                    Health = 500;
                    break;
            }
        }

        public void Attack() {
            switch(Name) {
                case ("Imp"):
                    if (r.Next(1, 101) > 30) { //70% chance to hit
                        Damage = 10 + r.Next(-2, 3); //Damage: 8-12
                    }
                    else {
                        Damage = 0;
                    }
                    break;
                case ("Demon"):
                    if (r.Next(1, 101) > 60) { //40% chance to hit
                        Damage = 20 + r.Next(-4, 5); //Damage: 16-24
                    }
                    else {
                        Damage = 0;
                    }
                    break;
                case ("Cacodemon"):
                    if (r.Next(1, 101) > 50) { //50% chance to hit
                        Damage = 30 + r.Next(-6, 7); //Damage: 24-36
                    }
                    else {
                        Damage = 0;
                    }
                    break;
                case ("BaronOfHell"):
                    if (r.Next(1, 101) > 60) { //40% chance to hit
                        Damage = 40 + r.Next(-8, 9); //Damage: 32-48
                    }
                    else {
                        Damage = 0;
                    }
                    break;
                case ("Cyberdemon"):
                    if (r.Next(1, 101) > 60) { //40% chance to hit
                        Damage = 50 + r.Next(-10, 11); //Damage: 40-60
                    }
                    else {
                        Damage = 0;
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

        public override string ToString() {
            return base.ToString() + ", damage: " + damage;
        }
    }
}
