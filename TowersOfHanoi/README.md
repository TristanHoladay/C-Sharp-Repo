# Towers of Hanoi

Towers of Hanoi is a class puzzle game. The object is to move stacked blocks, bigger at the bottom to smallest on top, from one tower to another tower. You can't place a larger block on top of a smaller one. The goal is to achieve this in as little moves as possible.

## Installation

Download from GitHub 



## Notes (Code Plan)

The game is written as a Console App (.Net Framework) in C# using Visual Studio Community. The high-level plan was as such:

* Create a dictionary with strings as keys and stacks as values, to represent the towers and the blocks that "stack" in them.

* Initiate a do-while loop that prints the towers, asks for input, and checks for winning.

* Get user input: a from tower and a to tower.

* Validate that the input is legal (no larger blocks on top of smaller blocks).

* If validated, move the input by .Pop()'ing' from the "from tower" and .Push()'ing' it to the "to tower".

* Run a function to check if the third tower holds all the values in the same order as the first tower once did. If it does then user won. If not then print and loop continues.

* When printing the stacks you want to print them with he largest number (block) first and so on. However, you need to place the smallest number into the stack last (meaning will print first) so that it Pop()'s' off first. To reverse the order of the stack for printing, create a foreach loop that takes each stack, turns it into a list, the list is .Push()'ed' to a temporary stack and the temp stack is printed out next to the key (tower name) in the correct order due to the "Last In First Out" attribute.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
