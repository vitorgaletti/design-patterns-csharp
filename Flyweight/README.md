# Flyweight

Usar compartilhamento para suportar eficientemente grandes quantidades de objetos de granularidade fina.

É um padrão de design estrutural que visa reduzir o consumo de memória e melhorar o desempenho de sistemas que lidam com um grande número de objetos semelhantes. Esse padrão é especialmente útil quando temos muitos objetos que compartilham um conjunto comum de características, mas que não precisam ser armazenados de forma independente. Em vez de criar uma instância separada para cada objeto, o Flyweight permite que objetos "comuns" sejam compartilhados, economizando memória.

## Características principais do Flyweight Pattern:

- Compartilhamento de Objetos: Objetos semelhantes são compartilhados, evitando a criação de múltiplas instâncias idênticas.
- Estado Intrínseco e Extrínseco:
  - Intrínseco: Dados imutáveis compartilhados entre instâncias.
  - Extrínseco: Dados variáveis fornecidos externamente, como posição ou contexto.
- Fábrica de Flyweights: Gerencia a criação e reutilização de instâncias compartilhadas.
- Objetos Imutáveis: O estado intrínseco é imutável para garantir segurança no compartilhamento.
- Economia de Memória: Reduz o uso de memória ao compartilhar objetos semelhantes.
- Melhoria de Desempenho: A redução no número de objetos instanciados melhora a performance, especialmente em sistemas com grande quantidade de objetos.

## Quando usar:

- Quando o sistema precisa gerenciar grandes quantidades de objetos de forma eficiente, especialmente quando muitos objetos compartilham um grande número de características em comum.
- Quando a criação de muitos objetos idênticos de maneira isolada causa problemas de desempenho ou consome muita memória.
