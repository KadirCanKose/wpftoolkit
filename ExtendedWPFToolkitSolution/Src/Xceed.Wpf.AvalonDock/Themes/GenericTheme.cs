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

using System;

namespace Xceed.Wpf.AvalonDock.Themes
{
  public class GenericTheme : Theme
  {
    public override Uri GetResourceUri()
    {
      string uri;
#if NETCORE
          uri = "Xceed.Wpf.AvalonDock.NETCore";
#elif NET5
          uri = "Xceed.Wpf.AvalonDock.NET5";
#else
      uri = "Xceed.Wpf.AvalonDock";
#endif

      return new Uri( "/" + uri + ";component/Themes/generic.xaml", UriKind.Relative );
    }
  }
}
