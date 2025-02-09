﻿using NoSnoozeNET.Extensions.WPF;
using System.Collections.Generic;
using System.Windows;

namespace NoSnoozeNET.Extensions.Internal
{
    public static class ShadowConfigExt
    {
        public static void ApplyGlobalShadow(List<UIElement> shadowElements)
        {
            foreach (var element in shadowElements)
            {
                WindowExt.ApplyShadow(MainWindow.GlobalConfig.BrushConfig.ShadowConfig, element);
            }
        }
    }
}
