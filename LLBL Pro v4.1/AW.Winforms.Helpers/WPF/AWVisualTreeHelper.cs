using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace AW.Winforms.Helpers.WPF
{
  /// <summary>
  ///   http://social.msdn.microsoft.com/Forums/en/wpf/thread/a945608d-d072-4d3c-8f33-601d6e818457
  /// </summary>
  public static class AWVisualTreeHelper
  {
    /// <summary>
    ///   Get visual tree children of a type
    /// </summary>
    /// <typeparam name="T">Visual tree children type</typeparam>
    /// <param name="current">A DependencyObject reference</param>
    /// <param name="children">A collection of one visual tree children type</param>
    private static void GetVisualChildren<T>(DependencyObject current, Collection<T> children) where T : DependencyObject
    {
      if (current != null)
      {
        if (current.GetType() == typeof (T))
        {
          children.Add((T) current);
        }

        for (var i = 0; i < VisualTreeHelper.GetChildrenCount(current); i++)
        {
          GetVisualChildren(VisualTreeHelper.GetChild(current, i), children);
        }
      }
    }

    /// <summary>
    ///   Get visual tree children of a type
    /// </summary>
    /// <typeparam name="T">Visaul tree children type</typeparam>
    /// <param name="current">A DependencyObject reference</param>
    /// <returns>Returns a collection of one visual tree children type</returns>
    public static Collection<T> GetVisualChildren<T>(DependencyObject current) where T : DependencyObject
    {
      if (current == null)
      {
        return null;
      }

      var children = new Collection<T>();

      GetVisualChildren(current, children);

      return children;
    }

    /// <summary>
    ///   Get the first visual child from a FrameworkElement Template
    /// </summary>
    /// <typeparam name="TP">FrameworkElement type</typeparam>
    /// <typeparam name="T">FrameworkElement type</typeparam>
    /// <param name="templatedParent">A FrameworkElement typeof P</param>
    /// <returns>Returns a FrameworkElement visual child typeof T if found one; returns null otherwise</returns>
    public static T GetVisualChild<T, TP>(TP templatedParent)
      where T : FrameworkElement
      where TP : FrameworkElement
    {
      var children = GetVisualChildren<T>(templatedParent);
      return children.FirstOrDefault(child => child.TemplatedParent == templatedParent);
    }

    public static TChildItem FindVisualChild<TChildItem>(DependencyObject obj)
      where TChildItem : DependencyObject
    {
      for (var i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
      {
        var child = VisualTreeHelper.GetChild(obj, i);
        if (child is TChildItem)
          return (TChildItem) child;
        var childOfChild = FindVisualChild<TChildItem>(child);
        if (childOfChild != null)
          return childOfChild;
      }
      return null;
    }
  }
}