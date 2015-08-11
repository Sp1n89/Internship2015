using IoCExample.Bll;

namespace IoCExample.Presentation
{
    public class PersonPresentation
    {
        private readonly IBll _bll;

        public PersonPresentation(IBll bll)
        {
            _bll = bll;
        }
    }
}