using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCartelTools.SavingOptionsInFile
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Price
    {
        public Price() { }
        public Price(decimal buy,decimal sell) { Sell = sell;Buy = buy; }

        [JsonProperty("Cena sprzedaż")]
        public decimal Sell { get; set; }
        [JsonProperty("Cena kupno")]
        public decimal Buy { get; set; }
    }
}
