using System;
using System.Collections.Generic;

using System.Globalization;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Dialog;
using Tekla.Structures.Dialog.UIControls;
using Tekla.Structures.Model;
using Tekla.Structures.Drawing;

using Tekla.Structures.Geometry3d;
using Tekla.Structures.Datatype;
using Tekla.Structures.Catalogs;

using TSD = Tekla.Structures.Datatype;
using TSG = Tekla.Structures.Geometry3d;

using Connection = Tekla.Structures.Model.Connection;
using ModelObject = Tekla.Structures.Model.ModelObject;
using Polygon = Tekla.Structures.Model.Polygon;
using View = Tekla.Structures.Drawing.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DrawingsUIRebarColumnsFootings
{
    public partial class Form1 : ApplicationFormBase
    {
        public Form1()
        {
            InitializeComponent();
            base.InitializeForm();
            MyModel = new Model();
            SteelMaterials = new List<MaterialItem>();
            MyDrawingHandler = new DrawingHandler();
        }
        private readonly Model MyModel;
        private readonly List<MaterialItem> SteelMaterials;
        private readonly DrawingHandler MyDrawingHandler;
        private void CreateColumnsAndPadFootings_Click(object sender, EventArgs e)
        {
            if (MyModel.GetConnectionStatus() && !string.IsNullOrEmpty(ColumnsProfileTextBox.Text) && !string.IsNullOrEmpty(ColumnsMaterialsTextBox.Text) &&
                !string.IsNullOrEmpty(textBox_PadFooting_size.Text) && !string.IsNullOrEmpty(PadFootingMaterialtextBox.Text))
            {
                for (double PositionX = 0.0; PositionX <= 12000; PositionX += 3000)
                {
                    if (PositionX.Equals(0.0) || PositionX.Equals(12000))
                    {
                        for (double PositionY = 0.0; PositionY <= 30000; PositionY += 6000)
                        {
                            CallCreateColumnAndPadFooting(PositionX, PositionY);
                        }
                    }
                    else
                    {
                        CallCreateColumnAndPadFooting(PositionX, 0);
                        CallCreateColumnAndPadFooting(PositionX, 30000);
                    }
                }
                MyModel.CommitChanges();
            }
        }
        private void CallCreateColumnAndPadFooting(double PositionX, double PositionY)
        {
            //the user has to fill the fields indicating column profile and material
            //the user has to fill the fields indicating pad footing size and material
            string columnProfile = ColumnsProfileTextBox.Text;
            string columnMaterialProfile = ColumnsMaterialsTextBox.Text;
            string padFootingSize = textBox_PadFooting_size.Text;
            string padFootingMaterial = PadFootingMaterialtextBox.Text;
            Beam PadFooting = CreatePadFooting(PositionX, PositionY, padFootingSize, padFootingMaterial);
            Beam Column = CreateColumn(PositionX, PositionY, columnProfile, columnMaterialProfile);
            CreateBasePlate(Column);
        }
        private static Beam CreateColumn(double PositionX, double PositionY, string ColumnProfile, string ColumnMaterialProfile)
        {
            Beam Column = new Beam();
            Column.Name = "COLUMN";
            Column.Profile.ProfileString = ColumnProfile;
            Column.Material.MaterialString = ColumnMaterialProfile;
            Column.Class = "2";
            Column.StartPoint.X = PositionX;
            Column.StartPoint.Y = PositionY;
            Column.StartPoint.Z = 0;
            Column.EndPoint.X = PositionX;
            Column.EndPoint.Y = PositionY;
            Column.EndPoint.Z = 5000.0;
            Column.Position.Rotation = Position.RotationEnum.FRONT;
            Column.Position.Plane = Position.PlaneEnum.MIDDLE;
            Column.Position.Depth = Position.DepthEnum.MIDDLE;

            if (!Column.Insert())
            {
                Console.WriteLine("Insertion of column failed.");
            }

            return Column;
        }
        private static void CreateBasePlate(Beam Column)
        {
            Detail BasePlate = new Detail();

            BasePlate.Name = "Stiffened Base Plate";
            BasePlate.Number = 1014;
            BasePlate.LoadAttributesFromFile("standard");
            BasePlate.AutoDirectionType = AutoDirectionTypeEnum.AUTODIR_FROM_ATTRIBUTE_FILE;
            BasePlate.DetailType = DetailTypeEnum.END;

            BasePlate.SetPrimaryObject(Column);
            BasePlate.SetReferencePoint(Column.StartPoint);
            BasePlate.SetAttribute("cut", 1);  //Enable anchor rods

            if (!BasePlate.Insert())
            {
                Console.WriteLine("Insertion of stiffened base plate failed.");
            }
        }
        private static Beam CreatePadFooting(double PositionX, double PositionY, string FootingSize, string FootingMaterial)
        {
            Beam PadFooting = new Beam();
            PadFooting.Name = "FOOTING";
            PadFooting.Profile.ProfileString = FootingSize;
            //LAS DIMENSIONES DE LA ZAPATA SON UN DOUBLE. HAY QUE CONVERTIRLAS A DOUBLE.
            //in order to create pad footings, we need a double. So we convert the footing size string into a double
            PadFooting.Profile.ProfileString = double.Parse(FootingSize) + "*" + double.Parse(FootingSize); //"1500*1500";
            PadFooting.Material.MaterialString = FootingMaterial;
            PadFooting.Class = "8";
            PadFooting.StartPoint.X = PositionX;
            PadFooting.StartPoint.Y = PositionY;
            PadFooting.EndPoint.X = PositionX;
            PadFooting.EndPoint.Y = PositionY;
            PadFooting.EndPoint.Z = -500.0;
            PadFooting.Position.Rotation = Position.RotationEnum.FRONT;
            PadFooting.Position.Plane = Position.PlaneEnum.MIDDLE;
            PadFooting.Position.Depth = Position.DepthEnum.MIDDLE;

            if (!PadFooting.Insert())
            {
                Console.WriteLine("Insertion of pad footing failed.");
            }

            return PadFooting;
        }
        private void EditOpenedDrawing()
        {
            string text = DrawingTextBox.Text;
            if(MyDrawingHandler.GetConnectionStatus())
            {
                Drawing MyDrawing = MyDrawingHandler.GetActiveDrawing();
                if (MyDrawing == null)
                {
                    return;
                }
                ContainerView Sheet = MyDrawing.GetSheet();
                DrawingObjectEnumerator MyViewEnumerator = Sheet.GetViews();
                //Looping through views in the drawing
                while(MyViewEnumerator.MoveNext()) 
                {
                    View CurrentView = MyViewEnumerator.Current as View; //If ViewBase used instead of View, then multidrawing's container views would work here also
                    if(CurrentView != null)
                    {
                        //Getting bounding box for the view frame and calculating then the CenterPoint under it
                        RectangleBoundingBox ViewAABB = CurrentView.GetAxisAlignedBoundingBox();
                        TSG.Point CenterPoint = new TSG.Point();
                        CenterPoint.X = ViewAABB.LowerLeft.X + (ViewAABB.LowerRight.X - ViewAABB.LowerLeft.X) / 2.0;
                        CenterPoint.Y = ViewAABB.LowerLeft.Y - 5.0;  //5.0 mm below the view's bounding box

                        Text MyViewTitle = new Text(Sheet, CenterPoint, text, new Text.TextAttributes());
                        if(!MyViewTitle.Insert()) 
                        {
                            Console.WriteLine("Insert failed.");
                        }
                        else
                        {
                            RectangleBoundingBox TitleAABB = MyViewTitle.GetAxisAlignedBoundingBox();
                            /*Tekla.Structures.Drawing.*/Rectangle myBox = new /*Tekla.Structures.Drawing.*/Rectangle(Sheet, TitleAABB.LowerLeft, TitleAABB.UpperRight);
                            myBox.Insert();
                        }
                    }
                }
                MyDrawing.CommitChanges();
            }
        }


        private void materialCatalogColumn_SelectClicked(object sender, EventArgs e)
        {
            materialCatalogColumn.SelectedMaterial = ColumnsMaterialsTextBox.Text;
        }
        private void materialCatalogColumn_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(ColumnsMaterialsTextBox, materialCatalogColumn.SelectedMaterial);
        }

        private void profileCatalogColumn_SelectClicked(object sender, EventArgs e)
        {
            profileCatalogColumn.SelectedProfile = ColumnsProfileTextBox.Text;
        }

        private void profileCatalogColumn_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(ColumnsProfileTextBox, profileCatalogColumn.SelectedProfile);
        }

        private void materialCatalogPadFooting_SelectClicked(object sender, EventArgs e)
        {
            materialCatalogPadFooting.SelectedMaterial = PadFootingMaterialtextBox.Text;
        }

        private void materialCatalogPadFooting_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(PadFootingMaterialtextBox, materialCatalogPadFooting.SelectedMaterial);
        }

        private void EditOpenDrawingButton_Click(object sender, EventArgs e)
        {
            EditOpenedDrawing();
        }

        private void CreateDrawingButton_Click(object sender, EventArgs e)
        {
            CreateForm TeklaCreateDialog = new CreateForm();
            TeklaCreateDialog.Show();
        }

        //Without this OnLoad function, there won't be any drawings loaded
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AddDrawingsToListView();
        }

        private void OpenDrawingButton_Click(object sender, EventArgs e)
        {
            ListViewItem listView = new ListViewItem();
            if (MyDrawingHandler.GetConnectionStatus())
            {
                if (listView1.SelectedItems != null && listView1.SelectedItems.Count > 0 &&
                    listView1.SelectedItems[0] != null && listView1.SelectedItems[0].Tag is Drawing)
                {
                    if (!MyDrawingHandler.SetActiveDrawing(listView1.SelectedItems[0].Tag as Drawing))
                    {
                        MessageBox.Show("Drawing is not up to date, please update it before opening.");
                    }
                }
            }
        }

        /// <summary>
        /// Returns the type of the drawing in character style
        /// </summary>
        /// <param name="DrawingInstance"></param>
        /// <returns></returns>
        private string GetDrawingTypeCharacter(Drawing DrawingInstance)
        {
            string Result = "U"; // Unknown drawing

            if (DrawingInstance is GADrawing)
            {
                Result = "G";
            }
            else if (DrawingInstance is AssemblyDrawing)
            {
                Result = "A";
            }
            else if (DrawingInstance is CastUnitDrawing)
            {
                Result = "C";
            }
            else if (DrawingInstance is MultiDrawing)
            {
                Result = "M";
            }
            else if (DrawingInstance is SinglePartDrawing)
            {
                Result = "W";
            }

            return Result;
        }

        /*in order to make this AddDrawingsToListView function work, we need to indicate in the designer that the "field" where there'll be the
        available drawings is a listbox*/
        private void AddDrawingsToListView()
        {
            //List<Item> listView = new List<Item>();
            if (MyDrawingHandler.GetConnectionStatus())
            {
                int Index = 0;
                DrawingEnumerator MyDrawingEnumerator = MyDrawingHandler.GetDrawings();

                while (MyDrawingEnumerator.MoveNext())
                {
                    Drawing CurrentDrawing = MyDrawingEnumerator.Current;
                    ListViewItem Item = new ListViewItem();

                    Item.Tag = CurrentDrawing;
                    Item.Text = Index + " " + GetDrawingTypeCharacter(CurrentDrawing) + " - " + CurrentDrawing.Mark;

                    listView1.Items.Add(Item);
                    Index++;
                }
            }

        }


    }
}
