namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models
{
    public class Pokemons
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<ResultsPokemon> results { get; set; }
    }

    public class ResultsPokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
