# Knapsack-NSGA-2

## 1. Description of the problem considered
The classic problem of the knapsack is a combinatorial optimization problem.

Given a lot of elements, each item has a weight and a value. The purpose of the problem is to determine the optimal combination of selected items, given a maximum weight, so that the value of the items is maximum.

The problem solved in our project is an extension of the knapsack problem in the sense that the value of an item is represented by the pair (time, cost). 
In the classic case, optimization is done on a single dimension, but in our case we are dealing with a multi-dimensional problem, which requires a slightly different approach and that is why we chose to solve it through artificial intelligence techniques.

## 2. Description of the solution

There are 4 modules:

* __Algorithm__ - implementation of the NSGA-II algorithm functionality
* __CLI__ - running the command line algorithm using a mock data
* __GUI__ - running the algorithm from the graphical interface, with the possibility of adding new items, viewing results
* __Tests__ - the module for testing the functionality of chromosomes

The data structures built and used are:

- __Item__ - contains information about the name of that item, the value, weight and time required to collect it.
- __Chromosome__ - contains an array of bools that signify whether an item in a list of items is selected or not. It contains functions for calculating the fitness value according to the value and time required for collection
- __CrowdingDistanceAtom__ - contains a target chromosome and a clustering distance.
- __NonDominatedSort__ - contains a target chromosome, dominationCount which shows how many atoms it is dominated and dominates which is a list of dominated atoms.

### 2.1 Module Interaction

![Module interaction](https://github.com/TUIASI-AC-enaki/Knapsack-NSGA-2/blob/main/documentation/module-diagram.png)

### 2.2 Class Diagram

![Class Diagram](https://github.com/TUIASI-AC-enaki/Knapsack-NSGA-2/blob/main/documentation/class-diagram.png)

### 2.3 Description of the NSGA-II Algorithm

1. It receives the number of generations and the size of the population
2. The initial population of chromosomes is generated
3. The following operations are repeated in each generation:
    - select the pairs of parents by tournament
    - cross-over and generating children
    - mutation on children and their insertion in the population
    - non-dominant sorting on the chromosome list
    - sorting of agglomeration for the last front to be inserted in the population necessary to establish the initial size of the population
4. Returns the list of chromosomes following evolution 

## 3. GUI

The graphical interface part was implemented using Windows Forms, and the Live Charts package was used on the result analysis part.

Graphical interface functionalities:

* console logger - for recording each operation performed
* add item to the list of items
* reset the list of items
* load the list of default items
* delete selected items
* setting algorithm parameters
* front view after executing the algorithm
* chromosome filtering by weight
* view details of a chromosome in the final population

### 3.1 GUI Pages

![GUI Page](https://github.com/TUIASI-AC-enaki/Knapsack-NSGA-2/blob/main/documentation/ss/gui_1.png)

![GUI Page](https://github.com/TUIASI-AC-enaki/Knapsack-NSGA-2/blob/main/documentation/ss/gui_2.png)

![GUI Page](https://github.com/TUIASI-AC-enaki/Knapsack-NSGA-2/blob/main/documentation/ss/gui_3.png)

