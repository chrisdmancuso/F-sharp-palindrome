//Christopher Mancuso
//F# Palindrome Checker
//CSCI 4200-DA, Fall 2018
//Dr. Abi Salimi

open System
printfn "Enter a string and this will check if it is a palindrome: "

//Scan in user input
let userString = Console.ReadLine().ToLower()

printfn "\nChecking if %s is a palindrome...\n" userString

//Method which returns a boolean. If the character array of the userString is
//equal to its reverse, then this will return true.
let isPalindrome(stringToCheck: string) =
    let array = stringToCheck.ToCharArray()
    array = Array.rev array

//If isPalindrome returns true, then we print that the string is a palindrome.
//Otherwise, return false.
if isPalindrome userString
    then printfn "\"%s\" is a palindrome" userString
    else printfn "\"%s\" is not a palindrome" userString
System.Console.ReadKey() |> ignore;