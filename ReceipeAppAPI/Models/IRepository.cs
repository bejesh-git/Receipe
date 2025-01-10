namespace ReceipeAppAPI.Models
{
    public interface IRepository
    {
        public IEnumerable<Receipe> Receipe(string key);
    }
}
