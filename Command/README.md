# Command

Encapsular uma solicitação como objeto, desta forma permitindo parametrizar cliente com diferentes solicitações, enfileirar ou fazer o registro de solicitações e suportar operações que podem ser desfeitas.

Desacoplar o objeto que envia a solicitação (chamador) daquele que recebe a solicitação (receptor). Ao invés de chamar diretamente métodos em objetos, você cria comandos encapsulados em objetos específicos, o que torna o código mais flexível, reutilizável e mais fácil de manter.

## Características principais do Command:

- Encapsula solicitações como objetos: Ação ou solicitação é transformada em um objeto, permitindo maior flexibilidade.
- Desacoplamento: Separa quem faz a solicitação (Invoker) de quem executa a ação (Receiver).
- Extensibilidade: Facilita a adição de novos comandos sem alterar o código existente.
- Armazenamento de comandos: Permite enfileirar ou armazenar comandos para execução posterior.
- Suporte para "desfazer" e "refazer": Possibilita a reversão de ações, mantendo o histórico de comandos.
- Reusabilidade: Comandos podem ser reutilizados em diferentes contextos.

## Quando usar:

- Quando você precisa separar quem solicita a ação de quem a executa.
- Quando implementar funcionalidades de "desfazer" ou "refazer".
- Quando comandos precisam ser enfileirados ou executados em momentos diferentes.
- Quando encapsular uma sequência de comandos em um único comando (macro).
- Quando deseja adicionar novos comandos sem alterar o código existente.
