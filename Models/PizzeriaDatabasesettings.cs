namespace TizzarthApi.Models
{
    public class PizzeriaDatabaseSettings : IPizzeriaDatabaseSettings
    {
        public string PizzeriasCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPizzeriaDatabaseSettings
    {
        public string PizzeriasCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
