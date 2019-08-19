using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    /// <summary>
    /// Action constants to be used in features.
    /// </summary>
    public static class ActionConstants
    {
        /// <summary>
        /// Action : UNDEFINED
        /// Not to be used in features or script. This is for internal use.
        /// </summary>
        public const string UNDEFINED = "Undefined";

        /// <summary>
        /// Action : Click
        /// Use this action to perform mouse click
        /// </summary>
        public const string CLICK = "Click";

        /// <summary>
        /// Action : MiddleClick
        /// Use this action to perform mouse middle click
        /// </summary>
        public const string MIDDLECLICK = "MiddleClick";

        /// <summary>
        /// Action : RightClick
        /// Use this action to perform mouse right click
        /// </summary>
        public const string RIGHTCLICK = "RightClick";

        /// <summary>
        /// Action : DoubleClick
        /// Use this action to perform mouse double click
        /// </summary>
        public const string DOUBLECLICK = "DoubleClick";

        /// <summary>
        /// Action :  Mouse Drags.
        /// Use this actions to start mouse drag
        /// Ensure that you have added follwing drop action
        /// </summary>
        public const string DRAG = "Drag";

        /// <summary>
        /// Action : Mouse Drop
        /// Use this actions to start mouse drop
        /// Ensure that you have already added drag in previous steps
        /// </summary>
        public const string DROP = "Drop";

        /// <summary>
        /// Action : Middle Drag
        /// Use this actions to start mouse middle drag
        /// Ensure that you have added follwing Middle drop
        /// </summary>
        public const string MIDDLEDRAG = "MiddleDrag";

        /// <summary>
        /// Action : Middle Drop
        /// Use this actions to start mouse middle drop
        /// Ensure that you have already added Middle drag in previous steps
        /// </summary>
        public const string MIDDLEDROP = "MiddleDrop";

        /// <summary>
        /// Action : Select
        /// Use this action to perform slect action
        /// Most supported controls are like dropdown,radio button and list...
        /// </summary>
        public const string SELECT = "Select";

        /// <summary>
        /// Action : SelectItemByText
        /// Use this action to perform slect item by text
        /// This might be useful in belwo scenarios
        ///     1. select item from dropdown depending on display text of it
        ///     2. select list item from list depending on display text.
        ///Note: Use this action if default Select.
        /// </summary>
        public const string SELECTITEMBYTEXT = "SelectItemByText";

        /// <summary>
        /// Action : SelectItemByIndex
        /// Use this action when we want to select the element w.r.t 
        /// </summary>
        public const string SELECTITEMBYINDEX = "SelectItemByIndex";

        /// <summary>
        /// Action : Selects Combobox Item by clicking on item.
        /// Try to use this action when exeiting select actions are not working as expected
        /// This was introduced to supported specific controls
        /// </summary>
        public const string SELECTCOMBOITEMBYCLICK = "SelectComboItemByClick";

        /// <summary>
        /// Action : Select combobox item by using value patterns
        /// Try to use this action when exeiting select actions are not working as expected
        /// This was introduced to supported specific controls
        /// </summary>
        public const string SELECTITEMBYVALUE = "SelectItemByValue";

        /// <summary>
        /// Action : Toggle
        /// Use This action to toggle the check box on of off 
        /// </summary>
        public const string TOGGLE = "Toggle";

        /// <summary>
        /// Action : ToggleTreeItem
        /// Use this action to toggle treeitems which has check boxes
        /// </summary>
        public const string TOGGLETREEITEM = "ToggleTreeItem";

        /// <summary>
        /// Action : SetValue
        /// Use this action to set value in textbox or editable combobox
        /// </summary>
        public const string SETVALUE = "SetValue";

        /// <summary>
        /// Action : SENDKEYS
        /// Use this action to send keys(just pressing the keys in given pattern) to focused controls
        /// Make sure that intended control is in focus.
        /// </summary>
        public const string SENDKEYS = "SendKeys";

        /// <summary>
        /// Action : Expand
        /// Use this action to expand the tree item
        /// </summary>
        public const string EXPAND = "Expand";

        /// <summary>
        /// Action : Collapse
        /// Use this action to collapse the tree item
        /// </summary>
        public const string COLLAPSE = "Collapse";
        
        /// <summary>
        /// Action :  Moves the control.
        /// Use this action to move the control(will be useful for window)
        /// This should be used only when combined with other mouse actions
        /// </summary>
        public const string MOVE = "Move";

        /// <summary>
        /// Action :  Moves the control to given co-ordinates (not relative movement).
        /// Use this action when we have a requirement to move window to specifc location.
        /// </summary>
        public const string ABSOLUTEMOVE = "AbsoluteMove";

        /// <summary>
        /// Action : Hovers mouse cursor on the required control.
        /// Use this action when you have a requirement to hover the mouse on 
        /// any control for couple of seconds
        /// </summary>
        public const string HOVER = "Hover";

        /// <summary>
        /// Action : Moves the mouse cursor to the given coordinates on the required control.
        /// </summary>
        public const string MOUSEMOVE = "MouseMove";

        /// <summary>
        /// Action : Scroll operation will be performed on the required control. 
        /// </summary>
        public const string MOUSESCROLL = "MouseScroll";

        /// <summary>
        /// Action : To set the date  on DatePicker control
        /// </summary>
        public const string DATEASSTRING = "DateAsString";

        /// <summary>
        /// Action : GetPropertyValue
        /// Use this action to get specified property from any control
        /// Make sure it was supported by framework
        /// </summary>
        public const string GETPROPERTYVALUE = "GetPropertyValue";

        /// <summary>
        /// Action : Press the control for given time.
        /// Use this action when you have a requirement to press the mouse down on 
        /// any control and wait for couple of seconds
        /// </summary>
        public const string PRESSANDHOLD = "PressAndHold";

        /// <summary>
        /// Action : Press the keyboard key down
        /// Use this action when you have a requirement to press mouse down on for couple of seconds
        /// </summary>
        public const string KEYDOWN = "KeyDown";

        /// <summary>
        /// Action : Perform the keyboard key up
        /// Use this action when you have a requirement to perform mouse up
        /// Make sure that respective mouse up was added before
        /// </summary>
        public const string KEYUP = "KeyUp";

        /// <summary>
        /// Action : Get cell data from table for given cell(i.e. row and column)
        /// Use this action to retrieve data of the cell with given row and column indices.
        /// This is specific to controls with table behavior
        /// </summary>
        public const string GETCELLDATA = "GetCellData";

    }
    
}
