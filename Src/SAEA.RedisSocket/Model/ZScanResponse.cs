﻿/****************************************************************************
*Copyright (c) 2018 yswenli All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：yswenli
*命名空间：SAEA.RedisSocket.Model
*文件名： ZScanResponse
*版本号： v4.5.1.2
*唯一标识：bc48708f-e1e1-4b9e-be22-0cba54211c76
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/7/23 20:52:12
*描述：
*
*=====================================================================
*修改标记
*创建时间：2018/7/23 20:52:12
*修改人： yswenli
*版本号： v4.5.1.2
*描述：
*
*****************************************************************************/
using System.Collections.Generic;

namespace SAEA.RedisSocket.Model
{
    /// <summary>
    /// HScan返回值
    /// </summary>
    public class ZScanResponse
    {
        /// <summary>
        /// 游标参数
        /// </summary>
        public int Offset
        {
            get; set;
        }
        /// <summary>
        /// 返回数据
        /// </summary>
        public List<ZItem> Data
        {
            get; set;
        }
    }

    public class ZItem
    {
        public string Value
        {
            get; set;
        }
        public double Score
        {
            get; set;
        }
    }
}
