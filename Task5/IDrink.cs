using System;
namespace Task5
{
    public interface IDrink<T> where T : Product
    {
        void Add(T product);
        void Sell(string name, int count);
        void Display();
        void ShowIncome();
    }
}

