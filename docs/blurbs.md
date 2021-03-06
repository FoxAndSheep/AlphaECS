# Blurbs

This project was inspired by [Entitas](https://github.com/sschmid/Entitas-CSharp) and [uFrame ECS](https://github.com/micahosborne/uFrame) and was an attempt to have some of the simplicity and separation of Entitas while having some of the nicer reactive elements of uFrame ECS, so a huge thanks to the creators of those 2 libraries.

Now some common things you will probably want to ask/know:

## How Performant is it?

Not a clue, it is built to be functional and given there are a lot of enumerables which could be locked into lists and then updated as and when they are needed there are quite a few points where you could vastly improve performance without impacting the consumers, as you could just write your own `IPoolManager` which could do some smart caching etc.

Anyway the point is this library is not built with performance in mind, it is built with functionality and features in mind, but has been designed in such a way that you can easily replace aspects with faster more performant versions for your specific scenarios.

If you want to make some performance tests I would love to see them!

## Why should I use it?

No reason really, if you like the ECS pattern but want to have reactive systems then this may be a good fit, if not then probably not for you.

## Is ECS better than MVVM/MVC/MVP/MGS?

Well Metal Gear Solid is a great game, so ECS is not better than that. It is also not *better* than the other patterns, it is just different. So MVVM is great for the enterprise developer coming from web/app development to game development or people who make UI heavy/Data centric games. MVP is very much the same but with the more formal separation on the data binding, and MVC for those who want to have more of a payload sort of approach for managing logic.

However you look at it, it's whatever you are used to. Believe it or not I have hardly any experience with ECS... I just liked some other ECS systems but always felt a bit was missing, so maybe I should not be using ECS frameworks, let alone writing them...

## How can I use it with playmaker/visual coding tool etc

This is more geared for coders, you can easily communicate from playmaker or any other tool into the underlying *Systems* etc you would just need to write your own custom actions to bridge between this framework and the one you are consuming. If you are one of the people wanting this functionality then I am happy to assist you as I have written a lot of other libraries bridging frameworks in the unity world, especially Node Canvas.

## How is this any better than uFrame ECS, Entitas, Some other ECS system?

Chances are it is not, it's just different. Like Entitas is great and is very similar to this project, however it doesn't really have a complex reaction system, so anything you want to do reactively is a bit of a pain. Other than that this is pretty much the same sort of thing as Entitas. Compared to uFrame ECS it doesnt have the entity == gameobject convention mentioned earlier but it has all the reactive stuff and it also works nicely with the notion of models, which uFrame ECS requires type references for which loses a good part of the benefit of using the framework.

So ultimately this is not marketed as the one ECS system to rule them all, its just got what I would deem the nice bits of a few existing ones.

It is also pretty succinct as all you need to do is implement a couple of interfaces, the framework setup is trivial (and done for you if you use the unity layer package) and it also can work nicely with DI allowing you to have more config driven aspects to your game without passing random garbage around or having horrible statics/singletons to do this.
