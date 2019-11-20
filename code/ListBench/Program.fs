open System
open System.Collections.Generic
open System.Collections.Immutable

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running

[<MemoryDiagnoser>]
type Test() =

    let rnd = Random()

    [<Params(1, 10, 100, 1000)>]
    member val Num = 0 with get, set

    [<Benchmark(Baseline=true)>]
    member this.ListOfInt () =
        let list = List<int>()
        for _ in 1..this.Num do
            list.Add(rnd.Next(this.Num))
        list

    [<Benchmark>]
    member this.ImmutableListOfInt () =
        let builder = ImmutableList.CreateBuilder<int>()
        for _ in 1..this.Num do
            builder.Add(rnd.Next(this.Num))
        builder.ToImmutable()

    [<Benchmark>]
    member this.IntList () =
        let rec adder iter lst =
            if iter = this.Num
                then lst
                else adder (iter+1) (rnd.Next(this.Num) :: lst)
        adder 0 []

[<EntryPoint>]
let main _ =
    BenchmarkRunner.Run<Test>() |> ignore
    0
