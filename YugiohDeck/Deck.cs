using System.ComponentModel.DataAnnotations;

namespace YugiohDeck
{
    public class Deck
    {
        public int id { get; set; }

        [StringLength(50)]
        public string deckName { get; set; }
    }
}
