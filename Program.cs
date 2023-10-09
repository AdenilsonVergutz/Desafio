using DevExpress.XtraCharts;
using DevExpress.XtraTreeMap;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace Desafio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.teste
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}



//ALTER TABLE tbUsuario ADD bio VARCHAR(250)
//ALTER TABLE tbUsuario ADD slug VARCHAR(50)
//ALTER TABLE tbUsuario ADD email VARCHAR(50)


//  update tbUsuario set bio = 'Bio teste'
//  update tbUsuario set slug = 'Slug teste'
//  update tbUsuario set email = 'adenilson@teste.com'





//CREATE DATABASE[Servico]
//GO

//USE[Servico]
//GO

//DROP TABLE [tbAutor]
//DROP TABLE[tbPost]


//CREATE TABLE[tbAutor] (
//    [Id] INT NOT NULL,
//    [nome] VARCHAR(80) NOT NULL,

//    [cpf] CHAR (14) NULL,

//    [telefone] char (14) NULL,

//    [endereco] VARCHAR(100) NULL,

//    [bairro] VARCHAR(100) NULL,

//    [cidade] VARCHAR(100) NULL,

//    [estado] VARCHAR(100) NULL,

//    [dataDia] VARCHAR(20) NULL,

//    [cadastradoPor] VARCHAR(50) NULL,

//    CONSTRAINT[PK_IdAutor] PRIMARY KEY([Id]),
//	CONSTRAINT[UQ_AutorNome] UNIQUE([nome])


//)

//CREATE TABLE[tbCategoria] (
//    [Id] INT NOT NULL  IDENTITY(1, 1) ,
//    [nome] VARCHAR(80) NOT NULL,
//    [descricao] VARCHAR(max) NULL,
//    [observacao] VARCHAR(max) NOT NULL,
//    [dataDia] VARCHAR(20) NULL,
//    [cadastradoPor] VARCHAR(50) NULL,
//    [valor] DECIMAL(10,2) NULL

//    CONSTRAINT[PK_Category] PRIMARY KEY([Id]),
//	CONSTRAINT[UQ_Category_nome] UNIQUE([nome])

//)


//CREATE TABLE[tbTag] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [nome] VARCHAR(80) NOT NULL,

//    [dataDia] VARCHAR(20) NULL,

//    [cadastradorPor] VARCHAR(50) NULL,

//    CONSTRAINT[PK_Tag] PRIMARY KEY([Id]),
//	CONSTRAINT[UQ_Tag_nome] UNIQUE([nome])
//	)


//CREATE TABLE[tbPost] (

//    [Id] INT NOT NULL,
//    [IdCategoria] INT NOT NULL,
//    [IdAutor] INT NOT NULL,
//    [TagId] INT NULL,
//    [Titulo] VARCHAR(160) NOT NULL,
//    [Slug] VARCHAR(80) NOT NULL,
//[dataDia] VARCHAR(20) NULL,

//[cadastradorPor] VARCHAR(50) NULL,


//     CONSTRAINT[PK_Post] PRIMARY KEY([Id], [IdAutor]),
//     CONSTRAINT[FK_tbPost_tbCategoria_id] FOREIGN KEY([IdCategoria]) REFERENCES[tbCategoria]([Id]),
//     CONSTRAINT[FK_Post_AutorId] FOREIGN KEY([IdAutor]) REFERENCES[tbAutor]([Id]),
//     CONSTRAINT[FK_Post_Tag] FOREIGN KEY([TagId]) REFERENCES[tbTag]([Id]),

//)



//CREATE TABLE[tbPerfil] (

//    [idPerfil] INT NOT NULL,
//    [nome] VARCHAR(20) NOT NULL,

//   CONSTRAINT[PK_Perfil] PRIMARY KEY([idPerfil]),
//   CONSTRAINT[UQ_Perfil_Nome] UNIQUE([nome])


//)

//DROP TABLE[tbUsuario]

//CREATE TABLE[tbUsuario] (

//    [idUsuario] INT NOT NULL,
//    [usuario] VARCHAR(50) NOT NULL,
//    [senha] VARCHAR(50) NOT NULL,
//    [repitaSenha] VARCHAR(50) NOT NULL,
//    [nivelAcesso] VARCHAR(20) NOT NULL,
//    [dataDia] VARCHAR(20) NULL,
//    [cadastradorPor] VARCHAR(50) NULL,
//    [bio] VARCHAR(250) NULL,
//    [slug] VARCHAR(50) NULL,
//    [email] VARCHAR(50) NOT NULL,


//   CONSTRAINT[PK_Usuario] PRIMARY KEY([idUsuario]),

//)




























//Script para criar banco

//CREATE DATABASE[Servico]
//GO

//USE[Servico]
//GO

//CREATE TABLE[tbAutor] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [nome] VARCHAR(80) NOT NULL,

//    [cpf] CHAR (14) NULL,

//    [telefone] char (14) NULL,

//    [endereco] VARCHAR(100) NULL,

//    [bairro] VARCHAR(100) NULL,

//    [cidade] VARCHAR(100) NULL,

//    [estado] VARCHAR(100) NULL,

//    [dataDia] VARCHAR(20) NULL,

//    [cadastradoPor] VARCHAR(50) NULL,

//    CONSTRAINT[PK_IdAutor] PRIMARY KEY([Id]),
//	CONSTRAINT[UQ_AutorNome] UNIQUE([nome])


//)

//CREATE TABLE[tbCategoria] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [nome] VARCHAR(80) NOT NULL,
//    [descricao] VARCHAR(max) NULL,
//    [observacao] VARCHAR(max) NOT NULL,

//    [dataDia] VARCHAR(20) NULL,

//    [cadastradoPor] VARCHAR(50) NULL,

//    [valor] DECIMAL(10,2) NULL

//    CONSTRAINT[PK_Category] PRIMARY KEY([Id]),
//	CONSTRAINT[UQ_Category_nome] UNIQUE([nome])

//)


//CREATE TABLE[tbTag] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [nome] VARCHAR(80) NOT NULL,

//    CONSTRAINT[PK_Tag] PRIMARY KEY([Id]),
//	CONSTRAINT[UQ_Tag_nome] UNIQUE([nome])

//)


//CREATE TABLE[tbPost] (

//    [Id] INT NOT NULL,
//    [IdCategoria] INT NOT NULL,
//    [NomeCategoria] VARCHAR(80) NOT NULL,
//    [IdAutor] INT NOT NULL,
//    [NomeAutor] VARCHAR(80) NOT NULL,

//    [TagId] INT NOT NULL,
//    [TagNome] VARCHAR(80) NOT NULL,


//    [Titulo] VARCHAR(160) NOT NULL,
//    [Slug] VARCHAR(80) NOT NULL,


//    [dataDia] VARCHAR(20) NULL,

//    [cadastradorPor] VARCHAR(50) NULL,

//    [LastUpdateDate] DATETIME NULL DEFAULT(GETDATE()),


//     CONSTRAINT[PK_Post] PRIMARY KEY([Id], [IdAutor]),
//     CONSTRAINT[FK_tbPost_tbCategoria_id] FOREIGN KEY([IdCategoria]) REFERENCES[tbCategoria]([Id]),
//     CONSTRAINT[FK_Post_NomeCategoria] FOREIGN KEY([NomeCategoria]) REFERENCES[tbCategoria]([nome]),

//     CONSTRAINT[FK_Post_AutorId] FOREIGN KEY([IdAutor]) REFERENCES[tbAutor]([Id]),
//     CONSTRAINT[FK_Post_AutorNome] FOREIGN KEY([NomeAutor]) REFERENCES[tbAutor]([nome]),

//     CONSTRAINT[FK_Post_Tag] FOREIGN KEY([TagId]) REFERENCES[tbTag]([Id]),
//     CONSTRAINT[FK_Post_TagName] FOREIGN KEY([TagNome]) REFERENCES[tbTag]([Nome])

//)



//CREATE TABLE[tbPerfil] (

//    [idPerfil] INT NOT NULL,
//    [nome] VARCHAR(20) NOT NULL,

//   CONSTRAINT[PK_Perfil] PRIMARY KEY([idPerfil]),
//   CONSTRAINT[UQ_Perfil_Nome] UNIQUE([nome])


//)



//CREATE TABLE[tbUsuario] (

//    [idUsuario] INT NOT NULL,
//    [usuario] VARCHAR(50) NOT NULL,
//    [senha] VARCHAR(50) NOT NULL,
//    [repitaSenha] VARCHAR(50) NOT NULL,
//    [nivelAcesso] VARCHAR(20) NOT NULL,
//    [dataDia] VARCHAR(20) NULL,
//    [cadastradorPor] VARCHAR(50) NOT NULL,
//    [bio] VARCHAR(250) NULL,
//    [slug] VARCHAR(50) NOT NULL,
//    [email] VARCHAR(50) NOT NULL,


//   CONSTRAINT[PK_Usuario] PRIMARY KEY([idUsuario]),
//   CONSTRAINT[FK_User_Perfil] FOREIGN KEY([nivelAcesso]) REFERENCES[tbPerfil]([nome])

//)

