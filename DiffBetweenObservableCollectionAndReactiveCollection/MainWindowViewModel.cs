using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Reactive.Bindings;

namespace DiffBetweenObservableCollectionAndReactiveCollection
{
    class MainWindowViewModel
    {
        public ReactiveCollection<string> reactiveCollection { get; private set; }
        public ObservableCollection<string> observableCollection { get; private set; }

        public MainWindowViewModel()
        {
            observableCollection = new ObservableCollection<string>();
            reactiveCollection = new ReactiveCollection<string>();
        }

        public void AddObservableCollection()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    this.observableCollection.Add(i.ToString());
                }
            });
        }

        public void AddReactiveCollection()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    this.reactiveCollection.AddOnScheduler(i.ToString());
                }
            });
        }

    }
}
