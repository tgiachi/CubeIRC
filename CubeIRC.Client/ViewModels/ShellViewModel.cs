using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using CubeIRC.Api.Data;
using Reactive.Bindings;

namespace CubeIRC.Client.ViewModels
{
    public class ShellViewModel: Screen, IHandle<WindowObject>
    {
        private IEventAggregator _eventAggregator;

        public ReactiveCollection<WindowObject> Windows { get; set; }

        public ShellViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe(this);
            Windows = new ReactiveCollection<WindowObject>();
            _eventAggregator = eventAggregator;
        }

        public void Handle(WindowObject message)
        {
            
        }
    }
}
