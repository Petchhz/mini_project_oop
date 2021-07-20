using System;
using System.ComponentModel.DataAnnotations;

namespace Game_Center.Models
{
    public class Game
    {
        public int id { get; set; }
        public string name { get; set; }       
        public string description { get; set; }
        public decimal price { get; set; }
        public string player { get; set; }
    }
}