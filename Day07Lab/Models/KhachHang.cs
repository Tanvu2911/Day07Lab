using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day07Lab.Models;

public partial class KhachHang
{
    public int Id { get; set; }

    [Required(ErrorMessage ="không được để trống mã khách hàng")]
    public string? MaKhachHang { get; set; }

    [Required(ErrorMessage = "không được để trống họ tên")]
    public string? HoTenKhachHang { get; set; }
    [Required(ErrorMessage = "không được để trống email")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "không được để trống mật khẩu")]
    public string? MaKhau { get; set; }
    [Required(ErrorMessage = "không được để trống điện thọai")]
    public string? DienThoai { get; set; }
    [Required(ErrorMessage = "không được để trống địa chỉ")]
    public string? DiaChi { get; set; }
    [Required(ErrorMessage = "không được để trống Ngày đăng ký")]
    public DateTime? NgayDangKy { get; set; }
    [Required(ErrorMessage = "không được để trống trạng thái")]
    public byte? TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
