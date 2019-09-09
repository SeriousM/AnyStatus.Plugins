﻿using AnyStatus.API;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnyStatus.Plugins.Widgets.NuGet
{
    [DisplayColumn("NuGet")]
    [DisplayName("NuGet Package")]
    [Description("Get NuGet package information.")]
    public class NuGetPackageWidget : Metric
    {
        [DisplayName("Package Id")]
        [Description("The NuGet package id. For example: AnyStatus.API")]
        public string PackageId { get; set; }

        [DisplayName("Package Source")]
        [Description("The NuGet server feed URL. Official NuGet package source: https://api.nuget.org/v3/index.json")]
        public string PackageSource { get; set; } = "https://api.nuget.org/v3/index.json";
    }
}
