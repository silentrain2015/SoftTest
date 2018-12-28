using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// SoftTestTaskInfo 的摘要说明
/// </summary>
public class SoftTestTaskInfo
{

    /// <summary>
    /// 软件测试任务ID
    /// </summary>
    public string ID { get; set; }

    /// <summary>
    /// 报告编号
    /// </summary>
    public string ReportNum { get; set; }

    /// <summary>
    /// 产品名称
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// 产品版本号
    /// </summary>
    public string ProductVersion { get; set; }

    /// <summary>
    /// 生产厂商
    /// </summary>
    public string ProductUnit { get; set; }

    /// <summary>
    /// 生产厂商
    /// </summary>
    public string ProductAddr { get; set; }

    /// <summary>
    /// 产地
    /// </summary>
    public string ProductProvince { get; set; }

    /// <summary>
    /// 检验类别:
    /// 1. 软件产品登记测试
    ///     2.
    /// </summary>
    public int ExamineType { get; set; }

    /// <summary>
    /// 主检人
    /// </summary>
    public string MainExaminePeople { get; set; }

    /// <summary>
    /// 审核人
    /// </summary>
    public string Auditor { get; set; }

    /// <summary>
    /// 取样方式
    /// 1.	客户送样
    /// 2.	中心抽样
    /// 3.   其他
    /// </summary>
    public int SampleType { get; set; }

    /// <summary>
    /// 样品置备
    /// 1.	客户送样
    /// 2.	中心抽样
    /// 3.其他
    /// </summary>
    public int SampleBackupType { get; set; }

    /// <summary>
    /// 样品处置
    /// 1.	客户收回
    /// 2.	中心留样
    /// 3.其他
    /// </summary>
    public int SampleManaType { get; set; }

    /// <summary>
    /// 检验目的
    /// 1.	委托检验
    /// 2.	进网检验
    /// 3.	CCC认证检验
    /// </summary>
    public int TestPurpose { get; set; }

    /// <summary>
    /// 送样人
    /// </summary>
    public string SampleFeeder { get; set; }

    /// <summary>
    /// 联系电话
    /// </summary>
    public string Telephone { get; set; }

    /// <summary>
    /// 移动电话
    /// </summary>
    public string MovePhone { get; set; }

    /// <summary>
    /// 传真
    /// </summary>
    public string Fax { get; set; }

    /// <summary>
    /// 邮箱
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// 样品数量
    /// </summary>
    public string SampleCount { get; set; }

    /// <summary>
    /// 文件编号
    /// </summary>
    public string FileNum { get; set; }

    /// <summary>
    /// 抽样地点
    /// </summary>
    public string SampleUrl { get; set; }

    /// <summary>
    /// 抽样单位
    /// </summary>
    public string SampleUnit { get; set; }

    /// <summary>
    /// 组织机构代码
    /// </summary>
    public string OrgNo { get; set; }

    /// <summary>
    /// 抽样基数
    /// </summary>
    public string SampleBaseCount { get; set; }

    /// <summary>
    /// 样品编号
    /// </summary>
    public string SampleNum { get; set; }

    /// <summary>
    /// 生产日期
    /// </summary>
    public DateTime ProductionDate { get; set; }

    /// <summary>
    /// 产地
    /// </summary>
    public string ProductionAddr { get; set; }

    /// <summary>
    /// 测试开始日期
    /// </summary>
    public DateTime TestStartDate { get; set; }

    /// <summary>
    /// 测试结束日期
    /// </summary>
    public DateTime TestEndDate { get; set; }

    /// <summary>
    /// 测试单位
    /// </summary>
    public string TestUnit { get; set; }

    /// <summary>
    /// 测试地点
    /// </summary>
    public string TestAddr { get; set; }

    /// <summary>
    /// 交付文档
    /// 1.	中文报告
    /// 2.	英文报告
    /// </summary>
    public int HandOverType { get; set; }

    /// <summary>
    /// 文档类型
    /// 1.	纸质文档
    /// 2.	电子文档
    /// 3.其他
    /// </summary>
    public int DocumentType { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remarks { get; set; }

    /// <summary>
    /// 病毒检查
    /// </summary>
    public string TestViruses { get; set; }

    /// <summary>
    /// 光盘数
    /// </summary>
    public int CDCount { get; set; }

    /// <summary>
    /// 其它数
    /// </summary>
    public int OtherCount { get; set; }

    /// <summary>
    /// 创建日期
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string CreatePeople { get; set; }

    /// <summary>
    /// 创建人ID
    /// </summary>
    public string CreateUid { get; set; }



}