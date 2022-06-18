using System;
using System.Collections;
using Try101LinqSamples;

public class Program
{
    public static void Main(string[] agrs)
    {

        #region QueryExecution
        QueryExecution queryExecution = new QueryExecution();

        queryExecution.DeferredExecution();
        Console.WriteLine("--------------------------------------");
        queryExecution.EagerExecution();
        Console.WriteLine("--------------------------------------");
        queryExecution.ReuseQueryDefinition();

        #endregion
    }
}
