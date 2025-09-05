using Iterator;

ExpenseAccount expenseAccount = new();
SalesAccount salesAccount = new();

Accountant accountant = new(expenseAccount, salesAccount);
accountant.PrintTransactions();