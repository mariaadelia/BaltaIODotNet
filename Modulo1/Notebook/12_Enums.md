# Enums

-  Um inteiro que é usado para fornecer uma melhor visualização do código
-  É uma padronização para que não precisemos digitar nem o nome daquela opção (que se caso digitasse com letra minúscula seria entendido de maneira diferente do que com letra maiúscula)
-  Usado em listas curtas e sempre começar o enumerador com **E**
   -  ```csharp
                enum ENomeClasseEnumerador{
                    Valor = 1,
                    Valor2 = 2,
                    //....
                }
                //Exemplo
                enum EEstadoCivil{
                    Solteiro = 1,
                    Casado = 2,
                    Divorciado = 3
                }
-  Podemos usar esse enumerador como um tipo

ç