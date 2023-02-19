# Overview

This is a small C# program meant to track your relationships (friends/family) similar to the "friends" features of some social networks.
This is meant to be an exercise in learing C# and application of graph theory.
I came up with the idea when I wanted to invite people to a party that were in a certain geolocation and had at least one mutual friend.

In it's current state, you can add a set number of people and have regurgitated back to you.
As of yet, no relationships (edges on a graph) are implemented via this program.

[Software Demo Video](https://youtu.be/uh5h1JCD5iM)

# Development Environment

This program was developed using the Kate text editor on Linux.

This was programmed in C#. I found out quickly I'm not a fan of C# and how it is too similar to Java.
C# development on Linux is possible, but don't expect to write any decent cross-platform graphical application.

Due to all this, this program is a console application that requires `dotnet` to run.
It uses only built in libraries and should be cross-platform.

# Useful Websites

This is the documentation and snippets referenced for or in this project:

- [C# Documentation (dotnet)](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Accurate age calculation (code snippet)](https://stackoverflow.com/a/3055445)

# Future Work

- Rewrite it in a different language
- Fully implement relationship functionality
- Make a graphical interface
- Save and encrypt data
