using TSP2025.Common;
using TSP2025.Data.Model;
using TSP2025.Data;
using TSP2025.Utils;

namespace TSP2025.Managers
{
    public class Manager<T> : IManager where T : IEntity
    {
        private Button _AddButton;
        private Button _RemoveButton;
        private Button _SaveButton;
        private Button _CancelButton;
        private Button _NextTabButton;
        private Button _PrevTabButton;
        private DataGridView _GridView;
        private GroupBox _GroupBoxWithInputControls;
        private TextBox _FirstInputTextBox;
        private ComboBox _ParentChoice;
        private BindingSource _BindingSource;
        private PoslovniSistemDataContext _DataSource;
        private TabControl _MainTabControl;
        private Button _AddMernoMestoButton;

        private T Current
        {
            get
            {
                return (T)_BindingSource.Current;
            }
        }

        private IList<T> CurrentAll
        {
            get
            {
                return (IList<T>)_BindingSource.List;
            }
        }

        private Manager() { }

        public Manager(
            Button addButton,
            Button removeButton,
            Button saveButton,
            Button cancelButton,
            Button nextTabButton,
            Button prevTabButton,
            DataGridView gridView,
            GroupBox groupBoxWithInputControls,
            TextBox firstInputTextBox,
            ComboBox parentChoice,
            BindingSource bindingSource,
            PoslovniSistemDataContext dataSource,
            TabControl mainTabControl,
            Button addMernoMestoButton)
        {
            _AddButton = addButton;
            _RemoveButton = removeButton;
            _SaveButton = saveButton;
            _CancelButton = cancelButton;
            _NextTabButton = nextTabButton;
            _PrevTabButton = prevTabButton;
            _GridView = gridView;
            _GroupBoxWithInputControls = groupBoxWithInputControls;
            _FirstInputTextBox = firstInputTextBox;
            _ParentChoice = parentChoice;
            _BindingSource = bindingSource;
            _DataSource = dataSource;
            _MainTabControl = mainTabControl;
            _AddMernoMestoButton = addMernoMestoButton;
            _BindingSource.CurrentChanged += _BindingSource_CurrentChanged;            
        }

        private void _BindingSource_CurrentChanged(object? sender, EventArgs e)
        {
            if (_AddMernoMestoButton != null)
            {
                _AddMernoMestoButton.Visible = false;
                if (_BindingSource.Current != null && !(_BindingSource.Current as IEntity)!.ImaMernoMesto && (_BindingSource.Current as IEntity)!.Id > 0)
                {
                    _AddMernoMestoButton.Visible = true;
                }
            }
        }
        public void Add(IEntity newEntity)
        {
            _BindingSource.Add(newEntity);
            _BindingSource.MoveLast();
            SetControlsToRegime(FormMode.AddOrUpdate, _AddButton, _RemoveButton, _SaveButton, _CancelButton, _NextTabButton, _PrevTabButton, _GridView, _GroupBoxWithInputControls, _FirstInputTextBox, _ParentChoice);
        }
        public void Edit()
        {
            SetControlsToRegime(FormMode.AddOrUpdate, _AddButton, _RemoveButton, _SaveButton, _CancelButton, _NextTabButton, _PrevTabButton, _GridView, _GroupBoxWithInputControls, _FirstInputTextBox, _ParentChoice);
        }
        public void Remove()
        {
            if (_BindingSource.Current != null)
            {
                var item = (T)_BindingSource.Current;
                _BindingSource.RemoveCurrent();

                try
                {
                    item.Delete();
                    _BindingSource.MoveFirst();
                }
                catch
                {
                    throw;
                }
            }
        }
        public void Cancel()
        {
            if (Current.Id == 0)
            {
                _BindingSource.RemoveCurrent();
            }
            SetControlsToRegime(FormMode.Preview, _AddButton, _RemoveButton, _SaveButton, _CancelButton, _NextTabButton, _PrevTabButton, _GridView, _GroupBoxWithInputControls, _FirstInputTextBox, _ParentChoice);
            _BindingSource.MoveFirst();
        }
        public void Next()
        {
            if (_MainTabControl.SelectedIndex < _MainTabControl.TabCount - 1)
            {
                _MainTabControl.SelectedIndex = _MainTabControl.SelectedIndex + 1;
            }
        }
        public void Previous()
        {
            if (_MainTabControl.SelectedIndex > 0)
            {
                _MainTabControl.SelectedIndex = _MainTabControl.SelectedIndex - 1;
            }
        }
        public void Save()
        {
            // za update
            var zaUpdate = CurrentAll.Where(t => t.IsChanged && t.Id > 0 && !t.IsDeleted).ToList();
            foreach (var item in zaUpdate)
            {
                try
                {
                    item.Update();
                }
                catch
                {
                    throw;
                }
            }

            // za create
            var zaCreate = CurrentAll.Where(t => t.IsChanged && !t.IsDeleted && t.Id == 0).ToList();
            foreach (var item in zaCreate)
            {
                try
                {
                    item.Create();
                    if (_AddMernoMestoButton != null)
                    {
                        _AddMernoMestoButton.Visible = true;
                    }
                }
                catch
                {
                    throw;
                }
            }
            SetControlsToRegime(FormMode.Preview, _AddButton, _RemoveButton, _SaveButton, _CancelButton, _NextTabButton, _PrevTabButton, _GridView, _GroupBoxWithInputControls, _FirstInputTextBox, _ParentChoice);
        }
        private void SetControlsToRegime(
            FormMode regime,
            Button addButton,
            Button removeButton,
            Button saveButton,
            Button cancelButton,
            Button nextTabButton,
            Button prevTabButton,
            DataGridView gridView,
            GroupBox groupBoxWithInputControls,
            TextBox firstInputTextBox,
            ComboBox parentChoice)
        {
            if (regime == FormMode.Preview)
            {
                addButton.Enabled = true;
                removeButton.Enabled = true;
                saveButton.Visible = false;
                cancelButton.Visible = false;
                gridView.Enabled = true;
                groupBoxWithInputControls.Enabled = false;
                if (parentChoice != null)
                {
                    parentChoice.Enabled = true;
                }
                if (prevTabButton != null)
                {
                    prevTabButton.Enabled = true;
                }
                if (nextTabButton != null)
                {
                    nextTabButton.Enabled = true;
                }
            }
            else if (regime == FormMode.AddOrUpdate)
            {
                addButton.Enabled = false;
                removeButton.Enabled = false;
                saveButton.Visible = true;
                cancelButton.Visible = true;
                gridView.Enabled = false;
                groupBoxWithInputControls.Enabled = true;
                firstInputTextBox.Focus();
                firstInputTextBox.SelectAll();
                if (parentChoice != null)
                {
                    parentChoice.Enabled = false;
                }
                if (prevTabButton != null)
                {
                    prevTabButton.Enabled = false;
                }
                if (nextTabButton != null)
                {
                    nextTabButton.Enabled = false;
                }
            }
        }
    }

}
