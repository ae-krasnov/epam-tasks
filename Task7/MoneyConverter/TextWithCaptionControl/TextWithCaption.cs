using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextWithCaptionControl
{
    [DefaultProperty("DefualtText")]
    [ToolboxData("<{0}:TextWithCaptionControl runat=server></{0}:TextWithCaptionControl>")]
    public class TextWithCaption : WebControl
    {
        private string _defaultText;
        private string _textCaption;
        private string _separator;

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(CaptionAlign.left)]
        [Description("где относительно надписи размещается подпись")]
        [Localizable(true)]
        public CaptionAlign CaptionAlign 
        {
            get
            {
                object t = ViewState["CaptionAlign"];
                return (t == null) ? CaptionAlign.left : (CaptionAlign)t;
            }
            set
            {
                ViewState["CaptionAlign"] = value;
            }
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(":")]
        [Description("разделитель между основной надписью и подписью")]
        [Localizable(true)]
        public string Separator
        {
            get { return _separator; }
            set { _separator = value; }
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("100500")]
        [Description("подпись в контроле, по умолчанию равно 100500")]
        [Localizable(true)]
        public string TextCaption
        {
            get { return _textCaption; }
            set { _textCaption = value; }
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("сумма")]
        [Description("надпись для контрола, по умолчанию равно 'сумма'")]
        [Localizable(true)]
        public string DefaultText
        {
            get { return _defaultText; }
            set { _defaultText = value; }
        }

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Value, DefaultText);
            writer.AddAttribute(HtmlTextWriterAttribute.Value, TextCaption);
            writer.AddAttribute(HtmlTextWriterAttribute.Value, Separator);
            writer.AddAttribute(HtmlTextWriterAttribute.Value, CaptionAlign.ToString());

            base.AddAttributesToRender(writer);
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            Page.RegisterRequiresControlState(this);
            if (DefaultText == String.Empty) 
            {
                DefaultText = "сумма";
            }
            if (TextCaption== String.Empty)
            {
                TextCaption = "100500";
            }
            if(Separator==String.Empty)
            {
                Separator = ":";
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            CaptionAlign _align=CaptionAlign;

            output.RenderBeginTag(HtmlTextWriterTag.Div);

            switch (_align)
            {
                case CaptionAlign.before:
                    output.WriteEncodedText(TextCaption);
                    output.WriteEncodedText(Separator);
                    output.RenderBeginTag(HtmlTextWriterTag.Br);
                    output.RenderEndTag();
                    output.WriteEncodedText(DefaultText);
                    break;
                case CaptionAlign.after:
                    output.WriteEncodedText(DefaultText);
                    output.WriteEncodedText(Separator);
                    output.RenderBeginTag(HtmlTextWriterTag.Br);
                    output.RenderEndTag();
                    output.WriteEncodedText(TextCaption);
                    break;
                case CaptionAlign.left:
                    output.WriteEncodedText(DefaultText + " ");
                    output.WriteEncodedText(Separator);
                    output.WriteEncodedText(TextCaption);
                    break;
            }

            output.RenderEndTag();
        }
    }
}
