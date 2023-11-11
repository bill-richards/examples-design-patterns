[solution](./)
# Design Patterns in .Net 7.0
### Job Title: Lorem ipsum
#### The Company: Some Company that produces Software
#### Required Experience
Must have:

- Design Patterns

## A foreword

Early in 2023 an extremely influential academic died. 

Generally speaking, academics are only extremely influential within their primary knowledge domain: this one however, was influential within his knowledge domain, and then again within ours. [*Christopher Alexander*](https://en.wikipedia.org/wiki/Christopher_Alexander) was his name: born in Vienna, Austria, educated (though not exclusively) at Harvard, USA, he lectured and held a professorship at the University of California, Berkeley, USA and died aged 85 in Binsted, UK. 

If you ask a software engineer whether they know of his name, I am pretty certain that you will get a varied response.

The work of Alexander *et al.* had a direct influence upon the thinking of some well known names within our field of expertise: Do you know the names *[Erich Gamma](https://en.wikipedia.org/wiki/Erich_Gamma), [Richard Helm](https://en.wikipedia.org/wiki/Richard_Helm), [Ralph Johnson](https://en.wikipedia.org/wiki/Ralph_Johnson_(computer_scientist)),* and *[John Vlissides](https://en.wikipedia.org/wiki/John_Vlissides) (also, sadly, no longer with us)*? Of course you do. Everyone in software engineering knows these names, right? Collectively they came to be known as *The Gang of Four* after their seminal work, [***Design Patterns: Elements of Reusable Object-Oriented Software***](https://www.amazon.co.uk/Design-patterns-elements-reusable-object-oriented/dp/0201633612), was published in 1994.

The patterns presented in *Design Patterns: Elements of Reusable Object-Oriented Software* are usually what is being referred to when you see that job listing stating that a *"...knowledge of design patterns"* is required, though on occasion this also encompases the patterns presented by [Martin Fowler](https://en.wikipedia.org/wiki/Martin_Fowler_(software_engineer)) within his publication [***Patterns of Enterprise Application Architecture***](https://www.amazon.co.uk/Enterprise-Application-Architecture-Addison-Wesley-Signature/dp/0321127420)

## Do you really need to understand Design Patterns?

As previously mentioned, many job specifications list *design patterns* as a pre-requisite; but what does that mean exactly? 

For example: many (and I mean many) software engineers/developers use these patterns every day without knowing who the *Gang of Four* are, or without knowing what an *Abstract Factory* is, or where one would use an *Adapter*, a *Decorator*, or the *Bridge pattern*; many would struggle to differentiate between a *Behavioural Pattern*, and a *Structural Pattern*, or a *Creational Pattern*: but they use these patterns **every day**. 

Then there is the converse, where an individual knows the names of those patterns, and understands how to implement them, and yet might still use or suggest them as the [wrong solution](https://stackoverflow.com/questions/52409628/using-the-decorator-pattern-to-conditionally-replace-behaviour-instead-of-extend/52411160#52411160). 

Knowing what a tool is does not *ipso facto* directly translate to understanding how to use it, or how to manufacture it. This is where understanding comes in to play. I posit that it is **extremely important** to ***understand*** design patterns, to fully appreciate what each "pattern" is, and what problems it solves, because that is the heart of the matter: ***what problem is this pattern a solution for?*** When the individual has gained this understanding she will see these patterns all around her, and she will see where they are applied correctly, or incorrectly, she will see where they are the missing solution and she will see where they are overkill (when implemented in full). A pattern is only a pattern because **it is a *known* solution to a *known* problem**.

## Do you need to know how to implement Design Patterns?

Controversially, I am going to say *no, you do not necessarily need to know how to implement all of the documented design patterns* which currently reside within the public domain, especially so when using modern programming tools, languages, and Frameworks: for example .Net 7.0 

Knowing how to implement many of those documented design patterns is nowhere near as essential today as it was in 1994, and some might even argue that knowing *where* to apply them is nowehere near as essential today as it was in 1994 -which is not, however, a view held by this author.

So *why*, I hear you ask, *is knowing **how** to implement these patterns not as important today as it was in 1994?* And in answer to that, I present to you, the contents of [this git repository](https://github.com/bill-richards/examples-design-patterns).

Jump right in to the code or take a bit of time to read the accompanying documents that I have painstakingly taken the time to put together by way of describing what is laid out within this C# solution.

This project will run all examples sequentially
- [Examples Runner / Viewer](./Viewer/README.md)

These are all of the example projects
- [Iterator Implementation and consumer](./IteratorImplementation/README.md)
- [.net Iterator consumer](./DotNetIterator/README.md)
- [Pattern matching Iterator consumer](./PatternMatching/README.md)
- [Chain of Responsibility, Iterator, Decorator, Adapter](./Sorting/README.md)
- [Dependency Injection](./DependencyInjection/README.md)

And just for the fun of it, I have also put together a means of obtaining some Benchmarks detailing both speed and Heap allocated memory.
- [Benchmarks / Debug Runner](./Benchmarks/README.md)