# Decorator

Dinamicamente, agregar responsabilidades adicionais a objetos. Os Decorator fornecem uma alternativa flexível ao usuo de subclasses para extensão de funcionalidades

Ele permite adicionar comportamento a um objeto de maneira dinâmica, sem alterar o código original da classe. Isso é feito "envolvendo" o objeto com outro objeto que adiciona funcionalidades extras.

## Características principais do Decorator Pattern:

- Adiciona comportamento dinamicamente ao objeto.
- Composição: A adição de comportamentos ocorre através da composição de objetos (não herança).
- Flexibilidade: Permite adicionar múltiplos decoradores e combinar comportamentos.
- Interface consistente: A interface do objeto decorado permanece a mesma.
- Não altera o código original da classe base, mantendo a classe original intacta.
- Modularidade: Facilita a extensão de funcionalidades sem a necessidade de criar subclasses complexas.

## Quando usar:

- Quando você deseja adicionar comportamentos ou funcionalidades a objetos de maneira dinâmica e flexível.
- Quando quer evitar uma explosão de subclasses para diferentes combinações de comportamentos.
- Quando deseja seguir os princípios SOLID, especialmente o aberto para extensão, fechado para modificação.
- Quando você precisa separar responsabilidades de maneira modular e coesa.
- Quando você precisa de composição e flexibilidade no comportamento do objeto em tempo de execução.
