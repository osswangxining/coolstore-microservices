namespace WebUI.Shared.Sidebar
{
  public class SideBarViewModel
  {
    public int Min { get; set; } = 1;
    public int Max { get; set; } = 4000;
    public long PriceRange { get; set; } = 4000;
    public bool Sale { get; set; } = false;
  }
}
