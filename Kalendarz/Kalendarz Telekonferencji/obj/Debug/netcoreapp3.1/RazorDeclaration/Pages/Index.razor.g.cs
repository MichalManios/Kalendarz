#pragma checksum "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39a4c7d33d825a91feab7ff0663d6db457d72959"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Kalendarz_Telekonferencji.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using Kalendarz_Telekonferencji;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using Kalendarz_Telekonferencji.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Pages\Index.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Pages\Index.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Pages\Index.razor"
using Kalendarz_Telekonferencji.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Pages\Index.razor"
using Kalendarz_Telekonferencji.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Pages\Index.razor"
using Kalendarz_Telekonferencji.Data.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 210 "C:\PROJEKTY\KALENDARZ\Kalendarz Telekonferencji ZZ GOTOWY PROJEKT\Kalendarz Telekonferencji\Pages\Index.razor"
 

    List<CalendarViewModel> calendarList = new List<CalendarViewModel>();
    CalendarViewModel calendar = new CalendarViewModel();
    int iIdOfCalendarEvent = -1;
    Date date = new Date(DateTime.Today);
    string sDayFromCalendarClick { set; get; } = "";
    string[] classField = new string[42];
    int oldIndex = -1;
    int[] day = new int[42];

    void SetClassField()
    {
        for (int i = 0; i < 42; i++)
        {
            classField[i] = "calendarField";
        }
    }

    void SelectField(int index)
    {

        if (classField[index] == "calendarField")
        {
            classField[index] = "calendarFieldActive calendarField";
        }
        else
        {
            classField[index] = "calendarField";
        }

        if (oldIndex != -1)
        {
            classField[oldIndex] = "calendarField";
        }
        oldIndex = index;
        sDayFromCalendarClick = day[index].ToString();
    }

    protected override async Task OnInitializedAsync()
    {
        await CreateAdminAccount();
        SetClassField();
        //date = new Date(DateTime.Today);
        //załadowanie wszystkich eventów do listy view modeli calendarList
        sDayFromCalendarClick = DateTime.Today.Day.ToString();
        calendarList = await calendarServices.GetCalendarsByMonthAsync(new DateTime(Convert.ToInt32(date.Year), date.Month, Convert.ToInt32(sDayFromCalendarClick), 0, 0, 0));//.GetAllCalendarsAsync();//.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ThenBy(x => x.TimeStart).ToList();
    }

    void GoMonth()
    {
        navigationManager.NavigateTo("/", true);
    }

    async Task GoWeekAsync()
    {

        if (sDayFromCalendarClick != "")
        {
            DateTime selectedDate = new DateTime(Convert.ToInt32(date.Year), date.Month, Convert.ToInt32(sDayFromCalendarClick), 0, 0, 0);
            //navigationManager.NavigateTo("/week/"+selectetDate.Date.ToShortDateString(), true);
            navigationManager.NavigateTo($"/week/{selectedDate.Date.ToShortDateString()}");
        }
        else
        {
            await JsRuntime.InvokeVoidAsync("Alert");
        }
    }

    async Task GoDayAsync()
    {
        if (sDayFromCalendarClick != "")
        {
            DateTime selectedDate = new DateTime(Convert.ToInt32(date.Year), date.Month, Convert.ToInt32(sDayFromCalendarClick), 0, 0, 0);
            navigationManager.NavigateTo($"/day/{selectedDate.Date.ToShortDateString()}");
        }
        else
        {
            await JsRuntime.InvokeVoidAsync("Alert");
        }
    }


    bool bShowEvent = false;
    async Task ShowEventAsync(int IdOfCalendarEvent)
    {
        iIdOfCalendarEvent = IdOfCalendarEvent;
        calendar = await calendarServices.GetCalendarByIdAsync(iIdOfCalendarEvent);
        bShowEvent = true;
    }

    void CloseEvent()
    {
        bShowEvent = false;
        //navigationManager.NavigateTo("/", true);
    }

    async Task MovePreviousMonthAsync()
    {
        sDayFromCalendarClick = date.GetPreviousMonth();
        if (oldIndex != -1)
        {
            classField[oldIndex] = "calendarField";
        }
        calendarList = await calendarServices.GetCalendarsByMonthAsync(new DateTime(Convert.ToInt32(date.Year), date.Month, 1, 0, 0, 0));//.GetAllCalendarsAsync();//.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ThenBy(x => x.TimeStart).ToList();

    }
    async Task MoveNextMonthAsync()
    {
        sDayFromCalendarClick = date.GetNextMonth();
        if (oldIndex != -1)
        {
            classField[oldIndex] = "calendarField";
        }
        calendarList = await calendarServices.GetCalendarsByMonthAsync(new DateTime(Convert.ToInt32(date.Year), date.Month, 1, 0, 0, 0));//.GetAllCalendarsAsync();//.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ThenBy(x => x.TimeStart).ToList();

    }

    string GetDayOfWeekInPolish(string DayOfWeek)
    {
        string DayOfWeekPolish = "";
        switch (DayOfWeek)
        {
            case "Monday":
                DayOfWeekPolish = "Poniedziałek";
                break;
            case "Tuesday":
                DayOfWeekPolish = "Wtorek";
                break;
            case "Wednesday":
                DayOfWeekPolish = "Środa";
                break;
            case "Thursday":
                DayOfWeekPolish = "Czwartek";
                break;
            case "Friday":
                DayOfWeekPolish = "Piątek";
                break;
            case "Saturday":
                DayOfWeekPolish = "Sobota";
                break;
            case "Sunday":
                DayOfWeekPolish = "Niedziela";
                break;
        }
        return DayOfWeekPolish;
    }

    string SetMonthToPolishWord(int month)
    {
        string Month = "";
        switch (month)
        {
            case 1:
                Month = "STYCZEŃ";
                break;
            case 2:
                Month = "LUTY";
                break;
            case 3:
                Month = "MARZEC";
                break;
            case 4:
                Month = "KWIECIEŃ";
                break;
            case 5:
                Month = "MAJ";
                break;
            case 6:
                Month = "CZERWIEC";
                break;
            case 7:
                Month = "LIPIEC";
                break;
            case 8:
                Month = "SIERPIEŃ";
                break;
            case 9:
                Month = "WRZESIEŃ";
                break;
            case 10:
                Month = "PAŹDZIERNIK";
                break;
            case 11:
                Month = "LISTOPAD";
                break;
            case 12:
                Month = "GRUDZIEŃ";
                break;
        }
        return Month;
    }

    private IList<AuthenticationScheme> ExternalLogins { get; set; }

    private async Task CreateAdminAccount()
    {
        ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList();



        //if (userManager.FindByNameAsync("Admin").IsCompletedSuccessfully == false)
        //{
        var user = new IdentityUser { UserName = "Admin" };
        var result = await userManager.CreateAsync(user, "789Ka;oz");
        if (result.Succeeded)
        {
            var RoleResult = await roleManager.FindByNameAsync("ADMIN");
            if (RoleResult == null)
            {
                // Create
                await roleManager.CreateAsync(new IdentityRole("ADMIN"));
            }
            await userManager.AddToRoleAsync(user, "ADMIN");
        }

        // }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICalendarServices calendarServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> signInManager { get; set; }
    }
}
#pragma warning restore 1591
