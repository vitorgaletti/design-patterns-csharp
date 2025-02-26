# Strategy

Definir uma dependência um para muitos entre objetos, de maneira que quando um objeto muda de estado todos os seus dependentes são notificados e atulizados automaticamente

O objetivo é permitir que o algoritmo que está sendo utilizado em um determinado contexto seja selecionado dinamicamente em tempo de execução, sem alterar o código cliente que o utiliza.

## Características principais do Strategy:

- Desacoplamento: O padrão permite que a lógica de negócios seja separada do comportamento que pode ser alterado (os algoritmos), proporcionando maior flexibilidade e reutilização de código.
- Substituição de Algoritmos: Ele permite a troca de algoritmos de maneira dinâmica, ou seja, podemos mudar a estratégia utilizada sem precisar alterar o código cliente.
- Facilidade de Extensão: Novos algoritmos podem ser adicionados sem a necessidade de modificar o código existente. Isso segue o princípio aberto/fechado (Open/Closed Principle), onde o código é aberto para extensão, mas fechado para modificação.

## Quando usar:

- Existirem múltiplos algoritmos ou comportamentos que podem ser intercambiáveis.
- Você quiser evitar condicionais complexas (como if ou switch) espalhadas pelo código para escolher qual algoritmo usar.
- Precisar mudar o comportamento de uma classe dinamicamente em tempo de execução sem alterar o código cliente.
- Quiser facilitar a extensão do código: adicionar novos comportamentos sem modificar classes existentes.
