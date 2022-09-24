namespace GuildedRoseContract;

public abstract class StoreItemBase : Item
{
    protected const int MaxQuality = 50;
    protected const int MinQuality = 0;
    private const int ConjuredMultiplyFactor = 2;
    private const int NonConjuredMultiplyFactor = 1;

    public bool IsConjured { get; set; } = false;

    protected int GetConjuredMultiplier()
    {
        return IsConjured ? ConjuredMultiplyFactor : NonConjuredMultiplyFactor;
    }

    public abstract void UpdateStrategy();
}