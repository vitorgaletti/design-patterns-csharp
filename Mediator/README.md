# Mediator

Definir um objeto que encapsula a forma como um conjunto de objetos interage.
O Mediator promove o acoplamento fraco ao evitar que os objetos se refiram uns aos
outros explicitamente e permitir variar suas interações independentemente.

É um padrão de design comportamental que centraliza a comunicação entre objetos em um único ponto de interação (o "mediador"), evitando que os objetos se comuniquem diretamente entre si. Isso reduz o acoplamento e facilita a manutenção do código.

## Características principais do Mediator:

- Centralização da Comunicação: Todos os objetos interagem com o mediador, e não diretamente uns com os outros.
- Desacoplamento: Reduz a dependência entre os objetos, pois eles não precisam saber de outros objetos além do mediador.
- Facilidade de Manutenção: Modificar a lógica de comunicação é mais fácil, pois ela está centralizada.
- Encapsulamento de Comportamentos: O mediador controla e coordena as interações entre os objetos, encapsulando as regras de comunicação.

## Quando usar:

- Quando você tem um sistema com muitos objetos que precisam interagir, e a comunicação entre eles torna-se complexa e difícil de gerenciar.
- Quando a lógica de interação entre os objetos é mutável ou complexa, e você quer evitar que todos os objetos conheçam todos os outros objetos.
- Quando deseja reduzir o acoplamento entre as classes, tornando o sistema mais flexível e fácil de modificar.
- Quando é difícil mudar alguma classe porque ela está acoplada a outra classe.
- Quando você não pode reutilizar o componente em um programa diferente, porque ele é muito dependente de outros componentes
