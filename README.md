# ProjetoProcessos
Esse projeto serve para catalogar e organizar modelagens de processos.
No futuro irei adicionar meios para modificar detalhes de processos específicos.
Para garantir a segurança do usuário usamos método de Hash para as senhas, dessa forma quem tem acesso ao Banco de Dados, não terá acesso ás senhas dos usuários.
Os responsáveis pelo Projeto Integrador são: Welton Henrique, Vinicius, Wagner, Evanio e Ricardo. 

🚀 Funcionalidades

-- Cadastro de usuários com senha criptografada
-- Login com verificação de senha
-- Conexão com banco de dados MySQL
-- Interface gráfica simples (WinForms)
-- Validações de campos (telefone, datas, etc.)
-- Instalador que facilita a instalação do arquivo

🛠️ Tecnologias Utilizadas

-- C# (.NET Framework)
-- Windows Forms
-- MySQL
-- MySql.Data (NuGet)
-- BCrypt.Net (NuGet)

🔐 Segurança
-- As senhas são armazenadas de forma segura usando hash bcrypt, que impede que senhas sejam lidas diretamente do banco.
