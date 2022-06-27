namespace YugiohDeck
{
    public class Card
    {
        public int id { get; set; }

        public string cardName { get; set; }

        public string cardImage { get; set; }

        public string cardType { get; set; }

        public int cardCount { get; set; }

        public int deckListId { get; set; }
        public Deck? Deck { get; set; }
    }
}
