# Chain of Responsibility (Cadeia de Responsabilidade)

Evitar o acoplamento do remetente de uma solicitação ao seu receptor, ao dar a mais de um objeto a oportunidade de tratar a solicitação. Encadear os objetos receptores, passando a solicitação ao longo da cadeia até que um objeto a trate.

É um padrão de design comportamental que permite passar uma solicitação ao longo de uma cadeia de objetos até que um objeto na cadeia a processe. Ele desacopla o remetente da solicitação dos receptores, permitindo que múltiplos objetos tenham a oportunidade de tratar a solicitação, sem saber qual deles irá efetivamente tratá-la.

## Características principais do Chain Of Responsability Pattern:

- Desacoplamento: O remetente da solicitação não precisa saber qual objeto vai processá-la. Ele apenas envia a solicitação para o início da cadeia e a cadeia segue até encontrar um objeto que pode tratá-la.
- Cadeia de manipuladores: Cada objeto na cadeia é responsável por processar a solicitação ou passá-la adiante para o próximo objeto. Cada manipulador pode decidir se processa ou delega a solicitação.
- Flexibilidade: A cadeia pode ser configurada dinamicamente, alterando a ordem dos manipuladores conforme necessário.
- Extensibilidade: Novos manipuladores podem ser facilmente adicionados à cadeia sem a necessidade de alterar os objetos que a utilizam.

## Quando usar:

- Quando há múltiplos objetos que podem processar uma solicitação: Se você tiver várias classes que podem lidar com uma solicitação de forma diferente, a cadeia de responsabilidade permite passar a solicitação até o objeto adequado.
- Quando a solicitação pode ser tratada por diferentes objetos de forma condicional: Isso ocorre quando cada manipulador na cadeia pode ter critérios específicos para decidir se processa ou não a solicitação.
- Quando você precisa de uma forma flexível para adicionar ou remover manipuladores: A ordem de execução pode ser modificada de maneira dinâmica.
