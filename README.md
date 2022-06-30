# Desafio MVC .NET
Neste repositório encontra-se a resolução do desafio de MVC do programa Starter.
## Projeto Palmirinha Onofre
****
## Funcionalidades

Site de receitas onde o usuario consegue acessar e visiualizar as receitas disponíveis, na pagina principal é mostrado os cards em destaque que são marcados como favoritos pelo administrador.

### Para o Administrador

- Listar, adicionar, remover e alterar unidades de medidas;
- Listar, adicionar, remover e alterar ingredientes;
- Listar, adicionar, remover e alterar categorias;
- Listar, adicionar, remover e alterar receitas;
- Adicionar imagens ao sistema para utiliza-las nas receitas;
- visualizar grafico de acesso dos usuarios x receitas;
****
## Tecnologias utilizadas
- `Entitiy Framework`
- `.NET 5`
- `Xunit`
- `Jquery`
- `Ajax`
- `Auto Mapper`
- `JavaScript`
- `BootStrap`
- `Chart.js`
- `MySql`
- `Identity`
- `Data Tables`

## Banco de dados

Para a criação do sistema foi definido um relacionamento muitos para muitos, segue o diagrama E - R da aplicação:

<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/relacionamento.PNG">
</p>

Banco de dados utilizado no projeto é o MySql provedor de acesso Pomelo;

Ao abrir o projetol, ir para o diretorio desafio-mvc e dar o comando "dotnet ef database update" em seu terminal;

Ele populará o seu banco de dados com 8 receitas já cadastrada além disso habilitará a utilização dos testes, verificar as string de conexão antes de iniciar, caso for alterar a string de conexão, favor alterar ela nos metodos de teste também.

Para acesso ao sistema já estará disponível duas contas para utilizar.

- Acesso Administrador:
    Usuário: admin@gft.com
    senha: Gft@1234

- Acesso usuario:
    Usuário: usuario@gft.com
    senha: Gft@1234

## Detalhamento das Features

### Paginas do usuario

Para ter acesso inicial ao sistema é obrigatório que tanto o usuario quanto o admin estejam logado, a página não permitirá acesso anônimo.

A pagina inicial contém um Carousel e um botão que levará o usuario para todas as receitas do sistema, logo em seguida é mostrado os destaques que são as receitas com a propriedade IsPreferidos marcados como true, essa alteração pode ser feita na pagina do admin em editar as receitas.

pagina inicial:
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/imagen 2.PNG">
</p>

Na barra de navegação superior o usuario pode pesquisar pelo nome da receita ou pelo ingrediente e o sistema mostrará se tem alguma receita que contém o que foi buscado.

Ao clicar nos cards das receitas o usuario é levado para a pagina de detalhamento de cada receita aonde poderá ver suas informações e ter acesso ao conversor de medidas.
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/cards.PNG">
</p>

Para o usuario comum não será permitido acesso ao painel administrativo e o botão também não estará a mostra.

Na barra de navegação superior no canto direito terá a opção do usuario realizar o logoff ou do usuário clicar no seu nome e ir para pagina de configurações de perfil.

### Paginas do Administrador

Na area do administrador o usuario tem um menu lateral que pode ser encolhido através de um botão na barra superior.
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/Pagina adm.PNG">
</p>
No menu lateral pode-se navegar pelas seções de "Pagina Inicial" - "Dashboard" - "Categorias" - "Ingredientes" - "Unidade de Medidas" - "Receitas" - "Gerenciammento de Imagens".

Na seção "Pagina Inicial" leva o usuario para a pagina inicial de usuarios e das receitas.

Na seção "Dashboard" abre a pagina inicial do painel Administrativo com icons para levar o usuario para as outras abas e o grafico de usuarios x receitas em que na aba inferior é mostrado o Id da receita em que o usuario pode conferir na seção "receita" e na aba esquerda do gráfico é a quantidade de acessos que aquela receita teve.
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/acessoUsuario.PNG">
</p>

Na seção "Categorias" o usuario pode ver a lista completa das categorias cadastradas no sistema, ele pode criar, alterar ou deleta-las.

Na seção "Ingredientes" o usuario pode ver a lista completa dos ingredientes cadastrados no sistema, ele pode criar, alterar ou deleta-los.

Na seção "Unidade de Medidas" o usuario pode ver a lista completa das Unidades de Medidas cadastrados no sistema, ele pode criar, alterar ou deleta-los.

Na seção "Receitas" o usuario pode ver a lista completa das Receitas cadastradas no sistema, ele pode criar, alterar ou deleta-las.

Na seção "Gerenciamento de Imagens" o usuario pode ver as imagens cadastradas no servidor e verificar o nome delas para utilizar nas receitas, além disso o usuario pode adicionar imagens no servidor para serem utilizadas posteriormente.
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/Imagen.PNG">
</p>

na barra de navegação superior no canto direito se o usuario clicar no nome ele abrirá uma box em que pode realizar o ato de deslogar ou editar suas configurações.

## Exceeds

- Foi utilizado imagens no projeto;
- Criado conversor de Unidades;
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/Conversor.PNG">
</p>
- Criado testes unitários;
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/testes.PNG">
</p>
- No acesso Admin foi criado o historico de receitas preparadas pelos usuarios;
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/acessoUsuario.PNG">
</p>
- Ao se registar o usuario recebe um email de acesso a aplicação;
<p align="center">
    <img width = "470" src="/desafio-mvc/wwwroot/images/assets/email.PNG">
</p>
- Adicionado botões animados, cards com animações e carousel como elementos extra de front-end;
****
