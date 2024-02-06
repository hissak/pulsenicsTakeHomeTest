namespace GraphPlotterAPI;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Point(double x, double y)
{
  public int PointId { get; set; }
  public double X { get; set; } = x;
  public double Y { get; set; } = y;
  public int CurveId { get; set; }
  public Curve Curve { get; set; }

}