using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using CatchAll.Data;
using CatchAll.Models;
using CatchAll.Seeds;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TestScripts
{
    public class Program
    {
        public static void Main(string[] args)
        {
          string desktopPath = @"/Users/anthonyhoopes/desktop";
          string folderName = "TestTree";

          string folderPath = Path.Combine(desktopPath, folderName);

          Directory.CreateDirectory(folderPath);
        }
    }
}
