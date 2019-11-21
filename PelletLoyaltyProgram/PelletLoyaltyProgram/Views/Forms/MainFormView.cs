using PelletLoyaltyProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelletLoyaltyProgram
{
    public partial class MainFormView : Form, IMainView
    {
        private MainFormPresenter _presenter = null;
        private readonly MessageModel _model;

        public MainFormView(MessageModel model)
        {
            _model = model;
            InitializeComponent();
            _presenter = new MainFormPresenter(this, _model);
            SubscribeToModelEvents();
        }

        private void SubscribeToModelEvents()
        {
            _model.TextSet += _model_TextSet;
        }

        void _model_TextSet(object sender, MessageModelEventArgs e)
        {
            this.label1.Text = e.Message;
            //this.label1.Text = "Text changed from " + e.m_before + " to " + e.m_after;
        }

        public string TextValue
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presenter.SetTextValue();
        }
    }
}
