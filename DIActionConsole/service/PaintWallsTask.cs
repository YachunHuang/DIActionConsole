namespace DIActionConsole.service
{
    /// <summary>
    /// 油漆工實作
    /// </summary>
    internal class PaintWallsTask : IRenovationTask
    {
        public string Description { get; } = "牆面粉刷，顏色：白色";

        public void Execute(string taskDescription)
        {
            Console.WriteLine("油漆工執行: " + taskDescription);
        }
    }
}
