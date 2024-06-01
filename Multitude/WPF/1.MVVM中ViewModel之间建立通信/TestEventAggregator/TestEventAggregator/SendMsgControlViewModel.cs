using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAggregator
{
    public class SendMsgControlViewModel : ViewModelBase
    {
        public RelayCommand SendMsgCommand { get; set; }


        public SendMsgControlViewModel()
        {
            SendMsgCommand = new RelayCommand(SendMsg);
        }

        private void SendMsg()
        {

        }
    }
}
