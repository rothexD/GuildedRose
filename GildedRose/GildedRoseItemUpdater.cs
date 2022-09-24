using System.Collections.Generic;
using GuildedRoseContract;

namespace GildedRose;

public class GildedRoseItemUpdater : IGildedRoseItemUpdater
{
    public void UpdateItems(IEnumerable<StoreItemBase> items)
    {
        foreach (var t in items)
            t.UpdateStrategy();
    }
}