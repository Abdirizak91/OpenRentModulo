# OpenRent Technical Task Solution

## Setup
- `.NET 10` (`net10.0`)
- `xUnit` for tests

## What this solution does
Given an input string, `TransformInput` returns:
1. The reverse of the input string.
2. The earliest alphabetic character found in the input.
3. `open` if the number of vowels is odd, otherwise `rent`.

Example:
- Input: `nepo`
- Output: `openerent`

## Assumptions
- "Earliest" means alphabetically smallest letter (`a` to `z`) to ensure logic works I have written it for lowercase tests only.
- Vowels are `a, e, i, o, u`.

## Project structure
- `OpenRentTest/TextTransformation/OpenRentStringTransformerTests.cs`

The private method `TransformInput` inside the test class contains the full implementation.

## Time spent
About 10 minutes.



