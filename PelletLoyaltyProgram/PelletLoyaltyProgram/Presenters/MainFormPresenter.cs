using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PelletLoyaltyProgram
{
    public class MainFormPresenter
    {
        private IMessageModel _model;
        private readonly IMainView _view;

        public MainFormPresenter(IMainView view, IMessageModel model)
        {
            _model = model;
            _view = view;
        }

        public void SetTextValue()
        {
            _model.Set(_view.TextValue);
        }
    }
}
