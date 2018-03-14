using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doom {
    class Entity {

        private String name;
        private int health;

        public Entity(String name, int health) {
            this.name = name;
            this.health = health;
        }

        public Entity() {

        }

        public void GetAttacked(int takenDamage) {
            Health -= takenDamage;
        }

        public String Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public int Health {
            get {
                return health;
            }
            set {
                health = value;
            }
        }

        public override String ToString() {
            return "Name: " + name + ", health: " + health;
        }
    }
}
