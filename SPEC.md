# Breve Especificação do Negócio

A aplicação deve ser capaz de resolver os principais problemas na gestão de uma pequena academia de Squash. Isto é, possuir um cadastro de alunos, um cadastro de produtos/serviços, agendamento de aula, agendamento de quadra, etc..

No entanto, como projeto inicial, será criado apenas um sistema para gerir o bar da academia. Os clientes da academia possuem créditos no bar para consumo ou podem consumir pagando à vista.

E esse sistema deve possuir os seguintes requisitos.

* CRUD de Clientes
    * Nome do Cliente,
    * Dados de contato (e-mail e telefone),
    * Endereço,

* CRUD de Produtos do Bar
    * Nome do Produto,
    * Descrição,
    * Preço atual,
    * Estoque,

* Um sistema de Carrinho 
    * Cliente,
    * Data da compra,
    * Produto e quantidade,
    * Preço de compra,

* Um sistema de créditos
    * Cliente
    * Saldo em créditos
    * Compra de créditos
