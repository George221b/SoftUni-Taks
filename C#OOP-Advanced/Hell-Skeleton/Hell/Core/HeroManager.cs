using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class HeroManager : IManager
{
    private Dictionary<string, IHero> heroes;

    public HeroManager()
    {
        this.heroes = new Dictionary<string, IHero>();
    }

    public string AddHero(string heroName, string heroType)
    {
        string result = null;

        try
        {
            Type currentHeroType = Type.GetType(heroType);

            var constructors = currentHeroType.GetConstructors().First();

            IHero hero = (IHero)constructors.Invoke(new object[] { heroName });


            result = string.Format($"Created {heroType} - {heroName}");

            this.heroes.Add(heroName, hero);
        }
        catch (Exception e)
        {
            return e.Message;
        }

        return result;
    }

    public string AddItemToHero(string name, string heroName,
        int strengthBonus, int agilityBonus, int intelligenceBonus,
        int hitpointsBonus, int damageBonus)
    {
        string result = null;


        IItem newItem = new CommonItem(name, strengthBonus, agilityBonus,
            intelligenceBonus, hitpointsBonus, damageBonus);

        this.heroes[heroName].Inventory.AddCommonItem(newItem);

        result = string.Format(Constants.ItemCreateMessage, newItem.Name, heroName);

        return result;
    }

    public string AddRecipeToHero(string name, string heroName,
        int strengthBonus, int agilityBonus, int intelligenceBonus,
        int hitpointsBonus, int damageBonus, List<string> requiredItems)
    {
        string result = null;


        IRecipe newItem = new RecipeItem(name, strengthBonus, agilityBonus,
            intelligenceBonus, hitpointsBonus, damageBonus, requiredItems);

        this.heroes[heroName].Inventory.AddRecipeItem(newItem);

        result = string.Format(Constants.RecipeCreateMessage, newItem.Name, heroName);

        return result;
    }

    public string PrintAllHeroes()
    {
        StringBuilder sb = new StringBuilder();
        int numberOfHero = 1;

        foreach (IHero currentHero in this.heroes.Values.OrderByDescending(x => x.PrimaryStats).ThenByDescending(x => x.SecondaryStats))
        {
            AbstractHero hero = (AbstractHero) currentHero;

            sb.AppendLine($"{numberOfHero}. {hero.GetType().Name}: {hero.Name}");
            sb.AppendLine($"###HitPoints: {hero.HitPoints}");
            sb.AppendLine($"###Damage: {hero.Damage}");
            sb.AppendLine($"###Strength: {hero.Strength}");
            sb.AppendLine($"###Agility: {hero.Agility}");
            sb.AppendLine($"###Intelligence: {hero.Intelligence}");
            if (hero.Items.Count == 0)
            {
                sb.Append($"###Items: None");
            }
            else
            {
                sb.Append($"###Items: {string.Join(", ", hero.Items.Select(x => $"{x.Name}"))}");
            }
            sb.AppendLine();

            numberOfHero++;
        }

        return sb.ToString().TrimEnd();
    }

    public string Inspect(string name)
    {
        return this.heroes[name].ToString();
    }
}