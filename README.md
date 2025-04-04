# 📟 Calculadora Console em C#

Este é um aplicativo simples de calculadora feito em **C#**, que roda no terminal/console. Ele permite realizar as quatro operações matemáticas básicas: **adição, subtração, multiplicação e divisão**.

----------

## 📋 Funcionalidades

Ao executar o programa, você verá um menu com as seguintes opções:

1.  Soma
    
2.  Subtração
    
3.  Divisão
    
4.  Multiplicação
    
5.  Sair
    

O usuário escolhe uma opção digitando o número correspondente e, em seguida, fornece dois valores para realizar a operação selecionada. O resultado é exibido na tela, e o menu é mostrado novamente até que o usuário escolha sair.

----------

## 🚀 Como executar o programa

### Pré-requisitos

-   Ter o [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado (versão 6.0 ou superior recomendada)
    
-   Um editor de código ou terminal (como o Visual Studio, VS Code, ou o terminal padrão)
    

### Passos para rodar:

1.  Clone ou baixe este repositório:
    
    ```bash
    git clone https://github.com/LeoRVergani/Calculator.git
    cd Calculator
    
    ```
    
2.  Compile o programa:
    
    ```bash
    dotnet build
    
    ```
    
3.  Execute o programa:
    
    ```bash
    dotnet run
    
    ```
    

----------

## 🧠 Estrutura do código

O aplicativo é dividido em métodos:

-   `Menu()`: Apresenta o menu principal e redireciona para a operação escolhida.
    
-   `Soma()`, `Subtracao()`, `Divisao()`, `Multiplicacao()`: Realizam as respectivas operações matemáticas.
    
-   `Main()`: Ponto de entrada do programa, limpa o console e chama o menu.
    

----------

## 📌 Observações

-   O programa trata entradas via `Console.ReadLine()` e não possui tratamento de exceções. Portanto, entradas inválidas (como letras ao invés de números) irão gerar erros.
    
-   Ideal para iniciantes em C# aprenderem sobre estruturas condicionais, métodos e interação via console.
    

----------

## 📄 Licença

Este projeto está licenciado sob a [MIT License](https://chatgpt.com/c/LICENSE).

----------
## English>>
----------

# 📟 Console Calculator in C#

This is a simple **C#** console-based calculator application that performs four basic mathematical operations: **addition, subtraction, multiplication, and division**.

----------

## 📋 Features

When you run the program, you will see a menu with the following options:

1.  Addition
    
2.  Subtraction
    
3.  Division
    
4.  Multiplication
    
5.  Exit
    

The user selects an option by entering the corresponding number, then provides two values for the chosen operation. The result is displayed on the screen, and the menu is shown again until the user chooses to exit.

----------

## 🚀 How to Run the Program

### Prerequisites

-   Have the [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed (version 6.0 or later recommended)
    
-   A code editor or terminal (such as Visual Studio, VS Code, or a standard terminal)
    

### Steps to run:

1.  Clone or download this repository:
    
    ```bash
    git clone https://github.com/LeoRVergani/Calculator.git
    cd Calculator
    
    ```
    
2.  Compile the program:
    
    ```bash
    dotnet build
    
    ```
    
3.  Run the program:
    
    ```bash
    dotnet run
    
    ```
    

----------

## 🧠 Code Structure

The application is divided into several methods:

-   `Menu()`: Displays the main menu and redirects the user to the selected operation.
    
-   `Soma()`, `Subtracao()`, `Divisao()`, `Multiplicacao()`: Perform the respective mathematical operations.
    
-   `Main()`: The program's entry point, which clears the console and calls the menu.
    

----------

## 📌 Notes

-   The program handles input via `Console.ReadLine()`, but there is no exception handling. Therefore, invalid inputs (such as letters instead of numbers) may cause errors.
    
-   This project is ideal for beginners in C# to learn about conditional structures, methods, and console interaction.
    

----------

## 📄 License

This project is licensed under the [MIT License](https://chatgpt.com/c/LICENSE).

----------
