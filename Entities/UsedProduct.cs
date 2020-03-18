using System;

namespace exercicio.Entities {
    class UsedProducts : Product{
        public DateTime ManufactureDate { get; set; }

        public UsedProducts(){

        }

        public UsedProducts(string name, double price, DateTime manfac) : base(name, price){
            ManufactureDate = manfac;
        }
        public override string PriceTag(){
            return $"$ {Price}";
        }

        public override string ToString(){
            return Name
                 + " "
                 + PriceTag()
                 + " (Manufacture date: "
                 + ManufactureDate
                 + ")";
        }
    }
}