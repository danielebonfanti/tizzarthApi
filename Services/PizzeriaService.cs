using MongoDB.Driver;
using TizzarthApi.Models;
using System.Collections.Generic;
using System.Linq;


namespace TizzarthApi.Services
{
    public class PizzeriaService
    {
        private readonly IMongoCollection<Pizzeria> _Pizzerias;
        public PizzeriaService(IPizzeriaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _Pizzerias = database.GetCollection<Pizzeria>(settings.PizzeriasCollectionName);

        }

        public List<Pizzeria> Get()
        {
            List<Pizzeria> Pizzerias;
            Pizzerias = _Pizzerias.Find(emp => true).ToList();
            return Pizzerias;
        }

        public Pizzeria Get(string id) =>
            _Pizzerias.Find<Pizzeria>(emp => emp.Id == id).FirstOrDefault();

    }
}
