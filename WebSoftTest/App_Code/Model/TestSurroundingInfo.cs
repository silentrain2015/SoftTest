using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// TestSurroundingInfo 的摘要说明
/// </summary>
public class TestSurroundingInfo
{
    /// <summary>
    /// 软件测试ID
    /// </summary>
    public string Sid { get; set; }

    /// <summary>
    /// 测试内容类别
    /// 1.	软件环境
    /// 2.	硬件环境
    /// 3.	网络环境
    /// 4.	其他辅助设备
    /// </summary>
    public int TestContentType { get; set; }

    /// <summary>
    /// 1.	软件环境（终端类别）
    /// 2.	硬件环境（终端类别）
    /// 3.	网络环境（网络类型）
    /// 4.	其他辅助设备（设备名称）
    /// </summary>
    public string ContentOne { get; set; }

    /// <summary>
    /// 1.	软件环境（操作系统）
    /// 2.	硬件环境（机器名）
    /// 3.	网络环境（带宽）
    /// 4.	其他辅助设备（规格型号）
    /// </summary>
    public string ContentTwo { get; set; }

    /// <summary>
    /// 1.	软件环境（相关应用软件）
    /// 2.	硬件环境（设备编号）
    /// 3.	网络环境（设备）
    /// 4.	其他辅助设备（数量）
    /// </summary>
    public string ContentThree { get; set; }

    /// <summary>
    /// 1.	软件环境（空）
    /// 2.	硬件环境（配置说明）
    /// 3.	网络环境（数量）
    /// 4.	其他辅助设备（备注）
    /// </summary>
    public string ContentFour { get; set; }

    /// <summary>
    /// 排序编号
    /// </summary>
    public int OrderNum { get; set; }


}