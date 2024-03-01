using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;

namespace AutoSign
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class SignCheck : IExternalEventHandler
    {
        public class CodeInfo
        {
            public string code { get; set; }
            public string name { get; set; }
            public string chineseName { get; set; }
        }

        public void Execute(UIApplication uiapp)
        {
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;
            List<CodeInfo> codeInfoList = CodeInfoList(); // 紀錄資訊代號
            //TaskDialog.Show("Revit", "AutoSign");
        }
        // 紀錄資訊代號
        public List<CodeInfo> CodeInfoList()
        {
            List<CodeInfo> codeInfoList = new List<CodeInfo>();
            CodeInfo codeInfo = new CodeInfo(); codeInfo.code = "AD"; codeInfo.name = "ADVERTISING"; codeInfo.chineseName = "廣告"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "BC"; codeInfo.name = "BICYCLE"; codeInfo.chineseName = "腳踏車"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "BR"; codeInfo.name = "BREASTFEEDING ROOM"; codeInfo.chineseName = "哺集乳室"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "BS"; codeInfo.name = "BABY CHANGING STATION"; codeInfo.chineseName = "尿布台"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "CPC"; codeInfo.name = "CHILD PROTECTION CHAIR"; codeInfo.chineseName = "兒童安全座椅"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "CT"; codeInfo.name = "CHILD TOILET"; codeInfo.chineseName = "兒童馬桶/兒童小便器"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "CW"; codeInfo.name = "CHILD WASH BASIN"; codeInfo.chineseName = "兒童洗臉盆"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D"; codeInfo.name = "DESTINATION/DIRECTION"; codeInfo.chineseName = "目的地/方向"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D1"; codeInfo.name = "TO TAIPEI MAIN STATION"; codeInfo.chineseName = "往台北車站"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D2"; codeInfo.name = "TO TAMSHUI"; codeInfo.chineseName = "往淡水"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D3"; codeInfo.name = "TO XIANGSHAN"; codeInfo.chineseName = "往象山"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D4"; codeInfo.name = "TO BEITOU"; codeInfo.chineseName = "往北投"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D5"; codeInfo.name = "TO SONGSHAN"; codeInfo.chineseName = "往松山"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D6"; codeInfo.name = "TO XLNDIAN"; codeInfo.chineseName = "往新店"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D7"; codeInfo.name = "TO NANSHIJIAO"; codeInfo.chineseName = "往南勢角"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D8"; codeInfo.name = "TO HUILONG"; codeInfo.chineseName = "往迴龍"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D9"; codeInfo.name = "TO LUCHOU"; codeInfo.chineseName = "往蘆洲"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D10"; codeInfo.name = "TO DINGPU"; codeInfo.chineseName = "往頂埔"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D11"; codeInfo.name = "TO NANGANG EXHIBITION CENTER(BANNAN LINE)"; codeInfo.chineseName = "往南港展覽館(板南線)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D12"; codeInfo.name = "TO TAIPEI ZOO(WENHU LINE)"; codeInfo.chineseName = "往動物園(文湖線)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D13"; codeInfo.name = "TO NANGANG EXHIBITION CENTER(WENHU LINE)"; codeInfo.chineseName = "往南港展覽館(文湖線)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D14"; codeInfo.name = "TO JIANNAN RD."; codeInfo.chineseName = "往劍南路"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D15"; codeInfo.name = "TO CHIANG KAISHEKMEMORIAL HALL"; codeInfo.chineseName = "往中正紀念堂"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D16"; codeInfo.name = "TO NEW TAIPEI INDUSTRIAL PARK"; codeInfo.chineseName = "新北產業園區"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D17"; codeInfo.name = "TO JUGUANG"; codeInfo.chineseName = "莒光"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "D18"; codeInfo.name = "TO GUANGCI/FENGTIAN TEMPLE"; codeInfo.chineseName = "廣慈/奉天宮"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "DM"; codeInfo.name = "PASSENGER INFORMATION DISPLAY SYSTEM"; codeInfo.chineseName = "旅客資訊顯示系統"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "E"; codeInfo.name = "EXIT"; codeInfo.chineseName = "出口"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "EM"; codeInfo.name = "EMERGENCY EXIT"; codeInfo.chineseName = "緊急出口"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "EL"; codeInfo.name = "ELEVATOR"; codeInfo.chineseName = "電梯 (昇降梯)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "FHC"; codeInfo.name = "FIRE HOSE CABINET"; codeInfo.chineseName = "消防栓箱"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "FT"; codeInfo.name = "WOMEN'S TOILET"; codeInfo.chineseName = "女洗手間"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "FR"; codeInfo.name = "LOCATION MAP OF FAMILY RESTROOM FACILITIES"; codeInfo.chineseName = "親子設備位置圖"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "H"; codeInfo.name = "HANDICAPPED"; codeInfo.chineseName = "無障礙設施"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "HL"; codeInfo.name = "HANDICAPPED ELEVATOR"; codeInfo.chineseName = "無障礙專用電梯"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "I"; codeInfo.name = "INFORMATION"; codeInfo.chineseName = "詢問處"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "MT"; codeInfo.name = "MEN'S TOILET"; codeInfo.chineseName = "男洗手間"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "MO"; codeInfo.name = "MOTORCYCLE"; codeInfo.chineseName = "機車"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M1"; codeInfo.name = "TRTS ROUTE MAP(OLD) (800W X 1200H)"; codeInfo.chineseName = "路網圖(舊站) (800寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M2"; codeInfo.name = "STATION LOCATION MAP(OLD) (800W X 1200H)"; codeInfo.chineseName = "車站配置圖(舊站) (800寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M3"; codeInfo.name = "STATION LOCATION MAP(OLD) (800W X 1200H)"; codeInfo.chineseName = "周邊地圖(舊站) (800寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M4"; codeInfo.name = "EXIT INFORMATION MAP(OLD) (800W X 1200H)"; codeInfo.chineseName = "出口列表(舊站) (800寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M6E"; codeInfo.name = "FARE MAP (900W X 300H)"; codeInfo.chineseName = "票價路網圖(舊站) (900寬X300高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M7"; codeInfo.name = "TRTS ROUTE MAP(OLD) (990W X 1500H)"; codeInfo.chineseName = "路網圖(舊站) (990寬X1500高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M8"; codeInfo.name = "STATION INFORMATION MAP(OLD) (990W X 1500H)"; codeInfo.chineseName = "車站配置圖(舊站) (990寬X1500高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M9"; codeInfo.name = "STATION LOCATION(OLD) (990W X 1500H)"; codeInfo.chineseName = "周邊地圖(舊站) (990寬X1500高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M11"; codeInfo.name = "EXIT INFORMATION MAP(OLD) (990W X 1500H)"; codeInfo.chineseName = "出口列表(舊站) (990寬X1500高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M12"; codeInfo.name = "TRTS ROUTE MAP (1200W X 1200H)"; codeInfo.chineseName = "路網圖 (1200寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M13"; codeInfo.name = "STATION LOCATION MAP (1200W X 1200H)"; codeInfo.chineseName = "車站配置圖 (1200寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M14"; codeInfo.name = "SURROUNDING MAPS/TRANSFER INFORMATION (1200W X 1200H)"; codeInfo.chineseName = "周邊地圖/轉乘資訊 (1200寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M15"; codeInfo.name = "EXIT INFORMATION MAP (1200W X 1200H)"; codeInfo.chineseName = "出口列表 (1200寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M16"; codeInfo.name = "TRTS ROUTE MAP (800W X 1200H)"; codeInfo.chineseName = "路網圖 (800寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M17"; codeInfo.name = "STATION LOCATION MAP (800W X 1200H)"; codeInfo.chineseName = "車站配置圖 (800寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M18"; codeInfo.name = "SURROUNDING MAPS/TRANSFER INFORMATION (800W X 1200H)"; codeInfo.chineseName = "周邊地圖/轉乘資訊圖 (800寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M19"; codeInfo.name = "EXIT INFORMATION MAP (800W X 1200H)"; codeInfo.chineseName = "出口列表 (800寬X1200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M20"; codeInfo.name = "PLAN OF FIRE FIGHTING FACILITIES (600W X 400H)"; codeInfo.chineseName = "消防設施平面圖 (600寬X400高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M21"; codeInfo.name = "SINGLE ROUTE MAP ON THE PLATFORM DOOR (≥1080W X 200H)"; codeInfo.chineseName = "月台門上單一路線圖(半罩式) (≥1080寬X200高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M22"; codeInfo.name = "SINGLE ROUTE MAP ON THE PLATFORM DOOR (≥2150W X 355H)"; codeInfo.chineseName = "月台門上單一路線圖(全罩式) (≥2150寬X335高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M23"; codeInfo.name = "SINGLE ROUTE MAP ON THE PLATFORM DOOR (≥2400W)"; codeInfo.chineseName = "PELU及設備帶上單一路線圖(全罩式) (≥2400寬)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M24"; codeInfo.name = "COMPREHENSIVE STATION INFORMATION (1200W X 600H)"; codeInfo.chineseName = "車站綜合資訊橫幅 (1200寬X600高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M25"; codeInfo.name = "COMPREHENSIVE STATION INFORMATION (2400W X 600H)"; codeInfo.chineseName = "車站綜合資訊橫幅 (2400寬X600高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M26"; codeInfo.name = "COMPREHENSIVE STATION INFORMATION (3600W X 600H)"; codeInfo.chineseName = "車站綜合資訊橫幅 (3600寬X600高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M27"; codeInfo.name = "COMPREHENSIVE STATION INFORMATION (4800W X 600H)"; codeInfo.chineseName = "車站綜合資訊橫幅 (4800寬X600高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M28"; codeInfo.name = "COMPREHENSIVE STATION INFORMATION (800W X 250H)"; codeInfo.chineseName = "車站綜合資訊橫幅 (800寬X250高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M29"; codeInfo.name = "COMPREHENSIVE STATION INFORMATION (1600W X 250H)"; codeInfo.chineseName = "車站綜合資訊橫幅 (1600寬X250高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M30"; codeInfo.name = "COMPREHENSIVE STATION INFORMATION (2400W X 250H)"; codeInfo.chineseName = "車站綜合資訊橫幅 (2400寬X250高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M51"; codeInfo.name = "INFORMATION MAP FOR ELEVATOR ROUTE (400W X 600H)"; codeInfo.chineseName = "電梯樓層索引圖 (400寬X600高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M52"; codeInfo.name = "ELEVATOR PRIORITY (400W X 250H)"; codeInfo.chineseName = "電梯優先搭乘圖 (400寬X250高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "M53"; codeInfo.name = "ELEVATOR LOCATION MAP (400W X 500H)"; codeInfo.chineseName = "電梯位置圖 (1200寬X600高)"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "NE"; codeInfo.name = "NO ENTRY"; codeInfo.chineseName = "禁止進入"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "P"; codeInfo.name = "CAR PARKING"; codeInfo.chineseName = "小客車停車場"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "PC"; codeInfo.name = "PARENTAL CARE TOILETS"; codeInfo.chineseName = "親子廁所"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "PT"; codeInfo.name = "PUBLIC TELEPHONE"; codeInfo.chineseName = "公共電話"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "SB"; codeInfo.name = "STANDBY RM"; codeInfo.chineseName = "後勤室"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "SD"; codeInfo.name = "SITE DIRECTIONAL"; codeInfo.chineseName = "地面層方向指示"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "SF"; codeInfo.name = "STAIRWELL FLOOR MARKINGS"; codeInfo.chineseName = "樓梯間樓層標示"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "SL"; codeInfo.name = "STAIRWELL LANDING SIGN"; codeInfo.chineseName = "樓梯間平台標示"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "SI"; codeInfo.name = "STATION IDENTITY"; codeInfo.chineseName = "車站識別"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "SN"; codeInfo.name = "STATION NAME"; codeInfo.chineseName = "車站名"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "ST"; codeInfo.name = "STAIRS"; codeInfo.chineseName = "樓梯"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "T"; codeInfo.name = "TICKETING"; codeInfo.chineseName = "售票處"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "TRTS"; codeInfo.name = "TRTS LOGO"; codeInfo.chineseName = "臺北捷運系統識別標示"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "TP"; codeInfo.name = "TO PLATFORM"; codeInfo.chineseName = "往月台"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "TS"; codeInfo.name = "TOILET"; codeInfo.chineseName = "洗手間"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "TTS"; codeInfo.name = "TO OTHER TRANSPORT SYSTEMS"; codeInfo.chineseName = "往其他運輸系統"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "TX"; codeInfo.name = "CAR/TAXI - SHORT TERM PARKING MESSAGE"; codeInfo.chineseName = "小客車/計程車 - 暫停資訊"; codeInfoList.Add(codeInfo);
            codeInfo = new CodeInfo(); codeInfo.code = "-"; codeInfo.name = "NO MESSAGE REQUIRED"; codeInfo.chineseName = "無須資訊"; codeInfoList.Add(codeInfo);

            return codeInfoList;
        }

        public string GetName()
        {
            return "Event handler is working now!!";
        }
    }
}
