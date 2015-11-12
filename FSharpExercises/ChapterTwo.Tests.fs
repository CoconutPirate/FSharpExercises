﻿namespace FSharpExercises.Tests

open NUnit.Framework
open FsUnit
open FSharpExercises.ChapterTwo

module ChapterTwoTests = 

// 2.1
// Write function f: int -> bool such as f(n) = true exactly when
// n is divisible by 2 OR 3 AND NOT divisible by 5
        [<Test>] 
        let ``24 should give true as divisible by 2 and 3`` () =
                checkForDivision 24 
                |> should be True

        [<Test>] 
        let ``27 should give true as divisible by 3`` () =
                checkForDivision 27 
                |> should be True

        [<Test>]
        let ``30 should give false as divisable by 5`` () =
                checkForDivision 30 
                |> should be False

        [<Test>]
        let ``29 should give false as not divisible`` () =
                checkForDivision 29 
                |> should be False

// 2.2
// Declare a function power: string * int -> string, where
// power(s,n) = "s * s ... * s" n times

        [<Test>]
        let ``power 4 1 should return 4`` () =
                power "4" 1
                |> should equal "4"

        [<Test>]
        let ``power 5 3 should return 5 * 5 * 5 `` () =
                power "5" 3
                |> should equal "5 * 5 * 5"

// 2.3
// Declare function isIthChar: string * int * char -> bool, where
// the value is true if and only if ch is the i'th character in the string (numering from 0)

        [<Test>]
        let ``should be true when char is ith char of the string`` () =
                isIthChar "abc" 1 'b'
                |> should be True

        [<Test>]
        let ``should be false when char is not ith char of the string`` () =
                isIthChar "abc" 1 'z'
                |> should be False
