To use Blazor inside of MVC

Startup.cs:
	In ConfigurationServices:
        services.AddControllersWithViews().AddRazorRuntimeCompilation();
        services.AddServerSideBlazor();

	In Configure:
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapBlazorHub(); // SignalR connection
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });

_Layout.cshtml:
	In <head> tag add:
		<base href="~/" />

	For SignalR after list of scripts add:
		<script src="_framework/blazor.server.js"></script>

Create in root directory "_Imports.razor" file

