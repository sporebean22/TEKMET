﻿using MagicTheGathering.Models;
using System;
using System.Collections.Generic;

namespace MagicTheGathering
{
    public class Monster : Card
    {
        public int Attack { get; set; }
        public int Toughness { get; set; }
        public MonsterType MonsterType { get; set; }
        public static Effect Effect { get; set; }

        public Monster (Dictionary<TerrainColour, int>  manaCost, string cardName, MonsterType monsterType, TerrainColour terrainColour, int attack, int toughness) : base(manaCost, cardName, terrainColour)
        {
            ManaCost = manaCost;
            CardName = cardName;
            MonsterType = monsterType;
            Attack = attack;
            Toughness = toughness;
        }

        public Monster(Effect effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour, int attack, int toughness) : base(manaCost, cardName, terrainColour)
        {
            ManaCost = manaCost;
            CardName = cardName;
            Attack = attack;
            Toughness = toughness;
            Effect = effect;
        }
    }
}