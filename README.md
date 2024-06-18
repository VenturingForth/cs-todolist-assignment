# TODO List Assignment
## Overview
This application is a simple manager of TODOs. Each TODO is simply a description of a thing to be done (for example, "Order a cake for the birthday party"). Each description must be unique. TODOs can be added, removed, or viewed.
### Main application workflow
When the main application starts, it prints the available options:
```
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
```
The user can select `S`, `A`, `R` or `E` in either upper or lower case performing the tasks as described. An error message will display if the user selects an invalid option and prompts them for another entry.
If the user selects to `[S]ee all TODOs`, they will be shown a list of the all the current TODO items in a numbered list or a message informing them the list is empty.
When the user goes to `[A]dd a TODO`, they will be asked for a TODO description. This description must not be empty and must be unique, otherwise they will be shown an error message and prompted for another description.
If the user wants to `[R]emove a TODO`, they will be shown the list of TODOs and will be asked for the number of the task they wish to remove from the list. An error message will be displayed if the TODO list is empty and the user will be brought back to the main options. Error messages will be shown for an empty input or a numbered task not outside the range of the list, and the user will be prompted again for a number.
`[E]xit` will exit the application.
This is a Console App and has been written to run on command line.
