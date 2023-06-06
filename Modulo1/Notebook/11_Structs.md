# Structs

-  É um *value type* que armazena outros tipos de dados
-  Composto de propriedades e métodos
-  Nome da classe sempre no maiúsculo e é preciso instanciar (**new**) ele quando chamar 
-  ```csharp
        struct NomeClasse
        {
            //Propriedades
            //Métodos
        }
-  Chamando essa classe em uma outra classe:
   -  ```csharp
            static void Main (string [] args)
            {
                var nomeQueQuiser = new NomeClasse();
                //Para atribuir valores e/ou usar o método
                nomeQueQuiser.Propriedade = "Valor Propriedade";
                nomeQueQuiser.Metodo();
            }
-  **Construtor**
   -  É um método público com o mesmo nome da classe e que recebe parametros mas que não tem retorno
   -  Toda vez que instanciarmos a classe, irá passar por esse método e por essa razão precisaremos adicionar os atributos que definimos no construtor
      -  ```csharp
                //Classe struct
                struct NomeClasse
                {
                    public NomeClasse(tipoProp prop1, tipoProp2 prop2 )
                    {
                        Prop1Original = prop1;
                        Prop2Original = prop2;
                    }
                }
                //Classe Main
                static void Main (string [] args)
            {
                var nomeQueQuiser = new NomeClasse(prop1,prop2);
                
            }
   -  Se precisarmos iniciar algum valor, esse é o local correto para isso
-  d

ç