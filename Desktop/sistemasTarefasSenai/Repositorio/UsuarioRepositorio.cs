using System;
using System.Collections.Generic;
using System.IO;
using Sistema.Models;

namespace sistemasTarefasSenai.Repositorio
{
    public class UsuarioRepositorio
    {
        public List<UsuarioModel> Listar()
        {
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel>();

            //Abre o stream de leitura do arquivo
            string[] linhas = File.ReadAllLines("usuarios.csv");

            //Lê cada registro no CSV
            foreach (string linha in linhas)
            {
                //Separa os dados da linha
                string[] dadosDaLinha = linha.Split(';');

                //Cria o objeto com os dados da linha do CSV
                UsuarioModel usuario = new UsuarioModel
                {
                    ID = int.Parse(dadosDaLinha[0]),
                    Nome = dadosDaLinha[1],
                    Email = dadosDaLinha[2],
                    Senha = dadosDaLinha[3],
                    Tipo = dadosDaLinha[4],
                    DataCriacao = DateTime.Parse(dadosDaLinha[5])
                };

                //Adicionando o usuário na lista
                lsUsuarios.Add(usuario);
            }       
            return lsUsuarios;     
        }
    }
}