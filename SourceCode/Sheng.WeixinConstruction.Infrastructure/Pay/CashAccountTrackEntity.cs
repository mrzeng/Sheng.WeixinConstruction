﻿/*
********************************************************************
*
*    曹旭升（sheng.c）
*    E-mail: cao.silhouette@msn.com
*    QQ: 279060597
*    https://github.com/iccb1013
*    http://shengxunwei.com
*
*    © Copyright 2016
*
********************************************************************/


using Linkup.Common;
using Linkup.DataRelationalMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    [Table("CashAccountTrack")]
    public class CashAccountTrackEntity
    {
        private Guid _id = Guid.NewGuid();
        [Key]
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Guid Domain
        {
            get;
            set;
        }

        public string AppId
        {
            get;
            set;
        }

        public Guid Member
        {
            get;
            set;
        }

        /// <summary>
        /// 发生金额 单位：分
        /// </summary>
        public int Fee
        {
            get;
            set;
        }

        /// <summary>
        /// 发生后的余额 单位：分
        /// </summary>
        public int Balances
        {
            get;
            set;
        }

        [OrderBy(OrderBy = OrderBy.DESC)]
        public DateTime ChangeTime
        {
            get;
            set;
        }

        public EnumCashAccountTrackType Type
        {
            get;
            set;
        }

        [NotMapped]
        public string TypeString
        {
            get { return EnumHelper.GetEnumMemberValue(Type); }
            set { Type = EnumHelper.GetEnumFieldByMemberValue<EnumCashAccountTrackType>(value); }
        }

        public Guid OperatorUser
        {
            get;
            set;
        }

        public string Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名（下单时的）
        /// </summary>
        public string TagName
        {
            get;
            set;
        }

        /// <summary>
        /// 消费时的商品Id
        /// </summary>
        public Guid? TagId
        {
            get;
            set;
        }

    }
}
