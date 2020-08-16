using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Playground
{
    public interface INavigationService
    {
        Page CurrentPage { get; }

        int NavigationStackCount { get; }

        int ModalStackCount { get; }

        Page PreviousPage { get; }

        Task PushAsync(Page page);

        Task PopAsync();

        Task PopToRootAsync();
    }
}
