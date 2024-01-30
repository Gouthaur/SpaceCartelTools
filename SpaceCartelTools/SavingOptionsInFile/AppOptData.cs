using Newtonsoft.Json;
using SpaceCartelTools.Buldings;
using SpaceCartelTools.SavingOptionsInFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikaczBot.SavingOptionsInFile;

[JsonObject(MemberSerialization.OptIn)]
public class AppOptData
{

    [JsonProperty("Ceny iron ore")]
    public Price PriceIronOre { get; set; }

    [JsonProperty("Ceny copper ore")]
    public Price PriceCopperOre { get; set; }

    [JsonProperty("Ceny uran ore ")]
    public Price PriceUranOre { get; set; }

    [JsonProperty("Ceny steel")]
    public Price PriceSteel { get; set; }

    [JsonProperty("Ceny copper")]
    public Price PriceCopper { get; set; }

    [JsonProperty("Ceny uran")]
    public Price PriceUran { get; set; }

    [JsonProperty("Ceny czerwone nasiono")]
    public Price PriceRedSeed { get; set; }

    [JsonProperty("Ceny niebieskie nasiono")]
    public Price PriceBlueSeed { get; set; }

    [JsonProperty("Ceny pomaranczowe nasiono")]
    public Price PriceOrangeSeed { get; set; }

    [JsonProperty("Ceny czerwony kwiatek")]
    public Price PriceRedFlower { get; set; }

    [JsonProperty("Ceny niebieskie kwiatki")]
    public Price PriceBlueFlower { get; set; }
    [JsonProperty("Ceny pomaranczowy kwiatek")]
    public Price PriceOrangeFlower { get; set; }
    [JsonProperty("Ceny czerwony statek")]
    public Price PriceRedShip { get; set; }
    [JsonProperty("Ceny niebieskiego statku")]
    public Price PriceBlueShip { get; set; }
    [JsonProperty("Cena pomaranczowego statku")]
    public Price PriceOrangeShip { get; set; }

    [JsonProperty("Obiekt mine")]
    public Bulding MineBulding { get; set; }

    [JsonProperty("Obiekt steelworks")]
    public Bulding SteelworksBulding { get; set; }

    [JsonProperty("Obiekt shipyard")]
    public Bulding ShipyardBulding { get; set; }

}



