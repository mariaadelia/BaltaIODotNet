# Operadores



## Operadores de Atribuição

- **=** serve para atribuir um valor

- Caso queira realizar juntamente com a atribuição alguma operação (como soma, subtração, etc.), você pode colocar esse *atribuidor específico* e na sequencia o igual

- ```csharp
  int x = 0; // atribuindo o valor 0 para o x
  x += 5; //x = x + 5;
  x -= 1; // x = x - 1;
  x *= 10; // x = x * 10;
  x /= 2; // x = x / 2;
  ```

- Podemos utilizar também o **++** e o **--** *antes do =* para adicionar ou subtrair 1 daquele valor

- ```csharp
  int x = 10;
  ++x //x = 10 + 1 
  --x //x = 10 -1
  ```
  
  

## Operadores de Comparação

- Retornam dois valores possíveis, *True* ou *False*

- ```csharp
  == //Igual
  != // Diferente
  > // Maior que
  < // Menor qie
  >= //Maior ou igual a
  <= // Menor ou igual a
  ```
  
  

## Operadores lógicos

- Usado em operações condicionais
  
- Temos 3 tipos de Operações lógicas
- ```csharp
  condA && condB //AND - Deve atender todas as condições
  condA || condB //OR - Se atender uma das condições já é verdadeiro
  !condA  //NOT - Negando uma condição
  ```


