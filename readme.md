Documento de Redes:
https://docs.google.com/document/d/1Aj3GHShWowaXs-slht6JfZdH7kybjzqXGG-QnvThD90/edit?usp=sharing


Para usar o repositório, será necessário possuir .Net usando uma versão > .5;

-- Biblioteca é um exemplo de como criar sem usar a inteface de comando

1º pasta para a solução
2º abrir a pasta
3º criar solution
4º criar um projeto do tipo console
5º registrar o projeto na solution
    \"Program Files"\dotnet\dotnet sln NomeArquivo.sln add NomeArquivo.Console/NomeArquivo.Console.csproj


// 
1º Criar .Net project no ícone principal do VS Code
2º Escolher Console App
3º Selecionar ou Criar a Pasta (Solution) que ficará o Console App
4º Colocar o Console App dentro da pasta criada
5º Nomeie o projeto com .Console
6º Selecione a extensão da Solução (Normalmente sln)
7º Confirme a localização do projeto

FIM - Criado uma solução com um projeto em Console App
//



Se estiver em outra pasta o dotnet:
--
\"Program Files"\dotnet\dotnet
--

path = c:\program files\dotnet;%path%


````markdown
# 💻 Setup do Ambiente de Programação em C# com VS Code no Windows

Este guia rápido vai te ajudar na configuração do Visual Studio Code (VS Code) para desenvolver programas em C# no Windows.

---

## ✅ Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado:

- **.NET SDK**: Baixe e instale a versão mais recente do .NET SDK (recomenda-se a versão LTS) em [dotnet.microsoft.com](https://dotnet.microsoft.com).
- **Visual Studio Code**: Baixe e instale o VS Code em [code.visualstudio.com](https://code.visualstudio.com).
- **Extensão C# para VS Code**: No VS Code, instale a extensão **C# Dev Kit** na aba de extensões (`Ctrl+Shift+X`).

**Verificação:**

Abra o terminal (no VS Code ou no Windows) e digite:

```bash
dotnet --version
````

Se retornar um número de versão (ex.: `8.0.x`), o .NET SDK está instalado corretamente.

---

## 📁 Estrutura de Soluções e Projetos

Em C#, uma **solução (.sln)** é como uma "caixa" que organiza um ou mais projetos. Cada **projeto** tem um propósito específico (ex.: um aplicativo de console, uma biblioteca, testes).

### Estrutura recomendada:

```
MinhaSolucao/
├── MinhaSolucao.sln
├── MeuProjeto/
│   ├── MeuProjeto.csproj
│   └── Program.cs
```

---

## 🛠️ Passo a Passo para Configurar uma Solução e Projeto

Siga estas etapas para criar e configurar um projeto de console em C# usando o terminal integrado do VS Code.

### 1. Criar uma Pasta para a Solução

* Crie uma pasta no seu computador (ex.: `C:\Projetos\MinhaSolucao`).
* Abra o VS Code e selecione `File > Open Folder` para abrir essa pasta.

### 2. Criar uma Solução

No terminal integrado do VS Code (`Ctrl+`):

```bash
dotnet new sln -n MinhaSolucao
```

> Cria um arquivo `MinhaSolucao.sln` na pasta atual.

### 3. Criar um Projeto de Console

No mesmo terminal:

```bash
dotnet new console -o MeuProjeto
```

> Cria uma pasta `MeuProjeto` com um projeto de console.

### 4. Vincular o Projeto à Solução

```bash
dotnet sln MinhaSolucao.sln add MeuProjeto/MeuProjeto.csproj
```

> Adiciona o projeto à solução.

### 5. Verificar os Projetos na Solução

```bash
dotnet sln MinhaSolucao.sln list
```

**Saída esperada:**

```
Project(s)
----------
MeuProjeto\MeuProjeto.csproj
```

### 6. Executar o Projeto

```bash
dotnet run --project MeuProjeto/MeuProjeto.csproj
```

> Compila e executa o programa no projeto especificado.

---

## ⚙️ Configuração do VS Code para Console Externo

Por padrão, o VS Code executa programas C# no terminal integrado. Para usar uma **janela de console externa no Windows**:

1. Abra as configurações do VS Code (`Ctrl+,`).
2. Pesquise por `Csharp Debug Console`.
3. Defina **Csharp > Debug: Console** como `externalTerminal`.

> Isso se aplica a execuções em modo de **depuração**.

---

## 💡 Comandos Úteis do .NET CLI

| Comando                                                           | Descrição                      |
| ----------------------------------------------------------------- | ------------------------------ |
| `dotnet new list`                                                 | Lista os templates disponíveis |
| `dotnet sln MinhaSolucao.sln remove MeuProjeto/MeuProjeto.csproj` | Remove o projeto da solução    |

---

## ❗ Resolução de Problemas Comuns

* **Erro:** `dotnet: command not found`
  → O .NET SDK não está instalado ou não está no `PATH`. Reinstale o SDK e verifique com `dotnet --version`.

* **Erro:** Projeto não encontrado na solução
  → Confirme que o caminho do `.csproj` está correto no comando `dotnet sln add`.

* **Saída não aparece no console externo**
  → Verifique se a configuração `Csharp > Debug: Console` está definida como `externalTerminal`.

* **VS Code não reconhece C#**
  → Certifique-se de que a extensão **C# Dev Kit** está instalada e que a pasta do projeto foi aberta corretamente.

---

## ✅ Exemplo Completo

1. Crie uma pasta chamada `ExemploSolucao` e abra-a no VS Code.
2. No terminal integrado, execute:

```bash
dotnet new sln -n ExemploSolucao
dotnet new console -o MeuAppConsole
dotnet sln ExemploSolucao.sln add MeuAppConsole/MeuAppConsole.csproj
dotnet run --project MeuAppConsole/MeuAppConsole.csproj
```

3. Edite o arquivo `MeuAppConsole/Program.cs` para adicionar seu código.
4. Execute novamente com:

```bash
dotnet run --project MeuAppConsole/MeuAppConsole.csproj
```

---

## 👶 Dicas para Iniciantes

* 🗂️ **Organize seus projetos**: Use nomes descritivos (ex.: `SistemaEscolar`, `ProjetoConsole`).
* 💾 **Salve com frequência**: Use `Ctrl+S` ou configure salvamento automático.
* 🖥️ **Use o terminal integrado**: Facilita a execução de comandos `dotnet` sem sair do VS Code.
* 📘 **Consulte a documentação oficial**: Veja mais sobre o .NET CLI em [docs.microsoft.com](https://docs.microsoft.com).

---

> ℹ️ Esse guia é um ponto de partida para quem quer programar em C# com leveza e eficiência no VS Code no Windows.

```


