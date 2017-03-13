using System;
using Xamarin.Forms;

namespace GadoX {
    public class CustomEntry : Entry {
        public static readonly BindableProperty HasBorderProperty =
            BindableProperty.Create("HasBorder", typeof(bool), typeof(CustomEntry), true);

        public bool HasBorder {
            get {
                return (bool)GetValue(HasBorderProperty);
            }
            set {
                SetValue(HasBorderProperty, value);
            }
        }

        public static readonly BindableProperty FontProperty =
            BindableProperty.Create("Font", typeof(Font), typeof(CustomEntry), new Font());

        public Font Font {
            get {
                return (Font)GetValue(FontProperty);
            }
            set {
                SetValue(FontProperty, value);
            }
        }

        public static readonly BindableProperty MaxLengthProperty =
            BindableProperty.Create("MaxLength", typeof(int), typeof(CustomEntry), int.MaxValue);

        public int MaxLength {
            get {
                return (int)this.GetValue(MaxLengthProperty);
            }
            set {
                this.SetValue(MaxLengthProperty, value);
            }
        }
    }
}