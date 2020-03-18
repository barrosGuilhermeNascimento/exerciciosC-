using System;

namespace exercicio.Entities{
    class ImportedProduct : Product{
        public double CustomFee { get; set; }

        public ImportedProduct(){

        }

        public ImportedProduct(string name, double price, double cf): base(name, price){
            CustomFee = cf;

        }

        public override string PriceTag(){
            return $"$ {Price}";
        }
        public override  string ToString() {
            return Name
                 + " "
                 + PriceTag()
                 + " "
                 + "(Customs fee: $ "
                 + CustomFee
                 + ")";
        }
    }
}