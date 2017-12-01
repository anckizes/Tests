# Testes de Software

É parte essencial do desenvolvimento de software, e tem como principal objetivo encontrar falhas e bugs no código ou ainda ser base para a construção dele (veremos este em Test Driven Development). Testes servem para que se tenha certeza que o código escrito se comporta conforme o esperado do software.

O teste de software tem visão destrutiva do sistema, para evitar que este ocorra. Enquanto o desenvolvimento de software visa entregar alguma coisa com a execução do código, o teste avalia se em casos a aplicação irá parar e responder adequadamente, quebrar adequadamente e até funcionar adequadamente quando o teste for de sucesso.

## Teste de regressão.
Este teste é dedicado a manter um software funcionando de acordo com seus princípios quando nova versão for lançada. Por exemplo: Numa classe de descontos é validado sempre se o desconto é lançado como um negativo no proçe total. Isso garante que novas versões não farão o contrário.

## Tipos de teste

### Caixa Branca:

Este teste é sobre o código fonte do sistema, também chamado de teste estrutural aou teste orientado à lógica. Estes testes verificam se a o fluxo, os ciclos e os usos dos objetos estão coerentes. Este teste deve ser feito por quem possui domínio do código e da tecnologia utilizada. Estes testes podem ser de unidade, quando testam menores objetos e trechos de código atômicos, garantindo que na simplicidade do que este trecho deve fazer, faz-se de forma correta; tambem podem ser testes de integração onde são testadas as ligações com componentes externos aos códigos do sistema, como por exemplo o retorno de um banco de dados, serviço etc.

### Caixa Preta

Nos testes de caixa preta são testadaas funcionalidades servidas ao usuário sem que exista verificação intra código do que está sendo feito. Apenas é dada uma ou uma coleção de entradas e afere-se o resultado que a aplicação responde. Este teste pode ser executado automaticamente com ferramentas de repetição de uso (simulando um humano) ou até ser manual e feito por pessoas de negócio ou do próprio time de qualidade de software.


## TDD

TDD ou Test Driven Development (Desenvolvimento orientado à testes) é um conceito criado em 2003 por Dan North que orienta-nos a criar o código baseado em testes que a aplicação deve possuir. Exatamente camarada, primeiro o teste, depois o código. Por exemplo: Sabemos que dado um  estoque quando removermos um item então o contador deste item deve estar decrescido de 1 após a operação de remoção. Já nesta frase usamos o s termos "Dado", "Quando" e "Então" (Given, When, Then) que são a melhor forma de estruturar o significado do teste. Quando formos fazer os testes para aplicação o teste deve indicar qual o cenário inicial (Given), qual a ação tomada (When) e qual o resultado esperado após a ação (Then). Desta forma, além da programação ser iniciada de com o requisito do negócio, nos ajudando a não fugir do escopo da aplicação, o teste pode ser bolado pelo desenvolvedor do software, pelo PO, pelo gerente, pelo dono no negócio e mais.

Exemplo:
```
Dado um estoque com 5 Play Stations Quando um for retirado Então existirá 4 PlayStations no estoque.
```
Ou um teste em C#:

## BDD
BDD ou Behaviour Driven Development (Desenvolvimento orientado ao comportamento) é uma resposta ao TDD. Esta maneira de programar visa montar primeiramente as ações e funções que o sistema deverá ter, como isto deve ser implementado para então partir para a programação. A código é programado em blocos de funcionalidades de preferência em ordem que entregue melhor valor ao cliente, quando parte do programa já puder ser entregue.

## Agora um exemplo

A classe da aplicação é:
```cs
public class EasyMath
    {
        public int Increment (int a, int b)
        {
            return a + b;
        }
    }
```

Para testá-la fiz este teste de unidade em XUnit para DotNetCore:

```cs
[Fact]
public void Given_NTP_when_Inecremenr_recieves_two_Integers_should_return_a_number_higher_or_equal_both_given_numbers()
{
//Given
    Random random = new Random();
    int Int1 = random.Next();
    int Int2 = random.Next();
    EasyMath easyMaths = new EasyMath();
//When
    int result = easyMaths.Increment(Int1,Int2);
//Then
    Assert.True(Int1 <= result);
    Assert.True(Int2 <= result);
}
```

## Nomenclatura de testes

Nomes de testes devem expressar o cenário que estão testando. O teste uma funcionalidade simples e sem valor ao usuário quando isolada, deve ser feito também, estes são testes de regressão. Leia bem detalhadamente como descrevemos bem um teste usando o modelo Given WHen Then com Martin Fowler em: https://martinfowler.com/bliki/GivenWhenThen.html 


## Bibliografia

https://targettrust.com.br/blog/os-13-principais-tipos-de-testes-de-software/

https://pt.wikipedia.org/wiki/Teste_de_software

https://www.agilealliance.org/glossary/bdd

https://www.tableless.com.br/introducao-ao-behavior-driven-development/

https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test
