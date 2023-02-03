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
  
  - A ordem das constantes em C# é: **const** *tipoDaConstante nomeDaConstante = valorDaConstante*;  no caso das constantes, é necessário atribuir seus valores
  
  - O nome da constante deve ser coesos, específicos, em LETRAS_MAIUSCULAS (separados por _ ), não devem começar com números
  
  - ```csharp
    //const tipoConst VALOR_CONST = ValorDaConstante;
    
    const string TEXTO_ENTRADA = "Texto constante";
    ```
  
  - d

- *Palavras reservadas*
  
  - São palavras que você não pode utilizar dentro do C# pois elas já significam algo no sistema

- *Comentários*
  
  - Comentário de uma linha
    
    - ctrl k c => comentar linha
    
    - ctrl k u => tirar o comentário da linha
    
    - ```csharp
      // São duas barras 
      ```
  
  - Comentário de várias linhas
    
    - ```csharp
      /*
      Dessa forma seu comentário tem mais linhas
      */
      ```
  
  - Notação XML(Metadata)
    
    - ```csharp
      /// São 3 barras
      ```

- *Tipos primitivos*
  
  - *built in types* é um outro nome para tipos primitivos
  
  - Tipos não o primitivos (complexos) são o conjunto de tipos primitivos
  
  - São chamados de *Tipos de valor*
  
  - São organizados em?
    
    - Tipos simples (Simple Types)
    
    - Enumeradores (Enums)
    
    - Estruturas (Structs)
    
    - Tipos Nulos (Nullable Types)

- ### Tipos
  
  - **Signed** e **Unsigned**
    
    - Os tipos  *signed* são os que aceitam números negativos, os tipos *unsigned* não aceitam
  
  - **Byte**
    
    - O tipo **sbite** aceita números negativos
    
    - **byte (8 bit)** =>  0 - 255
      
      - ```csharp
        byte valorByte = 25;
        ```
    
    - **sbyte(8-bit)** => - 128 - 127
      
      - ```csharp
        sbyte valorSByte = -25;
        ```
  
  - **Números inteiros**
    
    - O *u* significa *unsigned*, ou seja, não aceitam negativos
    
    - **short/ushort**=> números pequenos (16-bit)
      
      - ```csharp
        short valorShort = -2;
        ushort valorUShort = 2;
        ```
    
    - **int/uint** => números médios (32-bit), quando você escreve um número real(utilizando o var), por padrão ele vem como int
      
      - ```csharp
        int valorInt = -25;
        uint valorUInt = 5;
        ```
    
    - **long/ulong** => números grandes (64-bit)
      
      - ```csharp
        long valorLong = -54115156;
        ulong valorULong = 4115156;
        ```
  
  - **Números reais**
    
    - Os números reais aceitam por padrão os números positivos negativos não sendo necessário utilizar o *signed/unsigned*
    
    - **float** (32-bit) => (tem um limite numérico menor que os dois a seguir)
      
      - Para definir que o número é float, você precisa colocar o *f* no final do número 
        
        - ```csharp
          float salarioFloat = 2.500f;
          ```
    
    - **double**(64-bit) => quando você escreve um número real(utilizando o var), por padrão ele vem como double(tem um limite menor que o decimal)
      
      - ```csharp
        double salarioDouble = -2.5;
        ```
    
    - **decimal**(128-bit) => para definir que o número é decimal, precisa colocar o *m* no final
      
      - ```csharp
        decimal salarioDecimal 2.500m;
        ```
  
  - **Bool**
    
    - Tipo *boolean* (quando vai declarar, declara como *bool*) e armazena valores de *true* ou *false*
    
    - tem 8-bits
    
    - ```csharp
      bool eVerdadeEsseBilhete = false;
      ```
  
  - **Char**
    
    - Utilizado para armazenar um caractere no formato Unicode
    
    - Para declarar um *char* usamos aspas simples (' ')
    
    - 16-bits
    
    - ```csharp
      char valorChar = 'A';
      ```
  
  - **String**
    
    - Armazena um cadeia de caracteres
    
    - Para declarar uma *string* usamos aspas duplas (" ")
    
    - O tamanho da string depende de seu tamanho
    
    - O *default* de uma var de caracteres é *string*
    
    - ```csharp
      string valorString = "texto";
      string valorStringUmCaracter = "A";
      var textoQualquer = "d"; // Isso será uma string
      ```
  
  - **Var**
    
    - Substitui o nome de um tipo
    
    - Será do tipo do primeiro valor atribuído a ele
    
    - ```csharp
      var tipoQualquer = 98;  //será tipo inteiro
      var nome = "Joao"; //será tipo string
      ```
    
    - O *var* acaba ajudando a escrever menos código 
  
  - **Object**
    
    - Tipo genérico que recebe qualquer valor ou objeto
    
    - Serve para quando você não sabe o tipo da informação ou ela seja de vários tipos diferentes
    
    - É bom evitar usar
    
    - Você não precisa definir o valor como no caso do var
    
    - Outra coisa é que você pode ir mudando os tipos pois o object não tem um tipo definido
    
    - ```csharp
      objetc nome = "ajdfadfad" //O tipo será object e não string
      nome = 5; //Aqui coloquei um tipo inteiro, mas como é object, não dá problema
      ```
    
    - d
