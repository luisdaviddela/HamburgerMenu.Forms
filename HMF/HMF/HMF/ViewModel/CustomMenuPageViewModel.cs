using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
namespace HMF
{
    public class CustomMenuPageViewModel: BindableBase
    {
        private ObservableCollection<MenuModel> listCategories;
        public ObservableCollection<MenuModel> ListCategories
        {
            get { return listCategories; }
            set { SetProperty(ref listCategories, value); }
        }
        private MenuModel selectedCategories;
        public MenuModel SelectedCategories
        {
            get { return selectedCategories; }
            set
            {
                if (selectedCategories != value)
                {
                    SetProperty(ref selectedCategories, value);
                    OnTapSelectedCategories();
                }
            }
        }



        


        #region Constructor
        public CustomMenuPageViewModel()
        {
            TapCerrarSesionCommand = new Command(TapCerrarSesion);
            ListCategories = new ObservableCollection<MenuModel>();
            ListCategories.Add(new MenuModel
            {
                IdMenu = 1,
                TitleItemMenu = "Pérfil",
                ImageItemMenu = ""
            });
            ListCategories.Add(new MenuModel
            {
                IdMenu = 2,
                TitleItemMenu = "Evaluación de equipo y herramienta",
                ImageItemMenu = ""
            });
            ListCategories.Add(new MenuModel
            {
                IdMenu = 3,
                TitleItemMenu = "Inspección trimestral",
                ImageItemMenu = ""
            });
        }
        #endregion

        #region Commands
        public ICommand TapCerrarSesionCommand { get; set; }
        #endregion

        #region Methods
        private void TapCerrarSesion()
        {
        }
        private async void OnTapSelectedCategories()
        {
            if (SelectedCategories.IdMenu == 1)
            {
                App.MasterDetail.IsPresented = false;
            }
         
        }
        #endregion
    }
}
