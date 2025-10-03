using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day07Lab.Models;

public partial class SanPham
{
    public int Id { get; set; }

    [Required(ErrorMessage ="phải nhập Mã sản phẩm")]
    public string? MaSanPham { get; set; }
    [Required(ErrorMessage = "phải nhập tên sản phẩm")]

    public string? TenSanPham { get; set; }
    [Required(ErrorMessage = "phải nhập hình ảnh")]

    public string? HinhAnh { get; set; }
    [Required(ErrorMessage = "phải nhập số lượng")]

    public int? SoLuong { get; set; }
    [Required(ErrorMessage = "phải nhập đơn giá")]
    public double? DonGia { get; set; }
    [Required(ErrorMessage = "phải nhập mã loại")]
    public int? MaLoai { get; set; }
    [Required(ErrorMessage = "phỉa nhập trạng thái")]
    public byte? TrangThai { get; set; }

    public virtual ICollection<CtHoaDon> CtHoaDons { get; set; } = new List<CtHoaDon>();

    public virtual LoaiSanPham? MaLoaiNavigation { get; set; }
}
