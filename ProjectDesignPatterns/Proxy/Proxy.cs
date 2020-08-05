namespace Proxy
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            if (this.realSubject == null)
            {
                this.realSubject = new RealSubject();
            }
            this.realSubject.Request();
        }
    }
}
