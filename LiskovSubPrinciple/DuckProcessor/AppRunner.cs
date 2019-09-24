using LiskovSubPrinciple.BaseClass;

namespace LiskovSubPrinciple
{
    public class DuckProcessor
    {
        public void Process(DuckBase duck)
        {
            duck.StopSwimming();
        }
    }
}