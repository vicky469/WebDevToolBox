using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCode.NET.async;

public class Program : Form
{
    public static async Task Main(string[] args)
    {
        Application.Run(new Program());
    }

    public Program()
    {
        for (int i = 0; i < 1000; i++)
        {
            WaitCallback waitCallback = state =>
            {
                Thread.Sleep(1000);
                Console.WriteLine($"i: {i} .Thread {Thread.CurrentThread.ManagedThreadId} is running");
            };
            ThreadPool.QueueUserWorkItem(waitCallback);
        }

        // if UI
        this.BeginInvoke(new Action(() =>
        {
            Console.WriteLine("UI Thread");
        }));
    }
}