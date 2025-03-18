using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Gamer
    {
        public int GamerId { get; set; }
        public string Name { get; set; }
        public string FavoriteGame { get; set; }
        public string Hours { get; set; }
        public string Platform { get; set; }

        public override string? ToString()
        {
            return $"{GamerId} - {Name} - {FavoriteGame} - {Platform} - {Hours} ";
        }
    }
}
