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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.WeixinContract
{
    [DataContract]
    public class TypeButton : ButtonBase
    {
        private ButtonType _type = ButtonType.Click;
        public ButtonType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        [DataMember(Name = "type")]
        public string TypeString
        {
            get { return EnumHelper.GetEnumMemberValue(_type); }
            set { _type = EnumHelper.GetEnumFieldByMemberValue<ButtonType>(value); }
        }
    }
}
