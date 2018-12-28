using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// TestInfo 的摘要说明
/// </summary>
public class TestInfo
{
    /// <summary>
    /// 软件测试ID
    /// </summary>
    public string Sid { get; set; }

    /// <summary>
    /// 测试内容类别
    /// 1.	用户文档
    /// 2.	功能性
    /// 3.	易用性
    /// 4.	中文特性
    /// </summary>
    public int TestContentType { get; set; }

    /// <summary>
    /// 树节点
    /// </summary>
    public string TreeNode { get; set; }

    /// <summary>
    /// 节点类型
    /// 1.	路径节点
    /// 2.	子节点
    /// </summary>
    public int TreeNoteType { get; set; }

    /// <summary>
    /// 测试需求
    /// </summary>
    public string TestNeed { get; set; }

    /// <summary>
    /// 测试过程说明
    /// </summary>
    public string TestGuid { get; set; }

    /// <summary>
    /// 测试结果
    /// 0.	未测试
    /// 1.	符合
    /// 2.	不符合
    /// </summary>
    public int TestResult { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remarks { get; set; }
}