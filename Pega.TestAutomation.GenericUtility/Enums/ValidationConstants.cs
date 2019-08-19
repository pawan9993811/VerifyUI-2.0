using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    /// <summary>
    /// All validation constants to be used in features.
    /// </summary>
    public static class ValidateConstants
    {
        /// <summary>
        /// Action : UNDEFINED
        /// Not to be used in features or script. This is for internal use.
        /// </summary>
        public const string UNDEFINED = "Undefined";

        /// <summary>
        /// Validation : Check if the control is visible or not
        /// </summary>
        public const string CHECKVISIBLE = "CheckVisible";

        /// <summary>
        /// Validation: Check the Text
        /// </summary>
        public const string CHECKTEXT = "CheckText";

        /// <summary>
        /// Validation: Check the containing/partial Text
        /// </summary>
        public const string CHECKCONTAINTEXT = "CheckContainText";

        /// <summary>
        /// Validation: Check the Name
        /// </summary>
        public const string CHECKNAME = "CheckName";

        /// <summary>
        /// Validation: Check the Enabling status to be true 
        /// </summary>
        public const string CHECKENABLED = "CheckEnabled";

        /// <summary>
        /// Validation:Compare the Height 
        /// </summary>
        public const string CHECKHEIGHT = "CheckHeight";

        /// <summary>
        /// Validation:Compare the Width
        /// </summary>
        public const string CHECKWIDTH = "CheckWidth";

        /// <summary>
        /// Validation: Check Existence of object
        /// </summary>
        public const string CHECKEXIST = "CheckExists";

        /// <summary>
        /// Validation:Compare the Selected Item
        /// </summary>
        public const string CHECKSELECTEDITEM = "CheckSelectedItem";

        /// <summary>
        /// Validation:Compare the Selected Item Text
        /// </summary>
        public const string CHECKSELECTEDITEMTEXT = "CheckSelectedItemText";

        /// <summary>
        /// Validation:Compare the value
        /// </summary>
        public const string CHECKVALUE = "CheckValue";

        /// <summary>
        /// Validation:Compare the HelpText
        /// </summary>
        public const string CHECKHELPTEXT = "HelpText";

        /// <summary>
        /// Validation:Compare the Title
        /// </summary>
        public const string CHECKTITLE = "Title";

        /// <summary>
        /// Validation:Compare the DisplayText
        /// </summary>
        public const string CHECKDISPLAYTEXT = "DisplayText";

        /// <summary>
        /// Validation:Compare the DisplayText
        /// </summary>
        public const string CHECKCONTAINDISPLAYTEXT = "ContainDisplayText";

        /// <summary>
        /// Validation: Check if the specified string is part of the Name
        /// </summary>
        public const string CHECKCONTAINSNAME = "ContainsName";

        /// <summary>
        /// Validation:Compare the RowCount
        /// </summary>
        public const string CHECKROWCOUNT = "RowCount";

        /// <summary>
        /// Validation:Compares the Checked Property
        /// </summary>
        public const string CHECKTOGGLE = "Checked";

        /// <summary>
        /// Validation:Compares the Indeterminate Property
        /// </summary>
        public const string CHECKINDETERMINATE = "Indeterminate";

        /// <summary>
        /// Validation:Compare the ChildCount
        /// </summary>
        public const string CHECKCHILDCOUNT = "ChildCount";

        /// <summary>
        /// Validation:Compares Expanded Property
        /// </summary>
        public const string CHECKEXPANDED = "Expanded";

        /// <summary>
        /// Validation:Compares IsTopParent Property
        /// </summary>
        public const string CHECKTOPPARENT = "IsTopParent";

        /// <summary>
        /// Validation:Compares Resizable Property
        /// </summary>
        public const string CHECKRESIZABLE = "Resizable";

        /// <summary>
        /// Validation:Compares Tool Tip Text
        /// </summary>
        public const string CHECKTOOLTIPTEXT = "ToolTipText";

        /// <summary>
        /// Validation : Compares Selected property of a control
        /// </summary>
        public const string CHECKSELECTED = "Selected";

        /// <summary>
        /// Validation : Check the existence of an Item
        /// </summary>
        public const string CHECKCOMBOITEMEXISTENCE = "ComboItemExistence";

        /// <summary>
        /// Validation : Check the ComboItemsCount
        /// </summary>
        public const string CHECKCOMBOITEMSCOUNT = "ComboItemsCount";

        /// <summary>
        /// Validation : Compare header text
        /// </summary>
        public const string CHECKHEADER = "CheckHeader";

        /// <summary>
        /// Validation : Check the count of List Items
        /// </summary>
        public const string CHECKLISTITEMSCOUNT = "CheckListItemsCount";

        /// <summary>
        /// Validation: Check the names of list items
        /// </summary>
        public const string CHECKLISTITEMNAMES = "CheckListItemNames";

        /// <summary>
        /// Validation : Check the value for Read only property
        /// </summary>
        public const string CHECKREADONLY = "ReadOnly";
        /// <summary>
        /// Validation : Check the value for AccessibleDescription property
        /// </summary>
        public const string CHECKACCESSIBLEDSCIPTION = "AccessibleDescription";

        /// <summary>
        /// Validation : Check if the specified control is Editable.
        /// </summary>
        public const string CHECKEDITABLE = "IsEditable";

        /// <summary>
        /// Validation : Check the value for RowIndex property
        /// </summary>
        public const string CHECKROWINDEX = "RowIndex";

        /// <summary>
        /// Validation: Check the value for Pressed property of a Control
        /// </summary>
        public const string CHECKPRESSED = "Pressed";

        /// <summary>
        /// Validation: Check the value for State property of a Control
        /// </summary>
        public const string CHECKSTATE = "State";

        /// <summary>
        /// Validation: Check the value for HasFocus property of a Control
        /// </summary>
        public const string CHECKFOCUS = "HasFocus";

    }
}
