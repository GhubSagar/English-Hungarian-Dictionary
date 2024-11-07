namespace DictionaryAPI.Models
{
    public class DictionaryEntry
    {
        public int Id { get; set; }
        public string? English_Word { get; set; }  // Renamed for PascalCase
        public string? Hungarian_Translation { get; set; }  // Renamed for PascalCase
    }
}
