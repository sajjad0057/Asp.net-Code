using System;
using System.Collections;
using Try101LinqSamples;

public class Program
{
    public static void Main(string[] agrs)
    {

        #region QueryExecution

        Console.WriteLine($"Practice QueryExecution" +
            $"\n-----------------------------------------------------");

        //QueryExecution queryExecution = new QueryExecution();
        //queryExecution.DeferredExecution();
        //Console.WriteLine("--------------------------------------");
        //queryExecution.EagerExecution();
        //Console.WriteLine("--------------------------------------");
        //queryExecution.ReuseQueryDefinition();

        #endregion

        #region Projections

        //Console.WriteLine($"Practice Projections" +
        //    $"\n-----------------------------------------------------");

        //Projections projections = new Projections();
        //projections.SelectSyntax();
        //Console.WriteLine("--------------------------------------");
        ////projections.SelectProperty();
        //Console.WriteLine("--------------------------------------");
        //projections.TransformWithSelect();
        //Console.WriteLine("--------------------------------------");
        //projections.SelectByCaseAnonymous();
        //Console.WriteLine("--------------------------------------");
        //projections.SelectByCaseTuple();
        //Console.WriteLine("--------------------------------------");
        //projections.SelectAnonymousConstructions();
        //Console.WriteLine("---------------------------------------");
        //projections.SelectWithIndex();
        //Console.WriteLine("---------------------------------------");
        ////projections.IndexedSelectMany();
        //Console.WriteLine("--------------------------------------");

        //// Here , there have more funactionality , see Projections class .

        #endregion

        #region AggregateOperators

        //Console.WriteLine($"Practice AggregateOperators" +
        //    $"\n-----------------------------------------------------");

        //AggregateOperators aggregateOperators = new AggregateOperators();

        //Console.WriteLine(aggregateOperators.CountConditional());

        ////Console.WriteLine(aggregateOperators.NestedCount());

        //Console.WriteLine(aggregateOperators.GroupedCount());

        //Console.WriteLine(aggregateOperators.MinProjection());

        //Console.WriteLine(aggregateOperators.MinGrouped());

        //Console.WriteLine($"---------------------------------------");

        //Console.WriteLine(aggregateOperators.MinEachGroup());

        //Console.WriteLine(aggregateOperators.MaxGrouped());

        //Console.WriteLine($"----------------------------------------");

        //Console.WriteLine(aggregateOperators.AggregateSyntax());

        //Console.WriteLine(aggregateOperators.SeededAggregate());


        #endregion

        #region Conversions
        //Console.WriteLine($"Practice Conversions" +
        //    $"\n-----------------------------------------------------");

        //Conversions conversions = new Conversions();

        //Console.WriteLine(conversions.ConvertToList());
        //Console.WriteLine(conversions.ConvertToDictionary());

        //Console.WriteLine(conversions.ConvertSelectedItems());

        #endregion

        #region ElementOperations

        //Console.WriteLine($"Practice ElementOperations" +
        //    $"\n-----------------------------------------------------");

        //ElementOperations elementOperations = new ElementOperations();

        //Console.WriteLine(elementOperations.MaybeFirstElement());

        //Console.WriteLine(elementOperations.ElementAtPosition());

        #endregion

        #region Generators

        //Console.WriteLine($"Practice Generators" +
        //    $"\n-----------------------------------------------------");

        //Generators generators = new Generators();

        //Console.WriteLine(generators.RangeOfIntegers());

        //Console.WriteLine(generators.RepeatNumber());

        #endregion


        #region Groupings

        Console.WriteLine($"Practice Groupings" +
            $"\n-----------------------------------------------------");

        //Groupings groupings = new Groupings();

        //Console.WriteLine(groupings.GroupingSyntax());

        //Console.WriteLine(groupings.GroupByProperty());

        //Console.WriteLine(groupings.GroupByCategory());


        //Console.WriteLine(groupings.NestedGrouBy());

        //Console.WriteLine(groupings.NestedGroupByCustom());


        #endregion



        #region JoinOperations

        Console.WriteLine($"Practice JoinOperations" +
            $"\n-----------------------------------------------------");

        JoinOperations joinOperations = new JoinOperations();

        //Console.WriteLine(joinOperations.GroupJoinQquery());

        Console.WriteLine(joinOperations.LeftOuterJoin());

        #endregion


    }
}
