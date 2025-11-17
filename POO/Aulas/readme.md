programação orientada a objetos é um paradigma

Ela utiliza Abstração:
    é abstraído, sobre regras ou de acordo com o funcionamento, características deste objeto, tais podem ser:
    1. CPF.
    2. Nome
    3. Altura.
    4. Etc.

Ela utiliza Classe:
    Aquilo que caracteriza um substantivo, cria o formato de um objeto. Pode ser pensada como uma forma de bolo, a classe define o formato do objeto, da mesma forma que a forma cria a base de um bolo. Usando a Classe, diversos objetos podem ser criados com características diferentes.

Ela utiliza Objetos:
    O resultado final, criado por uma forma onde se pode possuir caracterírticas próprias e específicas, da mesma forma que ainda possui um "formato", semelhante à outros objetos da mesma Classe.


Exemplo:
    Características do bolo: forma - redonda, peso - 300g, sabor - chocolate com baunilha, cobertura - chocolate, etc.

Todas características possuem uma chave e valor:
Classe - Valor:
Ex: Cor de cabelo - Loiro

A palavra característica, em uma Classe na POO, vai possuir o nome "propriedade". Algo inerente da classe.


A Classe também descreve, além das Propriedades, descreve Ações, as ações serão o que cada um executa, por exemplo, acelerar, freiar, buzina, capota. As ações serão verbos.

As ações serão, na POO, chamadas de Métodos.

A Classe descreve o método e as propriedades, quem a executa é o objeto em si.



===============//=================

Um paradigma POO possui em sua abstração

Classe --descreve--> Propriedade/Atributo
Objeto --descreve--> Método/Operação

Classe --Representa--> Método/Operação
Objeto --Representa--> Propriedade/Atributo

Nos métodos de um objeto, o mais comum de existir é o constructor.
O qual cria um objeto da classe com valores.

As Classes são escritas globalmente como:

__________________
|      Nome      |
|----------------|
|   Propriedades |
|----------------|
|    Métodos     |
|________________|

Que seriam:

Nome: Livro
Propriedades: 

    +titulo: string,
    +autor: string, 
    +sbn: string, 
    +anoPublicacao: int, 
    +paginas: int.

Métodos:

    Livro(cod: string, tit: string, aut: string, pub: int, pag: string)
        Construtores não possui tipos, e possui o mesmo nome que a classe.

    ImprimirDados() void;
        Outros métodos possuem tipo, este é nomeado no fim da função, neste caso 'void'.





HPG:

Exemplo:
  Uma classe chamada BaseCRUD é genérica ou generalizada (será herdada).
  Outras classes irão usar ela como herança.
  As classes que herdam, são chamadas de classes especializadas.

  Ou seja, uma classe será a classe pai/mãe ou filho/filha.


