using System.Collections.Generic;

namespace TheRickAndMorthy.Models
{
    public class Response<T> where T : class
    {
        public Information info { get; set; }
        public IEnumerable<T> results { get; set; }
    }
}
