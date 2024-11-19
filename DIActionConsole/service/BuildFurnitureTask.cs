namespace DIActionConsole.service
{
    /// <summary>
    /// 木工實作
    /// </summary>
    internal class BuildFurnitureTask : IRenovationTask
    {
        public string Description { get; } = "訂製客廳沙發和茶几";

        public void Execute(string taskDescription)
        {
            Console.WriteLine("木工執行: " + taskDescription);
        }
    }
}
