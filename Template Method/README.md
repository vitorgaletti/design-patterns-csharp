# Template Method

Definir o esqueleto de um algoritmo em uma operação, postergando alguns passos
para as subclasses. Template Method permite que subclasses redefinam certos passos
de um algoritmo sem mudar a estrutura do mesmo

É um padrão de projeto comportamental que define a estrutura de um algoritmo, delegando parte do comportamento para subclasses. Esse padrão permite que as subclasses redefinam certos passos do algoritmo sem alterar a estrutura geral.

## Características principais do Template Method Pattern:

- Reusabilidade: O comportamento comum é centralizado na classe base, enquanto as variações específicas são delegadas para as subclasses.
- Extensibilidade: Novos tipos de processamento de arquivo podem ser adicionados facilmente criando novas subclasses.
- Consistência: O esqueleto do algoritmo permanece o mesmo, garantindo consistência em toda a aplicação.

## Quando usar:

- Quando quiser deixar os clientes extenderem apenas etapas particulares de um algoritmo, mas não todo algoritmo e sua estrutura;
- Quando o algoritmo tem uma estrutura comum, mas algumas etapas precisam ser personalizadas.
- Para manter a flexibilidade nas etapas do algoritmo sem mudar sua estrutura.
