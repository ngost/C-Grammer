using System;
using System.Threading.Tasks;
using System.Threading;
namespace _Net_Grammer.Grammer.Basic
{
    public class AwaitGrammer : GrammerInterface
    {
        // C# async는 컴파일러에게 해당 메서드가 await를 가지고 있음을 알려주는 역활을 한다. async라고 표시된 메서드는 await를 1개 이상 가질 수 있다
        public AwaitGrammer()
        {
        }

        public void PrintConsole()
        {
            ButtonClick();
        }

        public void ButtonClick()
        {
            Run();
        }

        private async void Run()
        {
            // 비동기로 Worker Thread에서 도는 task1
            var task1 = Task.Run(() => LongCalcAsync(10));

            // 콘솔프로그램인 경우 SynchronizationContext가 null
            Console.WriteLine(SynchronizationContext.Current);

            // task1이 끝나길 기다렸다가 끝나면 결과치를 sum에 할당
            int sum = await task1;

            // Worker Thread 에서 실행
            Console.WriteLine(sum);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        private int LongCalcAsync(int times)
        {
            int result = 0;
            for (int i = 0; i < times; i++)
            {
                result += i;
                Thread.Sleep(1000);
            }
            return result;
        }

    }
}
