using System;

namespace ProductInventory.Shared
{
    public class ProductType
    {

        string description;
        string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}
