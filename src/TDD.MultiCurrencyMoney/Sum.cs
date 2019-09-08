﻿using System;

namespace TDD.MultiCurrencyMoney
{
	public class Sum : Expression
	{
		public Sum(Expression augend, Expression addend)
		{
			Augend = augend;
			Addend = addend;
		}

        public Expression Augend { get; }
		public Expression Addend { get; }

		public Money Reduce(Bank bank, string targetCurrency)
        {
            var reducedAugend = Augend.Reduce(bank, targetCurrency);
            var reducedAddend = Addend.Reduce(bank, targetCurrency);
            var totalAmount = reducedAugend.Amount +  reducedAddend.Amount;
            return new Money(totalAmount, targetCurrency);
		}

        public Expression Plus(Expression other)
        {
            throw new NotImplementedException();
        }
	}
}