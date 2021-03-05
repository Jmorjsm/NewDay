# NewDay 
Simple markdown todo lists, managed from your command line

## Example structure
### Daily todo files
Daily todo lists use markdown formatting to describe tasks and heavily rely on nesting for identifying subtasks within larger tasks or projects.

A _today_ section contains tasks that should be worked on today. Obviously, its up to you how you schedule these things but for my purposes, it's okay if these don't all get looked at today, sometimes these will carry forward to the next day and will form the start of the next day, and sometimes they'll become deprioritised out of my todo list.

An _ongoing_ section is maintained at the bottom of the daily todo list file for any ongoing/background tasks which do not require immediate attention but could be investigated in spare moments/at some point in the future.

An example todo file, `2021-01-01-todo.md` is shown below:

```
# 2021-01-01

## Today

- [x] Card converter initial work
    - [x] Implement card scanner
    - [x] Unit tests for conversion logic
    - [x] Implement conversion logic
    - [x] Raise pull request
    - [x] PR Reviews
    - [x] Complete PR

- [ ] Project 1
    - [x] Document project goals
    - [ ] Ask Annie about printing service - meeting 15:15 
        - What do we want to do about spooling?
        - Where do we get our paper?
        - How do we know how much ink we have?

- [ ] Water plants
    - [x] Calathea 
    - [x] Ivy
    - [ ] Bamboo - 14:00
    - [ ] Hoya - 14:00

## Ongoing

- [ ] Investigate pooling issues with card converter db
- [ ] Connection timeout retry against postgres
- [ ] this list gets bigger than it reasonably should be over time so needs pruning
```

### Folders
Shown below is an example folder structure for daily todo lists. It's pretty simple and doesn't get _too_ out of hand when you've been using it for a while, like it did when I didn't have these split by year/month!
```
├───2020
│   ├───11
│   │       2020-11-1-todo.txt
│   │       2020-11-2-todo.txt
│   │       2020-11-29-todo.txt
│   │       2020-11-30-todo.txt
│   │
│   └───12
│           2020-12-1-todo.txt
│           2020-12-2-todo.txt
│           2020-12-30-todo.txt
│           2020-12-31-todo.txt
│
└───2021
    ├───01
    │       2021-01-1-todo.txt
    │       2021-01-2-todo.txt
    │       2021-01-29-todo.txt
    │       2021-01-30-todo.txt
    │
    └───02
    │       2021-02-1-todo.txt
    │       2021-02-2-todo.txt
    |       ....
```

## Usage
### Setup a new Todo list
```shell
todo init [name]	creates a new todo list
todo [nd]		moves ongoing tasks to a new todo list for to day
todo view		views the todo list
todo review		steps through viewing each task
```
