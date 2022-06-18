using System;
using System.Collections;
using Try101LinqSamples;

public class Program
{
    public static void Main(string[] agrs)
    {

        #region QueryExecution

        //QueryExecution queryExecution = new QueryExecution();
        //queryExecution.DeferredExecution();
        //Console.WriteLine("--------------------------------------");
        //queryExecution.EagerExecution();
        //Console.WriteLine("--------------------------------------");
        //queryExecution.ReuseQueryDefinition();

        #endregion


        #region Projections

        Projections projections = new Projections();
        projections.SelectSyntax();
        Console.WriteLine("--------------------------------------");
        //projections.SelectProperty();
        Console.WriteLine("--------------------------------------");
        projections.TransformWithSelect();
        Console.WriteLine("--------------------------------------");
        projections.SelectByCaseAnonymous();
        Console.WriteLine("--------------------------------------");
        projections.SelectByCaseTuple();
        Console.WriteLine("--------------------------------------");
        projections.SelectAnonymousConstructions();
        Console.WriteLine("---------------------------------------");
        projections.SelectWithIndex();
        Console.WriteLine("---------------------------------------");
        //projections.IndexedSelectMany();
        Console.WriteLine("--------------------------------------");

        //// Here , there have more funactionality , see Projections class .

        #endregion



    }
}
