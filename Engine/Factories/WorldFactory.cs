using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld() 
        {
            World newWorld = new World();

            newWorld.AddLocation(0,0, "Safehouse", "Mercenary Residence", "safehouse1.jpg", "safehouse2.jpg");

            newWorld.AddLocation(0, 1, "Nexus", "Heart of Quantum", "nexus1.png", "nexus2.png");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.LocationAt(0, 1).AddMonster(3, 100);

            newWorld.AddLocation(1, 1, "Cyber District", "Skyscapers", "district1.png", "district2.jpg");
            newWorld.LocationAt(1, 1).TraderHere = TraderFactory.GetTraderByName("Mysterious Trader");
            newWorld.LocationAt(1, 1).AddMonster(1, 100);

            newWorld.AddLocation(-1, 1, "Labyrinths", "Underground Tunnels", "laby1.png", "laby2.jpg");
            newWorld.LocationAt(-1, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));
            newWorld.LocationAt(-1, 1).AddMonster(2, 100);

            newWorld.AddLocation(0, 2, "Utopia Corp", "Center of the City", "utopia1.png", "utopia2.jpg");
            newWorld.LocationAt(0, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(6));
            newWorld.LocationAt(0, 2).AddMonster(7, 100);

            newWorld.AddLocation(1, 2, "Pulse Hub", "Trading Center", "hub1.png", "hub2.png");
            newWorld.LocationAt(1, 2).TraderHere = TraderFactory.GetTraderByName("Mysterious Trader");

            newWorld.AddLocation(-1, 2, "Sun Park", "Just a normal park", "park1.png", "park2.png");
            newWorld.LocationAt(-1, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(4));
            newWorld.LocationAt(-1, 2).AddMonster(5, 100);

            newWorld.AddLocation(-1, 0, "Nexopolis", "Quantum City", "city1.jpg", "city2.jpg");
            newWorld.LocationAt(-1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(5));
            newWorld.LocationAt(-1, 0).AddMonster(6, 100);

            newWorld.AddLocation(1, 0, "Highways", "Fast Lanes", "highway1.jpg", "highway2.jpg");
            newWorld.LocationAt(1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));
            newWorld.LocationAt(1, 0).AddMonster(4, 100);





            return newWorld;
        }
    }
}
