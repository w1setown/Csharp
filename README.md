















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

###Expected input and output
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
