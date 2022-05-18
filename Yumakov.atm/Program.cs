﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yumakov.atm
{
   abstract class Score
   {
    protected int score;
    protected abstract void showScore(); // Посмотреть баланс
      protected abstract int takeОff(); // Снять деньги
      protected abstract int topUp(); // Пополнить баланс
      protected abstract int transferMoney();// Перевести деньги
      // добавить срок действия счёта / карты
   }
    class CreditScore : Score
    {
        protected override string showScore()
        {
            throw new NotImplementedException();
        }

        protected override int takeОff()
        {
            throw new NotImplementedException();
        }

        protected override int topUp()
        {
            throw new NotImplementedException();
        }

        protected override int transferMmoney()
        {
            throw new NotImplementedException();
        }
    }
    class Program
   {
      static void Main(string[] args)
      {
            Console.WriteLine("Abdula");
            Console.ReadKey();
      }
   }
}
