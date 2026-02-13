# Validador de Cartão de Crédito

## Descrição

Aplicação web desenvolvida em ASP.NET Core que valida números de cartão de crédito e identifica automaticamente a bandeira correspondente.

## Funcionalidades

- **Validação de Cartões**: Verifica se o número do cartão está no formato correto para a bandeira
- **Identificação de Bandeiras**: Reconhece as seguintes bandeiras:
  - MasterCard
  - Visa (16 Dígitos)
  - American Express
  - Diners Club
  - Discover
  - EnRoute
  - JCB
  - Voyager
  - HiperCard
  - Aura

- **Interface Web Intuitiva**: Formulário simples para inserção de números de cartão
- **Processamento em Tempo Real**: Validação instantânea com resultado imediato
- **Sanitização de Entrada**: Remove automaticamente caracteres não numéricos

## Tecnologias Utilizadas

- ASP.NET Core
- Razor Pages
- C#
- Expressões Regulares (Regex)

## Como Usar

1. Acesse a aplicação através do navegador
2. Digite ou cole o número do cartão de crédito no campo de entrada
3. Clique no botão de validação
4. A aplicação exibirá:
   - Se o cartão é válido
   - Qual é a bandeira do cartão

## Requisitos

- .NET 10.0 ou superior
- Navegador web moderno

