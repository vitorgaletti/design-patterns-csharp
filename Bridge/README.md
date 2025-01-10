# Bridge

O padrão Bridge é um padrão estrutural utilizado para separar abstrações de suas implementações, permitindo que ambas variem independentemente.

## Quando usar:

- Dividir uma classe monolítica: Para separar uma classe grande em componentes menores e mais gerenciáveis.

- Diversas variantes das mesmas funcionalidades: Quando há a necessidade de diferentes implementações para uma mesma funcionalidade.

## Prós:

- Classes independentes de plataforma: Permite criar classes que não dependem de uma plataforma específica.

- Abstrato e fechado: Segue o princípio do aberto/fechado, permitindo extensões sem alterações.

- Responsabilidade única: As classes têm responsabilidades bem definidas, facilitando a manutenção.

## Contras:

- Código mais complicado: O número de classes e a necessidade de organização tornam o código mais complexo.
