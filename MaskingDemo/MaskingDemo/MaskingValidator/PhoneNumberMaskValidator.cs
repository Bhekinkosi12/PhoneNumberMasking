using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MaskingDemo.MaskingValidator
{
    public class PhoneNumberMaskValidator: Behavior<Entry>
    {        
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntry_TextChanged;
            base.OnAttachedTo(entry);
        }
        
        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntry_TextChanged;
            base.OnDetachingFrom(entry);
        }


        private void OnEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                if (e.OldTextValue != null && e.NewTextValue.Length < e.OldTextValue.Length)
                    return;

                var value = e.NewTextValue;
                
                if (value.Length == 3)
                {
                    ((Entry)sender).Text += "-";
                    return;
                }
                if (value.Length == 7)
                {
                    ((Entry)sender).Text += "-";
                    return;
                }

                ((Entry)sender).Text = e.NewTextValue;
                
            }
        }
    }
}
