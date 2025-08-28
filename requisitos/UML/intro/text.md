NOME: Realizar transferência
AOTRES: Cliente
Pré-confição: O ator deve ser um cliente com conta ativa.

Fluxo principal:

1.[in]: o cliente realiza a identificação.
2.[out]: Validar identificação.
3.[in]: Escolher o tipo de transferência.
4.[in]: Informar destino.
5.[in]: Informar valor da transferência.
6.[out]: Consultar saldo.
7.[in]: Confirmar dados da tranferência.
8.[in]: Informar senha.
9.[out]: Validar senha.
10.[out]: Debitar valor na conta.

Floxo alternativo:
2a: indetificação incorreta.
    a. Mostrar mensagem de erro.
    b. Retornar para passo 1 (se errar 3x encerra o processo).

4a Destino inválido.
    a. Mostrar mensagem de erro.
    b. Voltar ao passo 4.

6a Saldo insufuciente.
    a. Mostrar mensagem de saldo insuficiente.
    b. Encerra processo.

7a Dados não confirmados.
    a. Voltar ao passo 3.

9a Senha incorreta.
    a. Repetir até 3x.

11a Gerar comprovante de pagamento.

Extends: 
- Mostrar mensagens de erro.
- Gerar comprovante

Includs: 
- Validar login.
- Validar saldo.
- Validar senha.