using System;

namespace Pega.TestAutomation.GenericUtility
{
    internal class SeleniumActionHelper : ActionHelper
    {

        //UIControl actionableControl;
        object webElement;

        public SeleniumActionHelper(UIControl control,ActionInfo actionInfo) 
            : base(control,actionInfo)
        {
            //actionableControl = control;
            webElement = ControlSearchHelper.GetControl();
        }

        public override void AbsoluteMove()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckAccessibleDescription()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckComboItemExistance()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckComboItemsCount()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckContainsDisplayText()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckContainsName()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckContainText()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckDisplayText()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckEditable()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckEnabled()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckExist()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckExpanded()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckFocus()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckHeader()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckHeight()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckHelpText()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckIndeterminate()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckListItemCount()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckListItemNames()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckName()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckPressed()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckReadOnly()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckResizable()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckRowCount()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckRowIndex()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckSelected()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckSelectedItem()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckSelectedItemText()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckState()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckText()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckTitle()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckToggle()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckToolTipText()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckTopParent()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckValue()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckVisible()
        {
            throw new NotImplementedException();
        }

        public override ReturnObject CheckWidth()
        {
            throw new NotImplementedException();
        }

        public override void Click()
        {
            throw new NotImplementedException();
        }

        public override void Collapse()
        {
            throw new NotImplementedException();
        }

        public override void DateAsString()
        {
            throw new NotImplementedException();
        }

        public override void DoubleClick()
        {
            throw new NotImplementedException();
        }

        public override void Drag()
        {
            throw new NotImplementedException();
        }

        public override void Drop()
        {
            throw new NotImplementedException();
        }

        public override void Expand()
        {
            throw new NotImplementedException();
        }

        public override void GetCellData()
        {
            throw new NotImplementedException();
        }

        public override void GetPropertyValue()
        {
            throw new NotImplementedException();
        }

        public override void Hover()
        {
            throw new NotImplementedException();
        }

        public override void KeyDown()
        {
            throw new NotImplementedException();
        }

        public override void KeyUp()
        {
            throw new NotImplementedException();
        }

        public override void MiddleClick()
        {
            throw new NotImplementedException();
        }

        public override void MiddleDrag()
        {
            throw new NotImplementedException();
        }

        public override void MiddleDrop()
        {
            throw new NotImplementedException();
        }

        public override void MouseMove()
        {
            throw new NotImplementedException();
        }

        public override void MouseScroll()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void PressAndHold()
        {
            throw new NotImplementedException();
        }

        public override void RightClick()
        {
            throw new NotImplementedException();
        }

        public override void Select()
        {
            throw new NotImplementedException();
        }

        public override void SelectComboItemByClick()
        {
            throw new NotImplementedException();
        }

        public override void SelectItemByIndex()
        {
            throw new NotImplementedException();
        }

        public override void SelectItemByText()
        {
            throw new NotImplementedException();
        }

        public override void SelectItemByValue()
        {
            throw new NotImplementedException();
        }

        public override void SendKeys()
        {
            throw new NotImplementedException();
        }

        public override void SetValue()
        {
            throw new NotImplementedException();
        }

        public override void Toggle()
        {
            throw new NotImplementedException();
        }

        public override void ToggleTreeItem()
        {
            throw new NotImplementedException();
        }
    }
}
