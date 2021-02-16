Sample **CINEMA** example of Model C4 in .NET Core with EventStorming.
==============================================================

## Give a Star! :star:
If you like this project, learn something, or are using it in your applications, please give it a star. Thanks!

## Model C4

Newsletter for this project in Polish: [ModelC4.pl](https://modelc4.pl)

## First step is a BigPicture, and C1 System Context
I used three first phases from EventStorming BigPicture to create a model of Cinema.

To create Model C4 diagrams I did not need a whole and detailed model with all events ;)

![EventStorming](images/C1/event_storming_big_picture.png)

But after this step. I can saw some components for C1 System Context.
That's are Events as my Cinema Domain, Actors as Persons, and External Systems.

And now I can show the first layer of C4 Model.
![C1-SystemContext](images/C1/c1_system_context.png)

Of course, the legend is necessary.
![C1-SystemContext](images/C1/c1_system_context_legend.png)

## Now is time to another level 2 which is C2 Container
At this level, I used BigPicture to determine inputs in the system, potential technologies, intentions, and protocols.

This information can be created on the brainstorm and write on events, notes, external systems, or other ES element.

By red dot, I marked important pieces of information.

![EventStorming](images/C2/cinema_event_storming_inputs.png)

I describe some paths in EventStorming BigPicture. That is a way to identity inputs in the system. 
Another important piece of information we can add when adding comments on are of the process because in brainstorm/discussion we see more and sometimes chosen tools. 

Many things are hidden by the conversation between attendants. We should note this interesting information. Because we work at the problem and pick solution...


Is time to show what I found in EventStorming and prepare some Containers in Level two in Model C4.
![C2-Container](images/C2/c2_container.png)

In legend is little more elements.
![C2-Container](images/C2/c2_container_legend.png)