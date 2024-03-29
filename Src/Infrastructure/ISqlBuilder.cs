﻿namespace FS.Sql.Infrastructure
{
    /// <summary>
    ///     查询支持的SQL方法
    /// </summary>
    public interface ISqlBuilder
    {
        /// <summary>
        ///     查询单条记录
        /// </summary>
        ISqlParam ToEntity();

        /// <summary>
        ///     查询多条记录
        /// </summary>
        /// <param name="top">限制显示的数量</param>
        /// <param name="isDistinct">返回当前条件下非重复数据</param>
        /// <param name="isRand">返回当前条件下随机的数据</param>
        ISqlParam ToList(int top = 0, bool isDistinct = false, bool isRand = false);

        /// <summary>
        ///     查询多条记录
        /// </summary>
        /// <param name="pageSize">每页显示数量</param>
        /// <param name="pageIndex">分页索引</param>
        /// <param name="isDistinct">返回当前条件下非重复数据</param>
        ISqlParam ToList(int pageSize, int pageIndex, bool isDistinct = false);

        /// <summary>
        ///     查询数量
        /// </summary>
        /// <param name="isDistinct">返回当前条件下非重复数据</param>
        ISqlParam Count(bool isDistinct = false);

        /// <summary>
        ///     累计和
        /// </summary>
        ISqlParam Sum();

        /// <summary>
        ///     查询最大数
        /// </summary>
        ISqlParam Max();

        /// <summary>
        ///     查询最小数
        /// </summary>
        ISqlParam Min();

        /// <summary>
        ///     查询单个值
        /// </summary>
        ISqlParam GetValue();

        /// <summary>
        ///     删除
        /// </summary>
        ISqlParam Delete();

        /// <summary>
        ///     插入
        /// </summary>
        ISqlParam Insert();

        /// <summary>
        ///     插入，并返回标识
        /// </summary>
        ISqlParam InsertIdentity();

        /// <summary>
        ///     修改
        /// </summary>
        ISqlParam Update();

        /// <summary>
        ///     添加或者减少某个字段
        /// </summary>
        ISqlParam AddUp();
    }
}