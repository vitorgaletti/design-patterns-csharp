# Composite

Compor objetos em estruturas de árvore para representar hierarquia partes-todo.
Composite permite aos clientes tratarem de maneira uniforme objetos individuais e
composições de objetos;

Esse padrão é útil quando você tem uma estrutura hierárquica de objetos, e você precisa tratar grupos de objetos e objetos individuais de maneira similar.

## Características principais do Composite Pattern:

- Estrutura hierárquica: Cria uma árvore de objetos.
- Interface comum: Folhas e compostos implementam a mesma interface.
- Transparência: O cliente não precisa se preocupar com o tipo do objeto (folha ou composto).
- Recursividade: A composição pode ser recursiva (com objetos compostos contendo outros compostos).
- Flexibilidade: Facilita a expansão sem alterar o código cliente.
- Independência de composição: Permite que operações sejam feitas de maneira uniforme, independentemente da profundidade da árvore.
- Simplicidade no cliente: O cliente pode interagir com a árvore sem se preocupar com as diferenças entre folhas e objetos compostos.

## Quando usar:

- Quando você quer tratar tanto objetos simples quanto compostos de forma similar.
- Quando você prevê que novos tipos de objetos serão adicionados, mas não quer alterar o código existente.
- Quando o sistema envolve processamento de objetos de maneira recursiva (como com árvores de diretórios, componentes gráficos, etc.).
- Quando você quer que o código cliente interaja com a árvore de objetos sem se preocupar com sua profundidade ou composição interna.
