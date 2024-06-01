using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAggregator
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _receiveMsg { get; set; }
        public string ReceiveMsg
        {
            get
            {
                return _receiveMsg;
            }
            set
            {
                _receiveMsg = value;
                RaisePropertyChanged(() => ReceiveMsg);
            }
        }

        private void RaisePropertyChanged(Func<string> value)
        {
            throw new NotImplementedException();
        }

        public MainWindowViewModel()
        {

        }

    }
}
