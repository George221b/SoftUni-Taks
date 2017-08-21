public class Assassin : AbstractHero
{
    public Assassin(string name)
        : base(name, HeroConstants.AssassinStrength,
            HeroConstants.AssassinAgility,
            HeroConstants.AssassinIntelligence,
            HeroConstants.AssassinHitPoints,
            HeroConstants.AssassinDamage)
    {
    }
}
