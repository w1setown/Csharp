# Basic
## Add two numbers
Given three numbers, write a method that adds two first ones and multiplies them by a third one.

### Expected input and output
AddAndMultiply(2, 4, 5) → 30

<br>

## Celsius to Fahrenheit
Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. Remember that temperature below -271.15°C (absolute zero) does not exist!

### Expected input and output
CtoF(0) → "T = 32F"

CtoF(100) → "T = 212F"

CtoF(-300) → "Temperature below absolute zero!"

<br>

## Elementary operations
Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division. Remember that you can't divide any number by 0!

### Expected input and output
ElementaryOperations(3, 8) → 11, -5, 24, 0.375

<br>

## Is result the same
Given two different arithmetic operations (addition, subtraction, multiplication, division), write a method that checks if they return the same result.

### Expected input and output
IsResultTheSame(2+2, 2*2) → true

IsResultTheSame(9/3, 16-1) → false

<br>

## Modulo operations
Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.

### Expected input and output
ModuloOperations(8, 5, 2) → 1

<br>

## The cube of
Given a number, write a method that returns its cube.

### Expected input and output
CubeOf(2) → 8

CubeOf(-5.5) → -166.375

<br>

## Swap two numbers
Given two integers, write a method that swaps them using temporary variable.

### Expected input and output
SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"

SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13"

<br>




# Conditional Statements
## Absolute value
Given an integer, write a method that returns its absolute value.

### Expected input and output
AbsoluteValue(6832) → 6832

AbsoluteValue(-392) → 392
<br>
## Divisible by 2 or 3
Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.

### Expected input and output
DivisibleBy2Or3(15, 30) → 450

DivisibleBy2Or3(2, 90) → 180

DivisibleBy2Or3(7, 12) → 19
<br>
## If consists of uppercase letters
Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.

###Expected input and output
IfConsistsOfUppercaseLetters("xyz") → false

IfConsistsOfUppercaseLetters("DOG") → true

IfConsistsOfUppercaseLetters("L9#") → false
<br>
## If greater than third one
Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.

### Expected input and output
IfGreaterThanThirdOne([2, 7, 12]) → true

IfGreaterThanThirdOne([-5, -8, 50]) → false
<br>
## If number is even
Given an integer, write a method that checks if it is even.

### Expected input and output
IfNumberIsEven(721) → false

IfNumberIsEven(1248) → true
<br>
## If sorted ascending
Given an array of three integers, write a method that checks if they are sorted in ascending order.

### Expected input and output
IfSortedAscending([3, 7, 10])→ true

IfSortedAscending([74, 62, 99])→ false
<br>
## Positive, negative or zero
Given a number, write a method that checks if it is positive, negative or zero.

### Expected input and output
PositiveNegativeOrZero(5.24) → positive

PositiveNegativeOrZero(0.0) → zero

PositiveNegativeOrZero(-994.53) → negative
<br>
## If year is leap
Given a year as integer, write a method that checks if year is leap.

### Expected input and output
IfYearIsLeap(2016) → true





<br>

# Loops

## Multiplication table
Write a method that prints 10 by 10 multiplication table. Remember readability (spaces in the right place).

### Expected output
```
  1   2   3   4   5   6   7   8   9  10
  2   4   6   8  10  12  14  16  18  20
  3   6   9  12  15  18  21  24  27  30
  4   8  12  16  20  24  28  32  36  40
  5  10  15  20  25  30  35  40  45  50
  6  12  18  24  30  36  42  48  54  60
  7  14  21  28  35  42  49  56  63  70
  8  16  24  32  40  48  56  64  72  80
  9  18  27  36  45  54  63  72  81  90
 10  20  30  40  50  60  70  80  90 100
```
<br>

## The biggest number
Given an array of integers, write a method that returns the biggest number in this array.

### Expected input and output
TheBiggestNumber([190, 291, 145, 209, 280, 200]) → 291

TheBiggestNumber([-9, -2, -7, -8, -4]) → -2
<br>
## Two 7s next to each other
Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.

### Expected input and output
Two7sNextToEachOther([ 8, 2, 5, 7, 9, 0, 7, 7, 3, 1]) → 1

Two7sNextToEachOther([ 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 ]) → 3
<br>
## Three increasing adjacent
Given an array of numbers, write a method that checks if there are three adjacent numbers where second is greater by 1 than the first one and third is greater by 1 than the second one.

### Expected input and output
ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82 ]) → True

ThreeIncreasingAdjacent([7, 3, 5, 8, 9, 3, 1, 4 ]) → False
<br>
## Sieve of Eratosthenes
Given an integer n (n>2), write a method that returns prime numbers from range [2, n].

### Expected input and output
SieveOfEratosthenes(30) → [2, 3, 5, 7, 11, 13, 17, 19, 23, 29]
<br>
## Extract string M
Given a string, write a method that returns substring from between two double hash signs (#).

### Expected input and output
ExtractString("##abc##def") → "abc"

ExtractString("12####78") → empty string

ExtractString("gar##d#en") → empty string

ExtractString("++##--##++") → "--"
<br>
## Full sequence of letters M
Given a string of two letters, where first one occurs before the second in the alphabet, write a method that returns full sequence of letters starting from first and ending at the second one.

### Expected input and output
FullSequenceOfLetters("ds") → "defghijklmnopqrs"

FullSequenceOfLetters("or") → "opqr"
<br>
## Sum and average
Given two integers n and m (n <= m), write a method that returns sum of all integers and average from range [n, m].

### Expected input and output
SumAndAverage(11, 66) → "Sum: 2156, Average: 38.5"

SumAndAverage(-10, 0) → "Sum: -55, Average: -5"

<br>

## Draw triangle
Write a method that draws triangle shape like below.

### Expected input and output
DrawTriangle() →
```
         *
        ***
       *****
      *******
     *********
    ***********
   *************
  ***************
 *****************
*******************
```

<br>

## To the power of
Given two integers, write a method that returns first number raised to the power of second one.

### Expected input and output
ToThePowerOf(-2, 3) → -8

ToThePowerOf(5, 5) → 3125
