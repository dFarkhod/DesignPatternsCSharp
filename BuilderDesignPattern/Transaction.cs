using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class Transaction
    {
        public List<string> DTOFiles = null;
        public List<string> ProcessFiles = null;
        public List<string> UIFiles = null;

        public Transaction()
        {
            DTOFiles = new List<string>();
            ProcessFiles = new List<string>();
            UIFiles = new List<string>();
        }
    }
}
