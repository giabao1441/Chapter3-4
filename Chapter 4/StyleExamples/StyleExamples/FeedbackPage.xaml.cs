﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StyleExamples
{
    public partial class FeedbackPage : ContentPage
    {
        const string placeHolderText = "Type your message here";

        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var text = Feedback.Text;

            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                return;
            }

            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                return;
            }
        }

        public FeedbackPage()
        {
            InitializeComponent();
            Feedback.Text = placeHolderText;
        }
    }
}
