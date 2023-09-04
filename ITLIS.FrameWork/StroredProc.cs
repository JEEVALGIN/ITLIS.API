namespace ITLIS.FrameWork
{
    public class StroredProc
    {
        public class InventooryDetail
        {

            public const string InventorySelectSP = "[Inventory].[InventorySelectSP]";
            public const string InventoryInsertSP = "[Inventory].[InventoryInsertSP]";
            public const string InventorySelectByIdSP = "[Inventory].[InventorySelectByIdSP]";
            public const string InventoryUpdateSP = "[Inventory].[InventoryUpdateSP]";
            public const string InventoryDeleteSP = "[Inventory].[InventoryDeleteSP]";

        }
        public class EmployeeDetails
        {
            public const string EmployeeSelectSP = "[Employee].[EmployeeSelectSP]";
            public const string EmployeeInsertSP = "[Employee].[EmployeeInsertSP]";
            public const string EmployeeSelecByIdtSP = "[Employee].[EmployeeSelecByIdtSP]";
            public const string EmployeeUpdateSP = "[Employee].[EmployeeUpdateSP]";
            public const string EmployeeDeleteSP = "[Employee].[EmployeeDeleteSP]";
        }
    }
}