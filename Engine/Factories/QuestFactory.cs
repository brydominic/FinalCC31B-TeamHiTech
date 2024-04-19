using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static List<Quest> s_Quests = new List<Quest>();

        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(2501, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            List<ItemQuantity> itemsToComplete2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems2 = new List<ItemQuantity>();
            itemsToComplete2.Add(new ItemQuantity(2502, 1));
            rewardItems2.Add(new ItemQuantity(1003, 1));

            List<ItemQuantity> itemsToComplete3 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems3 = new List<ItemQuantity>();
            itemsToComplete3.Add(new ItemQuantity(2503, 1));
            rewardItems3.Add(new ItemQuantity(1005, 1));

            List<ItemQuantity> itemsToComplete4 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems4 = new List<ItemQuantity>();
            itemsToComplete4.Add(new ItemQuantity(2504, 1));
            rewardItems4.Add(new ItemQuantity(1004, 1));

            List<ItemQuantity> itemsToComplete5 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems5 = new List<ItemQuantity>();
            itemsToComplete5.Add(new ItemQuantity(2505, 1));
            rewardItems5.Add(new ItemQuantity(1006, 1));

            List<ItemQuantity> itemsToComplete6 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems6 = new List<ItemQuantity>();
            itemsToComplete6.Add(new ItemQuantity(2506, 1));
            rewardItems6.Add(new ItemQuantity(1007, 1));

            s_Quests.Add(new Quest(1,
                                  "AI Colonization",
                                  "Collect 5 AI Chips",
                                  itemsToComplete,
                                  25, 50,
                                  rewardItems));

            s_Quests.Add(new Quest(2,
                                  "Iron and Shocks",
                                  "Collect AI Golem's Core",
                                  itemsToComplete2,
                                  50, 100,
                                  rewardItems2));

            s_Quests.Add(new Quest(3,
                                  "The Starship",
                                  "Retrieve a Blueprint from the Starship",
                                  itemsToComplete3,
                                  100, 200,
                                  rewardItems3));

            s_Quests.Add(new Quest(4,
                                  "Quantum's Pet",
                                  "Slay the Dragon",
                                  itemsToComplete4,
                                  100, 200,
                                  rewardItems4));

            s_Quests.Add(new Quest(5,
                                  "Assassin's Creed",
                                  "Gather 3 Phantom Chips",
                                  itemsToComplete5,
                                  100, 200,
                                  rewardItems5));

            s_Quests.Add(new Quest(6,
                                  "Evil must be destroyed",
                                  "Kill the boss Quantum",
                                  itemsToComplete6,
                                  100, 200,
                                  rewardItems6));

        }
        internal static Quest GetQuestByID(int id)
        {
            return s_Quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
