# BaltaIO - Linguagem de programação com C#

- DotNet é **case sensitive**



## Escopo de um programa

- *Importações*
  
  - é demarcado pelo *using*

- *Namespace*
  
  - divisões lógicas que tem o nome do namespace

- *Classe*
  
  - é uma classe
  
  - Tudo que for executado está dentro da classe *Program*

- *Método principal*
  
  - Método *Main* (static void main)

- ```csharp
  using System;
  
  namespace FirstProject
  {
      class Program
      {
          static void Main(string[] args)
          {
              var texto = "Hello World";
              Console.WriteLine(texto);
          }
      }
  }
  ```
