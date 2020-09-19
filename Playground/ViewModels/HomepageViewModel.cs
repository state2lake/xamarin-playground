using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Playground.Models;
using Playground.Resources;
using Xamarin.Forms;

namespace Playground.ViewModels
{
    public class HomepageViewModel
    {
        readonly IList<Workout> source;
        public ObservableCollection<Workout> Workouts { get; private set; }
        public ICommand ProfileMenuCommand => new Command(async () => await ProfileMenuCommandAsync());

        public HomepageViewModel()
        {
            source = new List<Workout>();
            CreateWorkoutCollection();
        }

        void CreateWorkoutCollection()
        {
            //TODO: A cleaner more performance-considerate way of doing this 
            source.Add(new Workout
            {
                Name = AppStringResources.warmup_tee_drill,
                Location = AppStringResources.indoor_outdoor,
                Details = AppStringResources.warmup_tee_drill_description,
                ImageUrl = "teework.jpg",
            });
            source.Add(new Workout
            {
                Name = AppStringResources.warmup_bread_basket,
                Location = AppStringResources.indoor_outdoor,
                Details = AppStringResources.warmup_bread_basket_description,
                ImageUrl = "teework.jpg",
            });

            Workouts = new ObservableCollection<Workout>(source);
        }
        public async Task ProfileMenuCommandAsync()
        {

        }
    }
}
