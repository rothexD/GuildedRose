namespace GuildedRoseContract;

public interface IGildedRoseItemUpdater
{
    public void UpdateItems(IEnumerable<StoreItemBase> items);
}