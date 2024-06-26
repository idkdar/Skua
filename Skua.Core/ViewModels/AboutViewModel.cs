﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Skua.Core.Utils;
using System.Diagnostics;

namespace Skua.Core.ViewModels;
public class AboutViewModel : BotControlViewModelBase
{
    private string _markDownContent = "Loading content...";
    
    public AboutViewModel() : base("About")
    {
        _markDownContent = string.Empty;
        
        Task.Run(async () => await GetAboutContent());
        
        NavigateCommand = new RelayCommand<string>(url => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true }));
    }

    public string MarkdownDoc
    {
        get { return _markDownContent; }
        set { SetProperty(ref _markDownContent, value); }
    }

    public IRelayCommand NavigateCommand { get; }

    private async Task GetAboutContent()
    {
        using(var client = new HttpClient())
        {
            var response = await client.GetAsync("https://raw.githubusercontent.com/BrenoHenrike/Skua/op-version/about.md");
            if (!response.IsSuccessStatusCode)
                MarkdownDoc = "### No content found. Please check your internet connection.";

            MarkdownDoc = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }
    }
}
