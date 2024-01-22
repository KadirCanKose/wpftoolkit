﻿/*************************************************************************************
   
   Toolkit for WPF

   Copyright (C) 2007-2023 Xceed Software Inc.

   This program is provided to you under the terms of the XCEED SOFTWARE, INC.
   COMMUNITY LICENSE AGREEMENT (for non-commercial use) as published at 
   https://github.com/xceedsoftware/wpftoolkit/blob/master/license.md 

   For more features, controls, and fast professional support,
   pick up the Plus Edition at https://xceed.com/xceed-toolkit-plus-for-wpf/

   Stay informed: follow @datagrid on Twitter or Like http://facebook.com/datagrids

  ***********************************************************************************/

using System.Windows;

namespace Xceed.Wpf.Toolkit
{
  public class ItemEventArgs : RoutedEventArgs
  {
    #region Protected Members

    private object _item;

    #endregion

    #region Constructor

    internal ItemEventArgs( RoutedEvent routedEvent, object newItem )
      : base( routedEvent )
    {
      _item = newItem;
    }

    #endregion

    #region Property Item

    public object Item
    {
      get
      {
        return _item;
      }
    }

    #endregion
  }
}
