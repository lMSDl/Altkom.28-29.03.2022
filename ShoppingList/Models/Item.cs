using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class Item
    {

        /*
//pole
private string name;
//metody dostępowe do pola (getter i setter)
public void SetName(string value)
{
name = value;
//if(name == null)
//    name = value.ToUpper();
}
public string GetName()
{
return name;
}
*/
        

        private int quantity; // back-field dla property
        //Właściwość - property

        //auto-property
        public string Name { get; set; }

        //full-property
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if(value > 0)
                    quantity = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} : {Quantity}";
        }
    }
}
