using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// FilesInfo 的摘要说明
/// </summary>
public class FilesInfo
{

    /// <summary>
    /// 文档ID
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// 软件测试ID
    /// </summary>
    public string Sid { get; set; }

    /// <summary>
    /// 文档名称
    /// </summary>
    public string DocumentName { get; set; }

    /// <summary>
    /// 文档后缀
    /// </summary>
    public string DocumentDirr { get; set; }

    /// <summary>
    /// 文档相对路径
    /// </summary>
    public string DocumentAddr { get; set; }

    /// <summary>
    /// 文档类别
    /// 1.	用户文档
    /// 2.	测试依据
    /// 3.	其他附件
    /// </summary>
    public int DocumentType { get; set; }

    /// <summary>
    /// 排序号码
    /// </summary>
    public int OrderNo { get; set; }

}