using Inheritence;

//BankAccount bankAcoount1 = new BankAccount();


SavingAccount savingAccount1 = new SavingAccount();
savingAccount1.AccountNo = "S-1";
savingAccount1.CustomerName = "Kabir";
savingAccount1.Deposit(5000);
savingAccount1.WithDraw(1000);
decimal balance = savingAccount1.Balance; 

CheckingAccount checkingAccount1 = new CheckingAccount();
checkingAccount1.AccountNo = "C-1";
checkingAccount1.CustomerName = "Rayhan";
checkingAccount1.Deposit(100000);
checkingAccount1.WithDraw(200000);

balance = checkingAccount1.Balance;

Console.WriteLine(balance);
