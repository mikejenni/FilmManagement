using FilmManagement.Business.Services;
using FilmManagement.Persistence.Database;
using FilmManagement.UI.Helpers;
using FilmManagement.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace FilmManagement.UI.ViewModels
{
    public class FilmManagementViewModel : ViewModelBase
    {
        private enum EditMode { New, Edit };
        private EditMode _eMode;
        private IFilmService _repoFilm = new FilmRepository();
        private IGenreService _repoGenre = new GenreRepository();
        private IFilmValidatorService _filmValidator = new FilmValidatorService();


        private ObservableCollection<FilmModel> _filmList = new ObservableCollection<FilmModel>();
        public ObservableCollection<FilmModel> FilmList
        {
            get { return _filmList; }
            set
            {
                _filmList = value;
                RaisePropertyChanged(nameof(FilmList));
            }
        }

        private ObservableCollection<GenreModel> _genreList = new ObservableCollection<GenreModel>();
        public ObservableCollection<GenreModel> GenreList
        {
            get { return _genreList; }
            set
            {
                _genreList = value;
                RaisePropertyChanged(nameof(GenreList));
            }
        }

        private ObservableCollection<string> _genreListNamen = new ObservableCollection<string>();
        public ObservableCollection<string> GenreListNamen
        {
            get { return new ObservableCollection<string>(GenreList.Select(x => x.Name)); }
            set
            {
                _genreListNamen = value;
                RaisePropertyChanged(nameof(GenreListNamen));
            }
        }

        private FilmModel _selectedFilm = new FilmModel();
        public FilmModel SelectedFilm
        {
            get { return _selectedFilm; }
            set
            {
                _selectedFilm = value;
                RaisePropertyChanged(nameof(SelectedFilm));
            }
        }

        private string _searchWord = string.Empty;
        public string SearchWord
        {
            get { return _searchWord; }
            set
            {
                _searchWord = value;
                RaisePropertyChanged(nameof(SearchWord));
            }
        }


        private SolidColorBrush _newEntryBackground = new SolidColorBrush(Colors.White);
        public SolidColorBrush NewEntryBackground
        {
            get { return _newEntryBackground; }
            set
            {
                _newEntryBackground = value;
                RaisePropertyChanged(nameof(NewEntryBackground));
            }
        }

        private bool _isEnabled = true;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                RaisePropertyChanged(nameof(IsEnabled));
            }
        }

        public FilmManagementViewModel()
        {
            GetFilmList();
            GetGenreList();
            GenreListNamen = new ObservableCollection<string>(GenreList.Select(x => x.Name));
            _eMode = EditMode.Edit;
        }

        private void RefreshFilmList()
        {
            FilmList.Clear();
            GetFilmList(SearchWord);
        }

        private Film CreateNewFilm(FilmModel selectedFilm)
        {
            bool isValidFilm = _filmValidator.ValidateFilm(selectedFilm);
            if (isValidFilm == false)
            {
                MessageBox.Show($"Bitte alle Felder komplett ausfüllen!", "Hinweis", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return null;

            }
            var film = new Film()
            {
                Id = selectedFilm.Id,
                Genre = selectedFilm.Genre,
                GenreId = GenreList.FirstOrDefault(x => x.Name.Equals(selectedFilm.GenreName))?.GenreId,
                Director = selectedFilm.Director,
                PlayTime = selectedFilm.PlayTime,
                Rating = selectedFilm.Rating,
                ReleaseYear = selectedFilm.ReleaseYear,
                TitleName = selectedFilm.TitleName

            };
            return film;
        }

        private bool CanExecute()
        {
            return true;
        }

        public void GetFilmList(string searchWord = null)
        {
            var tmpFilmList = string.IsNullOrEmpty(searchWord)
                ? _repoFilm.GetFilmList()
                : _repoFilm.GetFilmList().Where(x => x.TitleName.ToUpper().Contains(searchWord.ToUpper()));

            foreach (var item in tmpFilmList)
            {
                FilmList.Add(new FilmModel()
                {
                    Id = item.Id,
                    Genre = item.Genre,
                    GenreId = item.GenreId,
                    Director = item.Director,
                    PlayTime = item.PlayTime,
                    Rating = item.Rating,
                    ReleaseYear = item.ReleaseYear,
                    TitleName = item.TitleName,
                    GenreName = item.Genre.Name

                });
            }
        }

        private void GetGenreList()
        {
            var tmpGenreList = _repoGenre.GetGenreList();
            foreach (var item in tmpGenreList)
            {
                GenreList.Add(new GenreModel()
                {
                    GenreId = item.GenreId,
                    Name = item.Name
                });
            }
        }


        private void NewEntryExecute()
        {
            SelectedFilm = null;
            if (_eMode == EditMode.Edit)
            {
                _eMode = EditMode.New;
                NewEntryBackground = Brushes.Green;
                IsEnabled = false;
            }
            else
            {
                _eMode = EditMode.Edit;
                NewEntryBackground = Brushes.White;
                IsEnabled = true;
            }

            if (SelectedFilm != null)
                return;
            SelectedFilm = new FilmModel { GenreName = GenreListNamen.FirstOrDefault() };
        }

        public ICommand NewEntry
        {
            get { return new RelayCommand(NewEntryExecute, CanExecute); }
        }

        private void SaveExecute()
        {
            Film resultFilm;
            if (_eMode == EditMode.Edit)
            {
                if (SelectedFilm == null)
                    return;
                resultFilm = CreateNewFilm(SelectedFilm);
                if (resultFilm == null)
                    return;
                _repoFilm.UpdateFilm(resultFilm);
            }
            else
            {
                resultFilm = CreateNewFilm(SelectedFilm);
                if (resultFilm == null)
                    return;
                _repoFilm.EntryFilm(resultFilm);
            }
            RefreshFilmList();
        }

        public ICommand Save
        {
            get { return new RelayCommand(SaveExecute, CanExecute); }
        }

        private void DeleteExecute()
        {
            if (SelectedFilm == null)
                return;

            _repoFilm.DeleteFilm(SelectedFilm.Id);
            RefreshFilmList();
        }

        public ICommand Delete
        {
            get { return new RelayCommand(DeleteExecute, CanExecute); }
        }

        private void SearchExecute()
        {
            RefreshFilmList();
        }

        public ICommand Search
        {
            get { return new RelayCommand(SearchExecute, CanExecute); }
        }

    }
}
