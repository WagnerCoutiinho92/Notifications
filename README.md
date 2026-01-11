# RabbitMQ.Notifications

Projeto de demonstração de arquitetura orientada a eventos utilizando .NET, com separação entre API e Worker para processamento assíncrono de notificações.

## 🧠 Visão geral

O objetivo deste projeto é demonstrar:
- Publicação de eventos de domínio
- Processamento assíncrono via Worker Service
- Desacoplamento entre produtor e consumidor
- Facilidade de troca do mecanismo de mensageria

## 🏗️ Arquitetura

- **Notification.Api**
  - Responsável por expor endpoints HTTP
  - Publica eventos de domínio

- **Notification.Worker**
  - Worker Service responsável por consumir e processar eventos

- **Notification.Domain**
  - Contém eventos e contratos compartilhados
  - Não depende de infraestrutura

## 🔄 Mensageria (InMemory)

Para facilitar a execução local e o entendimento da arquitetura, a mensageria foi implementada inicialmente de forma **InMemory**, utilizando abstrações (`IMessageBus`).

⚠️ **Observação importante**  
A implementação InMemory funciona apenas dentro do mesmo processo.  
Como a API e o Worker são executados em processos distintos, o transporte InMemory não realiza a comunicação entre eles.

Essa limitação é intencional e documentada, pois o foco do projeto é demonstrar a arquitetura e não simular incorretamente um broker distribuído.

## 🚀 Evolução planejada

O projeto está preparado para evolução para um broker real, como:
- RabbitMQ
- Azure Service Bus
- Kafka

A troca pode ser feita substituindo a implementação de `IMessageBus`, sem impacto no domínio ou nos consumidores.

## 🛠️ Tecnologias

- .NET
- Worker Service
- Arquitetura orientada a eventos
- Mensageria desacoplada

## 📌 Status do projeto

✔️ Estrutura arquitetural concluída  
✔️ Publicação de eventos via API  
✔️ Worker preparado para consumo assíncrono  
⏳ Integração com broker real (planejada)
