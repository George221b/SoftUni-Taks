public class Barbarian : AbstractHero
{
    public Barbarian(string name)
        :  base(name, HeroConstants.BarbarianStrength,
            HeroConstants.BarbarianAgility,
            HeroConstants.BarbarianIntelligence,
            HeroConstants.BarbarianHitPoints,
            HeroConstants.BarbarianDamage)
    {
    }
}
