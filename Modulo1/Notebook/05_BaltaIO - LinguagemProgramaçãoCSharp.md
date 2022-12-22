# BaltaIO - Linguagem de programação com C#

- DotNet é **case sensitive**

## Escopo de um programa

- *Importações*
  
  - é demarcado pelo *using*

- *Namespace*
  
  - enquanto as **pastas** são **divisões físicas**, os **namespaces** são **divisões lógicas**
  
  - **Não podemos** criar duas **classes** com o mesmo nome dentro do *mesmo namespace*
    
    - Uma possível solução seria, ao criarmos a outra pasta que terá o mesmo nome repetido, no namespace dessa classe repetida, colocar **namespace NomeDoNamespace.NomeDaPasta**
    
    - exemplo:
      
      - ```csharp
        //Classe 1
        using System;
        namespace Project1
        {
            class Program
            {
                ///....
            }
        }
        
        //Classe 2 na pasta RepeticaoNomeClasse
        //Isso irá gerar um erro pois são duas classes com mesmo nome no mesmo namespace
        using System;
        namespace Project1
        {
            class Program
            {
                ///....
            }
        }
        
        //Forma correta
        using System;
        //Correção para o problema: NameSpace.NomeDaPasta
        namespace Project1.RepeticaoNomeClasse
        {
            class Program
            {
                ///....
            }
        }
        ```
  
  - O namespace acompanha o **nome da pasta**
  
  - é ideal ter um namespace por arquivo (é possível ter mais de um, mas o ideal é ter um só)
  
  - O mesmo namespace pode estar em vários arquivos
  
  - Namespace começa com letra maiúscula e normalmente acompanham os nomes das pastas
  
  - Durante a execução, todos os arquivos do C# são unificadas (assim a divisão física - de pastas - se perderá e ficará apenas a divisão lógica - os namespace)

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



- *Variáveis*
  
  - Utilizamos para **armazenar informações** e seus valores **variam**
  
  - Sempre que instanciamos(*instanciar = criar*) uma variável estamos/precisamos inicializar elas
  
  - A ordem das variáveis em C# é: tipoDaVariavel nomeDaVariavel = valorDaVariavel;  , sendo esse valor algo opcional (quando não utilizamos o **var**)
    
    - ```csharp
      //tipo nomeVar = "valor inicial";
      string textoInicial = "Texto que quiser";
      string nome;
      ```
  
  - As variáveis tem **tipo** (string, int, etc.), mas podemos utilizar o tipo **var** 
    
    - Sempre que criarmos uma variável com *var*, ela irá assumir o tipo do primeiro valor que você informar, exemplo:
      
      - ```csharp
        var textoEntrada = "Texto";
        
        //A textoEntrada será do tipo string pois inicializei ela com uma string
        ```
  
  - Os nomes das variáveis devem ser **coesos, específicos, devem começar com letra minúscula e utilizar camel case**, *não devem começar com números, nem devem ter caracteres especiais nem espaços*

- *Constantes*
  
  - Armazena informações (assim como a variável), porém seu valor é fixo
  
  - As constantes não podem ser alteradas. São recomendadas para usos frequentes
  
  - Não podemos usar o tipo **var** em constantes e uma constante é definida pela palavra **const** antes do tipo da constante
  
  - A ordem das constantes em C# é: **const** tipoDaConstante nomeDaConstante = valorDaConstante;  no caso das constantes, é necessário atribuir seus valores
  
  - O nome da constante deve ser coesos, específicos, em LETRAS_MAIUSCULAS (separados por _ ), não devem começar com números
  
  - ```csharp
    //const tipoConst VALOR_CONST = ValorDaConstante;
    
    const string TEXTO_ENTRADA = "Texto constante";
    ```
  
  - d

- d
