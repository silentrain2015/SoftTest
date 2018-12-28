using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// UsersInfo 的摘要说明
/// </summary>
public class UsersInfo
{
    /// <summary>
    /// 用户ID
    /// </summary>
    public string Uid { get; set; }


    /// <summary>
    /// 登陆用户名
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// UserPassword
    /// </summary>
    public string UserPassword { get; set; }

    /// <summary>
    /// 用户类别
    /// 1.	企业
    /// 2.	管理员
    /// </summary>
    public int UserType { get; set; }

    /// <summary>
    /// 昵称
    /// </summary>
    public string RealName { get; set; }
}