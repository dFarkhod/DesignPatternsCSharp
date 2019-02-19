using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class TransactionBuildManager
    {
        ITransactionBuilder Builder = null;

        public TransactionBuildManager(ITransactionBuilder builder)
        {
            Builder = builder;
        }

        public void Build()
        {
            Builder.Initialize();
            Builder.LoadFiles();
            Builder.BuildDTOClass();
            Builder.BuildProcessClass();
            Builder.BuildUI();
        }
    }
}
