using GuildedRoseContract;

namespace GuildedRoseItemImplementations;

public class GenericStoreItem : StoreItemBase
{
    public override void UpdateStrategy()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    private void UpdateQuality()
    {
        Quality = Quality - 1 * GetConjuredMultiplier();
        if (Quality < MinQuality) Quality = MinQuality;
    }

    private void UpdateSellIn()
    {
        SellIn = SellIn - 1;
        BasicQualityReductionAfterSellInIsZero();
    }

    private void BasicQualityReductionAfterSellInIsZero()
    {
        if (SellIn >= 0) return;
        if (Quality <= MinQuality) return;
        UpdateQuality();
    }
}