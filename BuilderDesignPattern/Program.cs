using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransactionBuilder builder = new TransactionBuilder();
            TransactionBuildManager buildManager = new TransactionBuildManager(builder);
            buildManager.Build();
            Transaction myTran = builder.GetTransaction();

            Console.Read();
        }
    }
}
