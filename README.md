# 🛡️ EnerGenius Acessível – Sistema de Apoio a Pessoas Vulneráveis durante Apagões

## 🌟 Visão Geral

Durante apagões causados por eventos climáticos extremos, pessoas com deficiência são as mais impactadas. A ausência de luz, internet e comunicação pode colocar vidas em risco.

O **EnerGenius Acessível** é uma solução inovadora, inclusiva e resiliente que funciona **mesmo sem internet ou energia elétrica**. Coloca a acessibilidade no centro da inovação e propõe:

- 📹 Detecção de gestos ou quedas via câmera (MediaPipe)
- 🚨 Acionamento de alertas visuais e sonoros automaticamente
- 🔗 Comunicação offline via Bluetooth com vizinhos ou cuidadores
- 📱 App acessível com comandos por voz, rotas seguras e feedback tátil
- 🔐 Proteção de dados com criptografia mesmo offline

---

## 👩‍💻 Integrantes

- **Julia Palomari** — RM: 551910  
- **Julia Ortiz** — RM: 550204  
- **Leticia Baptista** — RM: 550289  

---

## 💻 Módulo em C# – Painel de Controle Local

### 🎯 Objetivo
Desenvolver um **painel de controle desktop** que permita:
- Gerenciar pessoas vulneráveis
- Registrar alertas emergenciais
- Gerar relatórios locais e logs offline

---

## ✅ Funcionalidades Implementadas

- [x] **Login obrigatório**
- [x] Cadastro de usuários vulneráveis
- [x] Registro de alertas com tipo e local
- [x] Logs com data/hora automática
- [x] Listagem de moradores e alertas
- [x] Tratamento robusto de exceções com `try-catch`

---

## 🧩 Estrutura de Classes

- `Pessoa`: Classe base com nome e endereço  
- `PessoaVulneravel`: Herda de Pessoa com tipo de deficiência  
- `Alerta`: Representa evento emergencial (queda, gesto, etc.)  
- `SistemaCentral`: Controla o menu principal e funcionalidades  
- `Login`: Autenticação de usuários

---

## 📋 Requisitos Atendidos

### Funcionais
- Cadastro e listagem de pessoas vulneráveis
- Registro de alertas com logs automáticos
- Acesso restrito por login
- Interface simples via terminal

### Não Funcionais
- Estrutura modular, com herança e encapsulamento
- Código limpo e bem indentado
- Erros tratados adequadamente (entradas inválidas, campos vazios)

---
