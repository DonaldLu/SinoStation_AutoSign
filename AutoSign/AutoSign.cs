using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace AutoSign
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    [Journaling(JournalingMode.NoCommandData)]
    public class AutoSign : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            RevitDocument m_connect = new RevitDocument(commandData.Application);
            IExternalEventHandler handler_SignCheck = new SignCheck(); // 指標校核
            ExternalEvent externalEvent_SignCheck = ExternalEvent.Create(handler_SignCheck);
            AutoSignForm autoSignForm = new AutoSignForm(commandData.Application, m_connect, externalEvent_SignCheck);
            autoSignForm.Show();

            return Result.Succeeded;
        }
    }
}
