# State

Definir uma dependência um para muitos entre objetos, de maneira que quando um objeto muda de estado todos os seus dependentes são notificados e atulizados automaticamente

É um padrão de design comportamental que permite que um objeto altere seu comportamento quando seu estado interno muda. Esse padrão ajuda a evitar o uso excessivo de instruções if-else ou switch que tentam controlar o comportamento do objeto em diferentes estados.

## Características principais do State:

- Mudança de Comportamento: Permite que um objeto altere seu comportamento quando seu estado interno muda.
- Encapsulamento de Estados: Cada estado é representado por uma classe separada que implementa o comportamento específico.
- Contexto Delegado: O objeto principal (Contexto) delega a responsabilidade de comportamento para os estados concretos.
- Facilidade de Extensão: Novos estados podem ser facilmente adicionados sem modificar o código existente.
- Eliminação de Condicionais: Reduz o uso de condicionais (if, switch), já que o comportamento é definido dentro das classes de estado.

## Quando usar:

- Comportamento variável: Um objeto muda seu comportamento dependendo de seu estado interno.
- Evitar condicionais complexas: O uso de if ou switch para gerenciar estados se torna difícil de manter.
- Sistema com múltiplos estados: O sistema precisa gerenciar vários estados que alteram o comportamento de um objeto de maneira distinta.
