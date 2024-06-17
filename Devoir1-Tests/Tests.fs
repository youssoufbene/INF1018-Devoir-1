namespace Devoir1_Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open INF1018_Devoir_1.Devoir1

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.TestCalculateSuccessRate0 () =
        Assert.AreEqual (0.0, calculateSuccessRate 0)

    [<TestMethod>]
    member this.TestCalculateSuccessRate6 () =
        Assert.AreEqual (0.9, calculateSuccessRate 6)
        
    [<TestMethod>]
    member this.TestCalculateSuccessRate10 () =
        Assert.AreEqual (0.77, calculateSuccessRate 10)


    [<TestMethod>]
    member this.TestCalculateHourlyProductionRate0 () =
        Assert.AreEqual (0.0, calculateHourlyProductionRate 0)
        
    [<TestMethod>]
    member this.TestCalculateHourlyProductionRate4 () =
        Assert.AreEqual (884.0, calculateHourlyProductionRate 4)

    [<TestMethod>]
    member this.TestCalculateHourlyProductionRate6 () =
        Assert.AreEqual (1193.4, calculateHourlyProductionRate 6)

        
    [<TestMethod>]
    member this.TestCalculateWorkingCarsPerMinute0 () =
        Assert.AreEqual (0, calculateWorkingCarsPerMinute 0)

    [<TestMethod>]
    member this.TestCalculateWorkingCarsPerMinute6 () =
        Assert.AreEqual (19, calculateWorkingCarsPerMinute 6)
        
    [<TestMethod>]
    member this.TestCalculateWorkingCarsPerMinute10 () =
        Assert.AreEqual (28, calculateWorkingCarsPerMinute 10)
