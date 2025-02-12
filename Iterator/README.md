# Iterator

Fornecer um meio de acessar, sequencialmente, os elementos de um objeto agregado
sem expor sua representação subjacente

O padrão Iterator permite que você percorra todos os elementos de uma coleção de objetos sem precisar entender ou lidar diretamente com a estrutura da coleção (se é uma lista, pilha, fila, etc.). Ele separa a lógica de navegação (iterar) da coleção em si.

## Características principais do Iterator:

- Acesso sequencial: Permite percorrer os elementos de uma coleção de forma sequencial.
- Independência da estrutura: Oculta a estrutura interna da coleção, permitindo que ela seja alterada sem afetar o código que a itera.
- Encapsulamento: Esconde a complexidade de navegação pela coleção.
- Fácil navegação: Simplifica a iteração, evitando o uso de índices e loops complexos.
- Suporte para diferentes coleções: Funciona bem com diversos tipos de coleções (listas, pilhas, filas, etc.).
- Facilidade de extensão: Novo tipo de coleção ou iteração pode ser adicionado facilmente sem alterar o restante do código.

## Quando usar:

- Quando você precisa percorrer diferentes tipos de coleções (listas, pilhas, filas) de maneira consistente, sem depender da estrutura interna delas.
- Quando deseja separar a lógica de iteração da estrutura de dados, permitindo que a coleção seja modificada sem afetar o código de navegação.
- Quando precisa percorrer grandes coleções ou coleções complexas de forma simples e sem se preocupar com índices ou implementações internas.
  -Quando deseja oferecer diferentes tipos de iteração (por exemplo, ordem inversa ou aleatória) sem mudar a estrutura da coleção.
