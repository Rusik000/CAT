using System;
using System.Threading;
using System.Text;

namespace Cat_House
{
    public partial  class Cat
    {
        public string NickName { get; set; } = String.Empty;
        private int _age;
        private int _price;
        private string _gender;
        private int _mealQuantity;
        public int Energy { get; private set; } = 100;
        private int _mealQuantityOfCatToday = default;
        public Cat(in string nickName, in int age, in int mealQuantity, in int price, in string gender)
        {
            NickName = nickName;
            Age = age;
            MealQuantity = mealQuantity;
            Price = price;
            Gender = gender;
            _mealQuantityOfCatToday = (MealQuantity * 10) / 100;
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidOperationException("Age must be more than -1.");
                _age = value;
            }
        }

        public int MealQuantity
        {
            get
            {
                return _mealQuantity;
            }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Meal Quantity must be more than 0.");
                _mealQuantity = value;
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Price must be more than 0.");
                _price = value;
            }
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (value.Trim().ToLower() != "male" && value.Trim().ToLower() != "female")
                    throw new InvalidOperationException("Gender must be \"Male\" or \"Female\"");
                _gender = value;
            }
        }

        
    }
}