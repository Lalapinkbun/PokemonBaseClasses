namespace LalaPokemon
{
    internal class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Id { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }

        public Item(string name, int quantity, string id, string context, string type)
        {
            Name = name;
            Quantity = quantity;
            Id = id;
            Content = context;
            Type = type;
        }
    }
}
