﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Skua.Core.Interfaces;
using Skua.Core.Messaging;
using Skua.Core.Models.Items;
using Skua.Core.Models.Skills;

namespace Skua.Core.ViewModels;
public partial class AutoViewModel : BotControlViewModelBase
{
    public AutoViewModel(IScriptAuto auto, IScriptInventory inventory, IAdvancedSkillContainer advancedSkills)
        : base("Auto Attack")
    {
        StrongReferenceMessenger.Default.Register<AutoViewModel, StopAutoMessage>(this, async (r, m) => await r.StopAutoAsync());
        StrongReferenceMessenger.Default.Register<AutoViewModel, StartAutoAttackMessage>(this, async (r, m) => await r.StartAutoAttack());
        StrongReferenceMessenger.Default.Register<AutoViewModel, StartAutoHuntMessage>(this, async (r, m) => await r.StartAutoHunt());

        Auto = auto;
        _inventory = inventory;
        _advancedSkills = advancedSkills;
        StopAutoAsyncCommand = new AsyncRelayCommand(StopAutoAsync);
    }

    private readonly IScriptInventory _inventory;
    private readonly IAdvancedSkillContainer _advancedSkills;
    [ObservableProperty]
    private ClassUseMode? _selectedClassMode;
    [ObservableProperty]
    private bool _useSelectedClass;

    public IScriptAuto Auto { get; }
    public List<string>? PlayerClasses => _inventory.Items?.Where(i => i.Category == ItemCategory.Class).Select(i => i.Name).ToList();

    private string? _selectedClass;
    public string? SelectedClass
    {
        get { return _selectedClass; }
        set
        {
            if(SetProperty(ref _selectedClass, value) && value is not null)
            {
                CurrentClassModes = new();
                CurrentClassModes.AddRange(_advancedSkills.LoadedSkills.Where(s => s.ClassName == _selectedClass).Select(s => s.ClassUseMode));
                OnPropertyChanged(nameof(CurrentClassModes));
            }
        }
    }

    public List<ClassUseMode>? CurrentClassModes { get; private set; }
    public IAsyncRelayCommand StopAutoAsyncCommand { get; }

    [RelayCommand]
    private void ReloadClasses()
    {
        OnPropertyChanged(nameof(PlayerClasses));

        CurrentClassModes = null;
        SelectedClass = null;
        SelectedClassMode = null;
    }

    [RelayCommand]
    private async Task StartAutoHunt()
    {
        if (UseSelectedClass && _selectedClass is not null && _selectedClassMode is not null)
        {
            await Task.Factory.StartNew(() => Auto.StartAutoHunt(_selectedClass, (ClassUseMode)_selectedClassMode));
            return;
        }

        await Task.Factory.StartNew(() => Auto.StartAutoHunt());
    }

    [RelayCommand]
    private async Task StartAutoAttack()
    {
        if (UseSelectedClass && _selectedClass is not null && _selectedClassMode is not null)
        {
            await Task.Factory.StartNew(() => Auto.StartAutoAttack(_selectedClass, (ClassUseMode)_selectedClassMode));
            return;
        }

        await Task.Factory.StartNew(() => Auto.StartAutoAttack());
    }

    private async Task StopAutoAsync()
    {
        await Auto.StopAsync();
    }
}
