﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevZest.Windows.Docking {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DevZest.Windows.Docking.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Docking.
        /// </summary>
        internal static string Category_Docking {
            get {
                return ResourceManager.GetString("Category_Docking", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property Changed.
        /// </summary>
        internal static string Category_PropoertyChanged {
            get {
                return ResourceManager.GetString("Category_PropoertyChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gets or sets the max number of undo unit in the undo/redo stack..
        /// </summary>
        internal static string Description_DockControl_MaxUndoLevel {
            get {
                return ResourceManager.GetString("Description_DockControl_MaxUndoLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DockItems collection is not empty. Close all DockItem before calling DockControl.Load.
        /// </summary>
        internal static string Exception_DockControl_Load_DockItemsNotEmpty {
            get {
                return ResourceManager.GetString("Exception_DockControl_Load_DockItemsNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not redo when CanRedo is false or UndoUnitLevel is non-zero..
        /// </summary>
        internal static string Exception_DockControl_Redo_InvalidOperation {
            get {
                return ResourceManager.GetString("Exception_DockControl_Redo_InvalidOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not undo when CanUndo is false or UndoUnitLevel is non-zero..
        /// </summary>
        internal static string Exception_DockControl_Undo_InvalidOperation {
            get {
                return ResourceManager.GetString("Exception_DockControl_Undo_InvalidOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot activate DockItem with DockPosition.Unknown..
        /// </summary>
        internal static string Exception_DockItem_Activate_InvalidDockPosition {
            get {
                return ResourceManager.GetString("Exception_DockItem_Activate_InvalidDockPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ContextMenu is attached to DockItem already..
        /// </summary>
        internal static string Exception_DockItem_ContextMenuAttachedAlready {
            get {
                return ResourceManager.GetString("Exception_DockItem_ContextMenuAttachedAlready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified dock position is invalid..
        /// </summary>
        internal static string Exception_DockItem_Show_InvalidDockPosition {
            get {
                return ResourceManager.GetString("Exception_DockItem_Show_InvalidDockPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source DockItem is attached to a different DockControl already..
        /// </summary>
        internal static string Exception_DockItem_VerifyShowParam_DifferentDockControl {
            get {
                return ResourceManager.GetString("Exception_DockItem_VerifyShowParam_DifferentDockControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DockControl is not loaded..
        /// </summary>
        internal static string Exception_DockItem_VerifyShowParam_UnloadedDockControl {
            get {
                return ResourceManager.GetString("Exception_DockItem_VerifyShowParam_UnloadedDockControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value to add. Value must be a non-null DockItem instance, which is not added to the collection..
        /// </summary>
        internal static string Exception_DockItemCollection_AddItem_InvalidValue {
            get {
                return ResourceManager.GetString("Exception_DockItemCollection_AddItem_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dock value is invalid..
        /// </summary>
        internal static string Exception_DockTreeZOrder_InvalidDockValue {
            get {
                return ResourceManager.GetString("Exception_DockTreeZOrder_InvalidDockValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot host OverlayActivator multiple times..
        /// </summary>
        internal static string Exception_OverlayActivator_HostMultipleTimes {
            get {
                return ResourceManager.GetString("Exception_OverlayActivator_HostMultipleTimes", resourceCulture);
            }
        }
    }
}
