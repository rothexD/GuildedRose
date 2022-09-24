using GuildedRoseContract;

namespace GuildedRoseItemImplementations;

public class AgedBrie : StoreItemBase
{
    public override void UpdateStrategy()
    {
        UpdateQuality();
        UpdateSellIn();
    }

    private void UpdateQuality()
    {
        if (Quality < MaxQuality)
            Quality = Quality + 1;
    }

    private void UpdateSellIn()
    {
        SellIn = SellIn - 1;
        if (SellIn < 0)
            if (Quality < MaxQuality)
                Quality = Quality + 1;
    }
}