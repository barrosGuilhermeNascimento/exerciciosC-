using System;

namespace exercicio.Entities
{
        class Product{

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){

        }

        public Product(string name, double price){
            Name = name;
            Price = Price;
        }

        public virtual string PriceTag(){
            return $"R$ {Price}";
        }

        public override string ToString(){
            return Name
                 + " "
                 + PriceTag();
        }
    }
}