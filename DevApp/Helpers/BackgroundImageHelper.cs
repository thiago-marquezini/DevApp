using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Blending;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DevApp.Helpers
{
    public class BackgroundImageHelper
    {
        XtraGridBlending _blendingComponent;
        Bitmap _originalImage;
        GridView _grid;
        ContentAlignment _pictureAlignment;

        public Bitmap Image
        {
            get
            {
                return _originalImage;
            }
            set
            {
                _originalImage = value;
                GenegateBackgroundImage();
            }
        }
        public ContentAlignment PictureAlignment
        {
            get
            {
                return _pictureAlignment;
            }
            set
            {
                _pictureAlignment = value;
                GenegateBackgroundImage();
            }
        }
        public BackgroundImageHelper(GridView grid, Bitmap image, ContentAlignment alignment = ContentAlignment.BottomRight)
        {
            _grid = grid;
            InitializingBlendingComponent();
            _originalImage = image;
            _grid.GridControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            PictureAlignment = alignment;
            _grid.GridControl.Resize += new EventHandler(GridControl_Resize);
            GenegateBackgroundImage();
        }

        void GridControl_Resize(object sender, EventArgs e)
        {
            GenegateBackgroundImage();
        }

        private void GenegateBackgroundImage()
        {
            GridViewInfo gvInfo = _grid.GetViewInfo() as GridViewInfo;
            Bitmap _processedImage = new Bitmap(gvInfo.ViewRects.Client.Width + 1, gvInfo.ViewRects.Client.Height + 1);
            using (Graphics g = Graphics.FromImage(_processedImage))
            {
                Point p = CalculateImageLocation(_originalImage.Width, _originalImage.Height, gvInfo, _pictureAlignment);
                g.DrawImage(_originalImage, p);
                g.Save();
            }
            _grid.GridControl.BackgroundImage = _processedImage;
        }

        private Point CalculateImageLocation(int imageWidht, int imageHeight, GridViewInfo gvInfo, ContentAlignment alignment)
        {
            Point location = Point.Empty;
            Rectangle rect = gvInfo.ViewRects.Rows;
            int indicatorWidth = gvInfo.ViewRects.IndicatorWidth;
            int vScrollSize = gvInfo.VScrollBarPresence == ScrollBarPresence.Visible ? 20 : 0;
            int hSctollSize = gvInfo.HScrollBarPresence == ScrollBarPresence.Visible ? 20 : 0;

            switch (alignment)
            {
                case ContentAlignment.BottomCenter:
                    location.Offset((rect.Width / 2) - (imageWidht / 2), rect.Bottom - imageHeight - hSctollSize);
                    break;
                case ContentAlignment.BottomLeft:
                    location.Offset(indicatorWidth, rect.Bottom - imageHeight - hSctollSize);
                    break;
                case ContentAlignment.BottomRight:
                    location.Offset(rect.Right - imageWidht - vScrollSize, rect.Bottom - imageHeight - hSctollSize);
                    break;
                case ContentAlignment.MiddleCenter:
                    location.Offset((rect.Width / 2) - (imageWidht / 2), (rect.Height / 2) - (imageHeight / 2));
                    break;
                case ContentAlignment.MiddleLeft:
                    location.Offset(indicatorWidth, (rect.Height / 2) - (imageHeight / 2));
                    break;
                case ContentAlignment.MiddleRight:
                    location.Offset(rect.Width - imageWidht - vScrollSize, (rect.Height / 2) - (imageHeight / 2));
                    break;
                case ContentAlignment.TopCenter:
                    location.Offset((rect.Width / 2) - (imageWidht / 2), rect.Top);
                    break;
                case ContentAlignment.TopLeft:
                    location.Offset(indicatorWidth, rect.Top);
                    break;
                case ContentAlignment.TopRight:
                    location.Offset(rect.Right - imageWidht - vScrollSize, rect.Top);
                    break;
                default:
                    break;
            }
            return location;
        }

        private void InitializingBlendingComponent()
        {
            _blendingComponent = new XtraGridBlending();
            _blendingComponent.GridControl = _grid.GridControl;
        }
    }
}
