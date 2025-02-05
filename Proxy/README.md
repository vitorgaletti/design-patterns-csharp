# Proxy

Fornecer um substituto ou marcador da localização de outro objeto para controlar
o acesso a esse objeto

É um padrão estrutural que fornece um substituto ou representante para um objeto, controlando o acesso a ele. Permite que criar um objeto que age como intermediário, proporcionando controle sobre como e quando o objeto real é acessado.

## Características principais do Proxy Pattern:

- Virtual Proxy: Usado para controlar o acesso a objetos que são caros para serem criados (por exemplo, objetos grandes ou complexos). A criação do objeto real é adiada até que seja realmente necessário.
- Remote Proxy: Serve como um representante de um objeto em um sistema distribuído, ou seja, um objeto remoto que está em um servidor diferente.
- Protection Proxy: Controle de acesso, onde o proxy serve para garantir que somente usuários ou processos autorizados possam acessar o objeto real.
- Cache Proxy: Ele armazena resultados previamente calculados para evitar que o objeto real seja processado novamente.

## Quando usar:

- Quando precisa controlar o acesso a um objeto (por exemplo, com autenticação ou autorização).
- Quando o objeto real precisa de lazy loading (inicialização preguiçosa) ou caching.
- Quando precisa de um intermediário para objetos remotos em um sistema distribuído.
- Quando há a necessidade de monitoramento, logging ou auditoria do acesso ao objeto real.
- Quando deseja proteger o acesso ao objeto real com verificações ou condições adicionais.
