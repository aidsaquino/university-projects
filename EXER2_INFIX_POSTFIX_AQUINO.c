#include<stdio.h>
#include<stdlib.h>
#include<math.h>
#include<string.h>

int pop();

int checkprio(char symbol);
int checkifEmpty();
int checkifSymbol(char symbol);

void infix_to_postfix();

void push(long int symbol);

char infix[20], postfix[20];
int top;
long int stack[20]; // limits the number of characters inside the 'stack'


int main()
		{
		int count, size;
		char temp;
		top = -1;
		
		printf("\nEnter an Expression:\t");
		
		scanf("%[^\n]s", infix);
		
		infix_to_postfix(); //calls infix to postfix function
		
		printf("\nExpression in Postfix Format: \t%s\n", postfix);
	
		return 0;
		}
		
		
void infix_to_postfix() // infix to postfix converter function
		{
		unsigned int count, temp = 0;
		char next;
		char symbol;
		
		for(count = 0; count < strlen(infix); count++)
				{
				symbol = infix[count];
				if(!checkifSymbol(symbol))
						{
						switch(symbol)
								{
								case '(': push(symbol);
								break;
								case ')':
								while((next = pop()) != '(') // releases values from the stack until open parentheses is met
								{
								postfix[temp++] = next;
								}
								break;
								
								
								case '+':
								case '-':
								case '*':
								case '/':
								case '%':
								case '^':
								while(!checkifEmpty() && checkprio(stack[top]) >= checkprio(symbol))
								postfix[temp++] = pop();
								push(symbol);
								break;
								default:
								postfix[temp++] = symbol;
								}
						}
				}
				
		while(!checkifEmpty()) // empties the stack
				{
				postfix[temp++] = pop();
				}
				
		postfix[temp] = '\0';
		}
		
		
int checkprio(char symbol) // checks the order of the operator precedence
		{
		switch(symbol)
				{
				case '(': return 0;
				case '+': return 1;
				case '-': return 1;
				case '*': return 2;
				case '/': return 2;
				case '%': return 2;
				case '^': return 3;
				default : return 0;
				}
		}
		
		
int checkifSymbol(char symbol) // checks if the character is either tab or space
		{
		if(symbol == '\t' || symbol == ' ')
				{
				return 1;
				}
				
		else
				{
				return 0;
				}
		}
		
		
int checkifEmpty() // checks if the variable is empty
		{
		if(top == -1)
				{
				return 1;
				}
				
		else
				{
				return 0;
				}
		}
		
		
void push(long int symbol) // adds the values into the stack until limit is met
		{
		if(top > 20)
				{
				printf("Stack Overflow\n");
				exit(1);
				}
				
		top = top + 1;
		
		stack[top] = symbol;
		}

		
		
int pop() // releases the values from the stack until empty
		{
		if(checkifEmpty())
				{
				printf("Stack is Empty\n");
				exit(1);
				}
				
		return(stack[top--]);
		}
		
