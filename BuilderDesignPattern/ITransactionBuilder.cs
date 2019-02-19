using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public interface ITransactionBuilder
    {
        void Initialize();
        void LoadFiles();
        void BuildProcessClass();
        void BuildDTOClass();
        void BuildUI();

        Transaction GetTransaction();
    }
}
