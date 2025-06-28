# BlockchainApp

Este repositório contém uma implementação educacional de um blockchain simplificado utilizando C#. O projeto foi desenvolvido como material complementar para a disciplina Fundamentos do Blockchain na Pós-Tech FIAP.

## Objetivo

O objetivo deste projeto é apresentar, de forma prática e didática, os conceitos fundamentais do funcionamento de uma blockchain:

- Criação de blocos encadeados com hashes
- Geração de hash SHA-256
- Prova de trabalho (Proof of Work)
- Verificação de integridade da cadeia
- Conceito de imutabilidade
- Simulação de rede ponto a ponto (versão futura)

## Estrutura

O projeto está dividido em arquivos principais:

- `Block.cs` – Representa um bloco da cadeia, contendo dados, timestamp, nonce e hash.
- `Blockchain.cs` – Controla a cadeia de blocos, adicionando e validando blocos.
- `Program.cs` – Exemplo de uso: criação da cadeia, mineração e verificação.
- `Utils/HashHelper.cs` – Responsável pela geração de hash SHA-256.

## Como executar

Pré-requisitos:
- .NET SDK 6.0 ou superior

Passos para execução:

```bash
git clone https://github.com/SEU_USUARIO/BlockchainApp.git
cd BlockchainApp
dotnet run
