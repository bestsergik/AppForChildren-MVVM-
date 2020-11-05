using System;
using System.Collections.Generic;
using System.Text;

namespace AppForChildren_MVVM_.ViewModels.Base
{
   internal class MainWindowViewModel : ViewModel
    {
        private string _Title;


        /// <summary>Заголовок окна </summary>
        public string Title
        {
            get => _Title;
            //set
            //{
            //    //if (Equals(_Title, value)) return;
            //    //_Title = value;
            //    //OnPropertyChancged();
            //    Set(ref _Title, value);
            //}

            set => Set(ref _Title, value);
        }
    }
}
