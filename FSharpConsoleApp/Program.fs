// Learn more about F# at http://fsharp.org

open System

//How to declare a function
//Similar to c#, however its different, because the 'let' keyword is used to denote values instead of variables, meaning that it's immutable by default
let a = 5

//this is actually an equality operator, hence why we get the green squiglies saying that the return value is a bool but is ignored (not used or returned anywhere)
a = 4

//if I wanted to assign something to a value I would have to use the arrow operator which is this  <-
//however because we declaed a mutable by default value, we cannot assign it a new value, hence the error "this value is not mutable"
//a <- 7

//We can, however, change the declaration in line 7 to say "let mutable a" which would allow us to do so
let mutable b = 8
b <- 20

//we can also use the let keyword to specify functions
//this shows the value of c being determined by adding two numbers together, but this is not a value specifed by a function, it's specifed by other values
let sum = 3 + 8

//This is how we would use the let keyword by specifying the function
//when looking at the codelense, we can see that the input of this function is "unit" which I believe seems to mean parameterless
// so "unit -> int" to me is a function that takes "nothing/unit" and outputs an int
let sum1 () = 5 + 6


//if we want to call the sum1 function we would need to add a parenthesis to the end of name of the function like so : sum1()
//if we dont, the value result would not be athe result of the sum1 function, but it just merely assigns the function sum1 to the value result
//codelens would be "int" if the parenthesis is add vs "(unit -> int)" which is the signature of the function sum1
let result1 = sum1 ()

//Every function usually has parameters and when it doesn't, it usually includes "()" which is a unit
//If we do want to add paramters, however, f# allows us to do so in it's own semantic way
//we can see "x" and "y" sitting on the left side of the equation next to the name of the function sum2 and are spaced, this shows that these are the arguments to pass when calling this function
//notice how we didnt mention if this is an int or not
//int -> int -> int //a function that takes int as a parameter, after evaluation it takes another int as a parameter after which it returns an int
let sum2 x y = x + y

//in here we can see that when calling the sum2 function, we have to pass in arguments on its right side
//nothing special here except the fact that the first call of this function seems to dictate what the types of the function arguments would be from then on (given that we havent declared any type when creating the function)
let result2 = sum2 3 6

//in this line, as a result, we cant change the types of the argument to string, for example, because we already used that function in a previous line
//let result3 = sum2 "ff" "aa"

//we can also assign a value to a partially completed function by only noting part of the arguments required
//here we can see that altough that sum2 requires 2 arguments, we were able to just provide one
//this transforms the value from having the full output value of the function called, to being only a "conduit" for the output of the sum2 function
//here it only adds one argument along the way to finalizing the true output value of sum2
//the value of this has now turned into a function that takes in n arguments (n = count of arguments required in inner function - amount of arguments already provided)
let result3 = sum2 5

//we can call the result3 function and add one argument such as this to get the output value of int
let result4 = result3 8

//arguments passed in parenthesis are actually tuples and the code lens shows the input as this "(int * int)"
//we can pass multiple parentheses


//[<EntryPoint>] //we don't really need this as the compiler already knows when we comment this out as well as the main function
//and also outdenting the printfn
//let main argv =
printfn "Hello World from F#!"
//0 // return an integer exit code //we also don't need this code as a result of commenting out the main function
