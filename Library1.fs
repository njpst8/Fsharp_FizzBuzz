module FSharp_FizzBuzz

open NUnit.Framework

[<Test>] 
let testFrameworkSetup() = 
    Assert.True(true)


let transform number = 
    let fizzBuzzTuple = (number % 3, number % 5)
    match fizzBuzzTuple with
    | (0, 0) -> "FizzBuzz"
    | (0, _) -> "Fizz"
    | (_, 0) -> "Buzz"
    | _ -> string number


[<Test>] 
let threeReturnsFizz() = 
    Assert.AreEqual("Fizz", transform 3)

[<Test>] 
let sixReturnsFizz() = 
    Assert.AreEqual("Fizz", transform 6)
    
[<Test>] 
let fiveReturnsBuzz() = 
    Assert.AreEqual("Buzz", transform 5)
        
[<Test>] 
let fifteenReturnsFizzBuzz() = 
    Assert.AreEqual("FizzBuzz", transform 15)
    
[<Test>] 
let thirteenReturns13() = 
    Assert.AreEqual("13", transform 13)