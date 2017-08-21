using System;
using System.Collections.Generic;

public interface IManager
{
    string AddHero(string heroName, string heroType);

    string AddItemToHero(string name, string heroName,
        int strengthBonus, int agilityBonus, int intelligenceBonus,
        int hitpointsBonus, int damageBonus);

    string AddRecipeToHero(string name, string heroName,
        int strengthBonus, int agilityBonus, int intelligenceBonus,
        int hitpointsBonus, int damageBonus, List<string> requiredItems);

    string PrintAllHeroes();

    string Inspect(string name);
}