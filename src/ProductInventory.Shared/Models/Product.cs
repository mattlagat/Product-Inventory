using System;

namespace ProductInventory.Shared
{
    public class Product
    {
        string code;
        string description;
        string name;


        public string Code
        {
            get => code;
            set => code = value;
        }

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
