#  Interview Prep - Keywords

## What is this?

Whiteboarding is the quintessential software development interviewing tool. In a whiteboarding session, the candidate is asked to solve a problem, in real time, with a literal whiteboard, meaning you need to be able to scribble out your solution without autocomplete, Intellisense, syntax-checking, or compiler errors. If that sounds intimidating, it is, but it's also very important: the purpose of whiteboarding isn't to see if you can solve the Fibonacci sequence using recursion (real example I've been asked, and not at all an uncommon one) but a chance for you to verbalize your thought process so that the interviewer can get a sense of how you solve problems in the moment. After all, that's what you're being hired to do!

Whiteboarding is not going anywhere. With the wealth of AI tools propping up now, homework assignments, which give candidates privacy and less pressure, are likely to become less common, so if you want to get hired, you should probably get comfortable with solving problems on the fly.

### The problems are not new

Patterns are a core concept in programming. Most of software development follows repeated implementation of tools, aka patterns, and as a result this shapes your solution. Whiteboarding is the same way: there are common problems that tend to appear over and over. If this is the case, why can't you just learn all the solutions, or better yet, why don't you literally just write software by using these patterns over and over? It shouldn't be that surprising that a pattern is just a starting point, and the needs of a business or project will still be specific, and will require that these patterns be tailored to fit a specific need. Similarly, different interviewers are going to come up with different problems in unique ways. So how on earth do you prepare for something that's going to be as different as each interviewer is from one another?

Well, in spite of the adversarial feeling an interview can have due to the pressure associated with it, your interviewer is working with you. It's in their best interest to determine if you're a good fit. As such, just like with story problems in elementary school math class, they are going to give you all the information you need in order to solve a problem. They will almost always do this by using _keywords_.

### Keywords

Keywords, in this context, are clues related to what an interviewer is looking for. If an interviewer says that they want you to find a value within a **sorted** array, they're probably telling you that you need to use binary search. If instead they say that a solution will be **deterministic**, it's most likely they're talking about either hashing, or dictionaries (which use hashing). These keywords can be an essential tool in figuring out where to start in a whiteboarding solution, which is critical to keeping your cool and doing a good job while you whiteboard. You can't, and really, shouldn't, try to memorize every solution in a book like _Cracking the Coding Interview_, but you can build a vocabulary of keywords that help to guide you towards the general solution for a whiteboarding problem.

## Who is this for?

At its heart, this repository can be for anyone who wants to know more about the data structures and algorithms at the heart of software engineering. In practice, this is for software engineers who are looking to work on their interviewing skills.

## How do I use this?

The `src/` directory contains 3 subdirectories:

- `Proof/`
- `Practice/`
- `Runtime/`

`Proof/` is the heart of this repo, and where you should likely start. Within `Proof/` are subdirectories, each named for a different keyword that you may hear during an interview. `Proof/README.md` has more information on each keyword, explaining why you might hear it, in what context, and what hearing it means. It also contains copy-paste blocks if you want to see the proven solution in action. Each solution is named followinf the `Proof/<keyword>/<solution>.cs` naming format, and each solution is heavily commented to contain critical information about the solution that will help you interview.

`Practice/` is where you will be spending most of your time, once you're familiar with the project. There is a single file, `Practice.cs`, which contains a single block, with instructions on how to change your return type to fit a given problem. Write your problem, then use the code snippets in `Practice/README.md` to test your work.

`Runtime/` contains a console application with a `main` entrypoint, which is how you actually run this repo as an app. You will use this to actually test your solution. v1 of this app is meant to have as few barrier to use as possible, so for right now, as previously stated, `Practice/README.md` has copy-paste blocks of code for you to include in `Runtime.cs` that will quickly test one of your solutions with appropriate input. In future versions, I may make this instead use some form of random generation, or even generative AI, but will not let perfect be the enemy of good.

## Table of Contents

#### Usage READMEs

[Proof](/src/Proof/README.md)
[Practice](/src/Practice/README.md)

#### Determinism

[README](/src/Proof/Deterministic/README.md)
[Dictionary](/src/Proof/Deterministic/Dictionary.cs)

#### Distinct

[README](/src/Proof/Distinct/README.md)
[HashSet](/src/Proof/Distinct/HashSet.cs)

#### Fibonacci

[README](/src/Proof/Fibonacci/README.md)
[Fibonacci](/src/Proof/Fibonacci/Fibonacci.cs)

#### Prefix

[README](/src/Proof/Prefix/README.md)
[Trie](/src/Proof/Prefix/Trie.cs)

#### Sorted

[README](/src/Proof/Sorted/README.md)
[BinarySearch](/src/Proof/Sorted/BinarySearch.cs)

### Getting started

To start, if you're brand new to this, you should give the [Proof README](/src/Proof/README.md) a look, as it will explain a lot of the concepts you need to know. Then after that, I would study each solution within `Proof/` to get an idea of how each implementation relates to a given keyword. Finally, you should practice! Literally write some solutions, as a library, in `Practice/Practice.cs`, then implement your library in `Runtime.cs`. Once you've done this and saved your work, you can run the console app with the command below.

```shell
dotnet run --project src/Runtime/Runtime.csproj
```

### Starting over

`RESET.sh` is a shell script that will reset `Practice.cs` to a neutral state, ready for you to try your next solution. To reset, from the top level of this repo in your terminal, run
```shell
./RESET.sh
```