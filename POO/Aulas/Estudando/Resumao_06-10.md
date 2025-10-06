``` A organização do conteúdo foi feita por IA, baseado nas aulas e conteúdos de simulados

# 🧠 POO - N1 (Programação Orientada a Objetos)  
**Curso:** Engenharia de Software - Católica SC  
**Professor:** Paulo Manseira  
**Turma:** 2A  

---

## 📚 CONTEÚDO PRINCIPAL DA PROVA

### 🔹 1. Classe e Objeto
- **Classe:** modelo ou molde que define atributos (características) e métodos (ações).  
- **Objeto:** instância concreta de uma classe, criada na memória.  
- **Instanciação:** processo de criar um objeto.

#### 🧩 Exemplo:
```java
public class Veiculo {
    String modelo;
    int ano;

    void exibirInformacoes() {
        System.out.println("Modelo: " + modelo + ", Ano: " + ano);
    }
}

Veiculo carro = new Veiculo();
carro.modelo = "Civic";
carro.ano = 2022;
carro.exibirInformacoes();
🔹 2. Atributos e Métodos
Atributos: variáveis internas da classe (características).

Métodos: funções internas (ações/comportamentos).

🧩 Exemplo:
java
Copiar código
class Pessoa {
    String nome;
    int idade;

    void falar() {
        System.out.println("Olá, meu nome é " + nome);
    }
}
🔹 3. Encapsulamento
Conceito fundamental que protege os dados da classe, permitindo acesso controlado.

Implementado com modificadores de acesso (private, public, protected).

Acesso a atributos privados é feito com getters e setters.

🧩 Exemplo:
java
Copiar código
class ContaBancaria {
    private double saldo;

    public double getSaldo() {
        return saldo;
    }

    public void depositar(double valor) {
        if (valor > 0) saldo += valor;
    }
}
💡 Resumo:

private → atributo só acessível dentro da classe.

public → acesso liberado a qualquer parte do código.

Encapsular = proteger + controlar acesso com métodos.

🔹 4. Construtor
Método especial, executado automaticamente ao criar um objeto.

Mesmo nome da classe e sem tipo de retorno.

🧩 Exemplo:
java
Copiar código
class Aluno {
    String nome;
    int idade;

    public Aluno(String n, int i) {
        nome = n;
        idade = i;
    }
}
🔹 5. Visibilidade (Modificadores de acesso)
Modificador	Dentro da classe	Mesmo pacote	Subclasse	Fora do pacote
public	✅	✅	✅	✅
protected	✅	✅	✅	❌
default	✅	✅	❌	❌
private	✅	❌	❌	❌

🔹 6. Morfologia da Classe
Estrutura básica:

Declaração (class NomeDaClasse)

Atributos

Métodos

Construtor

A primeira linha de um método é chamada de assinatura.

🧩 Exemplo:
java
Copiar código
public void exibirDados(String nome, int idade) { // assinatura
    System.out.println(nome + " tem " + idade + " anos");
}
✅ RESUMO — O QUE ESTUDAR DE CERTEZA
Tema	O que dominar	Exemplo de pergunta
Classe e Objeto	Diferença e instanciação	“O que acontece quando instanciamos uma classe?”
Encapsulamento	Conceito e implementação (private, get/set)	“Como o encapsulamento protege os dados?”
Visibilidade	Papel de public, private etc.	“Qual modificador é usado para esconder atributos?”
Morfologia	Estrutura da classe e assinatura	“O que é a assinatura de um método?”
Construtor	Quando é executado e função	“Quando o construtor é chamado e qual sua função?”
Erros comuns	Falta de ponto e vírgula, tipo incorreto, ausência de ;, ()	“Identifique o erro na classe Jogador.”
Métodos	Retorno e parâmetros	“Escreva o método ConsultarInformacoes() para Veículo.”

📝 QUESTÕES POSSÍVEIS (DISCURSIVAS)
O que é encapsulamento e por que é importante?
➜ É o ato de proteger os dados de uma classe, permitindo acesso apenas por métodos.

Explique a diferença entre classe e objeto.
➜ Classe é o molde; objeto é a instância concreta.

O que é a assinatura de um método?
➜ Primeira linha, composta pelo tipo de retorno, nome e parâmetros.

O que o construtor faz?
➜ Inicializa atributos e é executado ao criar um objeto.

Qual comando implementa o encapsulamento?
➜ private.

Como se chama o processo de criar um objeto?
➜ Instanciação.

Como declarar um atributo privado e criar métodos de acesso?

java
Copiar código
private String nome;
public String getNome() { return nome; }
public void setNome(String n) { nome = n; }
Escreva a classe Veiculo com método ConsultarInformacoes():

java
Copiar código
public class Veiculo {
    private String modelo;
    private int ano;

    public void consultarInformacoes() {
        System.out.println("Modelo: " + modelo + ", Ano: " + ano);
    }
}
🧾 COLA DE PROVA (RESUMIDA)
Conceito	Explicação Rápida	Exemplo
Classe	Modelo com atributos e métodos	class Pessoa { String nome; void falar(){} }
Objeto	Instância da classe	Pessoa p = new Pessoa();
Atributo	Variável da classe	String nome;
Método	Ação da classe	void falar(){}
Encapsulamento	Esconde detalhes internos	private int idade;
Getter/Setter	Acesso controlado	getNome()/setNome()
Construtor	Inicializa o objeto	Pessoa(String n){ nome = n; }
Assinatura	Primeira linha do método	public void falar(String msg)

🧠 EXPLICAÇÕES CURTAS
🔸 Classe
Representa o modelo de um objeto (estrutura base).

🔸 Objeto
Instância real criada na memória.

🔸 Encapsulamento
Esconde dados internos usando private e permite acesso via public.

🔸 Construtor
Inicializa atributos e é executado na criação do objeto.

🔸 Visibilidade
Controla quem pode acessar atributos e métodos:

public: todos

private: só dentro da classe

protected: subclasses

sem nada: mesmo pacote

🔸 Assinatura
Primeira linha do método (tipo + nome + parâmetros).

📝 SIMULADO DE 10 QUESTÕES OBJETIVAS
1. O que é uma classe em POO?
✅ b) Um molde que define atributos e métodos.

2. O que é um objeto?
✅ c) Uma instância real de uma classe.

3. O que é encapsulamento?
✅ a) Técnica de esconder detalhes internos e proteger dados.

4. Qual comando implementa o encapsulamento?
✅ b) private

5. A primeira linha de um método é chamada de:
✅ b) Assinatura

6. O que faz o construtor?
✅ b) Inicializa atributos ao criar o objeto.

7. Como se cria um objeto em Java?
✅ b) new Pessoa();

8. Sobre modificadores de acesso:
✅ c) private protege atributos dentro da classe.

9. Complete: “Encapsular é ______ os dados de uma classe.”
✅ b) ocultar

10. Em POO, “instanciar” significa:
✅ c) Criar um objeto na memória.

🎯 REVISÃO FINAL — O QUE VER NA VÉSPERA
✅ Memorize:
Diferença entre classe e objeto

Encapsulamento (conceito + private)

Construtor (executa na criação)

Assinatura de método

Modificadores de acesso

🧪 Pratique:
Criar classe Veiculo, Jogador ou Pessoa

Fazer getters e setters

Escrever método ConsultarInformacoes()

🧩 Exemplo completo:
java
Copiar código
public class Veiculo {
    private String modelo;
    private String marca;
    private int ano;

    public Veiculo(String modelo, String marca, int ano) {
        this.modelo = modelo;
        this.marca = marca;
        this.ano = ano;
    }

    public void consultarInformacoes() {
        System.out.println("Modelo: " + modelo + " | Marca: " + marca + " | Ano: " + ano);
    }
}
💡 DICA EXTRA
Se cair “Classe Veiculo” ou “Classe Jogador”, o professor provavelmente quer ver:

class NomeDaClasse

private nos atributos

public nos métodos

ConsultarInformacoes() mostrando os dados

Fim do resumo — boa sorte na prova! 💪

yaml
Copiar código

---
