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
                default:
                    return null;
            }
        }
    }
}
