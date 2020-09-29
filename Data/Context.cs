using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMR.Model;

namespace VMR.Data
{
    public class Context
    {
        internal static ObservableCollection<Product> Products = new ObservableCollection<Product>();

        internal static void LoadData()
        {
            var tempProducts = new ObservableCollection<Product>();
            tempProducts.Add(new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Hot Chocolate",
                Picture = "pack://application:,,,/VMR;component\\Assets/Image/hot_chocolate.jpg",
                PreparingSteps = new List<preparingStep>
                {
                    new preparingStep{Id = Guid.NewGuid(),Name ="Boil water",Picture = Static.NotStartedIcon },
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add drinking chocolate to cup",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add water",Picture = Static.NotStartedIcon},
                },
                StateName = StateName.InProgress,
                State = Enums.preparingStep.NotStarted,
                StateColor = StateColor.InProgress
            });
            tempProducts.Add(new Product()
            {
                Id = Guid.NewGuid(),
                Name = "White Coffee",
                Picture = "pack://application:,,,/VMR;component\\Assets/Image/white_coffee.jpg",
                PreparingSteps = new List<preparingStep>
                {
                    new preparingStep{Id = Guid.NewGuid(),Name ="Boil water",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add sugar",Picture =Static. NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add coffee granules to cup",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add water",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add milk",Picture = Static.NotStartedIcon},

                },
                StateName = StateName.InProgress,
                State = Enums.preparingStep.NotStarted,
                StateColor = StateColor.InProgress
            });
            tempProducts.Add(new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Lemon Tea",
                Picture = "pack://application:,,,/VMR;component\\Assets/Image/lemon_tea.jpg",
                PreparingSteps = new List<preparingStep>
                {
                    new preparingStep{Id = Guid.NewGuid(),Name ="Boil water",Picture =Static. NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add water",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Steep tea bag in hot water",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add lemon",Picture = Static.NotStartedIcon},
                },
                StateName = StateName.InProgress,
                State = Enums.preparingStep.NotStarted,
                StateColor = StateColor.InProgress
            });
            tempProducts.Add(new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Iced Coffee",
                Picture = "pack://application:,,,/VMR;component\\Assets/Image/iced_coffee.jpg",
                PreparingSteps = new List<preparingStep>
                {
                    new preparingStep{Id = Guid.NewGuid(),Name ="Crush Ice",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add ice to blender",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add coffee syrup to blender",Picture = Static.NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Blend ingredients",Picture =Static. NotStartedIcon},
                    new preparingStep{Id = Guid.NewGuid(),Name ="Add ingredients",Picture = Static.NotStartedIcon},
                },
                StateName = StateName.InProgress,
                State = Enums.preparingStep.NotStarted,
                StateColor = StateColor.InProgress
            });
            Products.Clear();
            Products = tempProducts;
        }
    }
}
