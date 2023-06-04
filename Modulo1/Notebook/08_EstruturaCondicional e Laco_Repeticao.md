# Estuturas Condicionais

## Switch

- Utilizado quando tem muitas decisões
- É executado em cascata
- Necessita do **break** para parar o switch
- e há o *default* onde definirá o valor default caso não corresponda a nenhuma das alternativas anteriores 
- ```csharp
  string variavel = 1;

  switch (variavel)
  {
    case 1: //O que será feito caso 1//
      break;

    case 2: //O que será feito caso 2//
      break;

    case 3: //O que será feito caso 3//
      break;

    case 4: //O que será feito caso 4//
      break; 

    default: //O que será feito caso não corresponda a nenhum dos valores anteriores//
      break;   
  }
  ```
  

# Laços de Repetição

## For
  - exige 3 parametros: Contador, Condição e o Incremento
  - ```csharp
    for(var i = 0; i <= 5; i++)
    {
        //O que deve ser feito enquanto a condição do for não for cumprida
    }
    //var i => contador
    // i <= 5 => condição para que continue ocorrendo a ação enquanto não chegar nessa condição
    // i++ => incremento
    ```

## While
  - enquanto uma condição for verdadeira, será executado uma ação que defini
  - Precisamos, a cada execução, atualizar(incrementar) o valor da condição ou ficaremos em um looping eterno
  - ```csharp
    var valor = 10;
    while(valor <= 5)
      {
        //O que deve ser feito enquanto a codião for verdadeira
      }

## Do / While
  - fazer algo, enquanto a condição for verdadeira
  - O ponto aqui é que primeiro vai entrar no que deve ser feito no *do* e **depois** será checada a condição (no *while*)
  - aqui é necessário que tenha um incremento no valor da condição para não ficar em um looping eterno
  - ```csharp 
      var valor = 0;
      do
      {
        //Ação que deve ser feita
      } while(valor < 5)
