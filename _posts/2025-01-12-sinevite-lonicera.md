---
name: sinevita-lonicera  
title: "Lonicera: Data Organisation for Relationship Graphs"  
date: 2025-01-12 06:00:00 +0000  
categories: [Devlogs, SineVita]  
tags: [devlog, compsci]  
---

## Introduction

[SineVita.Lonicera Git Repo](https://github.com/myoharin/lonicera/blob/main/csLonicera/src/Lonicera.cs)  
Lonicera is light weighted, high level data organisation class I’ve written for C\# to neatly organise, store, access and mutate relationships between nodes — **links**. The most straightforward applications are to store and easily access relationships between characters, intervals between notes in a chord in order to quantify harmony, edges defined by their vertices in a geometry, etc.

## Why not use Matrices / 2D Arrays?

Because Lonicera requires half the space needed whilst achieving the same effect\! As you can see from above, it omits cells where LHS.index \<= RHS.index, before concatenating each row behind the other. In a sense, it is like a pascal triangle, where for each row n, the nth element, last element, is omitted.

```c#
using System;
using SineVita.Lonicera;

Lonicera<int,long> PascalTriangle = new Lonicera<int,long>(growth=combination) // combination(r,n)
for (int i = 1; i < 10; i++) { // add number from 1 to 9
  PascalTriangle.Add(i, growNew=true)
}

// Print Elememnts
int index = 0;
Console.WriteLine(loniTest.Links.Count);
for (int i = 1; i < loniTest.NodeCount; i++) {
  for (int j = 0; j < i; j++) {
    Console.Write($"| {loniTest.Links[index]} ");
    index++;
  }
  Console.Write("\n");
}
```

```terminal
| 1
| 1 | 2
| 1 | 3 | 3
| 1 | 4 | 6 | 4
| 1 | 5 | 10 | 10 | 5
| 1 | 6 | 15 | 20 | 15 | 6
| 1 | 7 | 21 | 35 | 35 | 21 | 7
| 1 | 8 | 28 | 56 | 70 | 56 | 28 | 8
| 1 | 9 | 36 | 84 | 126 | 126 | 84 | 36 | 9
```

Although it is coded in a higher level language, C\#, since the Links list is completely dependent on the amount of nodes, it is memory efficient when it needs to be. However it cannot be implemented generally in a language that does not support generic types or lambda functions, and must be hard coded with them in mind.

## Specifications

Lonicera requires 2 datatypes: Node and Link, and one function that takes in 2 nodes in a set or non set order and returns the Link datatype, or otherwise an operation.

**Node** can be any data type.  
**Link** must be a data type that describes the relationship between 2 nodes.  
The **Growth** operation creates and defines each link using 2 of Nodes. The operation which must be either:

* Commutative, where A x B \= B x A  
* Or have an identity, where A x B is the inversion of B x A

The full and rather short documentation can be found in its [github repo](https://github.com/myoharin/lonicera/blob/main/csLonicera/src/Lonicera.cs)\!

## Why make a blog post for this…

A reminder for myself, mostly, and to set precedent as this class will be referenced in future devlogs\! I’d like to comment that this probably ain’t a new idea, and has been implemented in many data science environments already- this is just my inhouse solution that is intended to be generalised and reused for game dev purposes\!  
