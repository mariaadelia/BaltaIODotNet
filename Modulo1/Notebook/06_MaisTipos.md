Alias

- apelido que todo *tipo* no .NET tem
  
  - **Exemplo:** o nome do tipo **string** e na verdade **System.String**
  
  - ```csharp
    int idade = 23; //Alias
    Int32 idade = 23; //Tipo
    ```

### Valores Padrões

- Os **tipos built in** sempre vem com valores padrões, eles nunca veem nulos

- Os valores padrões de alguns deles são:
  
  - ```csharp
    int, float, decimal = 0
    bool = false
    char = '\0'
    string = ""
    ```

### Conversão de Dados

- #### Conversão Implícita
  
  - Possuem tipos compatíveis (um precisa "poder caber no outro")
  
  - ```csharp
    float pagamento = 25.8 //Numero real
    int outroValor = 25 //Número real
    pagamento = outroValor; // Conversão implicita
    ```



- #### Conversão Explícita
  
  - Ocorre quando os tipos não são compatíveis
  
  - É usado o **parênteses** antes da variável
  
  - ```csharp
    int valor = 100;
    uint valorConvertido = (uint)valor; 
    //(tipoAConverter) valorASerConvertido
    ```

- #### Parse
  
  - Todo primitivo tem o **.Parse**
  
  - Essa função tenta converter um *caracter/string* para qualquer tipo
  
  - ```csharp
    string valor = "300";
    int valorConvertido = int.Parse(valor);
    
    Console.WriteLine(valorConvertido);
    ```
  
  - Caso haja incompatibilidade, gera um erro

- #### Convert
  
  - Similar ao parse, porém permite converter **para vários tipos**, não apenas uma string/caracter
  
  - ```csharp
    int valordouble valor2 = 10.50;
                int valorConvertido2 = Convert.ToInt32(valor2);
    
                Console.WriteLine(valorConvertido2);
    ```
    
    - O resultado será  10 porque converti um double para int
  
  - 
