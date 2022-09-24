using GuildedRoseContract;

namespace GuildedRoseItemImplementations;

public class BackstagePass : StoreItemBase
{
    public override void UpdateStrategy()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    private void UpdateQuality()
    {
        Quality = Quality + 1;
        if (SellIn < 11) Quality = Quality + 1;
        if (SellIn < 6) Quality = Quality + 1;
        if (Quality > MaxQuality) Quality = MaxQuality;
    }

    private void UpdateSellIn()
    {
        SellIn = SellIn - 1;
        if (SellIn < 0) Quality = 0;
    }
}