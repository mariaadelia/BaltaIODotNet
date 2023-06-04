# Funções ou Métodos

- Podemos segmentar nosso programa em funções (também conhecidos como métodos)
- O método (funções) recebe um *retorno* (se o método retorna e o tipo dele ou não(void)), um *nome para o método* e *parâmetros* => isso é chamado de **Camada de Assinatura**
- Começam **sempre** com letra *Maiúscula*
- ```csharp
    static void NomeDoMetodo(string mensagem)
    {
        //O que o método irá fazer
    }

- Invocando o método:
  - ```csharp
        static void Main (string[] args)
        {
            //Para invocar o método é chamar ele e passar os parametros necessários
            NomeDoMetodo("Valor que será passado como parametro, lembrando que o valor aqui precisa ser do mesmo tipo do parametro do método ou vai dar erro");
        }
- Não é possível criar métodos dentro de métodos
- Quando o método tem retorno (ou seja, não é *void*), precisamos usar o **return** para retornar o valor definido lá no método (antes do nome do método)
- *Parametros Opcionais*
  - Quando precisamos colocar um parametro que pode quebrar outras chamadas dele, mas que essa nova info não é obrigatória, podemos setar o valor dele na assinatura do método
    - Exxemplo:
        - ```csharp
                static string RetornaInfos(
                    string parametro1,
                    string parametro2,
                    string parametroOpcional = "Valor default que quiser definir"
                )
                {
                    //O que o método irá fazer
                }
  - A restrição do parametro opcional é que ele precisa vir por último, caso contrário, dá erro
- d


ç