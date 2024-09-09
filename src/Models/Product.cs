using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.Models
{
    public class Product
    {
        // Atributos
        public int Id { get; set; } // 1 
        public string Name { get; set; } = string.Empty; // arroz
        public int Price { get; set; } // 1500

        // Entityframework relationships
        public List<User> Users { get;} = []; // juan, pedro, maria, jose...
    }
}