namespace FSharpExercises.Tests

open NUnit.Framework
open FsUnit
open FSharpExercises.ChapterOne

module ChapterOneTests = 

// 1.1:
// declare function g: int -> int where g(n) = n + 4
    [<Test>] 
    let ``1.1: g(0) = 4 `` () =
            g 0
            |> should equal 4

    [<Test>]
    let ``1.1: g(-5) = -1 `` () =
            g -5
            |> should equal -1

    [<Test>]
    let ``1.1: g(4) = 9 `` () =
            g 4
            |> should equal 9

// 1.2
// declare a function h: float * float -> float where h(x,y) = sqrt(x^2 + y^2)

    [<Test>]
    let ``1.2: h(3,4) = 5 `` () =
        h(3.f,4.f)
        |> should equal 5.f

    [<Test>]
    let ``1.2: h(5,12) = 13 `` () =
        h(5.f,12.f)
        |> should equal 13.f

// 1.3
// declare a recursive function f: int -> int, where
// f(n) = 1 + 2 + ... + (n - 1) + n, for n>= 0

    [<Test>]
    let ``1.3: f 4 = 10 `` () =
        f 4
        |> should equal 10

    [<Test>]
    let ``1.3: f 0 = 0 `` () =
        f 0
        |> should equal 0

    [<Test>]
    let ``1.3: f 1 = 1 `` () =
        f 1
        |> should equal 1

// 1.4
// The sequence F0, F1, F2,.. of Fibonacci numbers is defined by:
// F0 = 0, F1 = 1, Fn = F(n-1) + F(n-2)
// Declare a function to compute Fn
    
    [<Test>]
    let ``1.4: fib 0 = 0 `` () =
        fib 0
        |> should equal [0]

    [<Test>]
    let ``1.4: fib 1 = 0,1 `` () =
        fib 1
        |> should equal [0;1]

    [<Test>]
    let ``1.4: fib 2 = 0,1,1 `` () =
        fib 2
        |> should equal [0;1;1]

    [<Test>]
    let ``1.4: fib 5 = 0,1,1,2,3,5 `` () =
        fib 5
        |> should equal [0;1;1;2;3;5]

// 1.5
// declare a function sum: int * int -> int, where
// sum(m,n) = m + (m + 1) + (m + 2) + ... + (m + (n - 1)) + (m + n)

    [<Test>] 
    let ``1.5: sum (2,3) = 14 `` () =
        sum(2,3)
        |> should equal 14

    [<Test>]
    let ``1.5: sum (3, 2) = 12 `` () =
        sum(3,2)
        |> should equal 12
    


        

