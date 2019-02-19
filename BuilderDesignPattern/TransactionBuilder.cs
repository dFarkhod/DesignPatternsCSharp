using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BuilderDesignPattern
{
    public class TransactionBuilder : ITransactionBuilder
    {
        private Transaction Transaction = null;

        public TransactionBuilder()
        {
            Transaction = new Transaction();     
        }

        
        public void BuildDTOClass()
        {
            // 
            string dtoFile = @"C:\TransactionFiles\saDeposit.dto";
            Transaction.DTOFiles.Add(dtoFile);
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} is called");
        }

        public void BuildProcessClass()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} is called");
        }

        public void BuildUI()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} is called");
        }

        public Transaction GetTransaction()
        {
            return Transaction;
        }

        public void Initialize()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} is called");
        }

        public void LoadFiles()
        {
            // go to C:\TransactionsFiles and load all the files
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} is called");
        }
    }
}
