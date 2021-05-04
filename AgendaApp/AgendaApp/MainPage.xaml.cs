using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public ObservableCollection<Agenda> MyAgenda { get => GetAgenda(); }

        private ObservableCollection<Agenda> GetAgenda()
        {
            return new ObservableCollection<Agenda>
            {
                new Agenda { Topic = "Descubre los retos de Enero", Duration = "Haz clic aquí", Color = "#B96CBD", Date = new DateTime(2021, 1, 31), //Enero
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Comer 3 frutas", Time = "Dia 1" }, new Reto { Name = "Consume un licuado natural", Time = "Dia 2" },new Reto { Name = "Desayunar galletas de avena", Time = "Dia 3" },
                        new Reto { Name = "Pasar tiempo al aire libre", Time = "Dia 4" }, new Reto { Name = "Comer pescado o mariscos", Time = "Dia 5" }, new Reto { Name = "Meditar 20 minutos 2 veces al dia (Mindfulness)", Time = "Dia 6" }, new Reto { Name = "Toma 2 litros de agua y evitar el refresco", Time = "Dia 7" },
                        new Reto { Name = "Correr al menos 20 min", Time = "Dia 8" }, new Reto { Name = "No consumas productos lácteos", Time = "Dia 9" }, new Reto { Name = "Trabaja tu cerebro con algún juego de aprendizaje", Time = "Dia 10" }, new Reto { Name = "Reemplaza tu aceite por uno vegetal", Time = "Dia 11" },
                        new Reto { Name = "Duerme 9 horas", Time = "Dia 12" }, new Reto { Name = "Come despacio, te sentiras mas santisfecho", Time = "Dia 13" }, new Reto { Name = "Cena temprano, no te duermas con el estomago lleno", Time = "Dia 14" }, new Reto { Name = "Consume almendras y nueces", Time = "Dia 15" },
                        new Reto { Name = "Come 3 frutas y 2 verduras", Time = "Dia 16" }, new Reto { Name = "Lee 30 minutos", Time = "Dia 17" }, new Reto { Name = "No consumas productos procesados", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                        new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                        new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                        new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" }, new Reto { Name = "Reto 31", Time = "Dia 31" } } },

                new Agenda { Topic = "Descubre los retos de Febrero", Duration = "Haz clic aquí", Color = "#49A24D", Date = new DateTime(2021, 2, 28), //Febrero
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" } } },

                new Agenda { Topic = "Descubre los retos de Marzo", Duration = "Haz clic aquí", Color = "#FDA838", Date = new DateTime(2021, 3, 31),  //Marzo
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" }, new Reto { Name = "Reto 31", Time = "Dia 31" } } },

                new Agenda { Topic = "Descubre los retos de Abril", Duration = "Haz clic aquí", Color = "#F75355", Date = new DateTime(2021, 4, 30),  //Abril
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" } } },

                new Agenda { Topic = "Descubre los retos de Mayo", Duration = "Haz clic aquí", Color = "#00C6AE", Date = new DateTime(2021, 5, 31), //Mayo
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" }, new Reto { Name = "Reto 31", Time = "Dia 31" } } },

                new Agenda { Topic = "Descubre los retos de Junio", Duration = "Haz clic aquí", Color = "#455399", Date = new DateTime(2021, 6, 30),    //Junio
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" } } },

                new Agenda { Topic = "Descubre los retos de Julio", Duration = "Haz clic aquí", Color = "#B96CBD", Date = new DateTime(2021, 7, 31),    //Julio
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" }, new Reto { Name = "Reto 31", Time = "Dia 31" } } },

                new Agenda { Topic = "Descubre los retos de Agosto", Duration = "Haz clic aquí", Color = "#49A24D", Date = new DateTime(2021, 8, 31),    //Agosto
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" }, new Reto { Name = "Reto 31", Time = "Dia 31" } } },

                new Agenda { Topic = "Descubre los retos de Septiembre", Duration = "Haz clic aquí", Color = "#FDA838", Date = new DateTime(2021, 9, 30),    //Septiembre
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" } } },

                new Agenda { Topic = "Descubre los retos de Octubre", Duration = "Haz clic aquí", Color = "#F75355", Date = new DateTime(2021, 10, 31),    //Octubre
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" }, new Reto { Name = "Reto 31", Time = "Dia 31" } } },

                new Agenda { Topic = "Descubre los retos de Noviembre", Duration = "Haz clic aquí", Color = "#00C6AE", Date = new DateTime(2021, 11, 30),    //Noviembre
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" } } },

                new Agenda { Topic = "Descubre los retos de Diciembre", Duration = "Haz clic aquí", Color = "#455399", Date = new DateTime(2021, 12, 31),    //Diciembre
                    Mes = new ObservableCollection<Reto>{ new Reto { Name = "Reto 1", Time = "Dia 1" }, new Reto { Name = "Reto 2", Time = "Dia 2" }, new Reto { Name = "Reto 3", Time = "Dia 3" },
                    new Reto { Name = "Reto 4", Time = "Dia 4" }, new Reto { Name = "Reto 5", Time = "Dia 5" }, new Reto { Name = "Reto 6", Time = "Dia 6" }, new Reto { Name = "Reto 7", Time = "Dia 7" },
                    new Reto { Name = "Reto 8", Time = "Dia 8" }, new Reto { Name = "Reto 9", Time = "Dia 9" }, new Reto { Name = "Reto 10", Time = "Dia 10" }, new Reto { Name = "Reto 11", Time = "Dia 11" },
                    new Reto { Name = "Reto 12", Time = "Dia 12" }, new Reto { Name = "Reto 13", Time = "Dia 13" }, new Reto { Name = "Reto 14", Time = "Dia 14" }, new Reto { Name = "Reto 15", Time = "Dia 15" },
                    new Reto { Name = "Reto 16", Time = "Dia 16" }, new Reto { Name = "Reto 17", Time = "Dia 17" }, new Reto { Name = "Reto 18", Time = "Dia 18" }, new Reto { Name = "Reto 19", Time = "Dia 19" },
                    new Reto { Name = "Reto 20", Time = "Dia 20" }, new Reto { Name = "Reto 21", Time = "Dia 21" }, new Reto { Name = "Reto 22", Time = "Dia 22" }, new Reto { Name = "Reto 23", Time = "Dia 23" },
                    new Reto { Name = "Reto 24", Time = "Dia 24" }, new Reto { Name = "Reto 25", Time = "Dia 25" }, new Reto { Name = "Reto 26", Time = "Dia 26" }, new Reto { Name = "Reto 27", Time = "Dia 27" },
                    new Reto { Name = "Reto 28", Time = "Dia 28" }, new Reto { Name = "Reto 29", Time = "Dia 29" }, new Reto { Name = "Reto 30", Time = "Dia 30" }, new Reto { Name = "Reto 31", Time = "Dia 31" } } },

            };
        }
    }


    public class Agenda
    {
        public string Topic { get; set; }
        public string Duration { get; set; }
        public DateTime Date { get; set; }
        public ObservableCollection<Reto> Mes { get; set; }
        public string Color { get; set; }
    }

    public class Reto
    {
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
