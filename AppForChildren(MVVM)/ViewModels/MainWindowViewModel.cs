using System;
using System.Collections.Generic;
using System.Text;
using AppForChildren_MVVM_.ViewModels.Base;

namespace AppForChildren_MVVM_.ViewModels
{
   internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Программа для детей";

         
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
