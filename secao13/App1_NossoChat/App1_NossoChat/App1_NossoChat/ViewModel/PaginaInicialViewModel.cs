﻿using App1_NossoChat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using App1_NossoChat.Service;
using Newtonsoft;
using Newtonsoft.Json;
using App1_NossoChat.Util;

namespace App1_NossoChat.ViewModel
{
    public class PaginaInicialViewModel : INotifyPropertyChanged
    {
        public string _nome;
        public string Nome { 
            get { return _nome; } 
            set { _nome = value; PropertyChanged(this, new PropertyChangedEventArgs("Nome")); }}

        public string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; PropertyChanged(this, new PropertyChangedEventArgs("Senha")); }
        }

        private string _mensagem;
        public string Mensagem
        {
            get { return _mensagem; }
            set { _mensagem = value; PropertyChanged(this, new PropertyChangedEventArgs("Mensagem")); }
        }

        public Command AcessarCommand { get; set; }

        public PaginaInicialViewModel()
        {
            AcessarCommand = new Command(Acessar);
        }

        private void Acessar()
        {
            var user = new Usuario();
            user.nome = Nome;
            user.password = Senha;

            var usuarioLogado = ServiceWS.GetUsuario(user);
            if(usuarioLogado == null)
            {
                Mensagem = "Senha incorreta";
            }else
            {
                UsuarioUtil.SetUsuarioLogado(usuarioLogado);

                //App.Current.Properties["LOGIN"] = JsonConvert.SerializeObject(usuarioLogado);
                App.Current.MainPage = new NavigationPage(new View.Chats()) { BarBackgroundColor= Color.FromHex("#5ED055"), BarTextColor = Color.White };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
