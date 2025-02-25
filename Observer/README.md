# Observer

Definir uma dependência um para muitos entre objetos, de maneira que quando um objeto muda de estado todos os seus dependentes são notificados e atulizados automaticamente

Permite que um objeto (o sujeito ou subject) notifique automaticamente todos os seus dependentes (os observadores) sobre mudanças em seu estado, sem que o sujeito precise saber quem ou quantos observadores existem.

## Características principais do Observer:

- Desacoplamento: O sujeito (objeto que gera a mudança) não precisa conhecer os detalhes dos observadores, apenas notifica que algo mudou. Os observadores podem ser alterados ou removidos sem afetar o sujeito.
- Notificação automática: Quando o estado do sujeito muda, todos os observadores registrados são notificados automaticamente.
- Assinatura dinâmica: Observadores podem ser adicionados ou removidos dinamicamente durante a execução do programa
- Interface comum: O padrão define uma interface comum para os observadores, garantindo que todos implementem o método de atualização (Update).
- Relação de um para muitos: Um sujeito pode ter vários observadores, e todos recebem as mesmas notificações sobre mudanças no estado do sujeito.

## Quando usar:

- Quando alguns objetos em sua aplicação devem observar outros, mas por um tempo limitado ou casos específicos.
- Quando mudanças de um estado de um objeto podem precisar mudar outros objetos e o atual conjunto de objetos é desconhecido de antemão ou muda dinamicamente.
- O sujeito e os observadores devem ser desacoplados, permitindo flexibilidade para adicionar/remover observadores sem impactar o restante do sistema.
- Vários objetos precisam ser notificados sobre mudanças em outro objeto sem que o sujeito precise conhecer os detalhes dos observadores.
- A alteração do estado de um objeto precisa ser propagada automaticamente para outros objetos, como em sistemas de eventos ou interfaces gráficas.
- Você deseja uma relação de um para muitos entre o sujeito e os observadores, com notificações automáticas.
