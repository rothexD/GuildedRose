using System;
using System.Collections.Generic;
using GildedRose;
using GuildedRoseContract;
using GuildedRoseItemImplementations;

namespace GildedRoseTests;

public static class TexttestFixture
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IReadOnlyList<StoreItemBase> items = new List<StoreItemBase>
        {
            new GenericStoreItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            new AgedBrie {Name = "Aged Brie", SellIn = 2, Quality = 0},
            new GenericStoreItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            new Sulfuras {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            new Sulfuras {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            new BackstagePass
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            },
            new BackstagePass
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            },
            new BackstagePass
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            },
            // this conjured item does not work properly yet
            new GenericStoreItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 12, IsConjured = true}
        };

        IGildedRoseItemUpdater app = new GildedRoseItemUpdater();

        var days = 6;
        if (args.Length > 0) days = int.Parse(args[0]) + 1;

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            foreach (var t in items)
                Console.WriteLine(t.Name + ", " + t.SellIn + ", " + t.Quality);

            Console.WriteLine("");
            app.UpdateItems(items);
        }
    }
}