namespace DIActionConsole.service
{
    /// <summary>
    ///  水電工實作
    /// </summary>
    internal class InstallElectricalWiringTask : IRenovationTask
    {
        public string Description { get; } = "安裝廚房和浴室的電線";

        public void Execute(string taskDescription)
        {
            Console.WriteLine("水電工執行: " + taskDescription);
        }
    }
}
