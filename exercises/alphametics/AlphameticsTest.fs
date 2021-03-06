// This file was auto-generated based on version 1.0.0 of the canonical data.

module AlphameticsTest

open FsUnit.Xunit
open Xunit

open Alphametics

[<Fact>]
let ``Puzzle with three letters`` () =
    let puzzle = "I + BB == ILL"
    let expected = 
        [ ('I', 1);
          ('B', 9);
          ('L', 0) ]
        |> Map.ofList
        |> Some
    solve puzzle |> should equal expected

[<Fact(Skip = "Remove to run test")>]
let ``Solution must have unique value for each letter`` () =
    let puzzle = "A == B"
    let expected = None
    solve puzzle |> should equal expected

[<Fact(Skip = "Remove to run test")>]
let ``Leading zero solution is invalid`` () =
    let puzzle = "ACA + DD == BD"
    let expected = None
    solve puzzle |> should equal expected

[<Fact(Skip = "Remove to run test")>]
let ``Puzzle with four letters`` () =
    let puzzle = "AS + A == MOM"
    let expected = 
        [ ('A', 9);
          ('S', 2);
          ('M', 1);
          ('O', 0) ]
        |> Map.ofList
        |> Some
    solve puzzle |> should equal expected

[<Fact(Skip = "Remove to run test")>]
let ``Puzzle with six letters`` () =
    let puzzle = "NO + NO + TOO == LATE"
    let expected = 
        [ ('N', 7);
          ('O', 4);
          ('T', 9);
          ('L', 1);
          ('A', 0);
          ('E', 2) ]
        |> Map.ofList
        |> Some
    solve puzzle |> should equal expected

[<Fact(Skip = "Remove to run test")>]
let ``Puzzle with seven letters`` () =
    let puzzle = "HE + SEES + THE == LIGHT"
    let expected = 
        [ ('E', 4);
          ('G', 2);
          ('H', 5);
          ('I', 0);
          ('L', 1);
          ('S', 9);
          ('T', 7) ]
        |> Map.ofList
        |> Some
    solve puzzle |> should equal expected

[<Fact(Skip = "Remove to run test")>]
let ``Puzzle with eight letters`` () =
    let puzzle = "SEND + MORE == MONEY"
    let expected = 
        [ ('S', 9);
          ('E', 5);
          ('N', 6);
          ('D', 7);
          ('M', 1);
          ('O', 0);
          ('R', 8);
          ('Y', 2) ]
        |> Map.ofList
        |> Some
    solve puzzle |> should equal expected

[<Fact(Skip = "Remove to run test")>]
let ``Puzzle with ten letters`` () =
    let puzzle = "AND + A + STRONG + OFFENSE + AS + A + GOOD == DEFENSE"
    let expected = 
        [ ('A', 5);
          ('D', 3);
          ('E', 4);
          ('F', 7);
          ('G', 8);
          ('N', 0);
          ('O', 2);
          ('R', 1);
          ('S', 6);
          ('T', 9) ]
        |> Map.ofList
        |> Some
    solve puzzle |> should equal expected

