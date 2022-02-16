using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using MvvmHelpers;
using InterviewApp.Models;

namespace InterviewApp.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        public Guid? Id { get; set; }

        private string? _text;
        public string? Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        private string? _description;
        public string? Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string? _itemId;
        public string? ItemId
        {
            get => _itemId;
            set => SetProperty(ref _itemId, value, onChanged: () => LoadAsync(Guid.TryParse(_itemId, out Guid guid) ? guid : Guid.Empty).SafeFireAndForget());
        }

        public async Task LoadAsync(Guid itemId)
        {
            try
            {
                if (itemId.Equals(Guid.Empty))
                    return;

                Item? item = await DataStore.GetItemAsync(itemId);

                Id          = item?.Id;
                Text        = item?.Text;
                Description = item?.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
