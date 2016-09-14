using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo.Controller
{
    public partial class Controller : UserControl
    {
        public Controller()
        {
            InitializeComponent();
        }


        private string _controllerName;
        private string _state;
        private Color _stateColor;
        private Color _textColor;

        //名称
        [DefaultValue("控制器")]
        public string ControllerName
        {
            get
            {
                return _controllerName;
            }

            set
            {
                this.label1.Text = value;
                _controllerName = value;
            }
        }
        //状态
        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }
        //指示颜色
        [Browsable(true)]
        public Color StateColor
        {
            get
            {
                return _stateColor;
            }

            set
            {
                this.label1.BackColor = value;
                _stateColor = value;
            }
        }

        public Color TextColor
        {
            get
            {
                return _textColor;
            }

            set
            {
                this.label1.ForeColor = value;
                _textColor = value;
            }
        }
        //private IList<Door> _doors;
    }
}
