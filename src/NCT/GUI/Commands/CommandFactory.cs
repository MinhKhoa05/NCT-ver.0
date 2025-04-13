using System;

namespace GUI.Commands
{
    public static class CommandFactory
    {
        public static ICommand CreateCommand(string type)
        {
            switch (type)
            {
                case "Room":
                    return new RoomCommand();
                case "Tenant":
                    return new TenantCommand();
                case "Contract":
                    return new ContractCommand();
                default:
                    throw new InvalidOperationException($"Chưa hỗ trợ cho Command: {type}");
            }
        }
    }
}
