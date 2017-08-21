public class Wizard : AbstractHero
{
    public Wizard(string name)
        : base(name, HeroConstants.WizardStrength,
            HeroConstants.WizardAgility,
            HeroConstants.WizardIntelligence,
            HeroConstants.WizardHitPoints,
            HeroConstants.WizardDamage)
    {
    }
}
