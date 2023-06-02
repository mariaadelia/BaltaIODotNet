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
        //O que deve ser feito 
    }
    //var i => contador
    // i <= 5 => condição para que continue ocorrendo a ação enquanto não chegar nessa condição
    // i++ => incremento
    ```

- f

d