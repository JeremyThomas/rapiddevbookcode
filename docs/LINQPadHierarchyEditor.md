# LINQPad Hierarchy Editor
Hierarchy editor for displaying and editing [Adjacency List](http://articles.sitepoint.com/article/hierarchical-data-database)(self referencing) data in a tree.
It is based upon an enhanced version of [this Databound TreeView control](http://www.codeproject.com/KB/tree/bindablehierarchicaltree.aspx).

## Installation
Same as for the [LINQPad DataEditor](LINQPadDataEditor).

## Usage
Call one of these extension methods:
{code:c#}
public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn)
public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn, IGridDataEditorPersister gridDataEditorPersister)

public static IEnumerable<T> ShowSelfServicingHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase
public static IEnumerable<T> ShowAdapterHierarchyInTree<T>(this IQueryable<T> query, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase2
public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase2
{code:c#}You need to supply the name of the identity property, the parent property name and the name of the property to be displayed in the tree. You can optionally supply an IGridDataEditorPersister to persist any changes you make.

## Example usage
An example of this data is the HumanResources.Employee table in the adventureworks DB.

Here is a LINQPad file showing how to view this data in the HierarchyEditor: [LLBL_ShowEmployeesInTree.linq](http://rapiddevbookcode.codeplex.com/SourceControl/changeset/view/68089#1097830)
It's just one line shown here:
{code:c#}
Employee.ToEntityCollection().ShowSelfServicingHierarchyInTree("EmployeeID", "ManagerID", "EmployeeDisplayName") 
{code:c#}which opens a windows like so:
![](LINQPadHierarchyEditor_HierarchyEditor.PNG)
As well as the treeview there is a propertygrid showing the currently selected node and a grid showing all the children of that node.