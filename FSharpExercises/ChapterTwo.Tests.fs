namespace FSharpExercises.Tests

open NUnit.Framework
open FsUnit
open FSharpExercises.ChapterTwo

module ChapterTwoTests = 

// 2.1
// Write function f: int -> bool such as f(n) = true exactly when
// n is divisible by 2 OR 3 AND NOT divisible by 5
        [<Test>] 
        let ``2.1: 24 should give true as divisible by 2 and 3`` () =
                checkForDivision 24 
                |> should be True

        [<Test>] 
        let ``2.1: 27 should give true as divisible by 3`` () =
                checkForDivision 27 
                |> should be True

        [<Test>]
        let ``2.1: 30 should give false as divisable by 5`` () =
                checkForDivision 30 
                |> should be False

        [<Test>]
        let ``2.1: 29 should give false as not divisible`` () =
                checkForDivision 29 
                |> should be False

// 2.2
// Declare a function power: string * int -> string, where
// power(s,n) = "s * s ... * s" n times

        [<Test>]
        let ``2.2: power 4 1 should return 4`` () =
                power "4" 1
                |> should equal "4"

        [<Test>]
        let ``2.2: power 5 3 should return 5 * 5 * 5 `` () =
                power "5" 3
                |> should equal "5 * 5 * 5"

// 2.3
// Declare function isIthChar: string * int * char -> bool, where
// the value is true if and only if ch is the i'th character in the string (numering from 0)

        [<Test>]
        let ``2.3: should be true when char is ith char of the string`` () =
                isIthChar "abc" 1 'b'
                |> should be True

        [<Test>]
        let ``2.3: should be false when char is not ith char of the string`` () =
                isIthChar "abc" 1 'z'
                |> should be False
                

// 2.4
// Declare function occFromIth: string*int*char -> int, where
// occFromIth(str,i,ch) = the number of occurences of character ch
// in positions j in the string str with j >= i


        [<Test>]
        let ``2.4: should get 2 (indexes 3 and 4)`` () =
               occFromIth "aaaaa" 2 'a'
               |> should equal 3

        [<Test>]
        let ``2.4: should get 0 (not existing char)`` () =
               occFromIth "aaaaa" 1 'b'
               |> should equal 3

        [<Test>]
        let ``2.4: should get 0 as starting index is bigger than string length `` () =
               occFromIth "aaaaa" 10 'a'
               |> should equal 0

// 2.5
// Declare function occInString: string*char -> int, where
// occInString(str,ch) = the number of occurrences of character ch in the string str

        [<Test>]
        let ``2.5: should get 0 (not existing char) `` () =
                occInString "abc" 'd'
                |> should equal 0

        [<Test>]
        let ``2.5: should get 1 (only one occurence) `` () =
                occInString "abc" 'a'
                |> should equal 1

        [<Test>]
        let ``2.5: should get 3 (all characters in string) `` () =
                occInString "aaaa" 'a'
                |> should equal 4

// 2.6
// Declare function notDivisable: int*int -> bool, where
// notDivisible(d,n) is true if and only if d is NOT a divisor of n

        [<Test>]
        let ``2.6: 3 is not a divisor of 5 -> true `` () =
                notDivisable 3 5
                |> should be True

        [<Test>]
        let ``2.6: 4 is a divisor of 12 -> false `` () =
                notDivisable 4 12
                |> should be False

// 2.7

    // A. Declare function test: int*int*int -> bool. The value of test (a,b,c) for a<=b is the truth value of:
    // notDivisible (a,c) AND notDivisible (a+1,c) AND ... AND notDivisable (b,c)
        
        [<Test>]
        let `` 2.7.A: test should return true for 2, 4 and 5 `` () =
                test 2 4 5
                |> should be True 

        [<Test>]
        let `` 2.7.A: test should return false for 2, 4 and 6 `` () =
                test 2 4 6
                |> should be False

    // B. Declare function prime: int -> bool, where
    // prime(n) = true, if and only if n is a prime number

        [<Test>]
        let `` 2.7.B: 19 is a prime `` () =
                prime 19
                |> should be True

        [<Test>]
        let `` 2.7.B: 20 is not a prime `` () =
                prime 20
                |> should be False


    // C. Declare function nextPrime: int -> int, where
    // nextPrime(n) is the smallest prime number > n

        [<Test>]
        let `` 2.7.C: next prime after 18 is 19 `` () =
                nextPrime 18
                |> should equal 19

        [<Test>]
        let `` 2.7.C: next prime after 19 is 23 `` () =
                nextPrime 19
                |> should equal 23

// 2.8
// This figure is the first part of Pascal's triangle: http://tinyurl.com/opomz44
// The entries of the triangle are called binomial coefficients.
// http://tinyurl.com/qayuvda and
// http://tinyurl.com/pm2w9p6 (well, I cannot do here anything else than posting those as images, sorry)
// Declare function bin:int*int->int to compute binomial coefficients

        [<Test>]
        let `` 2.8: Binomial for n = 4, m = 2 equals 6 `` () =
                binomial 4 2
                |> should equal 6

        [<Test>]
        let `` 28: Biomial for n = 2, m = 1 equals 2 `` () =
                binomial 2 1
                |> should equal 2

        [<Test>]
        let `` 28: Binomial for n = 30, m = 15 equals 155 117 520`` () =
                binomial 30 15
                |> should equal 155117520

// 2.9

    // A. Declare function vat:int * float -> int, where
    // vat(n,x) is obtained by increasing x by n percent

        [<Test>]
        let ``2.9.A: 100 with 23 vat should give 123 `` () =
                vat 100 23.0f
                |> should equal 123.0f

    // B. Declare function unvat int * float -> float, where
    // unvat n (vat n x) = x
    
        [<Test>]
        let ``2.9.B: 123 with 23 vat should unvat to 100 `` () =
                unvat 23.0f 123.0f
                |> should equal 100.


// 2.10
// Declare function min: (int -> int) -> int, where
// the value of min(f) is the smallest natural number n where f(n) = 0 (if it exist)


        [<Test>]
        let ``2.10: y = x should give 0 `` () =
                min (fun x-> x)
                |> should equal 0

        [<Test>]
        let ``2.10: y = x - 5 should give 5 `` () =
                min (fun x -> x - 5)
                |> should equal 5

        [<Test>]
        let ``2.10: 2x^2 - 5x + 3 should give 1 `` () =
                min (fun x-> 2*x*x - 5*x + 3)
                |> should equal 1
