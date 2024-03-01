using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AutoSign
{
    public class RevitAPI : IExternalApplication
    {
        //static string addinAssmeblyPath = Assembly.GetExecutingAssembly().Location;
        static string addinAssmeblyPath = @"C:\ProgramData\Autodesk\Revit\Addins\2020\Sino_Station\"; // 封包版路徑位址
        public Result OnStartup(UIControlledApplication a)
        {
            addinAssmeblyPath = addinAssmeblyPath + "AutoSign.dll";

            RibbonPanel ribbonPanel = null;
            try { a.CreateRibbonTab("捷運規範校核"); } catch { }
            try { ribbonPanel = a.CreateRibbonPanel("捷運規範校核", "指標自動化"); }
            catch
            {
                List<RibbonPanel> panel_list = new List<RibbonPanel>();
                panel_list = a.GetRibbonPanels("指標自動化");
                foreach (RibbonPanel rp in panel_list)
                {
                    if (rp.Name == "指標校核")
                    {
                        ribbonPanel = rp;
                    }
                }
            }
            // 在面板上添加一個按鈕, 點擊此按鈕觸動AutoSign.AutoSign
            PushButton autoSignBtn = ribbonPanel.AddItem(new PushButtonData("AutoSign", "指標校核", addinAssmeblyPath, "AutoSign.AutoSign")) as PushButton;
            autoSignBtn.LargeImage = convertFromBitmap(Properties.Resources.指標自動化);

            return Result.Succeeded;
        }

        BitmapSource convertFromBitmap(System.Drawing.Bitmap bitmap)
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                bitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
