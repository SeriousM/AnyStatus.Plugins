﻿using AnyStatus.API;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnyStatus
{
    [DisplayColumn("Metrics")]
    [DisplayName("Process CPU Usage")]
    [Description("Shows the percentage of CPU usage for a single process")]
    public class CpuProcessUsage : Sparkline, ISchedulable
    {
        public CpuProcessUsage()
        {
            Symbol = "%";
            Interval = 10;
            Units = IntervalUnits.Seconds;
            Name = "CPU Process Usage";
            MaxValue = 100;
        }

        [Category("Process CPU Usage")]
        [DisplayName("Machine Name")]
        [Description("Optional. Leave blank for local computer.")]
        public string MachineName { get; set; }

        [Required]
        [Category("Process CPU Usage")]
        [DisplayName("Process Name")]
        [Description("Usually the file name without extension")]
        public string ProcessName { get; set; }
    }
}