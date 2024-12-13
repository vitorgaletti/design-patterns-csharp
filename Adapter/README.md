# Adapter

O Adapter é um padrão de design estrutural que permite que uma interface existente seja 
adaptada para uma nova interface esperada pelo sistema. Em vez de modificar diretamente 
a interface ou o comportamento de uma classe, você cria uma "camada" adaptadora entre as 
duas interfaces para torná-las compatíveis.

## Quando usar:
- ****Integrar sistemas legados:**** Quando você tem um sistema antigo ou de terceiros com uma interface que não pode ser modificada, mas precisa ser integrado a um sistema mais novo que espera uma interface diferente.
- ****Trabalhar com interfaces diferentes:**** Quando você precisa usar classes ou bibliotecas com interfaces incompatíveis, mas não pode alterar o código-fonte delas.
- ****Substituir ou trocar implementações:**** Quando você quer usar uma implementação diferente de uma classe, mas essa nova implementação tem uma interface incompatível com o código que já foi desenvolvido

## Quando evitar:
- ****Quando há mudanças frequentes na interface:**** Se a interface que você está tentando adaptar muda frequentemente, pode ser mais difícil de manter o Adapter.
- Quando a interface já é compatível ou se as mudanças frequentes tornam a adaptação difícil de manter.