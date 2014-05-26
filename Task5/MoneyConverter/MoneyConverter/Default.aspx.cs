using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoneyConverter
{
    public partial class Default : System.Web.UI.Page
    {
        static Dictionary<string, double> _listOfMoney;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _listOfMoney = new Dictionary<string, double>();
                _listOfMoney.Add("выбор валюты",0);
                _listOfMoney.Add("франки", 1.1);
                _listOfMoney.Add("рубль", 34.18);
                _listOfMoney.Add("фунт", 1.68);

                SourceMoneyList.DataSource = _listOfMoney.Keys;
                SourceMoneyList.DataBind();
                TargetMoneyList.DataSource = _listOfMoney.Keys;
                TargetMoneyList.DataBind();
            }
            
        }

        protected void SourceMoneyList_event(object sender, EventArgs e)
        {
            double value;
            if (_listOfMoney.TryGetValue(SourceMoneyList.SelectedValue.ToString(),out value)&&SourceMoneyList.SelectedIndex!=0)
            {
              SourceMoneyToDollarTextBox.Text=value.ToString();  
            }
            
        }

        protected void TargetMoneyList_event(object sender, EventArgs e)
        {
            double value;
            if (_listOfMoney.TryGetValue(TargetMoneyList.SelectedValue.ToString(), out value)&&TargetMoneyList.SelectedIndex!=0)
            {
                TargetMoneyToDollarTextBox.Text = value.ToString();
            }
        }

        protected void CountButton_Click(object sender, EventArgs e)
        {
            double _sourceMoney;
            double _targetMoney;
            double _summ;
            double _result;


            if (TargetMoneyList.SelectedIndex!=0 && SourceMoneyList.SelectedIndex!=0 && Double.TryParse(SourceMoneyToDollarTextBox.Text,out _sourceMoney)&&
                Double.TryParse(TargetMoneyToDollarTextBox.Text,out _targetMoney)&&
                Double.TryParse(SummTextBox.Text,out _summ))
            {
                _result = (_sourceMoney * _summ) / _targetMoney;
                ResultLabel.Text = "Результат: " + _result + " "+TargetMoneyList.SelectedValue.ToString();
            }
            else
            {
                ResultLabel.Text = "Ошибка, нельзя расчитать.";
            }


        }

        protected void SourceMoneyToDollarTextBox_TextChanged(object sender, EventArgs e)
        {
        }

    }
}