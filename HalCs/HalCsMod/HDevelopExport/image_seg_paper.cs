//
// File generated by HDevelop for HALCON/.NET (C#) Version 18.11.1.1
// Non-ASCII strings in this file are encoded in UTF-8.
// 
// Please note that non-ASCII characters in string constants are exported
// as octal codes in order to guarantee that the strings are correctly
// created on all systems, independent on any compiler settings.
// 
// Source files with different encoding should not be mixed in one project.
//
//  This file is intended to be used with the HDevelopTemplate or
//  HDevelopTemplateWPF projects located under %HALCONEXAMPLES%\c#

using System;
using HalconDotNet;

public partial class HDevelopExport
{
  public HTuple hv_ExpDefaultWinHandle;

  // Procedures 
  public void image_seg_paper (HObject ho_Image, out HObject ho_Image_rectified, 
      HTuple hv_WindowHandle)
  {




    // Local iconic variables 

    HObject ho_Region, ho_RegionFill, ho_ConnectedRegions;
    HObject ho_Paper, ho_Image_trans, ho_Rectangle, ho_Mask;

    // Local control variables 

    HTuple hv_Width = new HTuple(), hv_Height = new HTuple();
    HTuple hv_UsedThreshold = new HTuple(), hv_Area = new HTuple();
    HTuple hv_Row = new HTuple(), hv_Column = new HTuple();
    HTuple hv_Rows = new HTuple(), hv_Cols = new HTuple();
    HTuple hv_DistanceHeight = new HTuple(), hv_DistanceRMax = new HTuple();
    HTuple hv_DistanceWidth = new HTuple(), hv_DistanceCMax = new HTuple();
    HTuple hv_XCoordCorners = new HTuple(), hv_YCoordCorners = new HTuple();
    HTuple hv_HomMat2D = new HTuple();
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_Image_rectified);
    HOperatorSet.GenEmptyObj(out ho_Region);
    HOperatorSet.GenEmptyObj(out ho_RegionFill);
    HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
    HOperatorSet.GenEmptyObj(out ho_Paper);
    HOperatorSet.GenEmptyObj(out ho_Image_trans);
    HOperatorSet.GenEmptyObj(out ho_Rectangle);
    HOperatorSet.GenEmptyObj(out ho_Mask);
    //** Prog
    hv_Width.Dispose();hv_Height.Dispose();
    HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
    //对饱和度图像进行二值化

    //* Detecting Paper
    //auto_threshold (Saturation, Regions, 20)
    ho_Region.Dispose();hv_UsedThreshold.Dispose();
    HOperatorSet.BinaryThreshold(ho_Image, out ho_Region, "max_separability", "light", 
        out hv_UsedThreshold);
    ho_RegionFill.Dispose();
    HOperatorSet.FillUpShape(ho_Region, out ho_RegionFill, "area", 1, 40000);
    ho_ConnectedRegions.Dispose();
    HOperatorSet.Connection(ho_RegionFill, out ho_ConnectedRegions);

    hv_Area.Dispose();hv_Row.Dispose();hv_Column.Dispose();
    HOperatorSet.AreaCenter(ho_ConnectedRegions, out hv_Area, out hv_Row, out hv_Column);
    using (HDevDisposeHelper dh = new HDevDisposeHelper())
    {
    ho_Paper.Dispose();
    HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_Paper, "area", "and", hv_Area.TupleMax()
        , 9999999);
    }


    //* Detecting Corner

    hv_Rows.Dispose();hv_Cols.Dispose();
    region_get_corner(ho_Image, ho_Paper, hv_WindowHandle, out hv_Rows, out hv_Cols);
    //计算分割角点质检距离
    //Distance := []
    //for Index := 1 to 4 by 1
      //*     if (Index == 4)
      //*         distance_pp (Rows[Index], Cols[Index], Rows[1], Cols[1], Distance)
      //break
      //*     endif
      //*     distance_pp (Rows[Index], Cols[Index], Rows[Index+1], Cols[Index+1], Distance)
    //endfor
    //dev_set_colored (12)
    //for Index := 1 to 4 by 1
      //*     disp_circle(WindowHandle,Rows[Index],Cols[Index],64)
    //endfor
    using (HDevDisposeHelper dh = new HDevDisposeHelper())
    {
    hv_DistanceHeight.Dispose();hv_DistanceRMax.Dispose();
    HOperatorSet.DistanceSs(hv_Rows.TupleSelect(1), hv_Cols.TupleSelect(1), hv_Rows.TupleSelect(
        2), hv_Cols.TupleSelect(2), hv_Rows.TupleSelect(3), hv_Cols.TupleSelect(3), 
        hv_Rows.TupleSelect(4), hv_Cols.TupleSelect(4), out hv_DistanceHeight, out hv_DistanceRMax);
    }
    using (HDevDisposeHelper dh = new HDevDisposeHelper())
    {
    hv_DistanceWidth.Dispose();hv_DistanceCMax.Dispose();
    HOperatorSet.DistanceSs(hv_Rows.TupleSelect(2), hv_Cols.TupleSelect(2), hv_Rows.TupleSelect(
        3), hv_Cols.TupleSelect(3), hv_Rows.TupleSelect(1), hv_Cols.TupleSelect(1), 
        hv_Rows.TupleSelect(4), hv_Cols.TupleSelect(4), out hv_DistanceWidth, out hv_DistanceCMax);
    }




    hv_XCoordCorners.Dispose();
    using (HDevDisposeHelper dh = new HDevDisposeHelper())
    {
    hv_XCoordCorners = new HTuple();
    hv_XCoordCorners = hv_XCoordCorners.TupleConcat(hv_Rows.TupleSelect(
        2));
    hv_XCoordCorners = hv_XCoordCorners.TupleConcat(hv_Rows.TupleSelect(
        3));
    hv_XCoordCorners = hv_XCoordCorners.TupleConcat(hv_Rows.TupleSelect(
        4));
    hv_XCoordCorners = hv_XCoordCorners.TupleConcat(hv_Rows.TupleSelect(
        1));
    }
    hv_YCoordCorners.Dispose();
    using (HDevDisposeHelper dh = new HDevDisposeHelper())
    {
    hv_YCoordCorners = new HTuple();
    hv_YCoordCorners = hv_YCoordCorners.TupleConcat(hv_Cols.TupleSelect(
        2));
    hv_YCoordCorners = hv_YCoordCorners.TupleConcat(hv_Cols.TupleSelect(
        3));
    hv_YCoordCorners = hv_YCoordCorners.TupleConcat(hv_Cols.TupleSelect(
        4));
    hv_YCoordCorners = hv_YCoordCorners.TupleConcat(hv_Cols.TupleSelect(
        1));
    }




    using (HDevDisposeHelper dh = new HDevDisposeHelper())
    {
    hv_HomMat2D.Dispose();
    HOperatorSet.HomVectorToProjHomMat2d(hv_XCoordCorners, hv_YCoordCorners, (((new HTuple(1)).TupleConcat(
        1)).TupleConcat(1)).TupleConcat(1), (((((new HTuple(0)).TupleConcat(hv_DistanceHeight))).TupleConcat(
        hv_DistanceHeight))).TupleConcat(0), ((((new HTuple(0)).TupleConcat(0)).TupleConcat(
        hv_DistanceWidth))).TupleConcat(hv_DistanceWidth), (((new HTuple(1)).TupleConcat(
        1)).TupleConcat(1)).TupleConcat(1), "normalized_dlt", out hv_HomMat2D);
    }
    ho_Image_trans.Dispose();
    HOperatorSet.ProjectiveTransImage(ho_Image, out ho_Image_trans, hv_HomMat2D, 
        "bilinear", "false", "false");
    ho_Rectangle.Dispose();
    HOperatorSet.GenRectangle1(out ho_Rectangle, 0, 0, hv_DistanceHeight, hv_DistanceWidth);
    ho_Mask.Dispose();
    HOperatorSet.ReduceDomain(ho_Image_trans, ho_Rectangle, out ho_Mask);
    ho_Image_rectified.Dispose();
    HOperatorSet.CropDomain(ho_Mask, out ho_Image_rectified);
    ho_Region.Dispose();
    ho_RegionFill.Dispose();
    ho_ConnectedRegions.Dispose();
    ho_Paper.Dispose();
    ho_Image_trans.Dispose();
    ho_Rectangle.Dispose();
    ho_Mask.Dispose();

    hv_Width.Dispose();
    hv_Height.Dispose();
    hv_UsedThreshold.Dispose();
    hv_Area.Dispose();
    hv_Row.Dispose();
    hv_Column.Dispose();
    hv_Rows.Dispose();
    hv_Cols.Dispose();
    hv_DistanceHeight.Dispose();
    hv_DistanceRMax.Dispose();
    hv_DistanceWidth.Dispose();
    hv_DistanceCMax.Dispose();
    hv_XCoordCorners.Dispose();
    hv_YCoordCorners.Dispose();
    hv_HomMat2D.Dispose();

    return;
  }


}

