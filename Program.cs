using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doom
{
    enum Weapon { Shotgun, Chaingun, RocketLauncher, PlasmaGun, BFG9000 };
    enum Monsters { Imp, Demon, Cacodemon, BaronOfHell, Cyberdemon};
    enum States { Alive, Dead };

    class Program
    {
        static Doomguy d = new Doomguy("Doomguy", 200);
        static String currentState;

        static void Main(string[] args)
        {
            Console.WriteLine(d);
            Round(Monsters.Imp);
            if (currentState == "Alive") {
                Round(Monsters.Demon);
            }
            if (currentState == "Alive") {
                Round(Monsters.Cacodemon);
            }
            if (currentState == "Alive") {
                Round(Monsters.BaronOfHell);
            }
            if (currentState == "Alive") {
                Round(Monsters.Cyberdemon);
            }
            if (currentState == "Alive") {
                Console.WriteLine("You won the game");
            }
            if (currentState == "Dead") {
                Console.WriteLine("You died!");
            }
                
            Console.ReadLine();
        }

        public static Weapon DoomguyAttack() {
            Console.WriteLine("Select a weapon to attack with: 1 - Shotgun, 2 - Chaingun," +
                " 3 - Rocket Launcher, 4 - Plasmagun, 5 - BFG9000");
            String input = Console.ReadLine();
            int weaponID;
            Int32.TryParse(input, out weaponID);
            switch(weaponID) {
                case 1:
                    return Weapon.Shotgun;
                case 2:
                    return Weapon.Chaingun;
                case 3:
                    return Weapon.RocketLauncher;
                case 4:
                    return Weapon.PlasmaGun;
                case 5:
                    return Weapon.BFG9000;
                default:
                    return Weapon.Shotgun;
            }
        }

        public static void Round (Monsters monster) {
            Monster m = new Monster(monster);
            Console.WriteLine(m);
            while (d.Health > 0 && m.Health > 0) {
                d.Attack(DoomguyAttack());
                m.GetAttacked(d.Damage);
                Console.WriteLine(d);
                Console.WriteLine(m);
                m.Attack();
                d.GetAttacked(m.Damage);
                Console.WriteLine(d);
                Console.WriteLine(m);
            }
            if(d.Health <= 0) {
                currentState = States.Dead.ToString();
            }
            if(m.Health <= 0) {
                currentState = States.Alive.ToString();
                Console.WriteLine("You killed a(n) " + m.Name + "!");
            }
        }
    }
}
