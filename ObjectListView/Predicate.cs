namespace JesseJohnston
{
  /// <summary>
  /// Callback type for the <seealso cref="ObjectListView.FilterPredicate"/> property.
  /// </summary>
  /// <param name="listItem">The list item to be checked against the filter criteria.</param>
  /// <returns><b>true</b> if the list item matches the filter; <b>false</b> if it does not.</returns>
  public delegate bool Predicate(object listItem);
}