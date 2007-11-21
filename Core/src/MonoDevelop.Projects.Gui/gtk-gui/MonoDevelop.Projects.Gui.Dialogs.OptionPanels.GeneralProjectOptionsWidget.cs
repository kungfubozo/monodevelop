// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Projects.Gui.Dialogs.OptionPanels {
    
    
    internal partial class GeneralProjectOptionsWidget {
        
        private Gtk.VBox vbox40;
        
        private Gtk.VBox vbox47;
        
        private Gtk.Label informationHeaderLabel;
        
        private Gtk.HBox hbox29;
        
        private Gtk.Label label55;
        
        private Gtk.VBox vbox46;
        
        private Gtk.Table table11;
        
        private Gtk.Label descriptionLabel;
        
        private Gtk.Label label120;
        
        private Gtk.Label nameLabel;
        
        private Gtk.Entry projectDefaultNamespaceEntry;
        
        private Gtk.Entry projectNameEntry;
        
        private Gtk.ScrolledWindow scrolledwindow5;
        
        private Gtk.TextView projectDescriptionTextView;
        
        private Gtk.VBox vbox41;
        
        private Gtk.Label onProjectLoadHeaderLabel;
        
        private Gtk.HBox hbox26;
        
        private Gtk.Label label49;
        
        private Gtk.CheckButton newFilesOnLoadCheckButton;
        
        private Gtk.HBox hbox27;
        
        private Gtk.Label label50;
        
        private Gtk.CheckButton autoInsertNewFilesCheckButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Projects.Gui.Dialogs.OptionPanels.GeneralProjectOptionsWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Projects.Gui.Dialogs.OptionPanels.GeneralProjectOptionsWidget";
            // Container child MonoDevelop.Projects.Gui.Dialogs.OptionPanels.GeneralProjectOptionsWidget.Gtk.Container+ContainerChild
            this.vbox40 = new Gtk.VBox();
            this.vbox40.Name = "vbox40";
            this.vbox40.Spacing = 12;
            // Container child vbox40.Gtk.Box+BoxChild
            this.vbox47 = new Gtk.VBox();
            this.vbox47.Name = "vbox47";
            this.vbox47.Spacing = 6;
            // Container child vbox47.Gtk.Box+BoxChild
            this.informationHeaderLabel = new Gtk.Label();
            this.informationHeaderLabel.Name = "informationHeaderLabel";
            this.informationHeaderLabel.Xalign = 0F;
            this.informationHeaderLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("<b>Project Information</b>");
            this.informationHeaderLabel.UseMarkup = true;
            this.informationHeaderLabel.UseUnderline = true;
            this.vbox47.Add(this.informationHeaderLabel);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox47[this.informationHeaderLabel]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox47.Gtk.Box+BoxChild
            this.hbox29 = new Gtk.HBox();
            this.hbox29.Name = "hbox29";
            // Container child hbox29.Gtk.Box+BoxChild
            this.label55 = new Gtk.Label();
            this.label55.WidthRequest = 18;
            this.label55.Name = "label55";
            this.label55.LabelProp = "";
            this.hbox29.Add(this.label55);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox29[this.label55]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox29.Gtk.Box+BoxChild
            this.vbox46 = new Gtk.VBox();
            this.vbox46.Name = "vbox46";
            this.vbox46.Spacing = 6;
            // Container child vbox46.Gtk.Box+BoxChild
            this.table11 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table11.Name = "table11";
            this.table11.RowSpacing = ((uint)(6));
            this.table11.ColumnSpacing = ((uint)(6));
            // Container child table11.Gtk.Table+TableChild
            this.descriptionLabel = new Gtk.Label();
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Xalign = 0F;
            this.descriptionLabel.Yalign = 0.01F;
            this.descriptionLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("_Description:");
            this.descriptionLabel.UseUnderline = true;
            this.table11.Add(this.descriptionLabel);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table11[this.descriptionLabel]));
            w3.TopAttach = ((uint)(1));
            w3.BottomAttach = ((uint)(2));
            // Container child table11.Gtk.Table+TableChild
            this.label120 = new Gtk.Label();
            this.label120.Name = "label120";
            this.label120.Xalign = 0F;
            this.label120.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("Default Namespace:");
            this.table11.Add(this.label120);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table11[this.label120]));
            w4.TopAttach = ((uint)(2));
            w4.BottomAttach = ((uint)(3));
            // Container child table11.Gtk.Table+TableChild
            this.nameLabel = new Gtk.Label();
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Xalign = 0F;
            this.nameLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("_Name:");
            this.nameLabel.UseUnderline = true;
            this.table11.Add(this.nameLabel);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table11[this.nameLabel]));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table11.Gtk.Table+TableChild
            this.projectDefaultNamespaceEntry = new Gtk.Entry();
            this.projectDefaultNamespaceEntry.Name = "projectDefaultNamespaceEntry";
            this.projectDefaultNamespaceEntry.IsEditable = true;
            this.projectDefaultNamespaceEntry.InvisibleChar = '●';
            this.table11.Add(this.projectDefaultNamespaceEntry);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table11[this.projectDefaultNamespaceEntry]));
            w6.TopAttach = ((uint)(2));
            w6.BottomAttach = ((uint)(3));
            w6.LeftAttach = ((uint)(1));
            w6.RightAttach = ((uint)(2));
            w6.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table11.Gtk.Table+TableChild
            this.projectNameEntry = new Gtk.Entry();
            this.projectNameEntry.Name = "projectNameEntry";
            this.projectNameEntry.IsEditable = true;
            this.projectNameEntry.InvisibleChar = '●';
            this.table11.Add(this.projectNameEntry);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table11[this.projectNameEntry]));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table11.Gtk.Table+TableChild
            this.scrolledwindow5 = new Gtk.ScrolledWindow();
            this.scrolledwindow5.WidthRequest = 350;
            this.scrolledwindow5.HeightRequest = 150;
            this.scrolledwindow5.Name = "scrolledwindow5";
            this.scrolledwindow5.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow5.Gtk.Container+ContainerChild
            this.projectDescriptionTextView = new Gtk.TextView();
            this.projectDescriptionTextView.HeightRequest = 160;
            this.projectDescriptionTextView.Name = "projectDescriptionTextView";
            this.scrolledwindow5.Add(this.projectDescriptionTextView);
            this.table11.Add(this.scrolledwindow5);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table11[this.scrolledwindow5]));
            w9.TopAttach = ((uint)(1));
            w9.BottomAttach = ((uint)(2));
            w9.LeftAttach = ((uint)(1));
            w9.RightAttach = ((uint)(2));
            this.vbox46.Add(this.table11);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox46[this.table11]));
            w10.Position = 0;
            this.hbox29.Add(this.vbox46);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox29[this.vbox46]));
            w11.Position = 1;
            this.vbox47.Add(this.hbox29);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox47[this.hbox29]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            this.vbox40.Add(this.vbox47);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox40[this.vbox47]));
            w13.Position = 0;
            w13.Expand = false;
            w13.Fill = false;
            // Container child vbox40.Gtk.Box+BoxChild
            this.vbox41 = new Gtk.VBox();
            this.vbox41.Name = "vbox41";
            this.vbox41.Spacing = 6;
            // Container child vbox41.Gtk.Box+BoxChild
            this.onProjectLoadHeaderLabel = new Gtk.Label();
            this.onProjectLoadHeaderLabel.Name = "onProjectLoadHeaderLabel";
            this.onProjectLoadHeaderLabel.Xalign = 0F;
            this.onProjectLoadHeaderLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("<b>On Project Load</b>");
            this.onProjectLoadHeaderLabel.UseMarkup = true;
            this.onProjectLoadHeaderLabel.UseUnderline = true;
            this.vbox41.Add(this.onProjectLoadHeaderLabel);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox41[this.onProjectLoadHeaderLabel]));
            w14.Position = 0;
            w14.Expand = false;
            w14.Fill = false;
            // Container child vbox41.Gtk.Box+BoxChild
            this.hbox26 = new Gtk.HBox();
            this.hbox26.Name = "hbox26";
            // Container child hbox26.Gtk.Box+BoxChild
            this.label49 = new Gtk.Label();
            this.label49.WidthRequest = 18;
            this.label49.Name = "label49";
            this.label49.LabelProp = "";
            this.hbox26.Add(this.label49);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox26[this.label49]));
            w15.Position = 0;
            w15.Expand = false;
            w15.Fill = false;
            // Container child hbox26.Gtk.Box+BoxChild
            this.newFilesOnLoadCheckButton = new Gtk.CheckButton();
            this.newFilesOnLoadCheckButton.Name = "newFilesOnLoadCheckButton";
            this.newFilesOnLoadCheckButton.Label = MonoDevelop.Core.GettextCatalog.GetString("Search for new _files on load");
            this.newFilesOnLoadCheckButton.DrawIndicator = true;
            this.newFilesOnLoadCheckButton.UseUnderline = true;
            this.hbox26.Add(this.newFilesOnLoadCheckButton);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.hbox26[this.newFilesOnLoadCheckButton]));
            w16.Position = 1;
            w16.Expand = false;
            w16.Fill = false;
            this.vbox41.Add(this.hbox26);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox41[this.hbox26]));
            w17.Position = 1;
            w17.Expand = false;
            w17.Fill = false;
            // Container child vbox41.Gtk.Box+BoxChild
            this.hbox27 = new Gtk.HBox();
            this.hbox27.Name = "hbox27";
            // Container child hbox27.Gtk.Box+BoxChild
            this.label50 = new Gtk.Label();
            this.label50.WidthRequest = 18;
            this.label50.Name = "label50";
            this.label50.LabelProp = "";
            this.hbox27.Add(this.label50);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox27[this.label50]));
            w18.Position = 0;
            w18.Expand = false;
            w18.Fill = false;
            // Container child hbox27.Gtk.Box+BoxChild
            this.autoInsertNewFilesCheckButton = new Gtk.CheckButton();
            this.autoInsertNewFilesCheckButton.Name = "autoInsertNewFilesCheckButton";
            this.autoInsertNewFilesCheckButton.Label = MonoDevelop.Core.GettextCatalog.GetString("Automatically _include found files");
            this.autoInsertNewFilesCheckButton.DrawIndicator = true;
            this.autoInsertNewFilesCheckButton.UseUnderline = true;
            this.hbox27.Add(this.autoInsertNewFilesCheckButton);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.hbox27[this.autoInsertNewFilesCheckButton]));
            w19.Position = 1;
            w19.Expand = false;
            w19.Fill = false;
            this.vbox41.Add(this.hbox27);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox41[this.hbox27]));
            w20.Position = 2;
            w20.Expand = false;
            w20.Fill = false;
            this.vbox40.Add(this.vbox41);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.vbox40[this.vbox41]));
            w21.Position = 1;
            w21.Expand = false;
            w21.Fill = false;
            this.Add(this.vbox40);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
