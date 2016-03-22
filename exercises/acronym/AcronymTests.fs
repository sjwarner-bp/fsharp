module AcronymTests

open NUnit.Framework
open Acronym

type AcronymTests() =

    [<Test>]
    member tests.Empty_string_abbreviated_to_empty_string() =
        Assert.That(Acronym().abbreviate(""), Is.EqualTo(""))
        
    [<TestCase("Portable Network Graphics", ExpectedResult = "PNG", Ignore = "Remove to run test case")>]
    [<TestCase("Ruby on Rails", ExpectedResult = "ROR", Ignore = "Remove to run test case")>]
    [<TestCase("HyperText Markup Language", ExpectedResult = "HTML", Ignore = "Remove to run test case")>]
    [<TestCase("First In, First Out", ExpectedResult = "FIFO", Ignore = "Remove to run test case")>]
    [<TestCase("PHP: Hypertext Preprocessor", ExpectedResult = "PHP", Ignore = "Remove to run test case")>]
    [<TestCase("Complementary metal-oxide semiconductor", ExpectedResult = "CMOS", Ignore = "Remove to run test case")>]
    member tests.Phrase_abbreviated_to_acronym(phrase) =
        Acronym().abbreviate(phrase)