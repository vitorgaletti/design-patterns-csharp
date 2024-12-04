# Builder

Separar a construção de um objeto completo de sua representação de modo que o mesmo processo de
construção possa criar diferentes representações.

Classe Builder será responsável por configurar a classe principal e também responsável por 
retornar o objeto pronto.

## Características principais do Builder Pattern:
- Separação da Construção da Representação: O processo de construção do objeto é separado da sua representação final.
- Flexibilidade: Permite criar diferentes representações de um objeto com o mesmo código de construção.
- Encapsulamento: A lógica de construção de um objeto é encapsulada dentro de uma classe específica (o "Builder").
- Imutabilidade: Frequentemente, o objeto final gerado por um builder é imutável, ou seja, após sua construção, ele não pode ser modificado.


## Quando usar:
- Quando você precisa criar objetos complexos com diferentes combinações de características.
- Quando a criação de um objeto requer uma série de etapas ou quando a ordem das etapas é importante.
- Quando você deseja manter o código cliente desacoplado da construção do objeto.

