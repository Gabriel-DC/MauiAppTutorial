using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial.Models
{
    public class FotoViewModel
    {
        private ObservableCollection<Foto> _fotos;

        public ObservableCollection<Foto> Fotos
        {
            get => _fotos;
            set => _fotos = value;
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() { Nome = "Teste 1", ImageUrl = "dotnet_bot.svg" },
                new Foto() { Nome = "Teste 2", ImageUrl = "dotnet_bot.svg" },
                new Foto() { Nome = "Teste 3", ImageUrl = "dotnet_bot.svg" },
                new Foto() { Nome = "Teste 4", ImageUrl = "dotnet_bot.svg" },
                new Foto() { Nome = "Teste 5", ImageUrl = "dotnet_bot.svg" },
                new Foto() { Nome = "Teste 6", ImageUrl = "dotnet_bot.svg" },
            };
        }
    }
}
