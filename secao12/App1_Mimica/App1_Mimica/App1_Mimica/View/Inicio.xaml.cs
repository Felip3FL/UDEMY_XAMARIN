﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.ComponentModel;

namespace App1_Mimica.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();

            //BindingContext = new Grupo();
            BindingContext = new ViewModel.InicioViewModel();
        }

        //public class Grupo : INotifyPropertyChanged
        //{
        //    private string _NomeGrupo1;
        //    public string NomeGrupo1 { get { return _NomeGrupo1; } set { _NomeGrupo1 = value; PropriedadeMudada("NomeGrupo1"); }}
        //    public Grupo()
        //    {
        //        NomeGrupo1 = "The sims";
        //    }

        //    public event PropertyChangedEventHandler PropertyChanged;

        //    private void PropriedadeMudada(string NomePropriedade)
        //    {
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this,new PropertyChangedEventArgs(NomePropriedade));
        //        }
        //    }
        //}
    }
}