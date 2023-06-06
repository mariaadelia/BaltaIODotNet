# Reference Types

-  Mémoria é dividida em duas partes: **Heap** e **Stack**
   -  *Heap* - armazena os dados
      -  *Reference Types* armazenam o endereço do objeto que contém os dados
         -  Não armazena os dados em si, armazena a referência a essa info
         -  Classes, Objects, Arrays...
         -  Ao assimilar uma variável ele criará uma referência e apontará para a mesma informação. Não são independentes
         -  Menos espaço na memória
         -  O Garbage collector (que é uma parte do dotnet que observa os lixos para tirar) limpa o heap
   -  *Stack* - armazena as referências para os dados (endereço de onde fica a info)
      -  Tipos de valor (*Value Type*) são armazenados na stack
      -  Se assimilarmos uma variável do tipo de valor a outra, o valor será **copiado** e ambas serão independentes
      -  Bult-in, Structs, Enums
      -  Tem que ter cuidado pois pode ficar extremamente pesado na memória
      -  O Garbage collector (que é uma parte do dotnet que observa os lixos para tirar) não limpa o stack
