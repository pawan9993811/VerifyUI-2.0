using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    internal abstract class ActionHelper
    {
        #region Properties

        /// <summary>
        /// The action values
        /// </summary>
        ActionInfo actionValues;

        protected UIControl actionableControl;

        SearchHelper searhelper;

        internal SearchHelper ControlSearchHelper
        {
            get
            {
                if (searhelper == null)
                    searhelper = SearchHelperFactory.Create(actionableControl);
                return searhelper;
            }
        }

        #endregion

        #region Constructors
        public ActionHelper(UIControl control, ActionInfo actionValues)
        {
            this.actionValues = actionValues;
            this.actionableControl = control;
        }
        #endregion

        #region Methods
        internal ReturnObject PerformAction()
        {
            if (IsValidationAction(actionValues.Action))
            {
                return DoValidationAction();
            }
            else if (IsSyncAction(actionValues.Action))
            {
                return DoSyncAction();
            }
            else
            {
                return DoAction();
            }

        }
        #endregion

        #region Helper methods

        private bool IsValidationAction(string input)
        {
            FieldInfo[] fieldInfos = typeof(ValidateConstants).GetFields();
            return fieldInfos.Any(filed => filed.GetValue(null).ToString() == input);
        }

        private bool IsSyncAction(string input)
        {
            FieldInfo[] fieldInfos = typeof(SyncConstants).GetFields();
            return fieldInfos.Any(filed => filed.GetValue(null).ToString() == input);
        }

        private ReturnObject DoValidationAction()
        {
            ReturnObject rc = new ReturnObject();

            switch (actionValues.Action)
            {
                case (ValidateConstants.CHECKENABLED):
                    CheckEnabled();
                    break;

                case (ValidateConstants.CHECKEXIST):
                    CheckExist();
                    break;

                case (ValidateConstants.CHECKVISIBLE):
                    CheckVisible();
                    break;

                case (ValidateConstants.CHECKSELECTEDITEM):
                    CheckSelected();
                    break;
                case (ValidateConstants.CHECKSELECTEDITEMTEXT):
                    CheckSelectedItemText();
                    break;
                case (ValidateConstants.CHECKTEXT):
                    CheckText();
                    break;

                case (ValidateConstants.CHECKCONTAINTEXT):
                    CheckContainText();
                    break;

                case (ValidateConstants.CHECKNAME):
                    CheckName();
                    break;

                case (ValidateConstants.CHECKCONTAINSNAME):
                    CheckContainsName();
                    break;

                case (ValidateConstants.CHECKVALUE):
                    CheckValue();
                    break;

                case (ValidateConstants.CHECKHELPTEXT):
                    CheckHelpText();
                    break;

                case (ValidateConstants.CHECKTITLE):
                    CheckTitle();
                    break;

                case (ValidateConstants.CHECKDISPLAYTEXT):
                    CheckDisplayText();
                    break;

                case (ValidateConstants.CHECKCONTAINDISPLAYTEXT):
                    CheckContainsDisplayText();
                    break;

                case (ValidateConstants.CHECKHEIGHT):
                    CheckHeight();
                    break;
                case (ValidateConstants.CHECKWIDTH):
                    CheckWidth();
                    break;

                case (ValidateConstants.CHECKROWCOUNT):
                    CheckRowCount();
                    break;

                case (ValidateConstants.CHECKTOGGLE):
                    CheckToggle();
                    break;

                case (ValidateConstants.CHECKINDETERMINATE):
                    CheckIndeterminate();
                    break;

                case (ValidateConstants.CHECKCHILDCOUNT):

                    break;
                case (ValidateConstants.CHECKEXPANDED):
                    CheckExpanded();
                    break;
                case (ValidateConstants.CHECKTOPPARENT):
                    CheckTopParent();
                    break;
                case (ValidateConstants.CHECKRESIZABLE):
                    CheckResizable();
                    break;
                case (ValidateConstants.CHECKSELECTED):
                    CheckSelected();
                    break;
                case (ValidateConstants.CHECKREADONLY):
                    CheckReadOnly();
                    break;

                case (ValidateConstants.CHECKCOMBOITEMEXISTENCE):
                    CheckComboItemExistance();
                    break;
                case (ValidateConstants.CHECKCOMBOITEMSCOUNT):
                    CheckComboItemsCount();
                    break;
                case (ValidateConstants.CHECKTOOLTIPTEXT):
                    CheckToolTipText();
                    break;
                case (ValidateConstants.CHECKHEADER):
                    CheckHeader();
                    break;
                case (ValidateConstants.CHECKLISTITEMSCOUNT):
                    CheckListItemCount();
                    break;
                case (ValidateConstants.CHECKLISTITEMNAMES):
                    CheckListItemNames();
                    break;
                case (ValidateConstants.CHECKACCESSIBLEDSCIPTION):
                    CheckAccessibleDescription();
                    break;

                case (ValidateConstants.CHECKEDITABLE):
                    CheckEditable();
                    break;

                case (ValidateConstants.CHECKROWINDEX):
                    CheckRowIndex();
                    break;

                case (ValidateConstants.CHECKPRESSED):
                    CheckPressed();
                    break;
                case (ValidateConstants.CHECKFOCUS):
                    CheckFocus();
                    break;

                case (ValidateConstants.CHECKSTATE):
                    CheckState();
                    break;

                default:
                    //Report error here
                    break;
            }

            return rc;
        }

        private ReturnObject DoAction()
        {
            ReturnObject rc = new ReturnObject();

            switch (actionValues.Action)
            {
                case (ActionConstants.CLICK):
                    this.Click();
                    break;

                case (ActionConstants.MIDDLECLICK):
                    this.MiddleClick();
                    break;

                case (ActionConstants.DOUBLECLICK):
                    DoubleClick();
                    break;

                case (ActionConstants.RIGHTCLICK):
                    RightClick();
                    break;

                case (ActionConstants.SELECT):
                    this.Select();
                    break;

                case (ActionConstants.SELECTCOMBOITEMBYCLICK):
                    this.SelectComboItemByClick();
                    break;

                case (ActionConstants.SELECTITEMBYTEXT):
                    SelectItemByText();
                    break;

                case (ActionConstants.SELECTITEMBYINDEX):
                    SelectItemByIndex();
                    break;

                case (ActionConstants.SETVALUE):
                    SetValue();
                    break;

                case (ActionConstants.SENDKEYS):
                    SendKeys();
                    break;

                case (ActionConstants.TOGGLETREEITEM):
                    ToggleTreeItem();
                    break;
                case (ActionConstants.TOGGLE):
                    Toggle();
                    break;

                case (ActionConstants.MOUSESCROLL):
                    MouseScroll();
                    break;

                case (ActionConstants.EXPAND):
                    Expand();
                    break;

                case (ActionConstants.COLLAPSE):
                    Collapse();
                    break;

                case (ActionConstants.DRAG):
                    Drag();
                    break;

                case (ActionConstants.DROP):
                    Drop();
                    break;

                case (ActionConstants.MIDDLEDRAG):
                    MiddleDrag();
                    break;

                case (ActionConstants.MIDDLEDROP):
                    MiddleDrop();
                    break;

                case (ActionConstants.MOVE):
                    Move();
                    break;

                case (ActionConstants.ABSOLUTEMOVE):
                    AbsoluteMove();
                    break;

                case (ActionConstants.MOUSEMOVE):
                    MouseMove();
                    break;

                case (ActionConstants.DATEASSTRING):
                    DateAsString();
                    break;

                case (ActionConstants.HOVER):
                    Hover();
                    break;

                case (ActionConstants.GETPROPERTYVALUE):
                    GetPropertyValue();
                    break;

                case (ActionConstants.PRESSANDHOLD):
                    PressAndHold();
                    break;

                case (ActionConstants.KEYDOWN):
                    KeyDown();
                    break;

                case (ActionConstants.KEYUP):
                    KeyUp();
                    break;

                case (ActionConstants.SELECTITEMBYVALUE):
                    SelectItemByValue();
                    break;

                case (ActionConstants.GETCELLDATA):
                    GetCellData();
                    break;

                default:
                    //update failure
                    break;
            }
            return rc;
        }

        private ReturnObject DoSyncAction()
        {
            ReturnObject rc = new ReturnObject();
            switch (actionValues.Action)
            {
                case SyncConstants.WAITFORCONTROLREADY:
                    break;

                case SyncConstants.WAITFORPROPERTYEQUAL:
                    break;

                default:
                    break;
            }
            return rc;
        }

        #endregion

        #region Abstract Methods

        #region Actions

        public abstract void Click();

        public abstract void DoubleClick();

        public abstract void SelectComboItemByClick();

        public abstract void Select();

        public abstract void MiddleClick();

        public abstract void GetCellData();

        public abstract void SelectItemByValue();

        public abstract void KeyUp();
        public abstract void KeyDown();
        public abstract void PressAndHold();
        public abstract void GetPropertyValue();
        public abstract void Hover();
        public abstract void DateAsString();
        public abstract void MouseMove();
        public abstract void AbsoluteMove();
        public abstract void Move();
        public abstract void MiddleDrag();
        public abstract void MiddleDrop();
        public abstract void Drop();
        public abstract void Drag();
        public abstract void RightClick();
        public abstract void Expand();
        public abstract void MouseScroll();
        public abstract void Collapse();
        public abstract void Toggle();
        public abstract void ToggleTreeItem();
        public abstract void SendKeys();
        public abstract void SetValue();
        public abstract void SelectItemByIndex();
        public abstract void SelectItemByText();

        #endregion

        #region Validations

        public abstract ReturnObject CheckVisible();
        public abstract ReturnObject CheckText();
        public abstract ReturnObject CheckContainText();
        public abstract ReturnObject CheckName();
        public abstract ReturnObject CheckEnabled();
        public abstract ReturnObject CheckHeight();
        public abstract ReturnObject CheckWidth();
        public abstract ReturnObject CheckExist();
        public abstract ReturnObject CheckSelectedItem();
        public abstract ReturnObject CheckSelectedItemText();
        public abstract ReturnObject CheckValue();
        public abstract ReturnObject CheckHelpText();
        public abstract ReturnObject CheckTitle();
        public abstract ReturnObject CheckDisplayText();
        public abstract ReturnObject CheckContainsDisplayText();
        public abstract ReturnObject CheckContainsName();
        public abstract ReturnObject CheckRowCount();
        public abstract ReturnObject CheckToggle();
        public abstract ReturnObject CheckIndeterminate();
        public abstract ReturnObject CheckExpanded();
        public abstract ReturnObject CheckTopParent();
        public abstract ReturnObject CheckResizable();
        public abstract ReturnObject CheckToolTipText();
        public abstract ReturnObject CheckSelected();
        public abstract ReturnObject CheckComboItemExistance();
        public abstract ReturnObject CheckComboItemsCount();
        public abstract ReturnObject CheckHeader();
        public abstract ReturnObject CheckListItemCount();
        public abstract ReturnObject CheckListItemNames();
        public abstract ReturnObject CheckReadOnly();
        public abstract ReturnObject CheckAccessibleDescription();
        public abstract ReturnObject CheckEditable();
        public abstract ReturnObject CheckRowIndex();
        public abstract ReturnObject CheckPressed();
        public abstract ReturnObject CheckState();
        public abstract ReturnObject CheckFocus();

        #endregion

        #region Sync Methods

        #endregion

        #region Searching Methods
        #endregion
        #endregion
    }

    public class ActionInfo
    {
        #region Properties

        public string Action { get; set; }

        public string Value { get; set; }

        public string WaitTime { get; set; }

        #endregion

        #region Constructors

        public ActionInfo(string action, string value,int waitTime)
        {
            Action = action;
            Value = value;
            WaitTime = waitTime.ToString();
        }

        #endregion
    }
}
