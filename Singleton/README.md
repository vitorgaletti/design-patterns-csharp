# Singleton

Garantir que uma classe tenha somente uma instância e fornece um ponto global de acesso 
para a mesma.

É utilizado quando precisa de uma única instância de uma classe, que será compartilhada 
por todas as partes do sistema.

## Quando usar:
- O padrão é útil quando você quer garantir que apenas uma instância de uma classe seja criada e compartilhada em todo o programa, como gerenciadores de recursos (ex.: conexões com banco de dados, caches, gerenciadores de configuração).
- Se precisa de controle sobre a criação da instância (por exemplo, inicializando-a apenas quando necessário), o Singleton ajuda a garantir esse controle.
- Se a criação de uma instância de uma classe é cara em termos de tempo ou recursos, o Singleton pode ajudar a evitar a recriação desnecessária dessa instância, garantindo que seja criada uma vez e reutilizada.

## Exemplos de uso do Singleton:
- Loggers: Para evitar que múltiplas instâncias de um objeto de log sejam criadas.
- Conexões com o banco de dados: Para manter uma única conexão ativa durante a execução do sistema.
- Configurações globais: Para acessar configurações de uma maneira centralizada

## Quando evitar:
- Quando a classe precisa ser extensível ou ter várias instâncias (por exemplo, se o comportamento da instância precisar ser alterado em diferentes contextos).
- Quando o padrão se tornar um "anti-padrão" no seu projeto, criando dependências excessivas e dificultando os testes.
- Problemas em ambientes multithread: Se não for implementado corretamente, o Singleton pode criar problemas de concorrência, como a criação múltipla de instâncias em ambientes multithread.