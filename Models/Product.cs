﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        // [key] -> Anotación si la propiedad no se llama Id, ejemplo ProductId
        
    public int Id { get; set; } // Será la llave priamaría
       
    public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; } // Será la llave foránea  
        public Category Category { get; set; } // Propiedad de navegación
    }
}

    

