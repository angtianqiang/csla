﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WpUI
{
  public partial class MainPage : PhoneApplicationPage
  {
    // Constructor
    public MainPage()
    {
      InitializeComponent();
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
      App.ViewModel.LoginOut();
    }

    private void RefreshButton_Click(object sender, EventArgs e)
    {
      App.ViewModel.ReloadMainView();
    }

    private void RolesButton_Click(object sender, EventArgs e)
    {
      App.ViewModel.ViewRoles();
    }
  }
}