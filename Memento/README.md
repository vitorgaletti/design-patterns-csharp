# Memento

Sem violar o encapsulamento, capturar e externalizar um estado interno de um objeto, de maneira que o objeto possa ser restaurado para esse estado mais tarde

É um padrão de design comportamental que permite capturar e armazenar o estado interno de um objeto sem expor sua estrutura interna. Isso possibilita que o estado do objeto seja restaurado posteriormente, sem violar o princípio de encapsulamento.

## Características principais do Memento:

- Captura do Estado: O padrão permite que o estado de um objeto seja salvo em um momento específico.
- Restaurar o Estado: O estado salvo pode ser restaurado, permitindo desfazer alterações no objeto.
- Separação de Responsabilidades: O Memento mantém a responsabilidade de "salvar e restaurar" separada do objeto que está sendo observado, evitando que ele tenha conhecimento sobre seu próprio estado.
- Memento é Imutável: Uma vez criado, o memento não pode ser modificado, garantindo a integridade do estado salvo.

## Quando usar:

- Quando for necessário oferecer a funcionalidade de desfazer/refazer em uma aplicação.
- Quando o estado de um objeto precisa ser salvo e restaurado sem expor a sua estrutura interna.
- Quando for necessário salvar o estado de um objeto em diversos momentos, para possibilitar a recuperação do estado em um momento anterior.
