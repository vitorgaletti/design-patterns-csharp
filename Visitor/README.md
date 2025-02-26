# Visitor

Representar uma operação a ser executada nos elementos de uma estrutura de objetos. Visitor permite definir uma nova operação sem mudar as classes dos elementos sobre os quais opera

É um padrão comportamental que permite adicionar novas operações a uma estrutura de objetos sem modificar as classes dessas estruturas. Em outras palavras, ele permite que você defina uma nova operação em uma hierarquia de objetos sem alterar as classes dessas hierarquias.

## Características principais do Visitor:

- Separação de Operações e Estruturas de Objetos: Permite adicionar novas operações a uma estrutura de objetos sem modificar suas classes.
- Interface Visitor: Define métodos de visita específicos para cada tipo de elemento na estrutura de objetos.
- Método Accept: As classes de elementos (ou objetos) possuem um método Accept, que recebe um visitante e delega a execução de operações para ele.
- Extensibilidade: Facilita a adição de novas operações (novos visitantes) sem modificar os elementos existentes.
- Centralização de Operações: As operações ficam centralizadas na implementação do visitante, tornando o código mais organizado e facilitando a manutenção.
- Polimorfismo: Através do polimorfismo, o visitante pode realizar diferentes ações dependendo do tipo do elemento visitado.

## Quando usar:

- Você tem uma estrutura de objetos estável e deseja adicionar novas operações a ela sem modificar suas classes.
- Precisa realizar operações diferentes sobre os elementos de uma estrutura, mas mantendo o código organizado e centralizado.
- Evitar modificar frequentemente as classes de elementos, concentrando as operações em visitantes externos.
