# Entrada de valores pelo console

- Para que o usuário possa digitar algo na tela, usamos:
  ```csharp
        Console.ReadLine(); //ou Console.Read()

- Para que consigamos ler outros valores além da string utilizamos o *Parse* com o ReadLine:
    ```csharp
        float valor1 = float.Parse(Console.ReadLine());
- Para limpar a tela usamos:
    ```csharp
        Console.Clear();
