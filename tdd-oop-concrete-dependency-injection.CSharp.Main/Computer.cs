﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_concrete_dependency_injection.CSharp.Main
{
    public class Computer 
    {
        public List<Game> installedGames = new List<Game>();
        
        public PowerSupply powerSupply;

        public Computer(PowerSupply powerSupply) {
            this.powerSupply = powerSupply;

            installedGames.Add(new Game("Dwarf Fortress"));
            installedGames.Add(new Game("Baldur's Gate"));
        }
        /*
        public Computer(PowerSupply powerSupply, List<Game> PreInstalledGames) // added a secondary constructor to take in a list of pre-installed games
        {
            this.powerSupply = powerSupply;
            this.installedGames = PreInstalledGames;
        }
        */


        public void turnOn() {
            
            powerSupply.turnOn();
            
        }

        public void installGame(string name) {
            Game game = new Game(name);
            this.installedGames.Add(game);
        }

        public String playGame(string name) {
            foreach (Game g in this.installedGames) {
                if (g.name.Equals(name)) {
                    return g.start();
                }
            }

            return "Game not installed";
        }
    }
}
